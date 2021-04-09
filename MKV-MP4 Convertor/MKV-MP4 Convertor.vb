Imports System.ComponentModel
Imports System.IO
Imports System.Linq
Imports System.Management
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports Convertor.My.Resources
Imports MediaInfo
Imports Microsoft.WindowsAPICodePack.Taskbar

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ItemsList.Columns.Add(New DataGridViewProgressColumn())
        ItemsList.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ItemsList.Columns(1).HeaderText = "Progress"
        ItemsList.Columns(1).DataPropertyName = "Progress"
        ItemsList.Columns(1).DefaultCellStyle = New DataGridViewCellStyle() With {.Alignment = DataGridViewContentAlignment.MiddleCenter}
        ItemsList.Columns(1).ReadOnly = True

        Icon = app_icon

        _GPUs = GetGpuList()
        cmbGPU.DataSource = _GPUs
        cmbGPU.DisplayMember = "Name"
        cmbGPU.ValueMember = "DeviceID"

        cmbQuality.SelectedIndex = 0

        _Items = New BindingList(Of Item)
        ItemsList.DataSource = _Items
    End Sub

    Private _Items As BindingList(Of Item)

    Private _GPUs As BindingList(Of GpuInfo)

    Private Class GpuInfo
        Implements INotifyPropertyChanged

        Private _Name As String
        Private _DeviceID As Integer

        Public Property Name As String
            Get
                Return _Name
            End Get

            Set
                _Name = Value
                NotifyPropertyChanged()
            End Set
        End Property

        Public Property DeviceID As Integer
            Get
                Return _DeviceID
            End Get

            Set
                _DeviceID = Value
                NotifyPropertyChanged()
            End Set
        End Property

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Private Sub NotifyPropertyChanged(<CallerMemberName()> Optional ByVal propertyName As String = Nothing)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub
    End Class

    Private Function GetGpuList() As BindingList(Of GpuInfo)
        Dim retList = New BindingList(Of GpuInfo)
        retList.Add(New GpuInfo() With {.DeviceID = -1, .Name = "No Hardware Acceleration"})
        Using searcher = New ManagementObjectSearcher("select * from Win32_VideoController")
            For Each obj In searcher.Get()
                retList.Add(New GpuInfo With {.Name = obj("Name"), .DeviceID = Integer.Parse(obj("DeviceID").ToString().Last()) - 1})
            Next
        End Using
        Return retList
    End Function

    Public Class Item
        Implements INotifyPropertyChanged

        Private _Address As String
        Private _Progress As Integer

        Public Property Address As String
            Get
                Return _Address
            End Get

            Set
                _Address = Value
                Try
                    MediaInfo = New MediaInfoWrapper(Value)
                    Dim mi = New MediaInfo.MediaInfo($".\x64")
                    mi.Open(Value)
                    videoFrameCount = Integer.Parse(mi.Get(StreamKind.Video, 0, "FrameCount"))
                    audioFrameCount = Integer.Parse(mi.Get(StreamKind.Audio, 0, "FrameCount"))
                Catch
                End Try

                NotifyPropertyChanged()
            End Set
        End Property

        Public Property Progress As Integer
            Get
                Return _Progress
            End Get

            Set
                _Progress = Value
                NotifyPropertyChanged()
            End Set
        End Property

        Public Shared Property MediaInfo As MediaInfoWrapper
        Public videoFrameCount As New Integer
        Public audioFrameCount As New Integer

        Public Sub New(path As String)
            Address = path
            Progress = 0
        End Sub

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Private Sub NotifyPropertyChanged(<CallerMemberName()> Optional ByVal propertyName As String = Nothing)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub
    End Class

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As CancelEventArgs) Handles ofdAdd.FileOk
        For Each file In ofdAdd.FileNames
            If Not FileAlreadyExistsInlist(file) Then
                _Items.Add(New Item(file))
            Else
                MsgBox(ItemsList_Duplicated_files_are_not_allowed_in_list, , ItemsList__Error)
                e.Cancel = True
            End If
        Next
    End Sub

    Private Sub btnBrowseAdd_Click(sender As Object, e As EventArgs) Handles btnBrowseAdd.Click
        ofdAdd.Filter = "Matroska file|*.mkv;*.mka;*.mk3d;*.mks|Mp4 file|*.mp4"
        ofdAdd.FilterIndex = 1
        ofdAdd.ShowDialog()
    End Sub

    Private Sub ItemsList_DragEnter(sender As Object, e As DragEventArgs) Handles ItemsList.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub ItemsList_DragDrop(sender As Object, e As DragEventArgs) Handles ItemsList.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim myFiles() As String
            myFiles = e.Data.GetData(DataFormats.FileDrop)
            For i = 0 To myFiles.Length - 1
                If Not FileAlreadyExistsInlist(myFiles(i)) = True Then
                    _Items.Add(New Item(myFiles(i)))
                Else
                    MsgBox(ItemsList_Duplicated_files_are_not_allowed_in_list, , ItemsList__Error)
                End If
            Next
        End If
    End Sub

    Private Function FileAlreadyExistsInlist(file As String) As Boolean
        For Each row As DataGridViewRow In ItemsList.Rows
            If file = row.Cells(0).Value Then
                Return True
            End If
        Next
        Return False
    End Function

    Private source As New CancellationTokenSource()
    Private pOptions = New ParallelOptions() With {.CancellationToken = source.Token}

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        If btnConvert.Text = btnConvert_Convert Then
            btnConvert.Text = btnConvert_Stop

            BWMain.RunWorkerAsync(ItemsList.SelectedRows.Cast(Of DataGridViewRow).Select(Function(r) r.Index).ToArray())

        ElseIf btnConvert.Text = btnConvert_Stop Then
            btnConvert.Text = btnConvert_Convert
            source.Cancel()
        End If
    End Sub

    Private Sub btnConvertAll_Click(sender As Object, e As EventArgs) Handles btnConvertAll.Click
        If btnConvertAll.Text = btnConvertAll_Convert_All Then
            btnConvertAll.Text = btnConvert_Stop

            BWMain.RunWorkerAsync(Enumerable.Range(0, ItemsList.Rows.Count).ToArray())

        ElseIf btnConvertAll.Text = btnConvert_Stop Then
            btnConvertAll.Text = btnConvertAll_Convert_All
            source.Cancel()
        End If
    End Sub

    Private Delegate Sub MainThreadDelegate()

    Private Sub Getinfo(ID As Integer)
        Try
            Dim aviFile = _Items(ID).MediaInfo
            For i = 0 To aviFile.VideoStreams.Count - 1
                FileInfo.Rows.Add(aviFile.VideoStreams(i).Id - 1, aviFile.VideoStreams(i).Format,
                                       aviFile.VideoStreams(i).Width & " X " & aviFile.VideoStreams(i).Height, aviFile.VideoStreams(i).Codec.ToString)
            Next
            For i = 0 To aviFile.AudioStreams.Count - 1
                FileInfo.Rows.Add(aviFile.AudioStreams(i).Id - 1, aviFile.AudioStreams(i).Format,
                                       aviFile.AudioStreams(i).SamplingRate & " bit/s", aviFile.AudioStreams(i).Codec.ToString())
            Next
            For i = 0 To aviFile.Subtitles.Count - 1
                FileInfo.Rows.Add(aviFile.Subtitles(i).Id - 1, aviFile.Subtitles(i).Format, "", aviFile.Subtitles(i).Codec.ToString())
            Next
        Catch
        End Try
    End Sub

    Private mp3quality As String
    Private HWAccelParam As String

    Private x As ProcessStartInfo = New ProcessStartInfo With {
        .FileName = "x64\ffmpeg\ffmpeg.exe",
        .UseShellExecute = False,
        .RedirectStandardError = True,
        .StandardErrorEncoding = Encoding.UTF8,
        .WindowStyle = ProcessWindowStyle.Hidden,
        .CreateNoWindow = True}
    '.Verb = "runas",

    Private Sub BWMain_DoWork(sender As Object, e As DoWorkEventArgs) Handles BWMain.DoWork
        Invoke(New MainThreadDelegate(AddressOf DisableAll))
        Dim list As Integer() = e.Argument

        Parallel.ForEach(list, pOptions, Sub(i)
                                             Dim Input = _Items(i)
                                             Dim filesrc = Input.Address
                                             Dim aviFile = Input.MediaInfo
                                             Dim convtype As String
                                             Dim outputFile As String

                                             If chkAudioOnly.Checked Then
                                                 convtype = "ffmpeg-mp3"
                                             Else
                                                 convtype = "ffmpeg"
                                             End If

                                             Dim builder As New StringBuilder

                                             Select Case convtype
                                                 Case "ffmpeg"
                                                     Select Case Path.GetExtension(filesrc)
                                                         Case ".mp4"
                                                             outputFile = Path.ChangeExtension(filesrc, "mkv")
                                                             builder.Append("-i" & Chr(32) & Chr(34) & filesrc & Chr(34) & Chr(32) & "-codec copy" &
                                                                            Chr(32) & Chr(34) & outputFile & Chr(34) & Chr(32) & HWAccelParam)
                                                         Case ".mkv"
                                                             outputFile = Path.ChangeExtension(filesrc, "mp4")
                                                             builder.Append("-i" & Chr(32) & Chr(34) & filesrc & Chr(34) & Chr(32) & "-codec copy" &
                                                                            Chr(32) & Chr(34) & outputFile & Chr(34) & Chr(32) & HWAccelParam)
                                                         Case Else
                                                             MsgBox(NotSupported)
                                                             Exit Sub
                                                     End Select
                                                     If chkSubtitle.Checked = True Then
                                                         builder.Append(Chr(32) & "-c:s copy")
                                                     End If
                                                 Case "ffmpeg-mp3"
                                                     outputFile = Path.ChangeExtension(filesrc, "mp3")
                                                     builder.Append("-i" & Chr(32) & Chr(34) & filesrc & Chr(34) & Chr(32) & mp3quality & "-vn" &
                                                                            Chr(32) & Chr(34) & outputFile & Chr(34) & Chr(32) & HWAccelParam)
                                             End Select

                                             If File.Exists(outputFile) Then
                                                 File.Delete(outputFile)
                                             End If

                                             x.Arguments = builder.ToString
                                             Dim p As New Process With {.StartInfo = x}

                                             Try
                                                 p.Start()
                                                 Dim output As String
                                                 Dim logsrc As String

                                                 If chkLog.Checked = True Then
                                                     logsrc = "log\ffmpeg-" & Path.GetFileNameWithoutExtension(filesrc) & ".log"
                                                     If File.Exists(logsrc) Then
                                                         File.Delete(logsrc)
                                                     End If
                                                 End If

                                                 While Not p.HasExited
                                                     Dim currentFrame As Integer

                                                     While Not p.StandardError.EndOfStream
                                                         If source.IsCancellationRequested Then
                                                             Exit While
                                                         End If

                                                         output = p.StandardError.ReadLine() & Environment.NewLine
                                                         If output.Contains("frame=") Then
                                                             currentFrame = CInt(Mid(output, 7, 6))
                                                             Select Case convtype
                                                                 Case "ffmpeg"
                                                                     If aviFile.HasVideo Then
                                                                         Input.Progress = (currentFrame / Input.videoFrameCount) * 100
                                                                     End If
                                                                 Case "ffmpeg-mp3"
                                                                     If Not aviFile.AudioStreams.Count = 0 Then
                                                                         Input.Progress = (currentFrame / Input.audioFrameCount) * 100
                                                                     End If
                                                             End Select

                                                             BWMain.ReportProgress(0)
                                                         End If
                                                         If chkLog.Checked = True Then
                                                             File.AppendAllText(logsrc, output)
                                                         End If
                                                     End While
                                                     If source.IsCancellationRequested Then
                                                         p.Kill()
                                                         Exit Sub
                                                     End If
                                                 End While

                                                 p.WaitForExit()
                                             Catch ex2 As Exception
                                                 If Not ex2.Message.Contains("Object is currently in use elsewhere") Then
                                                     MsgBox(BWMain_DoWork_Error___ + ex2.Message, , "ffmpeg")
                                                     p.Kill()
                                                     Exit Sub
                                                 End If
                                             End Try

                                             If chkRemoveSrc.Checked = True And File.Exists(filesrc) Then
                                                 File.Delete(filesrc)
                                             End If

                                             Input.Progress = 100
                                             BWMain.ReportProgress(100)
                                         End Sub)
    End Sub

    Private Sub DisableAll()
        chkSubtitle.Enabled = False
        chkRemoveSrc.Enabled = False
        chkAudioOnly.Enabled = False
        chkLog.Enabled = False
    End Sub

    Private Sub BWMain_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BWMain.ProgressChanged
        Dim ProgressPercentage = Aggregate st In _Items Into Average(st.Progress)
        TaskbarManager.Instance.SetProgressValue(ProgressPercentage, 100)
    End Sub

    Private Sub BWMain_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BWMain.RunWorkerCompleted
        If source.IsCancellationRequested Then
            MsgBox(BWMain_Stopped)
        Else
            btnConvert.Text = btnConvert_Convert
            btnConvertAll.Text = btnConvertAll_Convert_All
            MsgBox(BWMain_Completed_Successfully)
        End If
        source = New CancellationTokenSource()
        pOptions = New ParallelOptions() With {.CancellationToken = source.Token}
        If chkAudioOnly.Checked = False Then
            chkSubtitle.Enabled = True
        End If
        chkRemoveSrc.Enabled = True
        chkLog.Enabled = True
        chkAudioOnly.Enabled = True
        TaskbarManager.Instance.SetProgressValue(0, 100)
    End Sub

    Private Sub chkLog_CheckedChanged(sender As Object, e As EventArgs) Handles chkLog.CheckedChanged
        If Not Directory.Exists("log") Then
            Directory.CreateDirectory("log")
        End If
    End Sub

    Private prev_checked3 As Boolean

    Private Sub chkAudioOnly_CheckedChanged(sender As Object, e As EventArgs) Handles chkAudioOnly.CheckedChanged
        If chkAudioOnly.Checked Then
            prev_checked3 = chkSubtitle.Checked
            chkSubtitle.Checked = False
            chkSubtitle.Enabled = False
            cmbQuality.Visible = True
        Else
            chkSubtitle.Checked = prev_checked3
            chkSubtitle.Enabled = True
            cmbQuality.Visible = False
        End If
    End Sub

    Private Sub cmbQuality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbQuality.SelectedIndexChanged
        Select Case cmbQuality.SelectedIndex
            Case 0
                mp3quality = ""
            Case 1
                mp3quality = "-b:a 64K "
            Case 2
                mp3quality = "-b:a 128K "
            Case 3
                mp3quality = "-b:a 192K "
            Case 4
                mp3quality = "-b:a 256K "
            Case 5
                mp3quality = "-b:a 384K "
            Case 5
                mp3quality = "-b:a 512K "
        End Select

    End Sub

    Private Sub ComboBox_GPU_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGPU.SelectedIndexChanged
        Dim selectedGpu = CType(cmbGPU.SelectedItem, GpuInfo)
        HWAccelParam = If(selectedGpu.DeviceID = -1, "-y", $"-hwaccel_device {selectedGpu.DeviceID} -y")
    End Sub

    Private Sub ItemsList_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles ItemsList.CellValidating
        If ItemsList.Columns(e.ColumnIndex).HeaderText = "File Address" Then
            If Not File.Exists(ItemsList.Rows(e.RowIndex).Cells(0).EditedFormattedValue) Then
                MsgBox(ItemsList_files_Does_Not_Exist, , ItemsList__Error)
                ItemsList.Rows(e.RowIndex).Cells(0).Value = ItemsList.Rows(e.RowIndex).Cells(0).Value
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub ItemsList_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles ItemsList.CellEndEdit
        ItemsList.Rows(e.RowIndex).ErrorText = String.Empty
    End Sub

    Private Sub ItemsList_SelectionChanged(sender As Object, e As EventArgs) Handles ItemsList.SelectionChanged
        If ItemsList.SelectedRows.Count = 1 Then
            FileInfo.Rows.Clear()
            Getinfo(ItemsList.CurrentRow.Index)
        Else
            FileInfo.Rows.Clear()
        End If
    End Sub

    Private Sub ItemsList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ItemsList.CellDoubleClick
        If e.ColumnIndex = 0 Then
            ItemsList.BeginEdit(False)
        End If
    End Sub
End Class

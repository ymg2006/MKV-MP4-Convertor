<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1

    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem7 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.ofdAdd = New System.Windows.Forms.OpenFileDialog()
        Me.btnBrowseAdd = New Telerik.WinControls.UI.RadButton()
        Me.btnConvert = New Telerik.WinControls.UI.RadButton()
        Me.FileInfo = New Telerik.WinControls.UI.RadGridView()
        Me.btnConvertAll = New Telerik.WinControls.UI.RadButton()
        Me.BWMain = New System.ComponentModel.BackgroundWorker()
        Me.chkRemoveSrc = New Telerik.WinControls.UI.RadCheckBox()
        Me.chkLog = New Telerik.WinControls.UI.RadCheckBox()
        Me.chkAudioOnly = New Telerik.WinControls.UI.RadCheckBox()
        Me.cmbQuality = New Telerik.WinControls.UI.RadDropDownList()
        Me.cmbGPU = New Telerik.WinControls.UI.RadDropDownList()
        Me.ItemsList = New Telerik.WinControls.UI.RadGridView()
        Me.chkSubtitle = New Telerik.WinControls.UI.RadCheckBox()
        Me.chkKeepType = New Telerik.WinControls.UI.RadCheckBox()
        Me.FluentDarkTheme = New Telerik.WinControls.Themes.FluentDarkTheme()
        Me.FluentTheme = New Telerik.WinControls.Themes.FluentTheme()
        CType(Me.btnBrowseAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnConvert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileInfo.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnConvertAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRemoveSrc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAudioOnly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbQuality, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbGPU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSubtitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkKeepType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ofdAdd
        '
        Me.ofdAdd.Multiselect = True
        '
        'btnBrowseAdd
        '
        Me.btnBrowseAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBrowseAdd.Location = New System.Drawing.Point(15, 260)
        Me.btnBrowseAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBrowseAdd.Name = "btnBrowseAdd"
        Me.btnBrowseAdd.Size = New System.Drawing.Size(138, 38)
        Me.btnBrowseAdd.TabIndex = 1
        Me.btnBrowseAdd.Text = "Browse/Add"
        '
        'btnConvert
        '
        Me.btnConvert.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConvert.Location = New System.Drawing.Point(160, 260)
        Me.btnConvert.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(138, 38)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Convert"
        '
        'FileInfo
        '
        Me.FileInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FileInfo.Location = New System.Drawing.Point(15, 305)
        Me.FileInfo.Margin = New System.Windows.Forms.Padding(4)
        '
        '
        '
        Me.FileInfo.MasterTemplate.AllowAddNewRow = False
        Me.FileInfo.MasterTemplate.AllowDeleteRow = False
        GridViewTextBoxColumn1.HeaderText = "ID"
        GridViewTextBoxColumn1.MinWidth = 6
        GridViewTextBoxColumn1.Name = "Column1"
        GridViewTextBoxColumn1.ReadOnly = True
        GridViewTextBoxColumn2.HeaderText = "Track type"
        GridViewTextBoxColumn2.MinWidth = 6
        GridViewTextBoxColumn2.Name = "Column2"
        GridViewTextBoxColumn2.ReadOnly = True
        GridViewTextBoxColumn3.HeaderText = "Quality"
        GridViewTextBoxColumn3.MinWidth = 6
        GridViewTextBoxColumn3.Name = "Column3"
        GridViewTextBoxColumn3.ReadOnly = True
        GridViewTextBoxColumn4.HeaderText = "Codec ID"
        GridViewTextBoxColumn4.MinWidth = 6
        GridViewTextBoxColumn4.Name = "Column4"
        GridViewTextBoxColumn4.ReadOnly = True
        Me.FileInfo.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4})
        Me.FileInfo.MasterTemplate.ShowRowHeaderColumn = False
        Me.FileInfo.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.FileInfo.Name = "FileInfo"
        Me.FileInfo.ReadOnly = True
        Me.FileInfo.Size = New System.Drawing.Size(572, 144)
        Me.FileInfo.TabIndex = 5
        CType(Me.FileInfo.GetChildAt(0).GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.GridTableElement).RowHeaderColumnWidth = 51
        CType(Me.FileInfo.GetChildAt(0).GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.GridTableElement).Text = ""
        '
        'btnConvertAll
        '
        Me.btnConvertAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConvertAll.Location = New System.Drawing.Point(305, 260)
        Me.btnConvertAll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConvertAll.Name = "btnConvertAll"
        Me.btnConvertAll.Size = New System.Drawing.Size(138, 38)
        Me.btnConvertAll.TabIndex = 21
        Me.btnConvertAll.Text = "Convert All"
        '
        'BWMain
        '
        Me.BWMain.WorkerReportsProgress = True
        Me.BWMain.WorkerSupportsCancellation = True
        '
        'chkRemoveSrc
        '
        Me.chkRemoveSrc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkRemoveSrc.Location = New System.Drawing.Point(15, 497)
        Me.chkRemoveSrc.Margin = New System.Windows.Forms.Padding(4)
        Me.chkRemoveSrc.Name = "chkRemoveSrc"
        Me.chkRemoveSrc.Size = New System.Drawing.Size(114, 18)
        Me.chkRemoveSrc.TabIndex = 28
        Me.chkRemoveSrc.Text = "Remove converted"
        '
        'chkLog
        '
        Me.chkLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkLog.Location = New System.Drawing.Point(174, 497)
        Me.chkLog.Margin = New System.Windows.Forms.Padding(4)
        Me.chkLog.Name = "chkLog"
        Me.chkLog.Size = New System.Drawing.Size(70, 18)
        Me.chkLog.TabIndex = 30
        Me.chkLog.Text = "Log to file"
        '
        'chkAudioOnly
        '
        Me.chkAudioOnly.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkAudioOnly.Location = New System.Drawing.Point(174, 464)
        Me.chkAudioOnly.Margin = New System.Windows.Forms.Padding(4)
        Me.chkAudioOnly.Name = "chkAudioOnly"
        Me.chkAudioOnly.Size = New System.Drawing.Size(109, 18)
        Me.chkAudioOnly.TabIndex = 37
        Me.chkAudioOnly.Text = "Only Audio (mp3)"
        '
        'cmbQuality
        '
        Me.cmbQuality.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbQuality.DropDownAnimationEnabled = True
        Me.cmbQuality.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "Audio Default"
        RadListDataItem2.Text = "64 Kbps"
        RadListDataItem3.Text = "128 Kbps"
        RadListDataItem4.Text = "192 Kbps"
        RadListDataItem5.Text = "256 Kbps"
        RadListDataItem6.Text = "384 Kbps"
        RadListDataItem7.Text = "512 Kbps"
        Me.cmbQuality.Items.Add(RadListDataItem1)
        Me.cmbQuality.Items.Add(RadListDataItem2)
        Me.cmbQuality.Items.Add(RadListDataItem3)
        Me.cmbQuality.Items.Add(RadListDataItem4)
        Me.cmbQuality.Items.Add(RadListDataItem5)
        Me.cmbQuality.Items.Add(RadListDataItem6)
        Me.cmbQuality.Items.Add(RadListDataItem7)
        Me.cmbQuality.Location = New System.Drawing.Point(314, 458)
        Me.cmbQuality.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbQuality.Name = "cmbQuality"
        Me.cmbQuality.Size = New System.Drawing.Size(139, 24)
        Me.cmbQuality.TabIndex = 38
        Me.cmbQuality.Visible = False
        '
        'cmbGPU
        '
        Me.cmbGPU.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbGPU.DropDownAnimationEnabled = True
        Me.cmbGPU.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.cmbGPU.Location = New System.Drawing.Point(314, 489)
        Me.cmbGPU.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbGPU.MaximumSize = New System.Drawing.Size(624, 0)
        Me.cmbGPU.Name = "cmbGPU"
        Me.cmbGPU.Size = New System.Drawing.Size(273, 24)
        Me.cmbGPU.TabIndex = 39
        '
        'ItemsList
        '
        Me.ItemsList.AllowDrop = True
        Me.ItemsList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemsList.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditProgrammatically
        Me.ItemsList.Location = New System.Drawing.Point(15, 15)
        Me.ItemsList.Margin = New System.Windows.Forms.Padding(4)
        '
        '
        '
        Me.ItemsList.MasterTemplate.AllowAddNewRow = False
        GridViewTextBoxColumn5.FieldName = "Address"
        GridViewTextBoxColumn5.HeaderText = "File Address"
        GridViewTextBoxColumn5.MinWidth = 6
        GridViewTextBoxColumn5.Name = "Address"
        Me.ItemsList.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn5})
        Me.ItemsList.MasterTemplate.ShowRowHeaderColumn = False
        Me.ItemsList.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.ItemsList.Name = "ItemsList"
        Me.ItemsList.Size = New System.Drawing.Size(572, 238)
        Me.ItemsList.TabIndex = 40
        CType(Me.ItemsList.GetChildAt(0).GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.GridTableElement).RowHeaderColumnWidth = 51
        CType(Me.ItemsList.GetChildAt(0).GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.GridTableElement).Text = ""
        '
        'chkSubtitle
        '
        Me.chkSubtitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkSubtitle.Location = New System.Drawing.Point(15, 464)
        Me.chkSubtitle.Margin = New System.Windows.Forms.Padding(4)
        Me.chkSubtitle.Name = "chkSubtitle"
        Me.chkSubtitle.Size = New System.Drawing.Size(124, 18)
        Me.chkSubtitle.TabIndex = 25
        Me.chkSubtitle.Text = "Add default subtitles"
        '
        'chkKeepType
        '
        Me.chkKeepType.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkKeepType.Location = New System.Drawing.Point(451, 272)
        Me.chkKeepType.Margin = New System.Windows.Forms.Padding(4)
        Me.chkKeepType.Name = "chkKeepType"
        Me.chkKeepType.Size = New System.Drawing.Size(69, 18)
        Me.chkKeepType.TabIndex = 41
        Me.chkKeepType.Text = "KeepType"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(612, 533)
        Me.Controls.Add(Me.chkKeepType)
        Me.Controls.Add(Me.ItemsList)
        Me.Controls.Add(Me.cmbGPU)
        Me.Controls.Add(Me.cmbQuality)
        Me.Controls.Add(Me.chkAudioOnly)
        Me.Controls.Add(Me.chkLog)
        Me.Controls.Add(Me.chkRemoveSrc)
        Me.Controls.Add(Me.chkSubtitle)
        Me.Controls.Add(Me.btnConvertAll)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.FileInfo)
        Me.Controls.Add(Me.btnBrowseAdd)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(620, 563)
        Me.Name = "Form1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MKV-MP4 Convertor"
        CType(Me.btnBrowseAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnConvert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileInfo.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnConvertAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRemoveSrc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAudioOnly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbQuality, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbGPU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSubtitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkKeepType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ofdAdd As OpenFileDialog
    Friend WithEvents btnBrowseAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnConvert As Telerik.WinControls.UI.RadButton
    Friend WithEvents FileInfo As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnConvertAll As Telerik.WinControls.UI.RadButton
    Friend WithEvents BWMain As System.ComponentModel.BackgroundWorker
    Friend WithEvents chkRemoveSrc As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chkLog As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chkAudioOnly As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents cmbQuality As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents cmbGPU As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Column1 As Telerik.WinControls.UI.GridViewTextBoxColumn
    Friend WithEvents Column2 As Telerik.WinControls.UI.GridViewTextBoxColumn
    Friend WithEvents Column3 As Telerik.WinControls.UI.GridViewTextBoxColumn
    Friend WithEvents Column4 As Telerik.WinControls.UI.GridViewTextBoxColumn
    Friend WithEvents ItemsList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents chkSubtitle As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents Address As Telerik.WinControls.UI.GridViewTextBoxColumn
    Friend WithEvents chkKeepType As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents FluentDarkTheme As Telerik.WinControls.Themes.FluentDarkTheme
    Friend WithEvents FluentTheme As Telerik.WinControls.Themes.FluentTheme
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ofdAdd = New System.Windows.Forms.OpenFileDialog()
        Me.btnBrowseAdd = New System.Windows.Forms.Button()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.FileInfo = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnConvertAll = New System.Windows.Forms.Button()
        Me.BWMain = New System.ComponentModel.BackgroundWorker()
        Me.chkRemoveSrc = New System.Windows.Forms.CheckBox()
        Me.chkLog = New System.Windows.Forms.CheckBox()
        Me.chkAudioOnly = New System.Windows.Forms.CheckBox()
        Me.cmbQuality = New System.Windows.Forms.ComboBox()
        Me.cmbGPU = New System.Windows.Forms.ComboBox()
        Me.ItemsList = New System.Windows.Forms.DataGridView()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chkSubtitle = New System.Windows.Forms.CheckBox()
        CType(Me.FileInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ofdAdd
        '
        Me.ofdAdd.Multiselect = True
        '
        'btnBrowseAdd
        '
        Me.btnBrowseAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBrowseAdd.Location = New System.Drawing.Point(12, 208)
        Me.btnBrowseAdd.Name = "btnBrowseAdd"
        Me.btnBrowseAdd.Size = New System.Drawing.Size(110, 30)
        Me.btnBrowseAdd.TabIndex = 1
        Me.btnBrowseAdd.Text = "Browse/Add"
        Me.btnBrowseAdd.UseVisualStyleBackColor = True
        '
        'btnConvert
        '
        Me.btnConvert.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConvert.Location = New System.Drawing.Point(128, 208)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(110, 30)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'FileInfo
        '
        Me.FileInfo.AllowUserToAddRows = False
        Me.FileInfo.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FileInfo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.FileInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FileInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FileInfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.FileInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FileInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FileInfo.DefaultCellStyle = DataGridViewCellStyle7
        Me.FileInfo.Location = New System.Drawing.Point(12, 244)
        Me.FileInfo.Name = "FileInfo"
        Me.FileInfo.ReadOnly = True
        Me.FileInfo.RowHeadersVisible = False
        Me.FileInfo.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FileInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.FileInfo.Size = New System.Drawing.Size(458, 115)
        Me.FileInfo.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column1.FillWeight = 50.0!
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column2.FillWeight = 160.0!
        Me.Column2.HeaderText = "Track type"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column3.FillWeight = 160.0!
        Me.Column3.HeaderText = "Quality"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column4.FillWeight = 540.0!
        Me.Column4.HeaderText = "Codec ID"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btnConvertAll
        '
        Me.btnConvertAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConvertAll.Location = New System.Drawing.Point(244, 208)
        Me.btnConvertAll.Name = "btnConvertAll"
        Me.btnConvertAll.Size = New System.Drawing.Size(110, 30)
        Me.btnConvertAll.TabIndex = 21
        Me.btnConvertAll.Text = "Convert All"
        Me.btnConvertAll.UseVisualStyleBackColor = True
        '
        'BWMain
        '
        Me.BWMain.WorkerReportsProgress = True
        Me.BWMain.WorkerSupportsCancellation = True
        '
        'chkRemoveSrc
        '
        Me.chkRemoveSrc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkRemoveSrc.AutoSize = True
        Me.chkRemoveSrc.Location = New System.Drawing.Point(12, 395)
        Me.chkRemoveSrc.Name = "chkRemoveSrc"
        Me.chkRemoveSrc.Size = New System.Drawing.Size(117, 17)
        Me.chkRemoveSrc.TabIndex = 28
        Me.chkRemoveSrc.Text = "Remove converted"
        Me.chkRemoveSrc.UseVisualStyleBackColor = True
        '
        'chkLog
        '
        Me.chkLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkLog.AutoSize = True
        Me.chkLog.Location = New System.Drawing.Point(139, 395)
        Me.chkLog.Name = "chkLog"
        Me.chkLog.Size = New System.Drawing.Size(72, 17)
        Me.chkLog.TabIndex = 30
        Me.chkLog.Text = "Log to file"
        Me.chkLog.UseVisualStyleBackColor = True
        '
        'chkAudioOnly
        '
        Me.chkAudioOnly.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkAudioOnly.AutoSize = True
        Me.chkAudioOnly.Location = New System.Drawing.Point(139, 369)
        Me.chkAudioOnly.Name = "chkAudioOnly"
        Me.chkAudioOnly.Size = New System.Drawing.Size(106, 17)
        Me.chkAudioOnly.TabIndex = 37
        Me.chkAudioOnly.Text = "Only Audio (mp3)"
        Me.chkAudioOnly.UseVisualStyleBackColor = True
        '
        'cmbQuality
        '
        Me.cmbQuality.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbQuality.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbQuality.FormattingEnabled = True
        Me.cmbQuality.Items.AddRange(New Object() {"Audio Default", "64 Kbps", "128 Kbps", "192 Kbps", "256 Kbps", "384 Kbps", "512 Kbps"})
        Me.cmbQuality.Location = New System.Drawing.Point(251, 366)
        Me.cmbQuality.Name = "cmbQuality"
        Me.cmbQuality.Size = New System.Drawing.Size(112, 21)
        Me.cmbQuality.TabIndex = 38
        Me.cmbQuality.Visible = False
        '
        'cmbGPU
        '
        Me.cmbGPU.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbGPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGPU.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbGPU.FormattingEnabled = True
        Me.cmbGPU.Location = New System.Drawing.Point(251, 391)
        Me.cmbGPU.MaximumSize = New System.Drawing.Size(500, 0)
        Me.cmbGPU.Name = "cmbGPU"
        Me.cmbGPU.Size = New System.Drawing.Size(219, 21)
        Me.cmbGPU.TabIndex = 39
        '
        'ItemsList
        '
        Me.ItemsList.AllowDrop = True
        Me.ItemsList.AllowUserToAddRows = False
        Me.ItemsList.AllowUserToOrderColumns = True
        Me.ItemsList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ItemsList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.ItemsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemsList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Address})
        Me.ItemsList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.ItemsList.Location = New System.Drawing.Point(12, 12)
        Me.ItemsList.Name = "ItemsList"
        Me.ItemsList.RowHeadersVisible = False
        Me.ItemsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ItemsList.Size = New System.Drawing.Size(458, 190)
        Me.ItemsList.TabIndex = 40
        '
        'Address
        '
        Me.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Address.DataPropertyName = "Address"
        Me.Address.FillWeight = 273.64!
        Me.Address.HeaderText = "File Address"
        Me.Address.Name = "Address"
        Me.Address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'chkSubtitle
        '
        Me.chkSubtitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkSubtitle.AutoSize = True
        Me.chkSubtitle.Location = New System.Drawing.Point(12, 369)
        Me.chkSubtitle.Name = "chkSubtitle"
        Me.chkSubtitle.Size = New System.Drawing.Size(121, 17)
        Me.chkSubtitle.TabIndex = 25
        Me.chkSubtitle.Text = "Add default subtitles"
        Me.chkSubtitle.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(484, 421)
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
        Me.MinimumSize = New System.Drawing.Size(500, 460)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MKV-MP4 Convertor"
        CType(Me.FileInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ofdAdd As OpenFileDialog
    Friend WithEvents btnBrowseAdd As Button
    Friend WithEvents btnConvert As Button
    Friend WithEvents FileInfo As DataGridView
    Friend WithEvents btnConvertAll As Button
    Friend WithEvents BWMain As System.ComponentModel.BackgroundWorker
    Friend WithEvents chkRemoveSrc As CheckBox
    Friend WithEvents chkLog As CheckBox
    Friend WithEvents chkAudioOnly As CheckBox
    Friend WithEvents cmbQuality As ComboBox
    Friend WithEvents cmbGPU As ComboBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents ItemsList As DataGridView
    Friend WithEvents chkSubtitle As CheckBox
    Friend WithEvents Address As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uctrl_mystudent_logs
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uctrl_mystudent_logs))
        Me.dgvLogs = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDateFrom = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtpDateTo = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.chkboxAutoSearch = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.cmbFilter = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtSearchBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSection = New Guna.UI2.WinForms.Guna2ComboBox()
        CType(Me.dgvLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvLogs
        '
        Me.dgvLogs.AllowUserToAddRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvLogs.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLogs.BackgroundColor = System.Drawing.Color.White
        Me.dgvLogs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvLogs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLogs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvLogs.ColumnHeadersHeight = 50
        Me.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvLogs.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLogs.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvLogs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLogs.EnableHeadersVisualStyles = False
        Me.dgvLogs.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvLogs.Location = New System.Drawing.Point(0, 0)
        Me.dgvLogs.Name = "dgvLogs"
        Me.dgvLogs.ReadOnly = True
        Me.dgvLogs.RowHeadersVisible = False
        Me.dgvLogs.RowTemplate.Height = 80
        Me.dgvLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLogs.Size = New System.Drawing.Size(862, 439)
        Me.dgvLogs.TabIndex = 0
        Me.dgvLogs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvLogs.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvLogs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvLogs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvLogs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvLogs.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvLogs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvLogs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvLogs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvLogs.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvLogs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvLogs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvLogs.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvLogs.ThemeStyle.ReadOnly = True
        Me.dgvLogs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvLogs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvLogs.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvLogs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvLogs.ThemeStyle.RowsStyle.Height = 80
        Me.dgvLogs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvLogs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.dgvLogs)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(15, 83)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(862, 439)
        Me.Guna2ShadowPanel1.TabIndex = 46
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Guna2Button1)
        Me.Panel2.Controls.Add(Me.Guna2Button2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 529)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(893, 43)
        Me.Panel2.TabIndex = 51
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.FillColor = System.Drawing.Color.Coral
        Me.Guna2Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.Location = New System.Drawing.Point(796, 2)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(96, 37)
        Me.Guna2Button1.TabIndex = 1
        Me.Guna2Button1.Text = "Export"
        Me.Guna2Button1.TextOffset = New System.Drawing.Point(4, 0)
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BorderRadius = 10
        Me.Guna2Button2.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.Guna2Button2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Image = CType(resources.GetObject("Guna2Button2.Image"), System.Drawing.Image)
        Me.Guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button2.Location = New System.Drawing.Point(689, 2)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(96, 37)
        Me.Guna2Button2.TabIndex = 0
        Me.Guna2Button2.Text = "Print"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(639, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Date To"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(492, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Date From"
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.dtpDateFrom.BorderRadius = 10
        Me.dtpDateFrom.BorderThickness = 1
        Me.dtpDateFrom.Checked = True
        Me.dtpDateFrom.CustomFormat = ""
        Me.dtpDateFrom.Enabled = False
        Me.dtpDateFrom.FillColor = System.Drawing.Color.White
        Me.dtpDateFrom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpDateFrom.ForeColor = System.Drawing.Color.Black
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpDateFrom.Location = New System.Drawing.Point(492, 20)
        Me.dtpDateFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDateFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(144, 38)
        Me.dtpDateFrom.TabIndex = 53
        Me.dtpDateFrom.Value = New Date(2022, 8, 8, 0, 0, 0, 0)
        '
        'dtpDateTo
        '
        Me.dtpDateTo.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.dtpDateTo.BorderRadius = 10
        Me.dtpDateTo.BorderThickness = 1
        Me.dtpDateTo.Checked = True
        Me.dtpDateTo.Enabled = False
        Me.dtpDateTo.FillColor = System.Drawing.Color.White
        Me.dtpDateTo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpDateTo.ForeColor = System.Drawing.Color.Black
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpDateTo.Location = New System.Drawing.Point(642, 20)
        Me.dtpDateTo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDateTo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(143, 36)
        Me.dtpDateTo.TabIndex = 52
        Me.dtpDateTo.Value = New Date(2022, 8, 8, 0, 0, 0, 0)
        '
        'chkboxAutoSearch
        '
        Me.chkboxAutoSearch.AutoSize = True
        Me.chkboxAutoSearch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkboxAutoSearch.CheckedState.BorderRadius = 2
        Me.chkboxAutoSearch.CheckedState.BorderThickness = 0
        Me.chkboxAutoSearch.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkboxAutoSearch.Location = New System.Drawing.Point(263, 60)
        Me.chkboxAutoSearch.Name = "chkboxAutoSearch"
        Me.chkboxAutoSearch.Size = New System.Drawing.Size(85, 17)
        Me.chkboxAutoSearch.TabIndex = 50
        Me.chkboxAutoSearch.Text = "Auto Search"
        Me.chkboxAutoSearch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chkboxAutoSearch.UncheckedState.BorderRadius = 2
        Me.chkboxAutoSearch.UncheckedState.BorderThickness = 0
        Me.chkboxAutoSearch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chkboxAutoSearch.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.BorderRadius = 10
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(791, 20)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(86, 36)
        Me.btnSearch.TabIndex = 49
        Me.btnSearch.Text = "Search"
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Location = New System.Drawing.Point(148, 4)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(29, 13)
        Me.lblFilter.TabIndex = 48
        Me.lblFilter.Text = "Filter"
        '
        'cmbFilter
        '
        Me.cmbFilter.BackColor = System.Drawing.Color.Transparent
        Me.cmbFilter.BorderRadius = 10
        Me.cmbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilter.FocusedColor = System.Drawing.Color.Empty
        Me.cmbFilter.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cmbFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.ItemHeight = 30
        Me.cmbFilter.Items.AddRange(New Object() {"Current Date", "By LRN", "By Date"})
        Me.cmbFilter.Location = New System.Drawing.Point(142, 20)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(113, 36)
        Me.cmbFilter.StartIndex = 0
        Me.cmbFilter.TabIndex = 47
        '
        'txtSearchBox
        '
        Me.txtSearchBox.BorderRadius = 10
        Me.txtSearchBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchBox.DefaultText = ""
        Me.txtSearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchBox.IconLeft = CType(resources.GetObject("txtSearchBox.IconLeft"), System.Drawing.Image)
        Me.txtSearchBox.Location = New System.Drawing.Point(263, 20)
        Me.txtSearchBox.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchBox.PlaceholderText = "Search..."
        Me.txtSearchBox.SelectedText = ""
        Me.txtSearchBox.Size = New System.Drawing.Size(221, 36)
        Me.txtSearchBox.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Section"
        '
        'cmbSection
        '
        Me.cmbSection.BackColor = System.Drawing.Color.Transparent
        Me.cmbSection.BorderRadius = 10
        Me.cmbSection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSection.FocusedColor = System.Drawing.Color.Empty
        Me.cmbSection.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cmbSection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbSection.FormattingEnabled = True
        Me.cmbSection.ItemHeight = 30
        Me.cmbSection.Location = New System.Drawing.Point(15, 20)
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.Size = New System.Drawing.Size(121, 36)
        Me.cmbSection.TabIndex = 56
        '
        'uctrl_mystudent_logs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbSection)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpDateFrom)
        Me.Controls.Add(Me.dtpDateTo)
        Me.Controls.Add(Me.chkboxAutoSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.cmbFilter)
        Me.Controls.Add(Me.txtSearchBox)
        Me.Name = "uctrl_mystudent_logs"
        Me.Size = New System.Drawing.Size(893, 572)
        CType(Me.dgvLogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvLogs As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpDateFrom As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpDateTo As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents chkboxAutoSearch As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblFilter As Label
    Friend WithEvents cmbFilter As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtSearchBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbSection As Guna.UI2.WinForms.Guna2ComboBox
End Class

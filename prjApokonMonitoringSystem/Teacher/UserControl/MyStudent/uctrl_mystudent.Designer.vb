<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uctrl_mystudent
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uctrl_mystudent))
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvStudent = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.action_view = New System.Windows.Forms.DataGridViewImageColumn()
        Me.action_edit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.action_delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.chkboxAutoSearch = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.Gender = New System.Windows.Forms.Label()
        Me.cmbGender = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.cmbFilter = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtSearchBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbSection = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.dgvStudent)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(15, 83)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(862, 439)
        Me.Guna2ShadowPanel1.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Actions"
        '
        'dgvStudent
        '
        Me.dgvStudent.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvStudent.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStudent.BackgroundColor = System.Drawing.Color.White
        Me.dgvStudent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvStudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvStudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStudent.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStudent.ColumnHeadersHeight = 50
        Me.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvStudent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.action_view, Me.action_edit, Me.action_delete})
        Me.dgvStudent.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStudent.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvStudent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvStudent.EnableHeadersVisualStyles = False
        Me.dgvStudent.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvStudent.Location = New System.Drawing.Point(0, 0)
        Me.dgvStudent.Name = "dgvStudent"
        Me.dgvStudent.ReadOnly = True
        Me.dgvStudent.RowHeadersVisible = False
        Me.dgvStudent.RowTemplate.Height = 80
        Me.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStudent.Size = New System.Drawing.Size(862, 439)
        Me.dgvStudent.TabIndex = 0
        Me.dgvStudent.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvStudent.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvStudent.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvStudent.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvStudent.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvStudent.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvStudent.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvStudent.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvStudent.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvStudent.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvStudent.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvStudent.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvStudent.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvStudent.ThemeStyle.ReadOnly = True
        Me.dgvStudent.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvStudent.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvStudent.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvStudent.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvStudent.ThemeStyle.RowsStyle.Height = 80
        Me.dgvStudent.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvStudent.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'action_view
        '
        Me.action_view.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.action_view.Frozen = True
        Me.action_view.HeaderText = ""
        Me.action_view.Image = CType(resources.GetObject("action_view.Image"), System.Drawing.Image)
        Me.action_view.Name = "action_view"
        Me.action_view.ReadOnly = True
        Me.action_view.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.action_view.Width = 35
        '
        'action_edit
        '
        Me.action_edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.action_edit.Frozen = True
        Me.action_edit.HeaderText = ""
        Me.action_edit.Image = CType(resources.GetObject("action_edit.Image"), System.Drawing.Image)
        Me.action_edit.Name = "action_edit"
        Me.action_edit.ReadOnly = True
        Me.action_edit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.action_edit.Width = 35
        '
        'action_delete
        '
        Me.action_delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.action_delete.DividerWidth = 2
        Me.action_delete.HeaderText = ""
        Me.action_delete.Image = CType(resources.GetObject("action_delete.Image"), System.Drawing.Image)
        Me.action_delete.Name = "action_delete"
        Me.action_delete.ReadOnly = True
        Me.action_delete.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.action_delete.Width = 35
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Guna2Button1)
        Me.Panel2.Controls.Add(Me.Guna2Button2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 529)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(893, 43)
        Me.Panel2.TabIndex = 40
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.FillColor = System.Drawing.Color.Coral
        Me.Guna2Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.Location = New System.Drawing.Point(796, 3)
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
        Me.Guna2Button2.Location = New System.Drawing.Point(689, 3)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(96, 37)
        Me.Guna2Button2.TabIndex = 0
        Me.Guna2Button2.Text = "Print"
        '
        'chkboxAutoSearch
        '
        Me.chkboxAutoSearch.AutoSize = True
        Me.chkboxAutoSearch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkboxAutoSearch.CheckedState.BorderRadius = 2
        Me.chkboxAutoSearch.CheckedState.BorderThickness = 0
        Me.chkboxAutoSearch.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkboxAutoSearch.Location = New System.Drawing.Point(378, 60)
        Me.chkboxAutoSearch.Name = "chkboxAutoSearch"
        Me.chkboxAutoSearch.Size = New System.Drawing.Size(85, 17)
        Me.chkboxAutoSearch.TabIndex = 39
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
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(791, 20)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(86, 36)
        Me.btnSearch.TabIndex = 38
        Me.btnSearch.Text = "Search"
        '
        'Gender
        '
        Me.Gender.AutoSize = True
        Me.Gender.Location = New System.Drawing.Point(686, 4)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(42, 13)
        Me.Gender.TabIndex = 37
        Me.Gender.Text = "Gender"
        '
        'cmbGender
        '
        Me.cmbGender.BackColor = System.Drawing.Color.Transparent
        Me.cmbGender.BorderRadius = 10
        Me.cmbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.Enabled = False
        Me.cmbGender.FocusedColor = System.Drawing.Color.Empty
        Me.cmbGender.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.ItemHeight = 30
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(689, 20)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(90, 36)
        Me.cmbGender.StartIndex = 0
        Me.cmbGender.TabIndex = 36
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Location = New System.Drawing.Point(209, 4)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(29, 13)
        Me.lblFilter.TabIndex = 35
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
        Me.cmbFilter.Items.AddRange(New Object() {"By Name", "By Gender", "By LRN"})
        Me.cmbFilter.Location = New System.Drawing.Point(203, 20)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(167, 36)
        Me.cmbFilter.TabIndex = 34
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
        Me.txtSearchBox.Enabled = False
        Me.txtSearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchBox.IconLeft = CType(resources.GetObject("txtSearchBox.IconLeft"), System.Drawing.Image)
        Me.txtSearchBox.Location = New System.Drawing.Point(378, 20)
        Me.txtSearchBox.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchBox.PlaceholderText = "Search..."
        Me.txtSearchBox.SelectedText = ""
        Me.txtSearchBox.Size = New System.Drawing.Size(303, 36)
        Me.txtSearchBox.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Section"
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
        Me.cmbSection.Size = New System.Drawing.Size(182, 36)
        Me.cmbSection.TabIndex = 41
        '
        'uctrl_mystudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cmbSection)
        Me.Controls.Add(Me.chkboxAutoSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Gender)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.cmbFilter)
        Me.Controls.Add(Me.txtSearchBox)
        Me.Name = "uctrl_mystudent"
        Me.Size = New System.Drawing.Size(893, 572)
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvStudent As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents action_view As DataGridViewImageColumn
    Friend WithEvents action_edit As DataGridViewImageColumn
    Friend WithEvents action_delete As DataGridViewImageColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents chkboxAutoSearch As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Gender As Label
    Friend WithEvents cmbGender As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblFilter As Label
    Friend WithEvents cmbFilter As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtSearchBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbSection As Guna.UI2.WinForms.Guna2ComboBox
End Class

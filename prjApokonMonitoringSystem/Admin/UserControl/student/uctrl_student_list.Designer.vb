<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uctrl_student_list
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uctrl_student_list))
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvStudent = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.action_view = New System.Windows.Forms.DataGridViewImageColumn()
        Me.action_edit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.action_delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.currentPg = New System.Windows.Forms.Label()
        Me.pgRows = New System.Windows.Forms.Label()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.chkboxAutoSearch = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.Gender = New System.Windows.Forms.Label()
        Me.cmbGender = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.cmbFilter = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtSearchBox = New Guna.UI2.WinForms.Guna2TextBox()
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
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(22, 132)
        Me.Guna2ShadowPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(1293, 675)
        Me.Guna2ShadowPanel1.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(36, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 30)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Actions"
        '
        'dgvStudent
        '
        Me.dgvStudent.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvStudent.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStudent.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStudent.ColumnHeadersHeight = 50
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
        Me.dgvStudent.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvStudent.Location = New System.Drawing.Point(0, 0)
        Me.dgvStudent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvStudent.Name = "dgvStudent"
        Me.dgvStudent.ReadOnly = True
        Me.dgvStudent.RowHeadersVisible = False
        Me.dgvStudent.RowHeadersWidth = 62
        Me.dgvStudent.RowTemplate.Height = 80
        Me.dgvStudent.Size = New System.Drawing.Size(1293, 675)
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
        Me.action_view.MinimumWidth = 8
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
        Me.action_edit.MinimumWidth = 8
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
        Me.action_delete.MinimumWidth = 8
        Me.action_delete.Name = "action_delete"
        Me.action_delete.ReadOnly = True
        Me.action_delete.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.action_delete.Width = 35
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.currentPg)
        Me.Panel2.Controls.Add(Me.pgRows)
        Me.Panel2.Controls.Add(Me.Guna2Button4)
        Me.Panel2.Controls.Add(Me.Guna2Button3)
        Me.Panel2.Controls.Add(Me.Guna2Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 814)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1340, 66)
        Me.Panel2.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(219, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 20)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "of"
        '
        'currentPg
        '
        Me.currentPg.AutoSize = True
        Me.currentPg.Location = New System.Drawing.Point(177, 25)
        Me.currentPg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.currentPg.Name = "currentPg"
        Me.currentPg.Size = New System.Drawing.Size(18, 20)
        Me.currentPg.TabIndex = 51
        Me.currentPg.Text = "1"
        '
        'pgRows
        '
        Me.pgRows.AutoSize = True
        Me.pgRows.Location = New System.Drawing.Point(270, 25)
        Me.pgRows.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pgRows.Name = "pgRows"
        Me.pgRows.Size = New System.Drawing.Size(18, 20)
        Me.pgRows.TabIndex = 50
        Me.pgRows.Text = "?"
        '
        'Guna2Button4
        '
        Me.Guna2Button4.BorderRadius = 10
        Me.Guna2Button4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.Location = New System.Drawing.Point(315, 5)
        Me.Guna2Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Size = New System.Drawing.Size(129, 55)
        Me.Guna2Button4.TabIndex = 49
        Me.Guna2Button4.Text = ">"
        '
        'Guna2Button3
        '
        Me.Guna2Button3.BorderRadius = 10
        Me.Guna2Button3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.Location = New System.Drawing.Point(36, 5)
        Me.Guna2Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(129, 55)
        Me.Guna2Button3.TabIndex = 48
        Me.Guna2Button3.Text = "<"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.FillColor = System.Drawing.Color.Coral
        Me.Guna2Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.Location = New System.Drawing.Point(1194, 5)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(144, 57)
        Me.Guna2Button1.TabIndex = 1
        Me.Guna2Button1.Text = "Export"
        Me.Guna2Button1.TextOffset = New System.Drawing.Point(4, 0)
        '
        'chkboxAutoSearch
        '
        Me.chkboxAutoSearch.AutoSize = True
        Me.chkboxAutoSearch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkboxAutoSearch.CheckedState.BorderRadius = 2
        Me.chkboxAutoSearch.CheckedState.BorderThickness = 0
        Me.chkboxAutoSearch.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkboxAutoSearch.Location = New System.Drawing.Point(315, 100)
        Me.chkboxAutoSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkboxAutoSearch.Name = "chkboxAutoSearch"
        Me.chkboxAutoSearch.Size = New System.Drawing.Size(124, 24)
        Me.chkboxAutoSearch.TabIndex = 30
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
        Me.btnSearch.Location = New System.Drawing.Point(1186, 35)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(129, 55)
        Me.btnSearch.TabIndex = 29
        Me.btnSearch.Text = "Search"
        '
        'Gender
        '
        Me.Gender.AutoSize = True
        Me.Gender.Location = New System.Drawing.Point(884, 11)
        Me.Gender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(63, 20)
        Me.Gender.TabIndex = 28
        Me.Gender.Text = "Gender"
        '
        'cmbGender
        '
        Me.cmbGender.BackColor = System.Drawing.Color.Transparent
        Me.cmbGender.BorderRadius = 10
        Me.cmbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.FocusedColor = System.Drawing.Color.Empty
        Me.cmbGender.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.ItemHeight = 30
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(888, 35)
        Me.cmbGender.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(278, 36)
        Me.cmbGender.StartIndex = 0
        Me.cmbGender.TabIndex = 27
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Location = New System.Drawing.Point(32, 11)
        Me.lblFilter.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(44, 20)
        Me.lblFilter.TabIndex = 26
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
        Me.cmbFilter.Items.AddRange(New Object() {"All", "By Name", "By Gender", "By LRN", "By Section", "No Section"})
        Me.cmbFilter.Location = New System.Drawing.Point(22, 35)
        Me.cmbFilter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(278, 36)
        Me.cmbFilter.StartIndex = 0
        Me.cmbFilter.TabIndex = 25
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
        Me.txtSearchBox.Location = New System.Drawing.Point(315, 35)
        Me.txtSearchBox.Margin = New System.Windows.Forms.Padding(8)
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchBox.PlaceholderText = "Search..."
        Me.txtSearchBox.SelectedText = ""
        Me.txtSearchBox.Size = New System.Drawing.Size(561, 55)
        Me.txtSearchBox.TabIndex = 23
        '
        'uctrl_student_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.chkboxAutoSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Gender)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.cmbFilter)
        Me.Controls.Add(Me.txtSearchBox)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "uctrl_student_list"
        Me.Size = New System.Drawing.Size(1340, 880)
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
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
    Friend WithEvents chkboxAutoSearch As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Gender As Label
    Friend WithEvents cmbGender As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblFilter As Label
    Friend WithEvents cmbFilter As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtSearchBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pgRows As Label
    Friend WithEvents currentPg As Label
    Friend WithEvents Label2 As Label
End Class

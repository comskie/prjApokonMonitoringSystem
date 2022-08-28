<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowse_Teacher
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBrowse_Teacher))
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.dgvTeacher = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.chkboxAutoSearch = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.Gender = New System.Windows.Forms.Label()
        Me.cmbGender = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.cmbFilter = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtSearchBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.dgvTeacher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.dgvTeacher)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(15, 87)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(862, 439)
        Me.Guna2ShadowPanel1.TabIndex = 42
        '
        'dgvTeacher
        '
        Me.dgvTeacher.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvTeacher.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTeacher.BackgroundColor = System.Drawing.Color.White
        Me.dgvTeacher.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTeacher.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvTeacher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTeacher.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTeacher.ColumnHeadersHeight = 50
        Me.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvTeacher.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTeacher.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTeacher.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTeacher.EnableHeadersVisualStyles = False
        Me.dgvTeacher.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTeacher.Location = New System.Drawing.Point(0, 0)
        Me.dgvTeacher.Name = "dgvTeacher"
        Me.dgvTeacher.ReadOnly = True
        Me.dgvTeacher.RowHeadersVisible = False
        Me.dgvTeacher.RowTemplate.Height = 80
        Me.dgvTeacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTeacher.Size = New System.Drawing.Size(862, 439)
        Me.dgvTeacher.TabIndex = 0
        Me.dgvTeacher.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvTeacher.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvTeacher.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvTeacher.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvTeacher.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvTeacher.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvTeacher.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvTeacher.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTeacher.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTeacher.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvTeacher.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvTeacher.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvTeacher.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvTeacher.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvTeacher.ThemeStyle.ReadOnly = True
        Me.dgvTeacher.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvTeacher.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvTeacher.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvTeacher.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvTeacher.ThemeStyle.RowsStyle.Height = 80
        Me.dgvTeacher.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTeacher.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'chkboxAutoSearch
        '
        Me.chkboxAutoSearch.AutoSize = True
        Me.chkboxAutoSearch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkboxAutoSearch.CheckedState.BorderRadius = 2
        Me.chkboxAutoSearch.CheckedState.BorderThickness = 0
        Me.chkboxAutoSearch.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkboxAutoSearch.Location = New System.Drawing.Point(210, 66)
        Me.chkboxAutoSearch.Name = "chkboxAutoSearch"
        Me.chkboxAutoSearch.Size = New System.Drawing.Size(85, 17)
        Me.chkboxAutoSearch.TabIndex = 48
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
        Me.btnSearch.CheckedState.Parent = Me.btnSearch
        Me.btnSearch.CustomImages.Parent = Me.btnSearch
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.HoverState.Parent = Me.btnSearch
        Me.btnSearch.Location = New System.Drawing.Point(791, 24)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.ShadowDecoration.Parent = Me.btnSearch
        Me.btnSearch.Size = New System.Drawing.Size(86, 36)
        Me.btnSearch.TabIndex = 47
        Me.btnSearch.Text = "Search"
        '
        'Gender
        '
        Me.Gender.AutoSize = True
        Me.Gender.Location = New System.Drawing.Point(589, 8)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(42, 13)
        Me.Gender.TabIndex = 46
        Me.Gender.Text = "Gender"
        '
        'cmbGender
        '
        Me.cmbGender.BackColor = System.Drawing.Color.Transparent
        Me.cmbGender.BorderRadius = 10
        Me.cmbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.FocusedColor = System.Drawing.Color.Empty
        Me.cmbGender.FocusedState.Parent = Me.cmbGender
        Me.cmbGender.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.HoverState.Parent = Me.cmbGender
        Me.cmbGender.ItemHeight = 30
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.ItemsAppearance.Parent = Me.cmbGender
        Me.cmbGender.Location = New System.Drawing.Point(592, 24)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.ShadowDecoration.Parent = Me.cmbGender
        Me.cmbGender.Size = New System.Drawing.Size(187, 36)
        Me.cmbGender.StartIndex = 0
        Me.cmbGender.TabIndex = 45
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Location = New System.Drawing.Point(21, 8)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(29, 13)
        Me.lblFilter.TabIndex = 44
        Me.lblFilter.Text = "Filter"
        '
        'cmbFilter
        '
        Me.cmbFilter.BackColor = System.Drawing.Color.Transparent
        Me.cmbFilter.BorderRadius = 10
        Me.cmbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilter.FocusedColor = System.Drawing.Color.Empty
        Me.cmbFilter.FocusedState.Parent = Me.cmbFilter
        Me.cmbFilter.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.HoverState.Parent = Me.cmbFilter
        Me.cmbFilter.ItemHeight = 30
        Me.cmbFilter.Items.AddRange(New Object() {"All", "By Name", "By Gender"})
        Me.cmbFilter.ItemsAppearance.Parent = Me.cmbFilter
        Me.cmbFilter.Location = New System.Drawing.Point(15, 24)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.ShadowDecoration.Parent = Me.cmbFilter
        Me.cmbFilter.Size = New System.Drawing.Size(187, 36)
        Me.cmbFilter.StartIndex = 0
        Me.cmbFilter.TabIndex = 43
        '
        'txtSearchBox
        '
        Me.txtSearchBox.BorderRadius = 10
        Me.txtSearchBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchBox.DefaultText = ""
        Me.txtSearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchBox.DisabledState.Parent = Me.txtSearchBox
        Me.txtSearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchBox.FocusedState.Parent = Me.txtSearchBox
        Me.txtSearchBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchBox.HoverState.Parent = Me.txtSearchBox
        Me.txtSearchBox.IconLeft = CType(resources.GetObject("txtSearchBox.IconLeft"), System.Drawing.Image)
        Me.txtSearchBox.Location = New System.Drawing.Point(210, 24)
        Me.txtSearchBox.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchBox.PlaceholderText = "Search..."
        Me.txtSearchBox.SelectedText = ""
        Me.txtSearchBox.ShadowDecoration.Parent = Me.txtSearchBox
        Me.txtSearchBox.Size = New System.Drawing.Size(374, 36)
        Me.txtSearchBox.TabIndex = 41
        '
        'frmBrowse_Teacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(893, 549)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.chkboxAutoSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Gender)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.cmbFilter)
        Me.Controls.Add(Me.txtSearchBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmBrowse_Teacher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Browse Teacher"
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        CType(Me.dgvTeacher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents dgvTeacher As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents chkboxAutoSearch As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Gender As Label
    Friend WithEvents cmbGender As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblFilter As Label
    Friend WithEvents cmbFilter As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtSearchBox As Guna.UI2.WinForms.Guna2TextBox
End Class

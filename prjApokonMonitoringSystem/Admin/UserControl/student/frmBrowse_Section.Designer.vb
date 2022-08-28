<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowse_Section
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBrowse_Section))
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.dgvSection = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.cmbFilter = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkboxAutoSearch = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.cmbYearLevel = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.txtSearchBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.dgvSection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.dgvSection)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(15, 84)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(862, 439)
        Me.Guna2ShadowPanel1.TabIndex = 43
        '
        'dgvSection
        '
        Me.dgvSection.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvSection.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSection.BackgroundColor = System.Drawing.Color.White
        Me.dgvSection.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSection.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSection.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSection.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSection.ColumnHeadersHeight = 50
        Me.dgvSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSection.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSection.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSection.EnableHeadersVisualStyles = False
        Me.dgvSection.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSection.Location = New System.Drawing.Point(0, 0)
        Me.dgvSection.Name = "dgvSection"
        Me.dgvSection.ReadOnly = True
        Me.dgvSection.RowHeadersVisible = False
        Me.dgvSection.RowTemplate.Height = 80
        Me.dgvSection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSection.Size = New System.Drawing.Size(862, 439)
        Me.dgvSection.TabIndex = 0
        Me.dgvSection.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvSection.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvSection.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvSection.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvSection.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvSection.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvSection.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSection.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSection.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvSection.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvSection.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvSection.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSection.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvSection.ThemeStyle.ReadOnly = True
        Me.dgvSection.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvSection.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSection.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvSection.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvSection.ThemeStyle.RowsStyle.Height = 80
        Me.dgvSection.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSection.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'cmbFilter
        '
        Me.cmbFilter.BackColor = System.Drawing.Color.Transparent
        Me.cmbFilter.BorderRadius = 10
        Me.cmbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilter.FocusedColor = System.Drawing.Color.Empty
        Me.cmbFilter.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.ItemHeight = 30
        Me.cmbFilter.Items.AddRange(New Object() {"All", "By Section", "By Grade Level"})
        Me.cmbFilter.Location = New System.Drawing.Point(15, 21)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(187, 36)
        Me.cmbFilter.StartIndex = 0
        Me.cmbFilter.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(589, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Grade Level"
        '
        'chkboxAutoSearch
        '
        Me.chkboxAutoSearch.AutoSize = True
        Me.chkboxAutoSearch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkboxAutoSearch.CheckedState.BorderRadius = 2
        Me.chkboxAutoSearch.CheckedState.BorderThickness = 0
        Me.chkboxAutoSearch.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chkboxAutoSearch.Location = New System.Drawing.Point(210, 63)
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
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(791, 21)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(86, 36)
        Me.btnSearch.TabIndex = 47
        Me.btnSearch.Text = "Search"
        '
        'cmbYearLevel
        '
        Me.cmbYearLevel.BackColor = System.Drawing.Color.Transparent
        Me.cmbYearLevel.BorderRadius = 10
        Me.cmbYearLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbYearLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYearLevel.FocusedColor = System.Drawing.Color.Empty
        Me.cmbYearLevel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYearLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbYearLevel.FormattingEnabled = True
        Me.cmbYearLevel.ItemHeight = 30
        Me.cmbYearLevel.Items.AddRange(New Object() {"Kinder 1", "Kinder 2", "Grade 1", "Grade 2", "Grade 3", "Grade 4", "Grade 5", "Grade 6"})
        Me.cmbYearLevel.Location = New System.Drawing.Point(592, 21)
        Me.cmbYearLevel.Name = "cmbYearLevel"
        Me.cmbYearLevel.Size = New System.Drawing.Size(187, 36)
        Me.cmbYearLevel.TabIndex = 46
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Location = New System.Drawing.Point(21, 5)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(29, 13)
        Me.lblFilter.TabIndex = 45
        Me.lblFilter.Text = "Filter"
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
        Me.txtSearchBox.Location = New System.Drawing.Point(210, 21)
        Me.txtSearchBox.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchBox.PlaceholderText = "Search..."
        Me.txtSearchBox.SelectedText = ""
        Me.txtSearchBox.Size = New System.Drawing.Size(374, 36)
        Me.txtSearchBox.TabIndex = 42
        '
        'frmBrowse_Section
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(893, 549)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.cmbFilter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkboxAutoSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.cmbYearLevel)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.txtSearchBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmBrowse_Section"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Browse Section"
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        CType(Me.dgvSection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents dgvSection As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents cmbFilter As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkboxAutoSearch As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbYearLevel As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblFilter As Label
    Friend WithEvents txtSearchBox As Guna.UI2.WinForms.Guna2TextBox
End Class

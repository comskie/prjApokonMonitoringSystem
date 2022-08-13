<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uctrl_import_student
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uctrl_import_student))
        Me.dgvImported = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.txtFileLocation = New Guna.UI2.WinForms.Guna2TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.ProfileContainer = New System.Windows.Forms.Panel()
        Me.lrn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pcontact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pemail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.syear = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvImported, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvImported
        '
        Me.dgvImported.AllowUserToAddRows = False
        Me.dgvImported.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvImported.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvImported.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvImported.BackgroundColor = System.Drawing.Color.White
        Me.dgvImported.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvImported.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvImported.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvImported.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvImported.ColumnHeadersHeight = 50
        Me.dgvImported.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvImported.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.lrn, Me.fname, Me.mname, Me.lname, Me.gender, Me.address, Me.pname, Me.pcontact, Me.pemail, Me.syear})
        Me.dgvImported.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvImported.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvImported.EnableHeadersVisualStyles = False
        Me.dgvImported.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvImported.Location = New System.Drawing.Point(15, 88)
        Me.dgvImported.Name = "dgvImported"
        Me.dgvImported.ReadOnly = True
        Me.dgvImported.RowHeadersVisible = False
        Me.dgvImported.RowTemplate.Height = 80
        Me.dgvImported.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvImported.Size = New System.Drawing.Size(862, 417)
        Me.dgvImported.TabIndex = 1
        Me.dgvImported.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvImported.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvImported.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvImported.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvImported.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvImported.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvImported.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvImported.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvImported.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvImported.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvImported.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvImported.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvImported.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvImported.ThemeStyle.HeaderStyle.Height = 50
        Me.dgvImported.ThemeStyle.ReadOnly = True
        Me.dgvImported.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvImported.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvImported.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgvImported.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvImported.ThemeStyle.RowsStyle.Height = 80
        Me.dgvImported.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvImported.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2Button3
        '
        Me.Guna2Button3.Animated = True
        Me.Guna2Button3.AutoRoundedCorners = True
        Me.Guna2Button3.BorderRadius = 21
        Me.Guna2Button3.CheckedState.Parent = Me.Guna2Button3
        Me.Guna2Button3.CustomImages.Parent = Me.Guna2Button3
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.HoverState.Parent = Me.Guna2Button3
        Me.Guna2Button3.Location = New System.Drawing.Point(15, 28)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.ShadowDecoration.Parent = Me.Guna2Button3
        Me.Guna2Button3.Size = New System.Drawing.Size(107, 45)
        Me.Guna2Button3.TabIndex = 17
        Me.Guna2Button3.Text = "Browse"
        '
        'txtFileLocation
        '
        Me.txtFileLocation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFileLocation.DefaultText = ""
        Me.txtFileLocation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFileLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFileLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFileLocation.DisabledState.Parent = Me.txtFileLocation
        Me.txtFileLocation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFileLocation.Enabled = False
        Me.txtFileLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFileLocation.FocusedState.Parent = Me.txtFileLocation
        Me.txtFileLocation.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFileLocation.HoverState.Parent = Me.txtFileLocation
        Me.txtFileLocation.Location = New System.Drawing.Point(129, 28)
        Me.txtFileLocation.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFileLocation.Name = "txtFileLocation"
        Me.txtFileLocation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFileLocation.PlaceholderText = ""
        Me.txtFileLocation.SelectedText = ""
        Me.txtFileLocation.ShadowDecoration.Parent = Me.txtFileLocation
        Me.txtFileLocation.Size = New System.Drawing.Size(256, 45)
        Me.txtFileLocation.TabIndex = 18
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BorderRadius = 21
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(718, 28)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(159, 45)
        Me.Guna2Button1.TabIndex = 19
        Me.Guna2Button1.Text = "Download Template"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.AutoRoundedCorners = True
        Me.Guna2Button2.BorderRadius = 21
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(361, 514)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(159, 45)
        Me.Guna2Button2.TabIndex = 20
        Me.Guna2Button2.Text = "Import Records"
        '
        'ProfileContainer
        '
        Me.ProfileContainer.BackgroundImage = CType(resources.GetObject("ProfileContainer.BackgroundImage"), System.Drawing.Image)
        Me.ProfileContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProfileContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProfileContainer.Location = New System.Drawing.Point(663, 31)
        Me.ProfileContainer.Name = "ProfileContainer"
        Me.ProfileContainer.Size = New System.Drawing.Size(49, 42)
        Me.ProfileContainer.TabIndex = 21
        Me.ProfileContainer.Visible = False
        '
        'lrn
        '
        Me.lrn.HeaderText = "LRN"
        Me.lrn.Name = "lrn"
        Me.lrn.ReadOnly = True
        '
        'fname
        '
        Me.fname.HeaderText = "First Name"
        Me.fname.Name = "fname"
        Me.fname.ReadOnly = True
        '
        'mname
        '
        Me.mname.HeaderText = "Middle Name"
        Me.mname.Name = "mname"
        Me.mname.ReadOnly = True
        '
        'lname
        '
        Me.lname.HeaderText = "Last Name"
        Me.lname.Name = "lname"
        Me.lname.ReadOnly = True
        '
        'gender
        '
        Me.gender.HeaderText = "Gender"
        Me.gender.Name = "gender"
        Me.gender.ReadOnly = True
        '
        'address
        '
        Me.address.HeaderText = "Address"
        Me.address.Name = "address"
        Me.address.ReadOnly = True
        '
        'pname
        '
        Me.pname.HeaderText = "Parent's Name"
        Me.pname.Name = "pname"
        Me.pname.ReadOnly = True
        '
        'pcontact
        '
        Me.pcontact.HeaderText = "Parent's Contact No."
        Me.pcontact.Name = "pcontact"
        Me.pcontact.ReadOnly = True
        '
        'pemail
        '
        Me.pemail.HeaderText = "Parent's Email"
        Me.pemail.Name = "pemail"
        Me.pemail.ReadOnly = True
        '
        'syear
        '
        Me.syear.HeaderText = "Year Level"
        Me.syear.Name = "syear"
        Me.syear.ReadOnly = True
        '
        'uctrl_import_student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ProfileContainer)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.txtFileLocation)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.dgvImported)
        Me.Name = "uctrl_import_student"
        Me.Size = New System.Drawing.Size(893, 572)
        CType(Me.dgvImported, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvImported As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtFileLocation As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ProfileContainer As Panel
    Friend WithEvents lrn As DataGridViewTextBoxColumn
    Friend WithEvents fname As DataGridViewTextBoxColumn
    Friend WithEvents mname As DataGridViewTextBoxColumn
    Friend WithEvents lname As DataGridViewTextBoxColumn
    Friend WithEvents gender As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents pname As DataGridViewTextBoxColumn
    Friend WithEvents pcontact As DataGridViewTextBoxColumn
    Friend WithEvents pemail As DataGridViewTextBoxColumn
    Friend WithEvents syear As DataGridViewTextBoxColumn
End Class

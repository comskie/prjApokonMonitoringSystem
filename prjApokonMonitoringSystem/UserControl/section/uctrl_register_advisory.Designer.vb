<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uctrl_register_advisory
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbYearLevel = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSectionName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.txtTeacherInfo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtTeacher = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(51, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Year Level:"
        '
        'cmbYearLevel
        '
        Me.cmbYearLevel.BackColor = System.Drawing.Color.Transparent
        Me.cmbYearLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbYearLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYearLevel.FocusedColor = System.Drawing.Color.Empty
        Me.cmbYearLevel.FocusedState.Parent = Me.cmbYearLevel
        Me.cmbYearLevel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbYearLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbYearLevel.FormattingEnabled = True
        Me.cmbYearLevel.HoverState.Parent = Me.cmbYearLevel
        Me.cmbYearLevel.ItemHeight = 30
        Me.cmbYearLevel.Items.AddRange(New Object() {"Kinder 1", "Kinder 2", "Grade 1", "Grade 2", "Grade 3", "Grade 4", "Grade 5", "Grade 6"})
        Me.cmbYearLevel.ItemsAppearance.Parent = Me.cmbYearLevel
        Me.cmbYearLevel.Location = New System.Drawing.Point(121, 111)
        Me.cmbYearLevel.Name = "cmbYearLevel"
        Me.cmbYearLevel.ShadowDecoration.Parent = Me.cmbYearLevel
        Me.cmbYearLevel.Size = New System.Drawing.Size(235, 36)
        Me.cmbYearLevel.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(14, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 15)
        Me.Label3.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(29, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Section Name:"
        '
        'txtSectionName
        '
        Me.txtSectionName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSectionName.DefaultText = ""
        Me.txtSectionName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSectionName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSectionName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSectionName.DisabledState.Parent = Me.txtSectionName
        Me.txtSectionName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSectionName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSectionName.FocusedState.Parent = Me.txtSectionName
        Me.txtSectionName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSectionName.HoverState.Parent = Me.txtSectionName
        Me.txtSectionName.Location = New System.Drawing.Point(121, 62)
        Me.txtSectionName.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txtSectionName.Name = "txtSectionName"
        Me.txtSectionName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSectionName.PlaceholderText = ""
        Me.txtSectionName.SelectedText = ""
        Me.txtSectionName.ShadowDecoration.Parent = Me.txtSectionName
        Me.txtSectionName.Size = New System.Drawing.Size(235, 36)
        Me.txtSectionName.TabIndex = 2
        '
        'Guna2Button4
        '
        Me.Guna2Button4.Animated = True
        Me.Guna2Button4.AutoRoundedCorners = True
        Me.Guna2Button4.BorderRadius = 21
        Me.Guna2Button4.CheckedState.Parent = Me.Guna2Button4
        Me.Guna2Button4.CustomImages.Parent = Me.Guna2Button4
        Me.Guna2Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.HoverState.Parent = Me.Guna2Button4
        Me.Guna2Button4.Location = New System.Drawing.Point(480, 323)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.ShadowDecoration.Parent = Me.Guna2Button4
        Me.Guna2Button4.Size = New System.Drawing.Size(107, 45)
        Me.Guna2Button4.TabIndex = 26
        Me.Guna2Button4.Text = "Clear"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button1)
        Me.Guna2GroupBox1.Controls.Add(Me.txtTeacherInfo)
        Me.Guna2GroupBox1.Controls.Add(Me.txtTeacher)
        Me.Guna2GroupBox1.Controls.Add(Me.Label7)
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.Controls.Add(Me.cmbYearLevel)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.txtSectionName)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(18, 61)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(854, 240)
        Me.Guna2GroupBox1.TabIndex = 23
        Me.Guna2GroupBox1.Text = "Section Information"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BorderRadius = 17
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(376, 168)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(107, 36)
        Me.Guna2Button1.TabIndex = 27
        Me.Guna2Button1.Text = "Browse"
        '
        'txtTeacherInfo
        '
        Me.txtTeacherInfo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTeacherInfo.DefaultText = ""
        Me.txtTeacherInfo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTeacherInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTeacherInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTeacherInfo.DisabledState.Parent = Me.txtTeacherInfo
        Me.txtTeacherInfo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTeacherInfo.Enabled = False
        Me.txtTeacherInfo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTeacherInfo.FocusedState.Parent = Me.txtTeacherInfo
        Me.txtTeacherInfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTeacherInfo.HoverState.Parent = Me.txtTeacherInfo
        Me.txtTeacherInfo.Location = New System.Drawing.Point(507, 94)
        Me.txtTeacherInfo.Margin = New System.Windows.Forms.Padding(7, 3, 7, 3)
        Me.txtTeacherInfo.Name = "txtTeacherInfo"
        Me.txtTeacherInfo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTeacherInfo.PlaceholderText = ""
        Me.txtTeacherInfo.SelectedText = ""
        Me.txtTeacherInfo.ShadowDecoration.Parent = Me.txtTeacherInfo
        Me.txtTeacherInfo.Size = New System.Drawing.Size(274, 42)
        Me.txtTeacherInfo.TabIndex = 16
        Me.txtTeacherInfo.Visible = False
        '
        'txtTeacher
        '
        Me.txtTeacher.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTeacher.DefaultText = ""
        Me.txtTeacher.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTeacher.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTeacher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTeacher.DisabledState.Parent = Me.txtTeacher
        Me.txtTeacher.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTeacher.Enabled = False
        Me.txtTeacher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTeacher.FocusedState.Parent = Me.txtTeacher
        Me.txtTeacher.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTeacher.HoverState.Parent = Me.txtTeacher
        Me.txtTeacher.Location = New System.Drawing.Point(121, 168)
        Me.txtTeacher.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtTeacher.Name = "txtTeacher"
        Me.txtTeacher.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTeacher.PlaceholderText = ""
        Me.txtTeacher.SelectedText = ""
        Me.txtTeacher.ShadowDecoration.Parent = Me.txtTeacher
        Me.txtTeacher.Size = New System.Drawing.Size(235, 36)
        Me.txtTeacher.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(62, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Teacher:"
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
        Me.Guna2Button3.Location = New System.Drawing.Point(279, 323)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.ShadowDecoration.Parent = Me.Guna2Button3
        Me.Guna2Button3.Size = New System.Drawing.Size(107, 45)
        Me.Guna2Button3.TabIndex = 25
        Me.Guna2Button3.Text = "Save"
        '
        'uctrl_register_advisory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.Guna2Button4)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Name = "uctrl_register_advisory"
        Me.Size = New System.Drawing.Size(893, 572)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbYearLevel As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSectionName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTeacher As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtTeacherInfo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
End Class

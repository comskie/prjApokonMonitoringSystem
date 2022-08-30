<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_edit_section
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbYearLevel = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSectionName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.prevTeacher = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbltid = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.txtTeacher = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtColID = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(51, 157)
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
        Me.cmbYearLevel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbYearLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbYearLevel.FormattingEnabled = True
        Me.cmbYearLevel.ItemHeight = 30
        Me.cmbYearLevel.Items.AddRange(New Object() {"Kinder 1", "Kinder 2", "Grade 1", "Grade 2", "Grade 3", "Grade 4", "Grade 5", "Grade 6"})
        Me.cmbYearLevel.Location = New System.Drawing.Point(121, 147)
        Me.cmbYearLevel.Name = "cmbYearLevel"
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
        Me.Label2.Location = New System.Drawing.Point(29, 108)
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
        Me.txtSectionName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSectionName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSectionName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSectionName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSectionName.Location = New System.Drawing.Point(121, 98)
        Me.txtSectionName.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txtSectionName.Name = "txtSectionName"
        Me.txtSectionName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSectionName.PlaceholderText = ""
        Me.txtSectionName.SelectedText = ""
        Me.txtSectionName.Size = New System.Drawing.Size(235, 36)
        Me.txtSectionName.TabIndex = 2
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.prevTeacher)
        Me.Guna2GroupBox1.Controls.Add(Me.Label8)
        Me.Guna2GroupBox1.Controls.Add(Me.lbltid)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button1)
        Me.Guna2GroupBox1.Controls.Add(Me.txtTeacher)
        Me.Guna2GroupBox1.Controls.Add(Me.Label7)
        Me.Guna2GroupBox1.Controls.Add(Me.txtColID)
        Me.Guna2GroupBox1.Controls.Add(Me.Label6)
        Me.Guna2GroupBox1.Controls.Add(Me.txtSID)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.Controls.Add(Me.cmbYearLevel)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.txtSectionName)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(19, 86)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(854, 254)
        Me.Guna2GroupBox1.TabIndex = 27
        Me.Guna2GroupBox1.Text = "Section Information"
        '
        'prevTeacher
        '
        Me.prevTeacher.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.prevTeacher.DefaultText = ""
        Me.prevTeacher.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.prevTeacher.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.prevTeacher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.prevTeacher.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.prevTeacher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.prevTeacher.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.prevTeacher.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.prevTeacher.Location = New System.Drawing.Point(491, 87)
        Me.prevTeacher.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.prevTeacher.Name = "prevTeacher"
        Me.prevTeacher.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.prevTeacher.PlaceholderText = ""
        Me.prevTeacher.SelectedText = ""
        Me.prevTeacher.Size = New System.Drawing.Size(235, 36)
        Me.prevTeacher.TabIndex = 38
        Me.prevTeacher.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(407, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 15)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Prev Teacher:"
        Me.Label8.Visible = False
        '
        'lbltid
        '
        Me.lbltid.AutoSize = True
        Me.lbltid.ForeColor = System.Drawing.Color.Black
        Me.lbltid.Location = New System.Drawing.Point(532, 208)
        Me.lbltid.Name = "lbltid"
        Me.lbltid.Size = New System.Drawing.Size(55, 15)
        Me.lbltid.TabIndex = 36
        Me.lbltid.Text = "[no data]"
        Me.lbltid.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(462, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 15)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Teacher ID:"
        Me.Label4.Visible = False
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BorderRadius = 17
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(373, 199)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(83, 36)
        Me.Guna2Button1.TabIndex = 34
        Me.Guna2Button1.Text = "Browse"
        '
        'txtTeacher
        '
        Me.txtTeacher.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTeacher.DefaultText = ""
        Me.txtTeacher.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTeacher.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTeacher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTeacher.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTeacher.Enabled = False
        Me.txtTeacher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTeacher.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTeacher.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTeacher.Location = New System.Drawing.Point(121, 199)
        Me.txtTeacher.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txtTeacher.Name = "txtTeacher"
        Me.txtTeacher.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTeacher.PlaceholderText = ""
        Me.txtTeacher.SelectedText = ""
        Me.txtTeacher.Size = New System.Drawing.Size(235, 36)
        Me.txtTeacher.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(63, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 15)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Teacher:"
        '
        'txtColID
        '
        Me.txtColID.AutoSize = True
        Me.txtColID.ForeColor = System.Drawing.Color.Black
        Me.txtColID.Location = New System.Drawing.Point(451, 60)
        Me.txtColID.Name = "txtColID"
        Me.txtColID.Size = New System.Drawing.Size(55, 15)
        Me.txtColID.TabIndex = 31
        Me.txtColID.Text = "[no data]"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(403, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 15)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Col ID:"
        '
        'txtSID
        '
        Me.txtSID.AutoSize = True
        Me.txtSID.ForeColor = System.Drawing.Color.Black
        Me.txtSID.Location = New System.Drawing.Point(119, 59)
        Me.txtSID.Name = "txtSID"
        Me.txtSID.Size = New System.Drawing.Size(55, 15)
        Me.txtSID.TabIndex = 29
        Me.txtSID.Text = "[no data]"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(49, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Section ID:"
        '
        'Guna2Button3
        '
        Me.Guna2Button3.Animated = True
        Me.Guna2Button3.AutoRoundedCorners = True
        Me.Guna2Button3.BorderRadius = 21
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.Location = New System.Drawing.Point(368, 360)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(107, 45)
        Me.Guna2Button3.TabIndex = 28
        Me.Guna2Button3.Text = "Save"
        '
        'frm_edit_section
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(893, 614)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.Guna2Button3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_edit_section"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Section"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents cmbYearLevel As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSectionName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtSID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtColID As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbltid As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents prevTeacher As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTeacher As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
End Class

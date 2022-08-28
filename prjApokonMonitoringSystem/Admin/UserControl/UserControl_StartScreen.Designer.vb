<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_StartScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl_StartScreen))
        Me.Guna2CirclePictureBox2 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel6 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.txtTeachers = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.IconPictureBox6 = New FontAwesome.Sharp.IconPictureBox()
        Me.Guna2GradientPanel3 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.txtUsers = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.txtStudents = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel6.SuspendLayout()
        CType(Me.IconPictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel3.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2CirclePictureBox2
        '
        Me.Guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox2.Image = CType(resources.GetObject("Guna2CirclePictureBox2.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox2.ImageRotate = 0!
        Me.Guna2CirclePictureBox2.Location = New System.Drawing.Point(316, 36)
        Me.Guna2CirclePictureBox2.Name = "Guna2CirclePictureBox2"
        Me.Guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox2.Size = New System.Drawing.Size(269, 298)
        Me.Guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox2.TabIndex = 3
        Me.Guna2CirclePictureBox2.TabStop = False
        Me.Guna2CirclePictureBox2.UseTransparentBackground = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(250, 337)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 36)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Student Monitoring System"
        '
        'Guna2GradientPanel6
        '
        Me.Guna2GradientPanel6.BorderRadius = 10
        Me.Guna2GradientPanel6.Controls.Add(Me.txtTeachers)
        Me.Guna2GradientPanel6.Controls.Add(Me.Label9)
        Me.Guna2GradientPanel6.Controls.Add(Me.IconPictureBox6)
        Me.Guna2GradientPanel6.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Guna2GradientPanel6.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Guna2GradientPanel6.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.Guna2GradientPanel6.Location = New System.Drawing.Point(615, 420)
        Me.Guna2GradientPanel6.Name = "Guna2GradientPanel6"
        Me.Guna2GradientPanel6.Size = New System.Drawing.Size(264, 121)
        Me.Guna2GradientPanel6.TabIndex = 7
        '
        'txtTeachers
        '
        Me.txtTeachers.AutoSize = True
        Me.txtTeachers.BackColor = System.Drawing.Color.Transparent
        Me.txtTeachers.Font = New System.Drawing.Font("Impact", 21.75!)
        Me.txtTeachers.ForeColor = System.Drawing.Color.White
        Me.txtTeachers.Location = New System.Drawing.Point(21, 45)
        Me.txtTeachers.Name = "txtTeachers"
        Me.txtTeachers.Size = New System.Drawing.Size(31, 36)
        Me.txtTeachers.TabIndex = 2
        Me.txtTeachers.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(26, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 17)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Total Teachers"
        '
        'IconPictureBox6
        '
        Me.IconPictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.UserFriends
        Me.IconPictureBox6.IconColor = System.Drawing.Color.White
        Me.IconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox6.IconSize = 112
        Me.IconPictureBox6.Location = New System.Drawing.Point(178, 36)
        Me.IconPictureBox6.Name = "IconPictureBox6"
        Me.IconPictureBox6.Size = New System.Drawing.Size(116, 112)
        Me.IconPictureBox6.TabIndex = 1
        Me.IconPictureBox6.TabStop = False
        '
        'Guna2GradientPanel3
        '
        Me.Guna2GradientPanel3.BorderRadius = 10
        Me.Guna2GradientPanel3.Controls.Add(Me.txtUsers)
        Me.Guna2GradientPanel3.Controls.Add(Me.Label5)
        Me.Guna2GradientPanel3.Controls.Add(Me.IconPictureBox1)
        Me.Guna2GradientPanel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Guna2GradientPanel3.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Guna2GradientPanel3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.Guna2GradientPanel3.Location = New System.Drawing.Point(316, 420)
        Me.Guna2GradientPanel3.Name = "Guna2GradientPanel3"
        Me.Guna2GradientPanel3.Size = New System.Drawing.Size(264, 121)
        Me.Guna2GradientPanel3.TabIndex = 6
        '
        'txtUsers
        '
        Me.txtUsers.AutoSize = True
        Me.txtUsers.BackColor = System.Drawing.Color.Transparent
        Me.txtUsers.Font = New System.Drawing.Font("Impact", 21.75!)
        Me.txtUsers.ForeColor = System.Drawing.Color.White
        Me.txtUsers.Location = New System.Drawing.Point(21, 45)
        Me.txtUsers.Name = "txtUsers"
        Me.txtUsers.Size = New System.Drawing.Size(31, 36)
        Me.txtUsers.TabIndex = 2
        Me.txtUsers.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(26, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Total Users"
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CircleUser
        Me.IconPictureBox1.IconColor = System.Drawing.Color.White
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 129
        Me.IconPictureBox1.Location = New System.Drawing.Point(160, 29)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(140, 129)
        Me.IconPictureBox1.TabIndex = 1
        Me.IconPictureBox1.TabStop = False
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BorderRadius = 10
        Me.Guna2GradientPanel1.Controls.Add(Me.IconPictureBox2)
        Me.Guna2GradientPanel1.Controls.Add(Me.txtStudents)
        Me.Guna2GradientPanel1.Controls.Add(Me.label2)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(16, 420)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(264, 121)
        Me.Guna2GradientPanel1.TabIndex = 5
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserFriends
        Me.IconPictureBox2.IconColor = System.Drawing.Color.White
        Me.IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox2.IconSize = 112
        Me.IconPictureBox2.Location = New System.Drawing.Point(178, 38)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(116, 112)
        Me.IconPictureBox2.TabIndex = 3
        Me.IconPictureBox2.TabStop = False
        '
        'txtStudents
        '
        Me.txtStudents.AutoSize = True
        Me.txtStudents.BackColor = System.Drawing.Color.Transparent
        Me.txtStudents.Font = New System.Drawing.Font("Impact", 21.75!)
        Me.txtStudents.ForeColor = System.Drawing.Color.White
        Me.txtStudents.Location = New System.Drawing.Point(21, 45)
        Me.txtStudents.Name = "txtStudents"
        Me.txtStudents.Size = New System.Drawing.Size(31, 36)
        Me.txtStudents.TabIndex = 2
        Me.txtStudents.Text = "0"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(26, 28)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(97, 17)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Total Students"
        '
        'UserControl_StartScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Guna2GradientPanel6)
        Me.Controls.Add(Me.Guna2GradientPanel3)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2CirclePictureBox2)
        Me.Name = "UserControl_StartScreen"
        Me.Size = New System.Drawing.Size(893, 617)
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel6.ResumeLayout(False)
        Me.Guna2GradientPanel6.PerformLayout()
        CType(Me.IconPictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel3.ResumeLayout(False)
        Me.Guna2GradientPanel3.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2CirclePictureBox2 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2GradientPanel6 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents txtTeachers As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents IconPictureBox6 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Guna2GradientPanel3 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents txtUsers As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents txtStudents As Label
    Friend WithEvents label2 As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
End Class

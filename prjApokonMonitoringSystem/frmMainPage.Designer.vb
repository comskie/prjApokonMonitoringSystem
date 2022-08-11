<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainPage
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainPage))
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.PanelMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.IconButton5 = New FontAwesome.Sharp.IconButton()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.btnStudent = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.currentIcon = New FontAwesome.Sharp.IconPictureBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.ProfilePicture = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.IconButton7 = New FontAwesome.Sharp.IconButton()
        Me.UserControlPanel = New System.Windows.Forms.Panel()
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.currentIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.ProfilePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(31, 32)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(138, 135)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 24
        Me.Guna2PictureBox1.TabStop = False
        '
        'PanelMenu
        '
        Me.PanelMenu.Controls.Add(Me.IconButton5)
        Me.PanelMenu.Controls.Add(Me.IconButton4)
        Me.PanelMenu.Controls.Add(Me.IconButton3)
        Me.PanelMenu.Controls.Add(Me.IconButton2)
        Me.PanelMenu.Controls.Add(Me.IconButton1)
        Me.PanelMenu.Controls.Add(Me.btnStudent)
        Me.PanelMenu.Controls.Add(Me.Panel2)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.ShadowDecoration.Parent = Me.PanelMenu
        Me.PanelMenu.Size = New System.Drawing.Size(221, 665)
        Me.PanelMenu.TabIndex = 3
        '
        'IconButton5
        '
        Me.IconButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.IconButton5.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton5.FlatAppearance.BorderSize = 0
        Me.IconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton5.ForeColor = System.Drawing.Color.White
        Me.IconButton5.IconChar = FontAwesome.Sharp.IconChar.Database
        Me.IconButton5.IconColor = System.Drawing.Color.White
        Me.IconButton5.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton5.IconSize = 30
        Me.IconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton5.Location = New System.Drawing.Point(0, 407)
        Me.IconButton5.Name = "IconButton5"
        Me.IconButton5.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton5.Size = New System.Drawing.Size(221, 55)
        Me.IconButton5.TabIndex = 10
        Me.IconButton5.Text = "Backup"
        Me.IconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.IconButton5.UseVisualStyleBackColor = False
        '
        'IconButton4
        '
        Me.IconButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.IconButton4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.IconButton4.FlatAppearance.BorderSize = 0
        Me.IconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton4.ForeColor = System.Drawing.Color.White
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.IconButton4.IconColor = System.Drawing.Color.White
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton4.IconSize = 30
        Me.IconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton4.Location = New System.Drawing.Point(0, 610)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton4.Size = New System.Drawing.Size(221, 55)
        Me.IconButton4.TabIndex = 9
        Me.IconButton4.Text = "Logout"
        Me.IconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.IconButton4.UseVisualStyleBackColor = False
        '
        'IconButton3
        '
        Me.IconButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.IconButton3.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton3.ForeColor = System.Drawing.Color.White
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.Bell
        Me.IconButton3.IconColor = System.Drawing.Color.White
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 30
        Me.IconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton3.Location = New System.Drawing.Point(0, 352)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton3.Size = New System.Drawing.Size(221, 55)
        Me.IconButton3.TabIndex = 8
        Me.IconButton3.Text = "Notify"
        Me.IconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.IconButton3.UseVisualStyleBackColor = False
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.IconButton2.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.ForeColor = System.Drawing.Color.White
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Book
        Me.IconButton2.IconColor = System.Drawing.Color.White
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 30
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton2.Location = New System.Drawing.Point(0, 297)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton2.Size = New System.Drawing.Size(221, 55)
        Me.IconButton2.TabIndex = 7
        Me.IconButton2.Text = "Logs"
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.IconButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Qrcode
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 30
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton1.Location = New System.Drawing.Point(0, 242)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton1.Size = New System.Drawing.Size(221, 55)
        Me.IconButton1.TabIndex = 6
        Me.IconButton1.Text = "Scan ID"
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'btnStudent
        '
        Me.btnStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnStudent.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStudent.FlatAppearance.BorderSize = 0
        Me.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudent.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudent.ForeColor = System.Drawing.Color.White
        Me.btnStudent.IconChar = FontAwesome.Sharp.IconChar.User
        Me.btnStudent.IconColor = System.Drawing.Color.White
        Me.btnStudent.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnStudent.IconSize = 30
        Me.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStudent.Location = New System.Drawing.Point(0, 187)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnStudent.Size = New System.Drawing.Size(221, 55)
        Me.btnStudent.TabIndex = 5
        Me.btnStudent.Text = "Student"
        Me.btnStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnStudent.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Guna2PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(221, 187)
        Me.Panel2.TabIndex = 3
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(52, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(39, 16)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Home"
        '
        'currentIcon
        '
        Me.currentIcon.BackColor = System.Drawing.Color.Transparent
        Me.currentIcon.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.currentIcon.IconColor = System.Drawing.Color.White
        Me.currentIcon.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.currentIcon.Location = New System.Drawing.Point(14, 10)
        Me.currentIcon.Name = "currentIcon"
        Me.currentIcon.Size = New System.Drawing.Size(32, 32)
        Me.currentIcon.TabIndex = 4
        Me.currentIcon.TabStop = False
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.lblClock)
        Me.Guna2Panel2.Controls.Add(Me.ProfilePicture)
        Me.Guna2Panel2.Controls.Add(Me.lblTitle)
        Me.Guna2Panel2.Controls.Add(Me.currentIcon)
        Me.Guna2Panel2.Controls.Add(Me.IconButton7)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(221, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(893, 48)
        Me.Guna2Panel2.TabIndex = 4
        '
        'lblClock
        '
        Me.lblClock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClock.AutoSize = True
        Me.lblClock.BackColor = System.Drawing.Color.Transparent
        Me.lblClock.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClock.ForeColor = System.Drawing.Color.White
        Me.lblClock.Location = New System.Drawing.Point(702, 13)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(72, 21)
        Me.lblClock.TabIndex = 7
        Me.lblClock.Text = "00:00:00"
        '
        'ProfilePicture
        '
        Me.ProfilePicture.BackColor = System.Drawing.Color.Transparent
        Me.ProfilePicture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProfilePicture.Image = CType(resources.GetObject("ProfilePicture.Image"), System.Drawing.Image)
        Me.ProfilePicture.Location = New System.Drawing.Point(811, 3)
        Me.ProfilePicture.Name = "ProfilePicture"
        Me.ProfilePicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.ProfilePicture.ShadowDecoration.Parent = Me.ProfilePicture
        Me.ProfilePicture.Size = New System.Drawing.Size(40, 39)
        Me.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProfilePicture.TabIndex = 0
        Me.ProfilePicture.TabStop = False
        Me.ProfilePicture.UseTransparentBackground = True
        '
        'IconButton7
        '
        Me.IconButton7.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.IconButton7.Dock = System.Windows.Forms.DockStyle.Right
        Me.IconButton7.FlatAppearance.BorderSize = 0
        Me.IconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton7.ForeColor = System.Drawing.Color.White
        Me.IconButton7.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.IconButton7.IconColor = System.Drawing.Color.White
        Me.IconButton7.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton7.IconSize = 30
        Me.IconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton7.Location = New System.Drawing.Point(857, 0)
        Me.IconButton7.Name = "IconButton7"
        Me.IconButton7.Size = New System.Drawing.Size(36, 48)
        Me.IconButton7.TabIndex = 5
        Me.IconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton7.UseVisualStyleBackColor = False
        '
        'UserControlPanel
        '
        Me.UserControlPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UserControlPanel.Location = New System.Drawing.Point(221, 48)
        Me.UserControlPanel.Name = "UserControlPanel"
        Me.UserControlPanel.Size = New System.Drawing.Size(893, 617)
        Me.UserControlPanel.TabIndex = 5
        '
        'tmrTimer
        '
        Me.tmrTimer.Enabled = True
        Me.tmrTimer.Interval = 1000
        '
        'frmMainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1114, 665)
        Me.Controls.Add(Me.UserControlPanel)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.currentIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.ProfilePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents PanelMenu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnStudent As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents lblTitle As Label
    Friend WithEvents currentIcon As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblClock As Label
    Friend WithEvents ProfilePicture As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents IconButton7 As FontAwesome.Sharp.IconButton
    Friend WithEvents UserControlPanel As Panel
    Friend WithEvents tmrTimer As Timer
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
End Class

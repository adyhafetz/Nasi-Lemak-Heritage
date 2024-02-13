<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formHome))
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.timerAds = New System.Windows.Forms.Timer(Me.components)
        Me.lblImage = New System.Windows.Forms.Label()
        Me.StaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.msStaff = New System.Windows.Forms.MenuStrip()
        Me.tsmStaff = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picAds = New System.Windows.Forms.PictureBox()
        Me.msStaff.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(343, 550)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(300, 90)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(670, 550)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(300, 90)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnSignUp
        '
        Me.btnSignUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSignUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignUp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.ForeColor = System.Drawing.Color.White
        Me.btnSignUp.Location = New System.Drawing.Point(13, 550)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(300, 90)
        Me.btnSignUp.TabIndex = 6
        Me.btnSignUp.Text = "Sign Up"
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'timerAds
        '
        Me.timerAds.Enabled = True
        Me.timerAds.Interval = 2000
        '
        'lblImage
        '
        Me.lblImage.AutoSize = True
        Me.lblImage.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImage.Location = New System.Drawing.Point(941, 513)
        Me.lblImage.Name = "lblImage"
        Me.lblImage.Size = New System.Drawing.Size(15, 18)
        Me.lblImage.TabIndex = 9
        Me.lblImage.Text = "1"
        Me.lblImage.Visible = False
        '
        'StaffToolStripMenuItem
        '
        Me.StaffToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem"
        Me.StaffToolStripMenuItem.Size = New System.Drawing.Size(79, 46)
        Me.StaffToolStripMenuItem.Text = "Staff"
        '
        'StaffToolStripMenuItem1
        '
        Me.StaffToolStripMenuItem1.Name = "StaffToolStripMenuItem1"
        Me.StaffToolStripMenuItem1.Size = New System.Drawing.Size(32, 19)
        '
        'msStaff
        '
        Me.msStaff.AutoSize = False
        Me.msStaff.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.msStaff.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.msStaff.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmStaff})
        Me.msStaff.Location = New System.Drawing.Point(0, 0)
        Me.msStaff.Name = "msStaff"
        Me.msStaff.Size = New System.Drawing.Size(982, 50)
        Me.msStaff.TabIndex = 42
        Me.msStaff.Text = "MenuStrip1"
        '
        'tsmStaff
        '
        Me.tsmStaff.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmStaff.ForeColor = System.Drawing.Color.White
        Me.tsmStaff.Name = "tsmStaff"
        Me.tsmStaff.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.tsmStaff.Size = New System.Drawing.Size(79, 46)
        Me.tsmStaff.Text = "Staff"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Bahari", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(723, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 23)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "nasi lemak heritage"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(676, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 38)
        Me.PictureBox1.TabIndex = 83
        Me.PictureBox1.TabStop = False
        '
        'picAds
        '
        Me.picAds.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picAds.Image = CType(resources.GetObject("picAds.Image"), System.Drawing.Image)
        Me.picAds.InitialImage = Nothing
        Me.picAds.Location = New System.Drawing.Point(21, 61)
        Me.picAds.Name = "picAds"
        Me.picAds.Size = New System.Drawing.Size(940, 480)
        Me.picAds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAds.TabIndex = 5
        Me.picAds.TabStop = False
        '
        'formHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(982, 653)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.msStaff)
        Me.Controls.Add(Me.lblImage)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.picAds)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formHome"
        Me.Text = "Home"
        Me.msStaff.ResumeLayout(False)
        Me.msStaff.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSignUp As Button
    Friend WithEvents picAds As PictureBox
    Friend WithEvents timerAds As Timer
    Friend WithEvents lblImage As Label
    Friend WithEvents StaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaffToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents msStaff As MenuStrip
    Friend WithEvents tsmStaff As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class

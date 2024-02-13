<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSignUp
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
        Dim Cust_NameLabel As System.Windows.Forms.Label
        Dim Cust_TelephoneLabel As System.Windows.Forms.Label
        Dim Cust_UsernameLabel As System.Windows.Forms.Label
        Dim Cust_PasswordLabel As System.Windows.Forms.Label
        Dim Cust_MembershipLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formSignUp))
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.txtCustTelephone = New System.Windows.Forms.TextBox()
        Me.txtCustUsername = New System.Windows.Forms.TextBox()
        Me.txtCustPassword = New System.Windows.Forms.TextBox()
        Me.radCustMemberYes = New System.Windows.Forms.RadioButton()
        Me.radCustMemberNo = New System.Windows.Forms.RadioButton()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.chkShow = New System.Windows.Forms.CheckBox()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Cust_NameLabel = New System.Windows.Forms.Label()
        Cust_TelephoneLabel = New System.Windows.Forms.Label()
        Cust_UsernameLabel = New System.Windows.Forms.Label()
        Cust_PasswordLabel = New System.Windows.Forms.Label()
        Cust_MembershipLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Cust_NameLabel
        '
        Cust_NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Cust_NameLabel.AutoSize = True
        Cust_NameLabel.BackColor = System.Drawing.Color.Transparent
        Cust_NameLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cust_NameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Cust_NameLabel.Location = New System.Drawing.Point(244, 147)
        Cust_NameLabel.Name = "Cust_NameLabel"
        Cust_NameLabel.Size = New System.Drawing.Size(84, 27)
        Cust_NameLabel.TabIndex = 16
        Cust_NameLabel.Text = "Name:"
        Cust_NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cust_TelephoneLabel
        '
        Cust_TelephoneLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Cust_TelephoneLabel.AutoSize = True
        Cust_TelephoneLabel.BackColor = System.Drawing.Color.Transparent
        Cust_TelephoneLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cust_TelephoneLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Cust_TelephoneLabel.Location = New System.Drawing.Point(244, 229)
        Cust_TelephoneLabel.Name = "Cust_TelephoneLabel"
        Cust_TelephoneLabel.Size = New System.Drawing.Size(174, 27)
        Cust_TelephoneLabel.TabIndex = 18
        Cust_TelephoneLabel.Text = "Telephone No:"
        Cust_TelephoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cust_UsernameLabel
        '
        Cust_UsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Cust_UsernameLabel.AutoSize = True
        Cust_UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Cust_UsernameLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cust_UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Cust_UsernameLabel.Location = New System.Drawing.Point(245, 317)
        Cust_UsernameLabel.Name = "Cust_UsernameLabel"
        Cust_UsernameLabel.Size = New System.Drawing.Size(134, 27)
        Cust_UsernameLabel.TabIndex = 20
        Cust_UsernameLabel.Text = "Username:"
        Cust_UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cust_PasswordLabel
        '
        Cust_PasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Cust_PasswordLabel.AutoSize = True
        Cust_PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Cust_PasswordLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cust_PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Cust_PasswordLabel.Location = New System.Drawing.Point(245, 398)
        Cust_PasswordLabel.Name = "Cust_PasswordLabel"
        Cust_PasswordLabel.Size = New System.Drawing.Size(129, 27)
        Cust_PasswordLabel.TabIndex = 22
        Cust_PasswordLabel.Text = "Password:"
        Cust_PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cust_MembershipLabel
        '
        Cust_MembershipLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Cust_MembershipLabel.AutoSize = True
        Cust_MembershipLabel.BackColor = System.Drawing.Color.Transparent
        Cust_MembershipLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cust_MembershipLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Cust_MembershipLabel.Location = New System.Drawing.Point(245, 482)
        Cust_MembershipLabel.Name = "Cust_MembershipLabel"
        Cust_MembershipLabel.Size = New System.Drawing.Size(156, 27)
        Cust_MembershipLabel.TabIndex = 24
        Cust_MembershipLabel.Text = "Membership:"
        Cust_MembershipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCustName
        '
        Me.txtCustName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCustName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustName.Location = New System.Drawing.Point(250, 177)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(485, 34)
        Me.txtCustName.TabIndex = 17
        '
        'txtCustTelephone
        '
        Me.txtCustTelephone.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCustTelephone.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustTelephone.Location = New System.Drawing.Point(250, 259)
        Me.txtCustTelephone.Name = "txtCustTelephone"
        Me.txtCustTelephone.Size = New System.Drawing.Size(485, 34)
        Me.txtCustTelephone.TabIndex = 19
        '
        'txtCustUsername
        '
        Me.txtCustUsername.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCustUsername.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustUsername.Location = New System.Drawing.Point(250, 347)
        Me.txtCustUsername.Name = "txtCustUsername"
        Me.txtCustUsername.Size = New System.Drawing.Size(485, 34)
        Me.txtCustUsername.TabIndex = 21
        '
        'txtCustPassword
        '
        Me.txtCustPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtCustPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustPassword.Location = New System.Drawing.Point(250, 428)
        Me.txtCustPassword.Name = "txtCustPassword"
        Me.txtCustPassword.Size = New System.Drawing.Size(387, 34)
        Me.txtCustPassword.TabIndex = 23
        Me.txtCustPassword.UseSystemPasswordChar = True
        '
        'radCustMemberYes
        '
        Me.radCustMemberYes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.radCustMemberYes.AutoSize = True
        Me.radCustMemberYes.BackColor = System.Drawing.Color.Transparent
        Me.radCustMemberYes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radCustMemberYes.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCustMemberYes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.radCustMemberYes.Location = New System.Drawing.Point(418, 480)
        Me.radCustMemberYes.Name = "radCustMemberYes"
        Me.radCustMemberYes.Size = New System.Drawing.Size(73, 31)
        Me.radCustMemberYes.TabIndex = 25
        Me.radCustMemberYes.TabStop = True
        Me.radCustMemberYes.Text = "Yes"
        Me.radCustMemberYes.UseVisualStyleBackColor = False
        '
        'radCustMemberNo
        '
        Me.radCustMemberNo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.radCustMemberNo.AutoSize = True
        Me.radCustMemberNo.BackColor = System.Drawing.Color.Transparent
        Me.radCustMemberNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.radCustMemberNo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCustMemberNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.radCustMemberNo.Location = New System.Drawing.Point(499, 480)
        Me.radCustMemberNo.Name = "radCustMemberNo"
        Me.radCustMemberNo.Size = New System.Drawing.Size(64, 31)
        Me.radCustMemberNo.TabIndex = 26
        Me.radCustMemberNo.TabStop = True
        Me.radCustMemberNo.Text = "No"
        Me.radCustMemberNo.UseVisualStyleBackColor = False
        '
        'btnSignUp
        '
        Me.btnSignUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSignUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignUp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.ForeColor = System.Drawing.Color.White
        Me.btnSignUp.Location = New System.Drawing.Point(767, 574)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(200, 70)
        Me.btnSignUp.TabIndex = 27
        Me.btnSignUp.Text = "Sign Up"
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'chkShow
        '
        Me.chkShow.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chkShow.AutoSize = True
        Me.chkShow.BackColor = System.Drawing.Color.Transparent
        Me.chkShow.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.chkShow.Location = New System.Drawing.Point(650, 433)
        Me.chkShow.Name = "chkShow"
        Me.chkShow.Size = New System.Drawing.Size(76, 24)
        Me.chkShow.TabIndex = 28
        Me.chkShow.Text = "Show"
        Me.chkShow.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Location = New System.Drawing.Point(12, 574)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(200, 70)
        Me.btnHome.TabIndex = 29
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'lblWelcome
        '
        Me.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Ketoprak", 31.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblWelcome.Location = New System.Drawing.Point(93, 55)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(850, 53)
        Me.lblWelcome.TabIndex = 44
        Me.lblWelcome.Text = "Welcome To Nasi Lemak Heritage!"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'formSignUp
        '
        Me.AcceptButton = Me.btnSignUp
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CSC301___Coding.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 653)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.chkShow)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.radCustMemberNo)
        Me.Controls.Add(Me.radCustMemberYes)
        Me.Controls.Add(Cust_MembershipLabel)
        Me.Controls.Add(Cust_PasswordLabel)
        Me.Controls.Add(Me.txtCustPassword)
        Me.Controls.Add(Cust_UsernameLabel)
        Me.Controls.Add(Me.txtCustUsername)
        Me.Controls.Add(Cust_TelephoneLabel)
        Me.Controls.Add(Me.txtCustTelephone)
        Me.Controls.Add(Cust_NameLabel)
        Me.Controls.Add(Me.txtCustName)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formSignUp"
        Me.Text = "Sign Up"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCustName As TextBox
    Friend WithEvents txtCustTelephone As TextBox
    Friend WithEvents txtCustUsername As TextBox
    Friend WithEvents txtCustPassword As TextBox
    Friend WithEvents radCustMemberYes As RadioButton
    Friend WithEvents radCustMemberNo As RadioButton
    Friend WithEvents btnSignUp As Button
    Friend WithEvents chkShow As CheckBox
    Friend WithEvents btnHome As Button
    Friend WithEvents lblWelcome As Label
End Class

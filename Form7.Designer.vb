<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formPayment))
        Me.gpQr = New System.Windows.Forms.GroupBox()
        Me.picQR = New System.Windows.Forms.PictureBox()
        Me.gpCash = New System.Windows.Forms.GroupBox()
        Me.picCash = New System.Windows.Forms.PictureBox()
        Me.btnCompleted = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.msBack = New System.Windows.Forms.MenuStrip()
        Me.tsmBack = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.picPayment = New System.Windows.Forms.PictureBox()
        Me.gpQr.SuspendLayout()
        CType(Me.picQR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpCash.SuspendLayout()
        CType(Me.picCash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.msBack.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpQr
        '
        Me.gpQr.Controls.Add(Me.picQR)
        Me.gpQr.Location = New System.Drawing.Point(562, 269)
        Me.gpQr.Name = "gpQr"
        Me.gpQr.Size = New System.Drawing.Size(200, 128)
        Me.gpQr.TabIndex = 55
        Me.gpQr.TabStop = False
        '
        'picQR
        '
        Me.picQR.Image = Global.CSC301___Coding.My.Resources.Resources.QR1
        Me.picQR.Location = New System.Drawing.Point(21, 31)
        Me.picQR.Name = "picQR"
        Me.picQR.Size = New System.Drawing.Size(163, 78)
        Me.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picQR.TabIndex = 48
        Me.picQR.TabStop = False
        '
        'gpCash
        '
        Me.gpCash.Controls.Add(Me.picCash)
        Me.gpCash.Location = New System.Drawing.Point(220, 269)
        Me.gpCash.Name = "gpCash"
        Me.gpCash.Size = New System.Drawing.Size(200, 128)
        Me.gpCash.TabIndex = 54
        Me.gpCash.TabStop = False
        '
        'picCash
        '
        Me.picCash.Image = Global.CSC301___Coding.My.Resources.Resources.CH1
        Me.picCash.Location = New System.Drawing.Point(20, 31)
        Me.picCash.Name = "picCash"
        Me.picCash.Size = New System.Drawing.Size(163, 78)
        Me.picCash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCash.TabIndex = 48
        Me.picCash.TabStop = False
        '
        'btnCompleted
        '
        Me.btnCompleted.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCompleted.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompleted.ForeColor = System.Drawing.Color.White
        Me.btnCompleted.Location = New System.Drawing.Point(768, 572)
        Me.btnCompleted.Name = "btnCompleted"
        Me.btnCompleted.Size = New System.Drawing.Size(200, 70)
        Me.btnCompleted.TabIndex = 52
        Me.btnCompleted.Text = "Completed"
        Me.btnCompleted.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(290, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(403, 54)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Payment Method"
        '
        'msBack
        '
        Me.msBack.AutoSize = False
        Me.msBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.msBack.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.msBack.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmBack})
        Me.msBack.Location = New System.Drawing.Point(0, 0)
        Me.msBack.Name = "msBack"
        Me.msBack.Size = New System.Drawing.Size(982, 50)
        Me.msBack.TabIndex = 69
        Me.msBack.Text = "MenuStrip1"
        '
        'tsmBack
        '
        Me.tsmBack.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmBack.ForeColor = System.Drawing.Color.White
        Me.tsmBack.Name = "tsmBack"
        Me.tsmBack.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.tsmBack.Size = New System.Drawing.Size(84, 46)
        Me.tsmBack.Text = "Back"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 49)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(982, 10)
        Me.ProgressBar1.TabIndex = 73
        Me.ProgressBar1.Value = 100
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Bahari", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(723, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(219, 23)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "nasi lemak heritage"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(676, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(44, 38)
        Me.PictureBox2.TabIndex = 89
        Me.PictureBox2.TabStop = False
        '
        'picPayment
        '
        Me.picPayment.Location = New System.Drawing.Point(78, 152)
        Me.picPayment.Name = "picPayment"
        Me.picPayment.Size = New System.Drawing.Size(827, 382)
        Me.picPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPayment.TabIndex = 56
        Me.picPayment.TabStop = False
        Me.picPayment.Visible = False
        '
        'formPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(982, 653)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.msBack)
        Me.Controls.Add(Me.gpQr)
        Me.Controls.Add(Me.gpCash)
        Me.Controls.Add(Me.btnCompleted)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picPayment)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formPayment"
        Me.Text = "Payment"
        Me.gpQr.ResumeLayout(False)
        CType(Me.picQR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpCash.ResumeLayout(False)
        CType(Me.picCash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.msBack.ResumeLayout(False)
        Me.msBack.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gpQr As GroupBox
    Friend WithEvents picQR As PictureBox
    Friend WithEvents gpCash As GroupBox
    Friend WithEvents picCash As PictureBox
    Friend WithEvents btnCompleted As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents picPayment As PictureBox
    Friend WithEvents msBack As MenuStrip
    Friend WithEvents tsmBack As ToolStripMenuItem
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formOption
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formOption))
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tsmCart = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmPreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.radCold = New System.Windows.Forms.RadioButton()
        Me.radHot = New System.Windows.Forms.RadioButton()
        Me.updQty = New System.Windows.Forms.NumericUpDown()
        Me.btnAddToCart = New System.Windows.Forms.Button()
        Me.cmbBeverage = New System.Windows.Forms.ComboBox()
        Me.cmbGravy = New System.Windows.Forms.ComboBox()
        Me.cmbSideDish = New System.Windows.Forms.ComboBox()
        Me.msPreviewCart = New System.Windows.Forms.MenuStrip()
        Me.lblCartQty = New System.Windows.Forms.Label()
        Me.gbSideDish = New System.Windows.Forms.GroupBox()
        Me.gbGravy = New System.Windows.Forms.GroupBox()
        Me.gbBeverage = New System.Windows.Forms.GroupBox()
        Me.prPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.pdPreview = New System.Drawing.Printing.PrintDocument()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.picOption = New System.Windows.Forms.PictureBox()
        CType(Me.updQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.msPreviewCart.SuspendLayout()
        Me.gbSideDish.SuspendLayout()
        Me.gbGravy.SuspendLayout()
        Me.gbBeverage.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDescription
        '
        Me.lblDescription.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblDescription.Location = New System.Drawing.Point(290, 161)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(661, 165)
        Me.lblDescription.TabIndex = 43
        Me.lblDescription.Text = "Description"
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 34.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(280, 76)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(690, 76)
        Me.lblTitle.TabIndex = 42
        '
        'tsmCart
        '
        Me.tsmCart.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmCart.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.tsmCart.Name = "tsmCart"
        Me.tsmCart.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.tsmCart.Size = New System.Drawing.Size(75, 46)
        Me.tsmCart.Text = "Cart"
        '
        'tsmPreview
        '
        Me.tsmPreview.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmPreview.ForeColor = System.Drawing.Color.White
        Me.tsmPreview.Name = "tsmPreview"
        Me.tsmPreview.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.tsmPreview.Size = New System.Drawing.Size(116, 46)
        Me.tsmPreview.Text = "Preview"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(19, 594)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 27)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Quantity:"
        '
        'radCold
        '
        Me.radCold.AutoSize = True
        Me.radCold.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCold.Location = New System.Drawing.Point(138, 92)
        Me.radCold.Name = "radCold"
        Me.radCold.Size = New System.Drawing.Size(76, 27)
        Me.radCold.TabIndex = 50
        Me.radCold.TabStop = True
        Me.radCold.Text = "Cold"
        Me.radCold.UseVisualStyleBackColor = True
        '
        'radHot
        '
        Me.radHot.AutoSize = True
        Me.radHot.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radHot.Location = New System.Drawing.Point(52, 92)
        Me.radHot.Name = "radHot"
        Me.radHot.Size = New System.Drawing.Size(62, 25)
        Me.radHot.TabIndex = 49
        Me.radHot.TabStop = True
        Me.radHot.Text = "Hot"
        Me.radHot.UseVisualStyleBackColor = True
        '
        'updQty
        '
        Me.updQty.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updQty.Location = New System.Drawing.Point(147, 588)
        Me.updQty.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.updQty.Name = "updQty"
        Me.updQty.Size = New System.Drawing.Size(120, 39)
        Me.updQty.TabIndex = 48
        '
        'btnAddToCart
        '
        Me.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAddToCart.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddToCart.ForeColor = System.Drawing.Color.White
        Me.btnAddToCart.Location = New System.Drawing.Point(741, 572)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(230, 70)
        Me.btnAddToCart.TabIndex = 47
        Me.btnAddToCart.Text = "Add To Cart"
        Me.btnAddToCart.UseVisualStyleBackColor = False
        '
        'cmbBeverage
        '
        Me.cmbBeverage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBeverage.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBeverage.FormattingEnabled = True
        Me.cmbBeverage.Items.AddRange(New Object() {"Tea", "Milk Tea", "Coffee"})
        Me.cmbBeverage.Location = New System.Drawing.Point(12, 48)
        Me.cmbBeverage.Name = "cmbBeverage"
        Me.cmbBeverage.Size = New System.Drawing.Size(250, 34)
        Me.cmbBeverage.TabIndex = 46
        '
        'cmbGravy
        '
        Me.cmbGravy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGravy.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGravy.FormattingEnabled = True
        Me.cmbGravy.Items.AddRange(New Object() {"Sambal", "Curry"})
        Me.cmbGravy.Location = New System.Drawing.Point(12, 47)
        Me.cmbGravy.Name = "cmbGravy"
        Me.cmbGravy.Size = New System.Drawing.Size(250, 34)
        Me.cmbGravy.TabIndex = 45
        '
        'cmbSideDish
        '
        Me.cmbSideDish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSideDish.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSideDish.FormattingEnabled = True
        Me.cmbSideDish.Location = New System.Drawing.Point(12, 47)
        Me.cmbSideDish.Name = "cmbSideDish"
        Me.cmbSideDish.Size = New System.Drawing.Size(250, 34)
        Me.cmbSideDish.TabIndex = 44
        '
        'msPreviewCart
        '
        Me.msPreviewCart.AutoSize = False
        Me.msPreviewCart.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.msPreviewCart.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.msPreviewCart.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmPreview, Me.tsmCart})
        Me.msPreviewCart.Location = New System.Drawing.Point(0, 0)
        Me.msPreviewCart.Name = "msPreviewCart"
        Me.msPreviewCart.Size = New System.Drawing.Size(982, 50)
        Me.msPreviewCart.TabIndex = 41
        Me.msPreviewCart.Text = "MenuStrip1"
        '
        'lblCartQty
        '
        Me.lblCartQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.lblCartQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCartQty.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCartQty.Location = New System.Drawing.Point(205, 9)
        Me.lblCartQty.Name = "lblCartQty"
        Me.lblCartQty.Size = New System.Drawing.Size(23, 23)
        Me.lblCartQty.TabIndex = 67
        '
        'gbSideDish
        '
        Me.gbSideDish.Controls.Add(Me.cmbSideDish)
        Me.gbSideDish.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSideDish.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.gbSideDish.Location = New System.Drawing.Point(24, 372)
        Me.gbSideDish.Name = "gbSideDish"
        Me.gbSideDish.Size = New System.Drawing.Size(275, 135)
        Me.gbSideDish.TabIndex = 68
        Me.gbSideDish.TabStop = False
        Me.gbSideDish.Text = "Select Side Dish"
        '
        'gbGravy
        '
        Me.gbGravy.Controls.Add(Me.cmbGravy)
        Me.gbGravy.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGravy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.gbGravy.Location = New System.Drawing.Point(352, 372)
        Me.gbGravy.Name = "gbGravy"
        Me.gbGravy.Size = New System.Drawing.Size(275, 135)
        Me.gbGravy.TabIndex = 69
        Me.gbGravy.TabStop = False
        Me.gbGravy.Text = "Select Gravy"
        '
        'gbBeverage
        '
        Me.gbBeverage.Controls.Add(Me.cmbBeverage)
        Me.gbBeverage.Controls.Add(Me.radCold)
        Me.gbBeverage.Controls.Add(Me.radHot)
        Me.gbBeverage.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBeverage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.gbBeverage.Location = New System.Drawing.Point(676, 372)
        Me.gbBeverage.Name = "gbBeverage"
        Me.gbBeverage.Size = New System.Drawing.Size(275, 135)
        Me.gbBeverage.TabIndex = 70
        Me.gbBeverage.TabStop = False
        Me.gbBeverage.Text = "Select Beverage"
        '
        'prPreview
        '
        Me.prPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.prPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.prPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.prPreview.Document = Me.pdPreview
        Me.prPreview.Enabled = True
        Me.prPreview.Icon = CType(resources.GetObject("prPreview.Icon"), System.Drawing.Icon)
        Me.prPreview.Name = "prPreview"
        Me.prPreview.Visible = False
        '
        'pdPreview
        '
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 49)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(982, 10)
        Me.ProgressBar1.TabIndex = 72
        Me.ProgressBar1.Value = 50
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Bahari", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(723, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 23)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "nasi lemak heritage"
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
        Me.PictureBox2.TabIndex = 85
        Me.PictureBox2.TabStop = False
        '
        'picOption
        '
        Me.picOption.Location = New System.Drawing.Point(24, 76)
        Me.picOption.Name = "picOption"
        Me.picOption.Size = New System.Drawing.Size(250, 250)
        Me.picOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOption.TabIndex = 41
        Me.picOption.TabStop = False
        '
        'formOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(982, 653)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.gbBeverage)
        Me.Controls.Add(Me.gbGravy)
        Me.Controls.Add(Me.gbSideDish)
        Me.Controls.Add(Me.lblCartQty)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picOption)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.updQty)
        Me.Controls.Add(Me.btnAddToCart)
        Me.Controls.Add(Me.msPreviewCart)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formOption"
        Me.Text = "Option"
        CType(Me.updQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.msPreviewCart.ResumeLayout(False)
        Me.msPreviewCart.PerformLayout()
        Me.gbSideDish.ResumeLayout(False)
        Me.gbGravy.ResumeLayout(False)
        Me.gbBeverage.ResumeLayout(False)
        Me.gbBeverage.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDescription As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents picOption As PictureBox
    Friend WithEvents tsmCart As ToolStripMenuItem
    Friend WithEvents tsmPreview As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents radCold As RadioButton
    Friend WithEvents radHot As RadioButton
    Friend WithEvents updQty As NumericUpDown
    Friend WithEvents btnAddToCart As Button
    Friend WithEvents cmbBeverage As ComboBox
    Friend WithEvents cmbGravy As ComboBox
    Friend WithEvents cmbSideDish As ComboBox
    Friend WithEvents msPreviewCart As MenuStrip
    Friend WithEvents lblCartQty As Label
    Friend WithEvents gbSideDish As GroupBox
    Friend WithEvents gbGravy As GroupBox
    Friend WithEvents gbBeverage As GroupBox
    Friend WithEvents prPreview As PrintPreviewDialog
    Friend WithEvents pdPreview As Printing.PrintDocument
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
End Class

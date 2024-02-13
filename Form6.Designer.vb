<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSummary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formSummary))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me._CSC301___DatabaseDataSet = New CSC301___Coding._CSC301___DatabaseDataSet()
        Me.InvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoiceTableAdapter = New CSC301___Coding._CSC301___DatabaseDataSetTableAdapters.InvoiceTableAdapter()
        Me.TableAdapterManager = New CSC301___Coding._CSC301___DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.dgvInvoice = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.msBackPreview = New System.Windows.Forms.MenuStrip()
        Me.tsmBack = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmPreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.prPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.btnRemarks = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me._CSC301___DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.msBackPreview.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(297, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(388, 54)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Order Summary"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.Window
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(290, 523)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(184, 28)
        Me.lblTotal.TabIndex = 47
        '
        'lblDiscount
        '
        Me.lblDiscount.BackColor = System.Drawing.SystemColors.Window
        Me.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiscount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(290, 479)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(184, 28)
        Me.lblDiscount.TabIndex = 46
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.SystemColors.Window
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(290, 435)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(184, 28)
        Me.lblTax.TabIndex = 45
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(10, 571)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(200, 70)
        Me.btnCancel.TabIndex = 44
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCheckout.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckout.ForeColor = System.Drawing.Color.White
        Me.btnCheckout.Location = New System.Drawing.Point(770, 571)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(200, 70)
        Me.btnCheckout.TabIndex = 43
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 524)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 27)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "TOTAL:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 480)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(261, 27)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Membership Discount:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 436)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 27)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Tax(7%):"
        '
        '_CSC301___DatabaseDataSet
        '
        Me._CSC301___DatabaseDataSet.DataSetName = "_CSC301___DatabaseDataSet"
        Me._CSC301___DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InvoiceBindingSource
        '
        Me.InvoiceBindingSource.DataMember = "Invoice"
        Me.InvoiceBindingSource.DataSource = Me._CSC301___DatabaseDataSet
        '
        'InvoiceTableAdapter
        '
        Me.InvoiceTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.InvoiceTableAdapter = Me.InvoiceTableAdapter
        Me.TableAdapterManager.OrderTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CSC301___Coding._CSC301___DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'dgvInvoice
        '
        Me.dgvInvoice.AllowUserToDeleteRows = False
        Me.dgvInvoice.AutoGenerateColumns = False
        Me.dgvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInvoice.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvoice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.dgvInvoice.DataSource = Me.InvoiceBindingSource
        Me.dgvInvoice.Location = New System.Drawing.Point(0, 138)
        Me.dgvInvoice.Name = "dgvInvoice"
        Me.dgvInvoice.ReadOnly = True
        Me.dgvInvoice.RowHeadersWidth = 51
        Me.dgvInvoice.RowTemplate.Height = 24
        Me.dgvInvoice.Size = New System.Drawing.Size(982, 186)
        Me.dgvInvoice.TabIndex = 48
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "No"
        Me.DataGridViewTextBoxColumn1.HeaderText = "No"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Item"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Price(RM)"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Price(RM)"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'msBackPreview
        '
        Me.msBackPreview.AutoSize = False
        Me.msBackPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.msBackPreview.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.msBackPreview.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmBack, Me.tsmPreview})
        Me.msBackPreview.Location = New System.Drawing.Point(0, 0)
        Me.msBackPreview.Name = "msBackPreview"
        Me.msBackPreview.Size = New System.Drawing.Size(982, 50)
        Me.msBackPreview.TabIndex = 68
        Me.msBackPreview.Text = "MenuStrip1"
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
        'tsmPreview
        '
        Me.tsmPreview.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmPreview.ForeColor = System.Drawing.Color.White
        Me.tsmPreview.Name = "tsmPreview"
        Me.tsmPreview.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.tsmPreview.Size = New System.Drawing.Size(116, 46)
        Me.tsmPreview.Text = "Preview"
        '
        'prPreview
        '
        Me.prPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.prPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.prPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.prPreview.Enabled = True
        Me.prPreview.Icon = CType(resources.GetObject("prPreview.Icon"), System.Drawing.Icon)
        Me.prPreview.Name = "prPreview"
        Me.prPreview.Visible = False
        '
        'txtRemarks
        '
        Me.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRemarks.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.txtRemarks.Location = New System.Drawing.Point(0, 332)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(982, 87)
        Me.txtRemarks.TabIndex = 69
        Me.txtRemarks.Text = "Add remarks..."
        '
        'btnRemarks
        '
        Me.btnRemarks.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemarks.Location = New System.Drawing.Point(904, 355)
        Me.btnRemarks.Name = "btnRemarks"
        Me.btnRemarks.Size = New System.Drawing.Size(66, 40)
        Me.btnRemarks.TabIndex = 70
        Me.btnRemarks.Text = "Add"
        Me.btnRemarks.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 49)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(982, 10)
        Me.ProgressBar1.TabIndex = 72
        Me.ProgressBar1.Value = 75
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
        Me.PictureBox2.TabIndex = 87
        Me.PictureBox2.TabStop = False
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
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "nasi lemak heritage"
        '
        'formSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(982, 653)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnRemarks)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.msBackPreview)
        Me.Controls.Add(Me.dgvInvoice)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formSummary"
        Me.Text = "Summary"
        CType(Me._CSC301___DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.msBackPreview.ResumeLayout(False)
        Me.msBackPreview.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnCheckout As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents _CSC301___DatabaseDataSet As _CSC301___DatabaseDataSet
    Friend WithEvents InvoiceBindingSource As BindingSource
    Friend WithEvents InvoiceTableAdapter As _CSC301___DatabaseDataSetTableAdapters.InvoiceTableAdapter
    Friend WithEvents TableAdapterManager As _CSC301___DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvInvoice As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents msBackPreview As MenuStrip
    Friend WithEvents tsmBack As ToolStripMenuItem
    Friend WithEvents tsmPreview As ToolStripMenuItem
    Friend WithEvents prPreview As PrintPreviewDialog
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents btnRemarks As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
End Class

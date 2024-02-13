<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formCustomer))
        Me.msBack = New System.Windows.Forms.MenuStrip()
        Me.tsmBack = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me._CSC301___DatabaseDataSet = New CSC301___Coding._CSC301___DatabaseDataSet()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New CSC301___Coding._CSC301___DatabaseDataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager = New CSC301___Coding._CSC301___DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.dgvCustomer = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstReview = New System.Windows.Forms.ListBox()
        Me.msBack.SuspendLayout()
        CType(Me._CSC301___DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'msBack
        '
        Me.msBack.AutoSize = False
        Me.msBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.msBack.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.msBack.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmBack, Me.ReviewToolStripMenuItem, Me.tsmRefresh})
        Me.msBack.Location = New System.Drawing.Point(0, 0)
        Me.msBack.Name = "msBack"
        Me.msBack.Size = New System.Drawing.Size(982, 50)
        Me.msBack.TabIndex = 44
        Me.msBack.Text = "MenuStrip1"
        '
        'tsmBack
        '
        Me.tsmBack.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmBack.ForeColor = System.Drawing.Color.White
        Me.tsmBack.Name = "tsmBack"
        Me.tsmBack.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.tsmBack.Size = New System.Drawing.Size(84, 46)
        Me.tsmBack.Text = "Back"
        '
        'ReviewToolStripMenuItem
        '
        Me.ReviewToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReviewToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window
        Me.ReviewToolStripMenuItem.Name = "ReviewToolStripMenuItem"
        Me.ReviewToolStripMenuItem.Size = New System.Drawing.Size(154, 46)
        Me.ReviewToolStripMenuItem.Text = "Review List"
        '
        'tsmRefresh
        '
        Me.tsmRefresh.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmRefresh.ForeColor = System.Drawing.Color.White
        Me.tsmRefresh.Name = "tsmRefresh"
        Me.tsmRefresh.Size = New System.Drawing.Size(115, 46)
        Me.tsmRefresh.Text = "Refresh"
        '
        '_CSC301___DatabaseDataSet
        '
        Me._CSC301___DatabaseDataSet.DataSetName = "_CSC301___DatabaseDataSet"
        Me._CSC301___DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me._CSC301___DatabaseDataSet
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.InvoiceTableAdapter = Nothing
        Me.TableAdapterManager.OrderTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CSC301___Coding._CSC301___DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'dgvCustomer
        '
        Me.dgvCustomer.AllowUserToDeleteRows = False
        Me.dgvCustomer.AutoGenerateColumns = False
        Me.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCustomer.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.dgvCustomer.DataSource = Me.CustomerBindingSource
        Me.dgvCustomer.Location = New System.Drawing.Point(12, 63)
        Me.dgvCustomer.Name = "dgvCustomer"
        Me.dgvCustomer.ReadOnly = True
        Me.dgvCustomer.RowHeadersWidth = 51
        Me.dgvCustomer.RowTemplate.Height = 24
        Me.dgvCustomer.Size = New System.Drawing.Size(958, 365)
        Me.dgvCustomer.TabIndex = 45
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Cust_Name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cust_Name"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Cust_Telephone"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cust_Telephone"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Cust_Username"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cust_Username"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Cust_Password"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cust_Password"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Cust_Membership"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cust_Membership"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
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
        Me.PictureBox2.TabIndex = 91
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
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "nasi lemak heritage"
        '
        'lstReview
        '
        Me.lstReview.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstReview.FormattingEnabled = True
        Me.lstReview.ItemHeight = 27
        Me.lstReview.Location = New System.Drawing.Point(12, 448)
        Me.lstReview.Name = "lstReview"
        Me.lstReview.Size = New System.Drawing.Size(958, 193)
        Me.lstReview.TabIndex = 92
        '
        'formCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(982, 653)
        Me.Controls.Add(Me.lstReview)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvCustomer)
        Me.Controls.Add(Me.msBack)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formCustomer"
        Me.Text = "Customer"
        Me.msBack.ResumeLayout(False)
        Me.msBack.PerformLayout()
        CType(Me._CSC301___DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msBack As MenuStrip
    Friend WithEvents tsmBack As ToolStripMenuItem
    Friend WithEvents _CSC301___DatabaseDataSet As _CSC301___DatabaseDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As _CSC301___DatabaseDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager As _CSC301___DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvCustomer As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents tsmRefresh As ToolStripMenuItem
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ReviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstReview As ListBox
End Class

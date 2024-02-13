<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formOrder))
        Me.msBack = New System.Windows.Forms.MenuStrip()
        Me.tsmBack = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me._CSC301___DatabaseDataSet = New CSC301___Coding._CSC301___DatabaseDataSet()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderTableAdapter = New CSC301___Coding._CSC301___DatabaseDataSetTableAdapters.OrderTableAdapter()
        Me.TableAdapterManager = New CSC301___Coding._CSC301___DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.dgvOrder = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblSA = New System.Windows.Forms.Label()
        Me.lblSS = New System.Windows.Forms.Label()
        Me.lblBA = New System.Windows.Forms.Label()
        Me.lblBS = New System.Windows.Forms.Label()
        Me.lblES = New System.Windows.Forms.Label()
        Me.lblEA = New System.Windows.Forms.Label()
        Me.lblCS = New System.Windows.Forms.Label()
        Me.lblCA = New System.Windows.Forms.Label()
        Me.lblTotalIncome = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.msBack.SuspendLayout()
        CType(Me._CSC301___DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'msBack
        '
        Me.msBack.AutoSize = False
        Me.msBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.msBack.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.msBack.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmBack, Me.ReportToolStripMenuItem, Me.tsmRefresh})
        Me.msBack.Location = New System.Drawing.Point(0, 0)
        Me.msBack.Name = "msBack"
        Me.msBack.Size = New System.Drawing.Size(982, 50)
        Me.msBack.TabIndex = 45
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
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(103, 46)
        Me.ReportToolStripMenuItem.Text = "Report"
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
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataMember = "Order"
        Me.OrderBindingSource.DataSource = Me._CSC301___DatabaseDataSet
        '
        'OrderTableAdapter
        '
        Me.OrderTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.InvoiceTableAdapter = Nothing
        Me.TableAdapterManager.OrderTableAdapter = Me.OrderTableAdapter
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CSC301___Coding._CSC301___DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'dgvOrder
        '
        Me.dgvOrder.AutoGenerateColumns = False
        Me.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOrder.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dgvOrder.DataSource = Me.OrderBindingSource
        Me.dgvOrder.Location = New System.Drawing.Point(12, 64)
        Me.dgvOrder.Name = "dgvOrder"
        Me.dgvOrder.RowHeadersWidth = 51
        Me.dgvOrder.RowTemplate.Height = 24
        Me.dgvOrder.Size = New System.Drawing.Size(958, 297)
        Me.dgvOrder.TabIndex = 46
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Order_Name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Order_Name"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Order_Type"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Order_Type"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Order_Quantity"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Order_Quantity"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
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
        Me.PictureBox2.TabIndex = 93
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
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "nasi lemak heritage"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 389)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 23)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "Egg-dition (Set):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 432)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(238, 23)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Egg-dition (A La Carte):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 518)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(278, 23)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Chicken Lover (A La Carte):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 475)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 23)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "Chicken Lover (Set):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(493, 518)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(288, 23)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "Seafood Addict (A La Carte):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(493, 475)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(217, 23)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "Seafood Addict (Set):"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(493, 432)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(258, 23)
        Me.Label8.TabIndex = 101
        Me.Label8.Text = "Beef Maniac (A La Carte):"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(493, 389)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(187, 23)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "Beef Maniac (Set):"
        '
        'lblSA
        '
        Me.lblSA.BackColor = System.Drawing.SystemColors.Window
        Me.lblSA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSA.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblSA.Location = New System.Drawing.Point(806, 514)
        Me.lblSA.Name = "lblSA"
        Me.lblSA.Size = New System.Drawing.Size(157, 28)
        Me.lblSA.TabIndex = 104
        '
        'lblSS
        '
        Me.lblSS.BackColor = System.Drawing.SystemColors.Window
        Me.lblSS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSS.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblSS.Location = New System.Drawing.Point(806, 471)
        Me.lblSS.Name = "lblSS"
        Me.lblSS.Size = New System.Drawing.Size(157, 28)
        Me.lblSS.TabIndex = 105
        '
        'lblBA
        '
        Me.lblBA.BackColor = System.Drawing.SystemColors.Window
        Me.lblBA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBA.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblBA.Location = New System.Drawing.Point(806, 428)
        Me.lblBA.Name = "lblBA"
        Me.lblBA.Size = New System.Drawing.Size(157, 28)
        Me.lblBA.TabIndex = 106
        '
        'lblBS
        '
        Me.lblBS.BackColor = System.Drawing.SystemColors.Window
        Me.lblBS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBS.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblBS.Location = New System.Drawing.Point(806, 385)
        Me.lblBS.Name = "lblBS"
        Me.lblBS.Size = New System.Drawing.Size(157, 28)
        Me.lblBS.TabIndex = 107
        '
        'lblES
        '
        Me.lblES.BackColor = System.Drawing.SystemColors.Window
        Me.lblES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblES.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblES.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblES.Location = New System.Drawing.Point(316, 385)
        Me.lblES.Name = "lblES"
        Me.lblES.Size = New System.Drawing.Size(157, 28)
        Me.lblES.TabIndex = 111
        '
        'lblEA
        '
        Me.lblEA.BackColor = System.Drawing.SystemColors.Window
        Me.lblEA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEA.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblEA.Location = New System.Drawing.Point(316, 428)
        Me.lblEA.Name = "lblEA"
        Me.lblEA.Size = New System.Drawing.Size(157, 28)
        Me.lblEA.TabIndex = 110
        '
        'lblCS
        '
        Me.lblCS.BackColor = System.Drawing.SystemColors.Window
        Me.lblCS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCS.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblCS.Location = New System.Drawing.Point(316, 471)
        Me.lblCS.Name = "lblCS"
        Me.lblCS.Size = New System.Drawing.Size(157, 28)
        Me.lblCS.TabIndex = 109
        '
        'lblCA
        '
        Me.lblCA.BackColor = System.Drawing.SystemColors.Window
        Me.lblCA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCA.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblCA.Location = New System.Drawing.Point(316, 514)
        Me.lblCA.Name = "lblCA"
        Me.lblCA.Size = New System.Drawing.Size(157, 28)
        Me.lblCA.TabIndex = 108
        '
        'lblTotalIncome
        '
        Me.lblTotalIncome.BackColor = System.Drawing.SystemColors.Window
        Me.lblTotalIncome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalIncome.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalIncome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblTotalIncome.Location = New System.Drawing.Point(506, 587)
        Me.lblTotalIncome.Name = "lblTotalIncome"
        Me.lblTotalIncome.Size = New System.Drawing.Size(184, 28)
        Me.lblTotalIncome.TabIndex = 113
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(293, 588)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(195, 27)
        Me.Label16.TabIndex = 112
        Me.Label16.Text = "TOTAL INCOME:"
        '
        'formOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(982, 653)
        Me.Controls.Add(Me.lblTotalIncome)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblES)
        Me.Controls.Add(Me.lblEA)
        Me.Controls.Add(Me.lblCS)
        Me.Controls.Add(Me.lblCA)
        Me.Controls.Add(Me.lblBS)
        Me.Controls.Add(Me.lblBA)
        Me.Controls.Add(Me.lblSS)
        Me.Controls.Add(Me.lblSA)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvOrder)
        Me.Controls.Add(Me.msBack)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formOrder"
        Me.Text = "Order"
        Me.msBack.ResumeLayout(False)
        Me.msBack.PerformLayout()
        CType(Me._CSC301___DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msBack As MenuStrip
    Friend WithEvents tsmBack As ToolStripMenuItem
    Friend WithEvents _CSC301___DatabaseDataSet As _CSC301___DatabaseDataSet
    Friend WithEvents OrderBindingSource As BindingSource
    Friend WithEvents OrderTableAdapter As _CSC301___DatabaseDataSetTableAdapters.OrderTableAdapter
    Friend WithEvents TableAdapterManager As _CSC301___DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvOrder As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents tsmRefresh As ToolStripMenuItem
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblSA As Label
    Friend WithEvents lblSS As Label
    Friend WithEvents lblBA As Label
    Friend WithEvents lblBS As Label
    Friend WithEvents lblES As Label
    Friend WithEvents lblEA As Label
    Friend WithEvents lblCS As Label
    Friend WithEvents lblCA As Label
    Friend WithEvents lblTotalIncome As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
End Class

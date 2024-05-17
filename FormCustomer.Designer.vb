<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCustomer))
        Me.PanelProduct = New System.Windows.Forms.Panel()
        Me.PanelBuy = New System.Windows.Forms.Panel()
        Me.DataGridViewKeranjang = New System.Windows.Forms.DataGridView()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMaterial = New System.Windows.Forms.TextBox()
        Me.txtJenis = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtWarna = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewFurniture = New System.Windows.Forms.DataGridView()
        Me.PanelCart = New System.Windows.Forms.Panel()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.PanelLeftSide = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCart = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBuy = New System.Windows.Forms.Button()
        Me.PanelOnBtnDF = New System.Windows.Forms.Panel()
        Me.btnProduct = New System.Windows.Forms.Button()
        Me.PanelTopSide = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.btnLemari2 = New System.Windows.Forms.Button()
        Me.btnMeja2 = New System.Windows.Forms.Button()
        Me.btnKursi2 = New System.Windows.Forms.Button()
        Me.btnKursi1 = New System.Windows.Forms.Button()
        Me.btnMeja1 = New System.Windows.Forms.Button()
        Me.btnLemari1 = New System.Windows.Forms.Button()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.txtHargaSatuan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelProduct.SuspendLayout()
        Me.PanelBuy.SuspendLayout()
        CType(Me.DataGridViewKeranjang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewFurniture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCart.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLeftSide.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelProduct
        '
        Me.PanelProduct.Controls.Add(Me.btnLemari2)
        Me.PanelProduct.Controls.Add(Me.btnMeja2)
        Me.PanelProduct.Controls.Add(Me.btnKursi2)
        Me.PanelProduct.Controls.Add(Me.btnKursi1)
        Me.PanelProduct.Controls.Add(Me.btnMeja1)
        Me.PanelProduct.Controls.Add(Me.btnLemari1)
        Me.PanelProduct.Location = New System.Drawing.Point(220, 50)
        Me.PanelProduct.Name = "PanelProduct"
        Me.PanelProduct.Size = New System.Drawing.Size(970, 599)
        Me.PanelProduct.TabIndex = 5
        '
        'PanelBuy
        '
        Me.PanelBuy.Controls.Add(Me.btnCheckout)
        Me.PanelBuy.Controls.Add(Me.DataGridViewKeranjang)
        Me.PanelBuy.Controls.Add(Me.btnCancel)
        Me.PanelBuy.Controls.Add(Me.btnDelete)
        Me.PanelBuy.Controls.Add(Me.btnUpdate)
        Me.PanelBuy.Controls.Add(Me.btnSave)
        Me.PanelBuy.Controls.Add(Me.GroupBox1)
        Me.PanelBuy.Controls.Add(Me.DataGridViewFurniture)
        Me.PanelBuy.Location = New System.Drawing.Point(223, 50)
        Me.PanelBuy.Name = "PanelBuy"
        Me.PanelBuy.Size = New System.Drawing.Size(970, 666)
        Me.PanelBuy.TabIndex = 12
        '
        'DataGridViewKeranjang
        '
        Me.DataGridViewKeranjang.AllowUserToAddRows = False
        Me.DataGridViewKeranjang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewKeranjang.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.DataGridViewKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewKeranjang.Location = New System.Drawing.Point(23, 377)
        Me.DataGridViewKeranjang.Name = "DataGridViewKeranjang"
        Me.DataGridViewKeranjang.RowHeadersVisible = False
        Me.DataGridViewKeranjang.RowHeadersWidth = 51
        Me.DataGridViewKeranjang.RowTemplate.Height = 24
        Me.DataGridViewKeranjang.Size = New System.Drawing.Size(893, 242)
        Me.DataGridViewKeranjang.TabIndex = 9
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(385, 329)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 31)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(259, 329)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(86, 31)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(143, 329)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(82, 31)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(23, 329)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(93, 31)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Add Cart"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtHargaSatuan)
        Me.GroupBox1.Controls.Add(Me.txtMaterial)
        Me.GroupBox1.Controls.Add(Me.txtJenis)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.txtHarga)
        Me.GroupBox1.Controls.Add(Me.txtWarna)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(455, 293)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Form Custumer"
        '
        'txtMaterial
        '
        Me.txtMaterial.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaterial.Location = New System.Drawing.Point(171, 77)
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.ReadOnly = True
        Me.txtMaterial.Size = New System.Drawing.Size(249, 30)
        Me.txtMaterial.TabIndex = 30
        '
        'txtJenis
        '
        Me.txtJenis.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJenis.Location = New System.Drawing.Point(171, 40)
        Me.txtJenis.Name = "txtJenis"
        Me.txtJenis.ReadOnly = True
        Me.txtJenis.Size = New System.Drawing.Size(249, 30)
        Me.txtJenis.TabIndex = 29
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(171, 197)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(249, 30)
        Me.NumericUpDown1.TabIndex = 14
        '
        'txtHarga
        '
        Me.txtHarga.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHarga.Location = New System.Drawing.Point(171, 243)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.ReadOnly = True
        Me.txtHarga.Size = New System.Drawing.Size(249, 30)
        Me.txtHarga.TabIndex = 26
        '
        'txtWarna
        '
        Me.txtWarna.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWarna.Location = New System.Drawing.Point(171, 122)
        Me.txtWarna.Name = "txtWarna"
        Me.txtWarna.ReadOnly = True
        Me.txtWarna.Size = New System.Drawing.Size(249, 30)
        Me.txtWarna.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 22)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Total Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 22)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Jumlah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 22)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Warna"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 22)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Material"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 22)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Jenis Furniture"
        '
        'DataGridViewFurniture
        '
        Me.DataGridViewFurniture.AllowUserToAddRows = False
        Me.DataGridViewFurniture.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewFurniture.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.DataGridViewFurniture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewFurniture.Location = New System.Drawing.Point(484, 28)
        Me.DataGridViewFurniture.Name = "DataGridViewFurniture"
        Me.DataGridViewFurniture.RowHeadersVisible = False
        Me.DataGridViewFurniture.RowHeadersWidth = 51
        Me.DataGridViewFurniture.RowTemplate.Height = 24
        Me.DataGridViewFurniture.Size = New System.Drawing.Size(432, 285)
        Me.DataGridViewFurniture.TabIndex = 0
        '
        'PanelCart
        '
        Me.PanelCart.Controls.Add(Me.DataGridView3)
        Me.PanelCart.Location = New System.Drawing.Point(223, 50)
        Me.PanelCart.Name = "PanelCart"
        Me.PanelCart.Size = New System.Drawing.Size(970, 593)
        Me.PanelCart.TabIndex = 29
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(53, 80)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersVisible = False
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(863, 371)
        Me.DataGridView3.TabIndex = 0
        '
        'PanelLeftSide
        '
        Me.PanelLeftSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.PanelLeftSide.Controls.Add(Me.Panel3)
        Me.PanelLeftSide.Controls.Add(Me.btnCart)
        Me.PanelLeftSide.Controls.Add(Me.Panel1)
        Me.PanelLeftSide.Controls.Add(Me.btnBuy)
        Me.PanelLeftSide.Controls.Add(Me.PanelOnBtnDF)
        Me.PanelLeftSide.Controls.Add(Me.btnProduct)
        Me.PanelLeftSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLeftSide.Location = New System.Drawing.Point(0, 0)
        Me.PanelLeftSide.Name = "PanelLeftSide"
        Me.PanelLeftSide.Size = New System.Drawing.Size(220, 786)
        Me.PanelLeftSide.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 346)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 37)
        Me.Panel3.TabIndex = 6
        '
        'btnCart
        '
        Me.btnCart.FlatAppearance.BorderSize = 0
        Me.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCart.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCart.ForeColor = System.Drawing.Color.White
        Me.btnCart.Location = New System.Drawing.Point(3, 346)
        Me.btnCart.Name = "btnCart"
        Me.btnCart.Size = New System.Drawing.Size(220, 37)
        Me.btnCart.TabIndex = 7
        Me.btnCart.Text = "MY CART"
        Me.btnCart.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 243)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 37)
        Me.Panel1.TabIndex = 2
        '
        'btnBuy
        '
        Me.btnBuy.FlatAppearance.BorderSize = 0
        Me.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuy.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuy.ForeColor = System.Drawing.Color.White
        Me.btnBuy.Location = New System.Drawing.Point(0, 243)
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(220, 37)
        Me.btnBuy.TabIndex = 3
        Me.btnBuy.Text = "BUY"
        Me.btnBuy.UseVisualStyleBackColor = True
        '
        'PanelOnBtnDF
        '
        Me.PanelOnBtnDF.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.PanelOnBtnDF.Location = New System.Drawing.Point(0, 147)
        Me.PanelOnBtnDF.Name = "PanelOnBtnDF"
        Me.PanelOnBtnDF.Size = New System.Drawing.Size(12, 39)
        Me.PanelOnBtnDF.TabIndex = 1
        '
        'btnProduct
        '
        Me.btnProduct.FlatAppearance.BorderSize = 0
        Me.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduct.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduct.ForeColor = System.Drawing.Color.White
        Me.btnProduct.Location = New System.Drawing.Point(0, 147)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(220, 39)
        Me.btnProduct.TabIndex = 1
        Me.btnProduct.Text = "PRODUCT"
        Me.btnProduct.UseVisualStyleBackColor = True
        '
        'PanelTopSide
        '
        Me.PanelTopSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.PanelTopSide.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTopSide.Location = New System.Drawing.Point(220, 0)
        Me.PanelTopSide.Name = "PanelTopSide"
        Me.PanelTopSide.Size = New System.Drawing.Size(995, 44)
        Me.PanelTopSide.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(220, 737)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(995, 49)
        Me.Panel4.TabIndex = 8
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'btnLemari2
        '
        Me.btnLemari2.BackgroundImage = Global.AlisaPemvis.My.Resources.Resources.download__32_
        Me.btnLemari2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLemari2.Location = New System.Drawing.Point(669, 341)
        Me.btnLemari2.Name = "btnLemari2"
        Me.btnLemari2.Size = New System.Drawing.Size(274, 213)
        Me.btnLemari2.TabIndex = 11
        Me.btnLemari2.UseVisualStyleBackColor = True
        '
        'btnMeja2
        '
        Me.btnMeja2.BackgroundImage = Global.AlisaPemvis.My.Resources.Resources._johnlewis
        Me.btnMeja2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMeja2.Location = New System.Drawing.Point(357, 341)
        Me.btnMeja2.Name = "btnMeja2"
        Me.btnMeja2.Size = New System.Drawing.Size(274, 213)
        Me.btnMeja2.TabIndex = 10
        Me.btnMeja2.UseVisualStyleBackColor = True
        '
        'btnKursi2
        '
        Me.btnKursi2.BackgroundImage = Global.AlisaPemvis.My.Resources.Resources.download__31_
        Me.btnKursi2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnKursi2.Location = New System.Drawing.Point(36, 341)
        Me.btnKursi2.Name = "btnKursi2"
        Me.btnKursi2.Size = New System.Drawing.Size(274, 213)
        Me.btnKursi2.TabIndex = 9
        Me.btnKursi2.UseVisualStyleBackColor = True
        '
        'btnKursi1
        '
        Me.btnKursi1.BackgroundImage = Global.AlisaPemvis.My.Resources.Resources.Gubi_TS_Round_Coffee_Table_in_Gold_Tan__Size_Small__21_7_Diameter
        Me.btnKursi1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnKursi1.Location = New System.Drawing.Point(669, 44)
        Me.btnKursi1.Name = "btnKursi1"
        Me.btnKursi1.Size = New System.Drawing.Size(274, 213)
        Me.btnKursi1.TabIndex = 8
        Me.btnKursi1.UseVisualStyleBackColor = True
        '
        'btnMeja1
        '
        Me.btnMeja1.BackgroundImage = Global.AlisaPemvis.My.Resources.Resources.Langue_Bar_Chair___Leather___Rust_21002___Light_Smoked_Beech___75_cm
        Me.btnMeja1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMeja1.Location = New System.Drawing.Point(357, 44)
        Me.btnMeja1.Name = "btnMeja1"
        Me.btnMeja1.Size = New System.Drawing.Size(274, 213)
        Me.btnMeja1.TabIndex = 7
        Me.btnMeja1.UseVisualStyleBackColor = True
        '
        'btnLemari1
        '
        Me.btnLemari1.BackgroundImage = Global.AlisaPemvis.My.Resources.Resources.Ukuran_Lemari_Pakaian_Minimalis_Pintu_3__Update_Terlengkap_
        Me.btnLemari1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLemari1.Location = New System.Drawing.Point(36, 44)
        Me.btnLemari1.Name = "btnLemari1"
        Me.btnLemari1.Size = New System.Drawing.Size(274, 213)
        Me.btnLemari1.TabIndex = 6
        Me.btnLemari1.UseVisualStyleBackColor = True
        '
        'btnCheckout
        '
        Me.btnCheckout.Location = New System.Drawing.Point(749, 625)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(111, 38)
        Me.btnCheckout.TabIndex = 10
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = True
        '
        'txtHargaSatuan
        '
        Me.txtHargaSatuan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHargaSatuan.Location = New System.Drawing.Point(171, 158)
        Me.txtHargaSatuan.Name = "txtHargaSatuan"
        Me.txtHargaSatuan.ReadOnly = True
        Me.txtHargaSatuan.Size = New System.Drawing.Size(249, 30)
        Me.txtHargaSatuan.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 22)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Harga Satuan"
        '
        'FormCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1215, 786)
        Me.Controls.Add(Me.PanelBuy)
        Me.Controls.Add(Me.PanelProduct)
        Me.Controls.Add(Me.PanelCart)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.PanelTopSide)
        Me.Controls.Add(Me.PanelLeftSide)
        Me.Name = "FormCustomer"
        Me.Text = "FormCustomer"
        Me.PanelProduct.ResumeLayout(False)
        Me.PanelBuy.ResumeLayout(False)
        CType(Me.DataGridViewKeranjang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewFurniture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCart.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLeftSide.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelProduct As Panel
    Friend WithEvents PanelBuy As Panel
    Friend WithEvents DataGridViewKeranjang As DataGridView
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PanelCart As Panel
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtWarna As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewFurniture As DataGridView
    Friend WithEvents btnLemari2 As Button
    Friend WithEvents btnMeja2 As Button
    Friend WithEvents btnKursi2 As Button
    Friend WithEvents btnKursi1 As Button
    Friend WithEvents btnMeja1 As Button
    Friend WithEvents btnLemari1 As Button
    Friend WithEvents PanelLeftSide As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCart As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBuy As Button
    Friend WithEvents PanelOnBtnDF As Panel
    Friend WithEvents btnProduct As Button
    Friend WithEvents PanelTopSide As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtMaterial As TextBox
    Friend WithEvents txtJenis As TextBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents btnCheckout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtHargaSatuan As TextBox
End Class

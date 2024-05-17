<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdmin))
        Me.PanelTopSide = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PanelLeftSide = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnLjual = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnPembelian = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDCustomer = New System.Windows.Forms.Button()
        Me.PanelOnBtnDF = New System.Windows.Forms.Panel()
        Me.btnDFurniture = New System.Windows.Forms.Button()
        Me.PanelDFurniture = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.gbFormFurniture = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDeskripsi = New System.Windows.Forms.TextBox()
        Me.txtJenis = New System.Windows.Forms.TextBox()
        Me.numStok = New System.Windows.Forms.NumericUpDown()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.cbMaterial = New System.Windows.Forms.ComboBox()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtWarna = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelDCustomer = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnPrintDCustomer = New System.Windows.Forms.Button()
        Me.btnCetakDataCustomer = New System.Windows.Forms.Button()
        Me.DataGridViewCustomer = New System.Windows.Forms.DataGridView()
        Me.PanelLPenjualan = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnPenjualan = New System.Windows.Forms.Button()
        Me.DataGridViewPenjualan = New System.Windows.Forms.DataGridView()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog2 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PanelTopSide.SuspendLayout()
        Me.PanelLeftSide.SuspendLayout()
        Me.PanelDFurniture.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFormFurniture.SuspendLayout()
        CType(Me.numStok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDCustomer.SuspendLayout()
        CType(Me.DataGridViewCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLPenjualan.SuspendLayout()
        CType(Me.DataGridViewPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTopSide
        '
        Me.PanelTopSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.PanelTopSide.Controls.Add(Me.Button5)
        Me.PanelTopSide.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTopSide.Location = New System.Drawing.Point(0, 0)
        Me.PanelTopSide.Name = "PanelTopSide"
        Me.PanelTopSide.Size = New System.Drawing.Size(1190, 55)
        Me.PanelTopSide.TabIndex = 1
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.AlisaPemvis.My.Resources.Resources.gambarClose
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Location = New System.Drawing.Point(1162, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(28, 29)
        Me.Button5.TabIndex = 15
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PanelLeftSide
        '
        Me.PanelLeftSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.PanelLeftSide.Controls.Add(Me.Panel3)
        Me.PanelLeftSide.Controls.Add(Me.btnLjual)
        Me.PanelLeftSide.Controls.Add(Me.Panel2)
        Me.PanelLeftSide.Controls.Add(Me.btnPembelian)
        Me.PanelLeftSide.Controls.Add(Me.Panel1)
        Me.PanelLeftSide.Controls.Add(Me.btnDCustomer)
        Me.PanelLeftSide.Controls.Add(Me.PanelOnBtnDF)
        Me.PanelLeftSide.Controls.Add(Me.btnDFurniture)
        Me.PanelLeftSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLeftSide.Location = New System.Drawing.Point(0, 55)
        Me.PanelLeftSide.Name = "PanelLeftSide"
        Me.PanelLeftSide.Size = New System.Drawing.Size(220, 660)
        Me.PanelLeftSide.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 217)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 37)
        Me.Panel3.TabIndex = 6
        '
        'btnLjual
        '
        Me.btnLjual.FlatAppearance.BorderSize = 0
        Me.btnLjual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLjual.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLjual.ForeColor = System.Drawing.Color.White
        Me.btnLjual.Location = New System.Drawing.Point(3, 218)
        Me.btnLjual.Name = "btnLjual"
        Me.btnLjual.Size = New System.Drawing.Size(220, 37)
        Me.btnLjual.TabIndex = 7
        Me.btnLjual.Text = "LAPORAN PENJUALAN"
        Me.btnLjual.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 271)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 37)
        Me.Panel2.TabIndex = 4
        '
        'btnPembelian
        '
        Me.btnPembelian.FlatAppearance.BorderSize = 0
        Me.btnPembelian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPembelian.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPembelian.ForeColor = System.Drawing.Color.White
        Me.btnPembelian.Location = New System.Drawing.Point(0, 271)
        Me.btnPembelian.Name = "btnPembelian"
        Me.btnPembelian.Size = New System.Drawing.Size(220, 37)
        Me.btnPembelian.TabIndex = 5
        Me.btnPembelian.Text = "LAPORAN PEMBELIAN"
        Me.btnPembelian.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 164)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 37)
        Me.Panel1.TabIndex = 2
        '
        'btnDCustomer
        '
        Me.btnDCustomer.FlatAppearance.BorderSize = 0
        Me.btnDCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDCustomer.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDCustomer.ForeColor = System.Drawing.Color.White
        Me.btnDCustomer.Location = New System.Drawing.Point(0, 164)
        Me.btnDCustomer.Name = "btnDCustomer"
        Me.btnDCustomer.Size = New System.Drawing.Size(220, 37)
        Me.btnDCustomer.TabIndex = 3
        Me.btnDCustomer.Text = "DATA CUSTOMER"
        Me.btnDCustomer.UseVisualStyleBackColor = True
        '
        'PanelOnBtnDF
        '
        Me.PanelOnBtnDF.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.PanelOnBtnDF.Location = New System.Drawing.Point(0, 108)
        Me.PanelOnBtnDF.Name = "PanelOnBtnDF"
        Me.PanelOnBtnDF.Size = New System.Drawing.Size(12, 39)
        Me.PanelOnBtnDF.TabIndex = 1
        '
        'btnDFurniture
        '
        Me.btnDFurniture.FlatAppearance.BorderSize = 0
        Me.btnDFurniture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDFurniture.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDFurniture.ForeColor = System.Drawing.Color.White
        Me.btnDFurniture.Location = New System.Drawing.Point(0, 108)
        Me.btnDFurniture.Name = "btnDFurniture"
        Me.btnDFurniture.Size = New System.Drawing.Size(220, 39)
        Me.btnDFurniture.TabIndex = 1
        Me.btnDFurniture.Text = "DATA FURNITURE"
        Me.btnDFurniture.UseVisualStyleBackColor = True
        '
        'PanelDFurniture
        '
        Me.PanelDFurniture.Controls.Add(Me.Panel4)
        Me.PanelDFurniture.Controls.Add(Me.DataGridView1)
        Me.PanelDFurniture.Controls.Add(Me.txtCari)
        Me.PanelDFurniture.Controls.Add(Me.btnBatal)
        Me.PanelDFurniture.Controls.Add(Me.btnHapus)
        Me.PanelDFurniture.Controls.Add(Me.btnUbah)
        Me.PanelDFurniture.Controls.Add(Me.btnSimpan)
        Me.PanelDFurniture.Controls.Add(Me.gbFormFurniture)
        Me.PanelDFurniture.Location = New System.Drawing.Point(220, 61)
        Me.PanelDFurniture.Name = "PanelDFurniture"
        Me.PanelDFurniture.Size = New System.Drawing.Size(988, 701)
        Me.PanelDFurniture.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 652)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(988, 49)
        Me.Panel4.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 345)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(960, 301)
        Me.DataGridView1.TabIndex = 6
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(499, 295)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(443, 30)
        Me.txtCari.TabIndex = 5
        '
        'btnBatal
        '
        Me.btnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(336, 294)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(88, 31)
        Me.btnBatal.TabIndex = 4
        Me.btnBatal.Text = "Cancel"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(232, 294)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(86, 31)
        Me.btnHapus.TabIndex = 3
        Me.btnHapus.Text = "Delete"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbah.Location = New System.Drawing.Point(132, 294)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(82, 31)
        Me.btnUbah.TabIndex = 2
        Me.btnUbah.Text = "Update"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(22, 294)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(93, 31)
        Me.btnSimpan.TabIndex = 1
        Me.btnSimpan.Text = "Save"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'gbFormFurniture
        '
        Me.gbFormFurniture.Controls.Add(Me.Label9)
        Me.gbFormFurniture.Controls.Add(Me.txtDeskripsi)
        Me.gbFormFurniture.Controls.Add(Me.txtJenis)
        Me.gbFormFurniture.Controls.Add(Me.numStok)
        Me.gbFormFurniture.Controls.Add(Me.dtpTanggal)
        Me.gbFormFurniture.Controls.Add(Me.cbMaterial)
        Me.gbFormFurniture.Controls.Add(Me.txtSupplier)
        Me.gbFormFurniture.Controls.Add(Me.txtHarga)
        Me.gbFormFurniture.Controls.Add(Me.txtWarna)
        Me.gbFormFurniture.Controls.Add(Me.txtId)
        Me.gbFormFurniture.Controls.Add(Me.Label8)
        Me.gbFormFurniture.Controls.Add(Me.Label7)
        Me.gbFormFurniture.Controls.Add(Me.Label6)
        Me.gbFormFurniture.Controls.Add(Me.Label5)
        Me.gbFormFurniture.Controls.Add(Me.Label4)
        Me.gbFormFurniture.Controls.Add(Me.Label3)
        Me.gbFormFurniture.Controls.Add(Me.Label2)
        Me.gbFormFurniture.Controls.Add(Me.Label1)
        Me.gbFormFurniture.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFormFurniture.Location = New System.Drawing.Point(16, 22)
        Me.gbFormFurniture.Name = "gbFormFurniture"
        Me.gbFormFurniture.Size = New System.Drawing.Size(960, 257)
        Me.gbFormFurniture.TabIndex = 0
        Me.gbFormFurniture.TabStop = False
        Me.gbFormFurniture.Text = "Form Furniture"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(527, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 22)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Deskripsi"
        '
        'txtDeskripsi
        '
        Me.txtDeskripsi.Location = New System.Drawing.Point(677, 11)
        Me.txtDeskripsi.Name = "txtDeskripsi"
        Me.txtDeskripsi.Size = New System.Drawing.Size(134, 27)
        Me.txtDeskripsi.TabIndex = 14
        '
        'txtJenis
        '
        Me.txtJenis.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJenis.Location = New System.Drawing.Point(178, 92)
        Me.txtJenis.Name = "txtJenis"
        Me.txtJenis.Size = New System.Drawing.Size(249, 30)
        Me.txtJenis.TabIndex = 13
        '
        'numStok
        '
        Me.numStok.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numStok.Location = New System.Drawing.Point(677, 53)
        Me.numStok.Name = "numStok"
        Me.numStok.Size = New System.Drawing.Size(249, 30)
        Me.numStok.TabIndex = 1
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTanggal.Location = New System.Drawing.Point(677, 145)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(249, 30)
        Me.dtpTanggal.TabIndex = 1
        '
        'cbMaterial
        '
        Me.cbMaterial.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMaterial.FormattingEnabled = True
        Me.cbMaterial.Items.AddRange(New Object() {"Kayu", "Jati", "Bambu", "Plastik", "Besi"})
        Me.cbMaterial.Location = New System.Drawing.Point(178, 150)
        Me.cbMaterial.Name = "cbMaterial"
        Me.cbMaterial.Size = New System.Drawing.Size(249, 30)
        Me.cbMaterial.TabIndex = 12
        '
        'txtSupplier
        '
        Me.txtSupplier.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplier.Location = New System.Drawing.Point(677, 199)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(249, 30)
        Me.txtSupplier.TabIndex = 11
        '
        'txtHarga
        '
        Me.txtHarga.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHarga.Location = New System.Drawing.Point(677, 97)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(249, 30)
        Me.txtHarga.TabIndex = 10
        '
        'txtWarna
        '
        Me.txtWarna.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWarna.Location = New System.Drawing.Point(178, 204)
        Me.txtWarna.Name = "txtWarna"
        Me.txtWarna.Size = New System.Drawing.Size(249, 30)
        Me.txtWarna.TabIndex = 9
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(178, 43)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(249, 30)
        Me.txtId.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(527, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 22)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Supplier"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(527, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 22)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Tanggal Terima"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(527, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 22)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(527, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Stok"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Warna"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Material"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jenis Furniture"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Furniture"
        '
        'PanelDCustomer
        '
        Me.PanelDCustomer.Controls.Add(Me.TextBox1)
        Me.PanelDCustomer.Controls.Add(Me.btnPrintDCustomer)
        Me.PanelDCustomer.Controls.Add(Me.btnCetakDataCustomer)
        Me.PanelDCustomer.Controls.Add(Me.DataGridViewCustomer)
        Me.PanelDCustomer.Location = New System.Drawing.Point(220, 61)
        Me.PanelDCustomer.Name = "PanelDCustomer"
        Me.PanelDCustomer.Size = New System.Drawing.Size(988, 701)
        Me.PanelDCustomer.TabIndex = 14
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(283, 178)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(380, 30)
        Me.TextBox1.TabIndex = 3
        '
        'btnPrintDCustomer
        '
        Me.btnPrintDCustomer.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintDCustomer.Location = New System.Drawing.Point(164, 178)
        Me.btnPrintDCustomer.Name = "btnPrintDCustomer"
        Me.btnPrintDCustomer.Size = New System.Drawing.Size(94, 29)
        Me.btnPrintDCustomer.TabIndex = 2
        Me.btnPrintDCustomer.Text = "Print"
        Me.btnPrintDCustomer.UseVisualStyleBackColor = True
        '
        'btnCetakDataCustomer
        '
        Me.btnCetakDataCustomer.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetakDataCustomer.Location = New System.Drawing.Point(68, 178)
        Me.btnCetakDataCustomer.Name = "btnCetakDataCustomer"
        Me.btnCetakDataCustomer.Size = New System.Drawing.Size(90, 29)
        Me.btnCetakDataCustomer.TabIndex = 1
        Me.btnCetakDataCustomer.Text = "Delete"
        Me.btnCetakDataCustomer.UseVisualStyleBackColor = True
        '
        'DataGridViewCustomer
        '
        Me.DataGridViewCustomer.AllowUserToAddRows = False
        Me.DataGridViewCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewCustomer.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.DataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCustomer.Location = New System.Drawing.Point(68, 233)
        Me.DataGridViewCustomer.Name = "DataGridViewCustomer"
        Me.DataGridViewCustomer.RowHeadersVisible = False
        Me.DataGridViewCustomer.RowHeadersWidth = 51
        Me.DataGridViewCustomer.RowTemplate.Height = 24
        Me.DataGridViewCustomer.Size = New System.Drawing.Size(855, 287)
        Me.DataGridViewCustomer.TabIndex = 0
        '
        'PanelLPenjualan
        '
        Me.PanelLPenjualan.Controls.Add(Me.TextBox2)
        Me.PanelLPenjualan.Controls.Add(Me.btnPenjualan)
        Me.PanelLPenjualan.Controls.Add(Me.DataGridViewPenjualan)
        Me.PanelLPenjualan.Location = New System.Drawing.Point(220, 61)
        Me.PanelLPenjualan.Name = "PanelLPenjualan"
        Me.PanelLPenjualan.Size = New System.Drawing.Size(988, 701)
        Me.PanelLPenjualan.TabIndex = 15
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(194, 167)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(380, 30)
        Me.TextBox2.TabIndex = 7
        '
        'btnPenjualan
        '
        Me.btnPenjualan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPenjualan.Location = New System.Drawing.Point(75, 167)
        Me.btnPenjualan.Name = "btnPenjualan"
        Me.btnPenjualan.Size = New System.Drawing.Size(94, 29)
        Me.btnPenjualan.TabIndex = 6
        Me.btnPenjualan.Text = "Print"
        Me.btnPenjualan.UseVisualStyleBackColor = True
        '
        'DataGridViewPenjualan
        '
        Me.DataGridViewPenjualan.AllowUserToAddRows = False
        Me.DataGridViewPenjualan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewPenjualan.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.DataGridViewPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPenjualan.Location = New System.Drawing.Point(67, 214)
        Me.DataGridViewPenjualan.Name = "DataGridViewPenjualan"
        Me.DataGridViewPenjualan.RowHeadersVisible = False
        Me.DataGridViewPenjualan.RowHeadersWidth = 51
        Me.DataGridViewPenjualan.RowTemplate.Height = 24
        Me.DataGridViewPenjualan.Size = New System.Drawing.Size(855, 287)
        Me.DataGridViewPenjualan.TabIndex = 4
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
        'PrintPreviewDialog2
        '
        Me.PrintPreviewDialog2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog2.Enabled = True
        Me.PrintPreviewDialog2.Icon = CType(resources.GetObject("PrintPreviewDialog2.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog2.Name = "PrintPreviewDialog2"
        Me.PrintPreviewDialog2.Visible = False
        '
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 715)
        Me.Controls.Add(Me.PanelLPenjualan)
        Me.Controls.Add(Me.PanelDCustomer)
        Me.Controls.Add(Me.PanelDFurniture)
        Me.Controls.Add(Me.PanelLeftSide)
        Me.Controls.Add(Me.PanelTopSide)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAdmin"
        Me.Text = "Form1"
        Me.PanelTopSide.ResumeLayout(False)
        Me.PanelLeftSide.ResumeLayout(False)
        Me.PanelDFurniture.ResumeLayout(False)
        Me.PanelDFurniture.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFormFurniture.ResumeLayout(False)
        Me.gbFormFurniture.PerformLayout()
        CType(Me.numStok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDCustomer.ResumeLayout(False)
        Me.PanelDCustomer.PerformLayout()
        CType(Me.DataGridViewCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLPenjualan.ResumeLayout(False)
        Me.PanelLPenjualan.PerformLayout()
        CType(Me.DataGridViewPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTopSide As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents PanelLeftSide As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnLjual As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDCustomer As Button
    Friend WithEvents PanelOnBtnDF As Panel
    Friend WithEvents btnDFurniture As Button
    Friend WithEvents PanelDFurniture As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents gbFormFurniture As GroupBox
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents txtJenis As TextBox
    Friend WithEvents numStok As NumericUpDown
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents cbMaterial As ComboBox
    Friend WithEvents txtSupplier As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtWarna As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelDCustomer As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnPrintDCustomer As Button
    Friend WithEvents btnCetakDataCustomer As Button
    Friend WithEvents DataGridViewCustomer As DataGridView
    Friend WithEvents PanelLPenjualan As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnPenjualan As Button
    Friend WithEvents DataGridViewPenjualan As DataGridView
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog2 As PrintPreviewDialog
    Friend WithEvents Label9 As Label
    Friend WithEvents btnPembelian As Button
End Class

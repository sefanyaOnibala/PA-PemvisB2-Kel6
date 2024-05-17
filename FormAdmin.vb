Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class FormAdmin
    Private CONN As MySqlConnection
    Private CMD As MySqlCommand
    Private DA As MySqlDataAdapter
    Private DS As DataSet
    Private originalDataSource As DataTable

    Private Sub PanelTopSide_Paint(sender As Object, e As PaintEventArgs) Handles PanelTopSide.Paint
    End Sub

    Private Sub Koneksi()
        Dim connStr As String = "server=localhost;user id=root;password=;database=dbsistemfurniture"
        CONN = New MySqlConnection(connStr)
        Try
            CONN.Open()
        Catch ex As Exception
            MsgBox("Kesalahan saat membuka koneksi: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadFurnitureData()
        Try
            Koneksi()
            Dim query As String = "SELECT `IdFurniture`, `JenisFurniture`, `Material`, `warna`, `Stok`, `Harga`, `TanggalPenerimaan`, `Supplier`, `Deskripsi` FROM `furniture`"
            CMD = New MySqlCommand(query, CONN)
            DA = New MySqlDataAdapter(CMD)
            DS = New DataSet()
            DA.Fill(DS, "furniture")
            DataGridView1.DataSource = DS.Tables("furniture")
            DataGridView1.AutoResizeColumns()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CONN.Close()
        End Try
    End Sub

    Private Sub LoadCustomerData()
        Try
            Koneksi()
            Dim query As String = "SELECT `Username`, `Email`, `PhoneNumber`, `Alamat`, `Password` FROM `datacustomer`"
            CMD = New MySqlCommand(query, CONN)
            DA = New MySqlDataAdapter(CMD)
            DS = New DataSet()
            DA.Fill(DS, "datacustomer")
            DataGridViewCustomer.DataSource = DS.Tables("datacustomer")
            DataGridViewCustomer.AutoResizeColumns()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CONN.Close()
        End Try
    End Sub

    Private Sub LoadPenjualanData()
        Try
            Koneksi()
            Dim query As String = "SELECT `Jenis`, `Material`, `Warna`, `Jumlah`, `HargaSatuan`, `Total` FROM `cart` WHERE 1"
            CMD = New MySqlCommand(query, CONN)
            DA = New MySqlDataAdapter(CMD)
            DS = New DataSet()
            DA.Fill(DS, "cart")
            DataGridViewPenjualan.DataSource = DS.Tables("cart")
            DataGridViewPenjualan.AutoResizeColumns()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CONN.Close()
        End Try
    End Sub




    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DataGridView1.DataSource IsNot Nothing Then
            ' Simpan sumber data asli saat memuat form
            originalDataSource = CType(DataGridView1.DataSource, DataTable).Copy()
        End If

        LoadFurnitureData()
        LoadCustomerData()
        LoadPenjualanData()
    End Sub


    Private Sub btnDFurniture_Click(sender As Object, e As EventArgs) Handles btnDFurniture.Click
        PanelDFurniture.Visible = True
        PanelDCustomer.Visible = False
        PanelLPenjualan.Visible = False
    End Sub

    Private Sub btnDCustomer_Click(sender As Object, e As EventArgs) Handles btnDCustomer.Click
        PanelDFurniture.Visible = False
        PanelDCustomer.Visible = True
        PanelLPenjualan.Visible = False
    End Sub

    Private Sub btnJual_Click(sender As Object, e As EventArgs) Handles btnLjual.Click
        PanelDFurniture.Visible = False
        PanelDCustomer.Visible = False
        PanelLPenjualan.Visible = True
    End Sub


    Private Sub ClearForm()
        txtId.Text = ""
        txtJenis.Text = ""
        cbMaterial.SelectedIndex = -1
        txtWarna.BackColor = Color.White
        numStok.Value = 0
        txtHarga.Text = ""
        dtpTanggal.Value = DateTime.Now
        txtSupplier.Text = ""
        txtDeskripsi.Text = ""
    End Sub

    ' Metode untuk menyimpan data ke database
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Try
            ' Pastikan objek koneksi diinisialisasi
            If CONN Is Nothing Then
                MsgBox("Objek koneksi belum diinisialisasi.")
                Return
            End If

            ' Pastikan koneksi ke database terbuka
            If CONN.State = ConnectionState.Closed Then
                Koneksi() ' Membuka koneksi jika belum terbuka
            End If

            ' Cek lagi apakah koneksi sudah terbuka
            If CONN.State = ConnectionState.Closed Then
                MsgBox("Gagal membuka koneksi!")
                Return
            End If

            ' Pastikan objek CMD diinisialisasi
            If CMD Is Nothing Then
                CMD = New MySqlCommand()
            End If

            ' Pengecekan inputan
            If txtId.Text = "" OrElse txtJenis.Text = "" OrElse cbMaterial.SelectedIndex = -1 OrElse txtWarna.BackColor = Color.White OrElse numStok.Value = 0 OrElse txtHarga.Text = "" OrElse txtSupplier.Text = "" OrElse txtDeskripsi.Text = "" Then
                MsgBox("Semua inputan harus diisi.")
                Return
            End If

            Dim query As String = "INSERT INTO furniture (IdFurniture, JenisFurniture, Material, Warna, Stok, Harga, TanggalPenerimaan, Supplier, Deskripsi) 
                               VALUES (@IdFurniture, @JenisFurniture, @Material, @Warna, @Stok, @Harga, @TanggalPenerimaan, @Supplier, @Deskripsi)"
            CMD.CommandText = query
            CMD.Connection = CONN

            CMD.Parameters.Clear()
            CMD.Parameters.AddWithValue("@IdFurniture", txtId.Text)
            CMD.Parameters.AddWithValue("@JenisFurniture", txtJenis.Text)
            CMD.Parameters.AddWithValue("@Material", cbMaterial.Text)
            ' Menggunakan nilai RGB untuk warna
            CMD.Parameters.AddWithValue("@Warna", txtWarna.BackColor.ToArgb().ToString())
            CMD.Parameters.AddWithValue("@Stok", numStok.Value)
            CMD.Parameters.AddWithValue("@Harga", txtHarga.Text)
            ' Menggunakan format tanggal standar MySQL
            CMD.Parameters.AddWithValue("@TanggalPenerimaan", dtpTanggal.Value.ToString("yyyy-MM-dd"))
            CMD.Parameters.AddWithValue("@Supplier", txtSupplier.Text)
            CMD.Parameters.AddWithValue("@Deskripsi", txtDeskripsi.Text)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil disimpan.")
            ClearForm()

        Catch ex As Exception
            MsgBox("Kesalahan saat menyimpan data: " & ex.Message)

        Finally
            ' Memastikan data diperbarui setelah penyimpanan
            LoadFurnitureData()
            ' Menutup koneksi jika terbuka
            If CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Try
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Mengambil data dari DataGridView dan memuatnya ke inputan
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            txtId.Text = row.Cells("IdFurniture").Value.ToString()
            txtJenis.Text = row.Cells("JenisFurniture").Value.ToString()
            cbMaterial.Text = row.Cells("Material").Value.ToString()
            txtWarna.BackColor = Color.FromArgb(Convert.ToInt32(row.Cells("Warna").Value.ToString()))
            numStok.Value = Convert.ToDecimal(row.Cells("Stok").Value)
            txtHarga.Text = row.Cells("Harga").Value.ToString()
            dtpTanggal.Value = DateTime.Parse(row.Cells("TanggalPenerimaan").Value.ToString())
            txtSupplier.Text = row.Cells("Supplier").Value.ToString()
            txtDeskripsi.Text = row.Cells("Deskripsi").Value.ToString()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Dim kodeFurniture As String = txtId.Text
        Dim query As String = "" ' Deklarasi variabel query di luar blok Try

        If kodeFurniture <> "" Then
            Try
                CONN.Open()
                query = "UPDATE furniture SET JenisFurniture = @JenisFurniture, Material = @Material, Warna = @Warna, Stok = @Stok, Harga = @Harga, TanggalPenerimaan = @TanggalPenerimaan, Supplier = @Supplier, Deskripsi = @Deskripsi WHERE IdFurniture = @IdFurniture"
                CMD = New MySqlCommand(query, CONN)
                CMD.Parameters.AddWithValue("@JenisFurniture", txtJenis.Text)
                CMD.Parameters.AddWithValue("@Material", cbMaterial.Text)
                CMD.Parameters.AddWithValue("@Warna", txtWarna.BackColor.ToArgb().ToString())
                CMD.Parameters.AddWithValue("@Stok", numStok.Value)
                CMD.Parameters.AddWithValue("@Harga", txtHarga.Text)
                CMD.Parameters.AddWithValue("@TanggalPenerimaan", dtpTanggal.Value.ToString("yyyy-MM-dd"))
                CMD.Parameters.AddWithValue("@Supplier", txtSupplier.Text)
                CMD.Parameters.AddWithValue("@Deskripsi", txtDeskripsi.Text)
                CMD.Parameters.AddWithValue("@IdFurniture", kodeFurniture)
                CMD.ExecuteNonQuery()
                MsgBox("Data berhasil diubah.")
                ClearForm()
            Catch ex As Exception
                MsgBox("Kesalahan saat mengubah data: " & ex.Message & vbCrLf & "Query: " & query)
            Finally
                If CONN.State = ConnectionState.Open Then
                    CONN.Close()
                End If
                LoadFurnitureData()
            End Try
        Else
            MsgBox("Masukkan kode furniture untuk mengubah data.")
        End If
    End Sub



    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim kodeFurniture As String = txtId.Text
        If kodeFurniture <> "" Then
            Try
                CONN.Open()
                Dim query As String = "DELETE FROM furniture WHERE IdFurniture = @IdFurniture"
                CMD = New MySqlCommand(query, CONN)
                CMD.Parameters.AddWithValue("@IdFurniture", kodeFurniture)
                CMD.ExecuteNonQuery()
                MsgBox("Data berhasil dihapus.")
                ClearForm()
            Catch ex As Exception
                MsgBox("Kesalahan saat menghapus data: " & ex.Message)
            Finally
                If CONN.State = ConnectionState.Open Then
                    CONN.Close()
                End If
                LoadFurnitureData()
            End Try
        Else
            MsgBox("Pilih data yang akan dihapus.")
        End If
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        ' Simpan filter teks dalam variabel
        Dim filterText As String = txtCari.Text.Trim()

        If originalDataSource IsNot Nothing AndAlso filterText <> "" Then
            ' Buat DataView baru untuk menerapkan filter
            Dim dv As New DataView(originalDataSource)
            dv.RowFilter = "JenisFurniture LIKE '%" & filterText & "%' OR Supplier LIKE '%" & filterText & "%' OR IdFurniture LIKE '%" & filterText & "%' OR Material LIKE '%" & filterText & "%' OR Stok LIKE '%" & filterText & "%' OR Harga LIKE '%" & filterText & "%'"

            ' Setel ulang DataSource DataGridView1 ke DataView yang difilter
            DataGridView1.DataSource = dv
        Else
            ' Setel ulang DataSource DataGridView1 ke sumber data asli jika filter kosong atau sumber data asli belum disetel
            DataGridView1.DataSource = originalDataSource
        End If
    End Sub



    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ClearForm()
    End Sub


    Private Sub txtWarna_Click(sender As Object, e As EventArgs) Handles txtWarna.Click
        Dim dlg As New ColorDialog()
        If dlg.ShowDialog() = DialogResult.OK Then
            txtWarna.BackColor = dlg.Color
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Set font and brush for drawing
        Dim fontTitle As New Font("Arial", 16, FontStyle.Bold)
        Dim fontRegular As New Font("Arial", 10)
        Dim brush As New SolidBrush(Color.Black)
        Dim lineHeight As Single = fontRegular.GetHeight(e.Graphics)

        ' Define starting positions
        Dim startX As Single = 50
        Dim startY As Single = 50
        Dim offsetY As Single = 0

        ' Draw title
        e.Graphics.DrawString("DATA CUSTOMER", fontTitle, brush, startX, startY)
        offsetY += lineHeight * 2

        ' Draw column headers
        e.Graphics.DrawString("Username", fontRegular, brush, startX, startY + offsetY)
        e.Graphics.DrawString("Email", fontRegular, brush, startX + 200, startY + offsetY)
        e.Graphics.DrawString("Phone Number", fontRegular, brush, startX + 300, startY + offsetY)
        e.Graphics.DrawString("Alamat", fontRegular, brush, startX + 400, startY + offsetY)
        offsetY += lineHeight

        ' Draw a line below headers
        e.Graphics.DrawLine(Pens.Black, startX, startY + offsetY, startX + 500, startY + offsetY)
        offsetY += lineHeight / 2

        ' Iterate through DataGridView rows to print each item
        For Each row As DataGridViewRow In DataGridViewCustomer.Rows
            If Not row.IsNewRow Then
                Dim Username As String = row.Cells("Username").Value.ToString()
                Dim Email As String = row.Cells("Email").Value.ToString()
                Dim PhoneNumber As String = row.Cells("PhoneNumber").Value.ToString()
                Dim Alamat As String = row.Cells("Alamat").Value.ToString()

                e.Graphics.DrawString(Username, fontRegular, brush, startX, startY + offsetY)
                e.Graphics.DrawString(Email, fontRegular, brush, startX + 200, startY + offsetY)
                e.Graphics.DrawString(PhoneNumber, fontRegular, brush, startX + 300, startY + offsetY)
                e.Graphics.DrawString(Alamat, fontRegular, brush, startX + 400, startY + offsetY)
                offsetY += lineHeight
            End If
        Next
    End Sub

    Private Sub btnPrintDCustomer_Click(sender As Object, e As EventArgs) Handles btnPrintDCustomer.Click
        ' Menetapkan dokumen print dan menampilkan print preview dialog
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub


    Private Sub btnPenjualan_Click(sender As Object, e As EventArgs) Handles btnPenjualan.Click
        ' Menetapkan dokumen print dan menampilkan print preview dialog
        PrintPreviewDialog2.Document = PrintDocument2
        PrintPreviewDialog2.ShowDialog()
    End Sub

    Private Sub PrintDocument2_PrintPage(sender As Object, e As PrintPageEventArgs)
        ' Set font and brush for drawing
        Dim fontTitle As New Font("Arial", 16, FontStyle.Bold)
        Dim fontRegular As New Font("Arial", 10)
        Dim brush As New SolidBrush(Color.Black)
        Dim lineHeight As Single = fontRegular.GetHeight(e.Graphics)

        ' Define starting positions
        Dim startX As Single = 50
        Dim startY As Single = 50
        Dim offsetY As Single = 0

        ' Draw title
        e.Graphics.DrawString("DATA PENJUALAN", fontTitle, brush, startX, startY)
        offsetY += lineHeight * 2

        ' Draw column headers
        e.Graphics.DrawString("Jenis", fontRegular, brush, startX, startY + offsetY)
        e.Graphics.DrawString("Material", fontRegular, brush, startX + 200, startY + offsetY)
        e.Graphics.DrawString("Jumlah", fontRegular, brush, startX + 300, startY + offsetY)
        e.Graphics.DrawString("HargaSatuan", fontRegular, brush, startX + 400, startY + offsetY)
        e.Graphics.DrawString("Total", fontRegular, brush, startX + 500, startY + offsetY)
        offsetY += lineHeight

        ' Draw a line below headers
        e.Graphics.DrawLine(Pens.Black, startX, startY + offsetY, startX + 600, startY + offsetY)
        offsetY += lineHeight / 2

        ' Iterate through DataGridView rows to print each item
        For Each row As DataGridViewRow In DataGridViewPenjualan.Rows
            If Not row.IsNewRow Then
                Dim Jenis As String = row.Cells("Jenis").Value.ToString()
                Dim Material As String = row.Cells("Material").Value.ToString()
                Dim Jumlah As String = row.Cells("Jumlah").Value.ToString()
                Dim HargaSatuan As String = row.Cells("HargaSatuan").Value.ToString()
                Dim Total As String = row.Cells("Total").Value.ToString()

                e.Graphics.DrawString(Jenis, fontRegular, brush, startX, startY + offsetY)
                e.Graphics.DrawString(Material, fontRegular, brush, startX + 200, startY + offsetY)
                e.Graphics.DrawString(Jumlah, fontRegular, brush, startX + 300, startY + offsetY)
                e.Graphics.DrawString(HargaSatuan, fontRegular, brush, startX + 400, startY + offsetY)
                e.Graphics.DrawString(Total, fontRegular, brush, startX + 500, startY + offsetY)
                offsetY += lineHeight
            End If
        Next
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Hide()
    End Sub


    'Private Sub DataGridViewPenjualan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPenjualan.CellContentClick
    '    ' Mengambil data dari DataGridView dan memuatnya ke inputan
    '    If e.RowIndex >= 0 Then
    '        Dim row As DataGridViewRow = Me.DataGridViewPenjualan.Rows(e.RowIndex)
    '        txtJenis.Text = row.Cells("Jenis").Value.ToString()
    '        cbMaterial.Text = row.Cells("Material").Value.ToString()
    '        Dim warnaValue As Integer
    '        If Integer.TryParse(row.Cells("Warna").Value.ToString(), warnaValue) Then
    '            txtWarna.BackColor = Color.FromArgb(warnaValue)
    '        Else
    '            MessageBox.Show("Format warna tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            Return
    '        End If
    '        NumericUpDown1.Value = Convert.ToDecimal(row.Cells("Jumlah").Value)
    '        txtHarga.Text = row.Cells("HargaSatuan").Value.ToString()
    '        txtHarga.Text = row.Cells("HargaSatuan").Value.ToString()
    '    End If
    'End Sub

    Private Sub DataGridViewPenjualan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPenjualan.CellClick
        ' Mengambil data dari DataGridView dan memuatnya ke inputan
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = Me.DataGridViewPenjualan.Rows(e.RowIndex)
            txtJenis.Text = row.Cells("Jenis").Value.ToString()
            cbMaterial.Text = row.Cells("Material").Value.ToString()
            Dim warnaValue As Integer
            If Integer.TryParse(row.Cells("Warna").Value.ToString(), warnaValue) Then
                txtWarna.BackColor = Color.FromArgb(warnaValue)
            Else
                MessageBox.Show("Format warna tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            numStok.Value = Convert.ToDecimal(row.Cells("Jumlah").Value)
            txtHarga.Text = row.Cells("HargaSatuan").Value.ToString()
            txtHarga.Text = row.Cells("HargaSatuan").Value.ToString()
        End If
    End Sub


End Class


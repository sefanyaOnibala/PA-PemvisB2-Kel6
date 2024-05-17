Imports System.Drawing.Printing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Menu
Imports MySql.Data.MySqlClient

Public Class FormCustomer

    Public Sub AddRowToDataGridView3(rowData As String())
        DataGridView3.Rows.Add(rowData)
    End Sub
    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        PanelProduct.Visible = True
        PanelBuy.Visible = False
        PanelCart.Visible = False
    End Sub
    Private Sub FormCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelProduct.Visible = True
        PanelBuy.Visible = False
        PanelCart.Visible = False
        LoadFurnitureData()
        LoadCartData()
    End Sub

    Private Sub btnBuy_Click(sender As Object, e As EventArgs) Handles btnBuy.Click
        PanelProduct.Visible = False
        PanelBuy.Visible = True
        PanelCart.Visible = False
    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        PanelProduct.Visible = False
        PanelBuy.Visible = False
        PanelCart.Visible = True
    End Sub

    Private Sub btnMeja1_Click(sender As Object, e As EventArgs) Handles btnMeja1.Click
        FormProduk.Show()
    End Sub

    Private Sub btnLemari1_Click(sender As Object, e As EventArgs) Handles btnLemari1.Click
        FormLemari.Show()
    End Sub

    Private Sub LoadCartData()
        Try
            Koneksi()
            Dim query As String = "SELECT `Jenis`, `Material`, `Warna`, `Jumlah`, `HargaSatuan`, `Total` FROM `cart` WHERE 1"
            CMD = New MySqlCommand(query, CONN)
            DA = New MySqlDataAdapter(CMD)
            DS = New DataSet()
            DA.Fill(DS, "cart")
            DataGridViewKeranjang.DataSource = DS.Tables("cart")
            DataGridViewKeranjang.AutoResizeColumns()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CONN.Close()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Ambil nilai dari kontrol inputan
        Dim jenis As String = txtJenis.Text
        Dim material As String = txtMaterial.Text
        Dim warna As String = txtWarna.Text
        Dim jumlah As Integer
        Dim hargaSatuan As Decimal
        Dim total As Decimal

        ' Validasi inputan jumlah
        If Not Integer.TryParse(NumericUpDown1.Value, jumlah) Then
            MessageBox.Show("Jumlah harus berupa angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validasi inputan harga satuan
        If Not Decimal.TryParse(txtHarga.Text, hargaSatuan) Then
            MessageBox.Show("Harga satuan harus berupa angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Hitung total
        total = jumlah * hargaSatuan

        Try
            ' Buka koneksi ke database
            Koneksi()

            ' Query untuk menyimpan data ke database
            Dim query As String = "INSERT INTO cart (Jenis, Material, Warna, Jumlah, HargaSatuan, Total) VALUES (@Jenis, @Material, @Warna, @Jumlah, @HargaSatuan, @Total)"

            ' Buat MySqlCommand
            CMD = New MySqlCommand(query, CONN)

            ' Tambahkan parameter ke MySqlCommand
            CMD.Parameters.AddWithValue("@Jenis", jenis)
            CMD.Parameters.AddWithValue("@Material", material)
            CMD.Parameters.AddWithValue("@Warna", txtWarna.BackColor.ToArgb().ToString())
            CMD.Parameters.AddWithValue("@Jumlah", jumlah)
            CMD.Parameters.AddWithValue("@HargaSatuan", hargaSatuan)
            CMD.Parameters.AddWithValue("@Total", total)

            ' Eksekusi perintah SQL
            CMD.ExecuteNonQuery()

            ' Tampilkan pesan sukses
            MessageBox.Show("Data berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh data di DataGridView
            LoadCartData()
        Catch ex As Exception
            ' Tampilkan pesan error jika terjadi kesalahan
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Tutup koneksi database
            CONN.Close()
        End Try
    End Sub

    Private Sub DataGridViewFurniture_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewFurniture.CellClick
        ' Mengambil data dari DataGridView dan memuatnya ke inputan
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = Me.DataGridViewFurniture.Rows(e.RowIndex)
            txtJenis.Text = row.Cells("JenisFurniture").Value.ToString()
            txtMaterial.Text = row.Cells("Material").Value.ToString()
            txtWarna.BackColor = Color.FromArgb(Convert.ToInt32(row.Cells("Warna").Value.ToString()))
            txtHargaSatuan.Text = row.Cells("Harga").Value.ToString()
            txtHarga.Text = row.Cells("Harga").Value.ToString()
        End If
    End Sub

    Private Sub DataGridViewKeranjang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewKeranjang.CellClick
        ' Mengambil data dari DataGridView dan memuatnya ke inputan
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = Me.DataGridViewKeranjang.Rows(e.RowIndex)
            txtJenis.Text = row.Cells("Jenis").Value.ToString()
            txtMaterial.Text = row.Cells("Material").Value.ToString()
            Dim warnaValue As Integer
            If Integer.TryParse(row.Cells("Warna").Value.ToString(), warnaValue) Then
                txtWarna.BackColor = Color.FromArgb(warnaValue)
            Else
                MessageBox.Show("Format warna tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            NumericUpDown1.Value = Convert.ToDecimal(row.Cells("Jumlah").Value)
            txtHargaSatuan.Text = row.Cells("HargaSatuan").Value.ToString()
            txtHarga.Text = row.Cells("HargaSatuan").Value.ToString()
        End If
    End Sub

    Private Sub ClearForm()
        txtJenis.Clear()
        txtMaterial.Clear()
        txtWarna.Clear()
        NumericUpDown1.Value = 0
        txtHarga.Clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim jenis As String = txtJenis.Text
        Dim material As String = txtMaterial.Text
        Dim warna As String = txtWarna.Text
        Dim jumlah As Integer = NumericUpDown1.Value
        Dim hargaSatuan As Decimal
        Dim total As Decimal

        ' Validasi inputan harga satuan
        If Not Decimal.TryParse(txtHarga.Text, hargaSatuan) Then
            MessageBox.Show("Harga satuan harus berupa angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Hitung total
        total = jumlah * hargaSatuan

        Dim query As String = "" ' Deklarasi variabel query

        Try
            ' Buka koneksi ke database
            Koneksi()

            ' Query untuk mengupdate data di database berdasarkan atribut lainnya
            query = "UPDATE cart SET Material = @Material, Warna = @Warna, Jumlah = @Jumlah, HargaSatuan = @HargaSatuan, Total = @Total WHERE Jenis = @Jenis"

            ' Buat MySqlCommand
            CMD = New MySqlCommand(query, CONN)

            ' Tambahkan parameter ke MySqlCommand
            CMD.Parameters.AddWithValue("@Jenis", jenis)
            CMD.Parameters.AddWithValue("@Material", material)
            CMD.Parameters.AddWithValue("@Warna", txtWarna.BackColor.ToArgb().ToString())
            CMD.Parameters.AddWithValue("@Jumlah", jumlah)
            CMD.Parameters.AddWithValue("@HargaSatuan", hargaSatuan)
            CMD.Parameters.AddWithValue("@Total", total)

            ' Eksekusi perintah SQL
            CMD.ExecuteNonQuery()

            ' Tampilkan pesan sukses
            MessageBox.Show("Data berhasil diubah.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh data di DataGridView
            LoadCartData()
        Catch ex As Exception
            ' Tampilkan pesan error jika terjadi kesalahan
            MessageBox.Show("Kesalahan saat mengubah data: " & ex.Message & vbCrLf & "Query: " & query)
        Finally
            ' Tutup koneksi database
            If CONN IsNot Nothing AndAlso CONN.State = ConnectionState.Open Then
                CONN.Close()
            End If
        End Try
    End Sub






    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim jenis As String = txtJenis.Text

        If jenis <> "" Then
            Try
                ' Buka koneksi ke database
                Koneksi()

                ' Query untuk menghapus data dari database berdasarkan jenis
                Dim query As String = "DELETE FROM cart WHERE Jenis = @Jenis"
                CMD = New MySqlCommand(query, CONN)
                CMD.Parameters.AddWithValue("@Jenis", jenis)
                CMD.ExecuteNonQuery()

                ' Tampilkan pesan sukses
                MessageBox.Show("Data berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Bersihkan form
                ClearForm()
            Catch ex As Exception
                ' Tampilkan pesan error jika terjadi kesalahan
                MessageBox.Show("Kesalahan saat menghapus data: " & ex.Message)
            Finally
                ' Tutup koneksi database
                If CONN.State = ConnectionState.Open Then
                    CONN.Close()
                End If
                ' Refresh data di DataGridView
                LoadCartData()
            End Try
        Else
            MessageBox.Show("Pilih data yang akan dihapus.")
        End If
    End Sub

    Private Sub LoadFurnitureData()
        Try
            Dim connStr As String = "server=localhost;user id=root;password=;database=dbsistemfurniture"
            Using conn As New MySqlConnection(connStr)
                conn.Open()
                Dim query As String = "SELECT IdFurniture, JenisFurniture, Material, Warna, Stok, Harga FROM furniture"
                Using cmd As New MySqlCommand(query, conn)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    DataGridViewFurniture.DataSource = table
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnKursi1_Click(sender As Object, e As EventArgs) Handles btnKursi1.Click
        FormMeja1.Show()
    End Sub

    Private Sub btnKursi2_Click(sender As Object, e As EventArgs) Handles btnKursi2.Click
        FormLemari2.show()
    End Sub


    ' Method untuk menghitung total harga dari DataGridView3
    Public Function CalculateTotalPrice() As Decimal
        Dim totalPrice As Decimal = 0
        For Each row As DataGridViewRow In DataGridView3.Rows
            Dim totalStr As String = row.Cells("Total").Value.ToString()
            Dim total As Decimal
            If Decimal.TryParse(totalStr, total) Then
                totalPrice += total
            End If
        Next
        Return totalPrice
    End Function

    Private Sub txtHargaSatuan_TextChanged(sender As Object, e As EventArgs) Handles txtHargaSatuan.TextChanged
        ' Ketika harga satuan berubah, perbarui harga total
        UpdateTotalHarga()
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        ' Ketika jumlah berubah, perbarui harga total
        UpdateTotalHarga()
    End Sub

    Private Sub UpdateTotalHarga()
        ' Mendapatkan nilai harga satuan dan jumlah
        Dim hargaSatuan As Decimal
        Dim jumlah As Integer

        If Decimal.TryParse(txtHargaSatuan.Text, hargaSatuan) AndAlso Integer.TryParse(NumericUpDown1.Value.ToString(), jumlah) Then
            ' Menghitung total harga
            Dim totalHarga As Decimal = hargaSatuan * jumlah
            ' Menampilkan total harga di txtHarga
            txtHarga.Text = totalHarga.ToString("N2")
        Else
            ' Jika input tidak valid, atur total harga menjadi 0
            txtHarga.Text = "0.00"
        End If
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
        e.Graphics.DrawString("Nota Pembelian", fontTitle, brush, startX, startY)
        offsetY += lineHeight * 2

        ' Draw column headers
        e.Graphics.DrawString("Nama Barang", fontRegular, brush, startX, startY + offsetY)
        e.Graphics.DrawString("Harga", fontRegular, brush, startX + 200, startY + offsetY)
        e.Graphics.DrawString("Jumlah", fontRegular, brush, startX + 300, startY + offsetY)
        e.Graphics.DrawString("Total", fontRegular, brush, startX + 400, startY + offsetY)
        offsetY += lineHeight

        ' Draw a line below headers
        e.Graphics.DrawLine(Pens.Black, startX, startY + offsetY, startX + 500, startY + offsetY)
        offsetY += lineHeight / 2

        ' Iterate through DataGridView rows to print each item
        For Each row As DataGridViewRow In DataGridViewKeranjang.Rows
            If Not row.IsNewRow Then
                Dim Jenis As String = row.Cells("Jenis").Value.ToString()
                Dim HargaSatuan As String = row.Cells("HargaSatuan").Value.ToString()
                Dim jumlah As String = row.Cells("Jumlah").Value.ToString()
                Dim total As String = row.Cells("Total").Value.ToString()

                e.Graphics.DrawString(Jenis, fontRegular, brush, startX, startY + offsetY)
                e.Graphics.DrawString(HargaSatuan, fontRegular, brush, startX + 200, startY + offsetY)
                e.Graphics.DrawString(jumlah, fontRegular, brush, startX + 300, startY + offsetY)
                e.Graphics.DrawString(total, fontRegular, brush, startX + 400, startY + offsetY)
                offsetY += lineHeight
            End If
        Next

        ' Optionally, draw a total amount at the end
        offsetY += lineHeight
        e.Graphics.DrawString("Total Pembelian: " & CalculateTotal(), fontRegular, brush, startX, startY + offsetY)
    End Sub


    Private Function CalculateTotal() As String
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In DataGridViewKeranjang.Rows
            If Not row.IsNewRow Then
                total += Convert.ToDecimal(row.Cells("Total").Value)
            End If
        Next
        Return total.ToString("C")
    End Function

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs)
        ' Set document and show print preview dialog
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btnMeja2_Click(sender As Object, e As EventArgs) Handles btnMeja2.Click
        FormKursi2.show()
    End Sub

    Private Sub btnLemari2_Click(sender As Object, e As EventArgs) Handles btnLemari2.Click
        FormLemari3.show()
    End Sub

    Private Sub txtHarga_TextChanged(sender As Object, e As EventArgs) Handles txtHarga.TextChanged

    End Sub

    Private Sub btnCheckout_Click_1(sender As Object, e As EventArgs) Handles btnCheckout.Click
        ' Set document and show print preview dialog
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub
End Class
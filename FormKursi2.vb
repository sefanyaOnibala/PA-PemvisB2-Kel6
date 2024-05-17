Imports System.Drawing.Printing

Public Class FormKursi2
    Private Sub FormKursi2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inisialisasi nilai Harga Satuan (misal)
        txtHargaSatuan.Text = "200000"
        ' Menetapkan txtHarga sebagai read-only
        txtHarga.ReadOnly = True
        txtHargaSatuan.ReadOnly = True
    End Sub

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


    Private Sub btnBeli_Click(sender As Object, e As EventArgs) Handles btnBeli.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
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
        e.Graphics.DrawString("===== NOTA PEMBELIAN =====", fontTitle, brush, startX, startY)
        offsetY += lineHeight * 2

        ' Draw data
        e.Graphics.DrawString("Jenis Furniture: " & txtJenis.Text, fontRegular, brush, startX, startY + offsetY)
        offsetY += lineHeight
        e.Graphics.DrawString("Material: " & txtMaterial.Text, fontRegular, brush, startX, startY + offsetY)
        offsetY += lineHeight
        e.Graphics.DrawString("Harga Satuan: " & txtHargaSatuan.Text, fontRegular, brush, startX, startY + offsetY)
        offsetY += lineHeight
        e.Graphics.DrawString("Jumlah: " & NumericUpDown1.Value.ToString(), fontRegular, brush, startX, startY + offsetY)
        offsetY += lineHeight
        e.Graphics.DrawString("Total Harga: " & txtHarga.Text, fontRegular, brush, startX, startY + offsetY)
        offsetY += lineHeight

        ' Draw a line below data
        offsetY += lineHeight / 2
        e.Graphics.DrawLine(Pens.Black, startX, startY + offsetY, startX + 500, startY + offsetY)
        offsetY += lineHeight / 2

        ' Optionally, draw a thank you message at the end
        e.Graphics.DrawString("Terima kasih telah berbelanja!", fontRegular, brush, startX, startY + offsetY)
    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

End Class

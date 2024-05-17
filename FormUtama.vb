Public Class formUtama
    ' Variabel untuk melacak panel yang terlihat saat ini
    Private currentPanelIndex As Integer = 1
    ' Form Load Event untuk menginisialisasi visibilitas panel
    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Menyembunyikan semua panel kecuali PanelGambar1 pada saat startup
        PanelGambar1.Visible = True
        PanelGambar2.Visible = False
        PanelGambar3.Visible = False
        PanelAbout.Visible = False
        PanelGambarProduct.Visible = False
    End Sub

    ' Event handler untuk Button1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Toggle visibilitas panel berdasarkan indeks saat ini
        Select Case currentPanelIndex
            Case 1
                PanelGambar1.Visible = False
                PanelGambar2.Visible = True
                PanelGambar3.Visible = False
                currentPanelIndex = 2
            Case 2
                PanelGambar1.Visible = False
                PanelGambar2.Visible = False
                PanelGambar3.Visible = True
                currentPanelIndex = 3
            Case 3
                PanelGambar1.Visible = True
                PanelGambar2.Visible = False
                PanelGambar3.Visible = False
                currentPanelIndex = 1
        End Select
    End Sub

    ' Event handler untuk Button2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Toggle visibilitas panel berdasarkan indeks saat ini
        Select Case currentPanelIndex
            Case 1
                PanelGambar1.Visible = False
                PanelGambar2.Visible = True
                PanelGambar3.Visible = False
                currentPanelIndex = 2
            Case 2
                PanelGambar1.Visible = False
                PanelGambar2.Visible = False
                PanelGambar3.Visible = True
                currentPanelIndex = 3
            Case 3
                PanelGambar1.Visible = True
                PanelGambar2.Visible = False
                PanelGambar3.Visible = False
                currentPanelIndex = 1
        End Select
    End Sub

    Private Sub AboutAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutAsToolStripMenuItem.Click
        ' Hanya tampilkan PanelAbout dan sembunyikan semua panel lainnya
        PanelGambar1.Visible = False
        PanelGambar2.Visible = False
        PanelGambar3.Visible = False
        PanelAbout.Visible = True
        PanelGambarProduct.Visible = False
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        PanelGambar1.Visible = True
        PanelGambar2.Visible = False
        PanelGambar3.Visible = False
        PanelAbout.Visible = False
        PanelGambarProduct.Visible = False
    End Sub

    Private Sub LogInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogInToolStripMenuItem.Click
        FormLogin.Show()
        Me.Hide()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        FormCustomer.Show()
    End Sub

    Private Sub ProdukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdukToolStripMenuItem.Click
        PanelGambar1.Visible = False
        PanelGambar2.Visible = False
        PanelGambar3.Visible = False
        PanelAbout.Visible = False
        PanelGambarProduct.Visible = True
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs)

    End Sub
End Class
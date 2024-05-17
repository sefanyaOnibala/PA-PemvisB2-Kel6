<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLemari2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLemari2))
        Me.PanelLemari = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMaterial = New System.Windows.Forms.TextBox()
        Me.txtJenis = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtHargaSatuan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnBeli = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelLemari.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelLemari
        '
        Me.PanelLemari.Controls.Add(Me.GroupBox1)
        Me.PanelLemari.Controls.Add(Me.Label5)
        Me.PanelLemari.Controls.Add(Me.Label4)
        Me.PanelLemari.Controls.Add(Me.Label1)
        Me.PanelLemari.Controls.Add(Me.Label3)
        Me.PanelLemari.Controls.Add(Me.Label9)
        Me.PanelLemari.Controls.Add(Me.btnBeli)
        Me.PanelLemari.Controls.Add(Me.PictureBox1)
        Me.PanelLemari.Location = New System.Drawing.Point(29, 12)
        Me.PanelLemari.Name = "PanelLemari"
        Me.PanelLemari.Size = New System.Drawing.Size(829, 622)
        Me.PanelLemari.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMaterial)
        Me.GroupBox1.Controls.Add(Me.txtJenis)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.txtHarga)
        Me.GroupBox1.Controls.Add(Me.txtHargaSatuan)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(38, 334)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(455, 252)
        Me.GroupBox1.TabIndex = 107
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
        Me.txtMaterial.Text = "Kayu Jati"
        '
        'txtJenis
        '
        Me.txtJenis.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJenis.Location = New System.Drawing.Point(171, 40)
        Me.txtJenis.Name = "txtJenis"
        Me.txtJenis.ReadOnly = True
        Me.txtJenis.Size = New System.Drawing.Size(249, 30)
        Me.txtJenis.TabIndex = 29
        Me.txtJenis.Text = "Lemari Pakaian"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(171, 163)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(249, 30)
        Me.NumericUpDown1.TabIndex = 14
        '
        'txtHarga
        '
        Me.txtHarga.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHarga.Location = New System.Drawing.Point(171, 204)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.ReadOnly = True
        Me.txtHarga.Size = New System.Drawing.Size(249, 30)
        Me.txtHarga.TabIndex = 26
        '
        'txtHargaSatuan
        '
        Me.txtHargaSatuan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHargaSatuan.Location = New System.Drawing.Point(171, 122)
        Me.txtHargaSatuan.Name = "txtHargaSatuan"
        Me.txtHargaSatuan.ReadOnly = True
        Me.txtHargaSatuan.Size = New System.Drawing.Size(249, 30)
        Me.txtHargaSatuan.TabIndex = 25
        Me.txtHargaSatuan.Text = "2000000"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 22)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Total Harga"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 22)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Jumlah"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 22)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Harga Satuan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(26, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 22)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Material"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(26, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 22)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Jenis Furniture"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(453, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 22)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Material"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(453, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(314, 42)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Panjang: 130 cm                                 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tinggi: 45 cm                  " &
    "                "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(427, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 53)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Lemari Pakaian"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(534, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 22)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Jati"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(432, 101)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(365, 40)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "Agar menemukan kenyamanan saat duduk, kita " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "memerlukan kursi yang empuk serta ko" &
    "koh, kursi"
        '
        'btnBeli
        '
        Me.btnBeli.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnBeli.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBeli.ForeColor = System.Drawing.Color.Firebrick
        Me.btnBeli.Location = New System.Drawing.Point(519, 542)
        Me.btnBeli.Name = "btnBeli"
        Me.btnBeli.Size = New System.Drawing.Size(148, 44)
        Me.btnBeli.TabIndex = 2
        Me.btnBeli.Text = "Buy"
        Me.btnBeli.UseVisualStyleBackColor = False
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AlisaPemvis.My.Resources.Resources.download__31_
        Me.PictureBox1.Location = New System.Drawing.Point(38, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(293, 273)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FormLemari2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 659)
        Me.Controls.Add(Me.PanelLemari)
        Me.Name = "FormLemari2"
        Me.Text = "FormLemari2"
        Me.PanelLemari.ResumeLayout(False)
        Me.PanelLemari.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLemari As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtMaterial As TextBox
    Friend WithEvents txtJenis As TextBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtHargaSatuan As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnBeli As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class

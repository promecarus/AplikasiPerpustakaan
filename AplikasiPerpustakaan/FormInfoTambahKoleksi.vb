Public Class FormInfoTambahKoleksi
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not String.IsNullOrEmpty(FormPerpustakaan.dataKoleksi.GSDirGambarBuku) Then
            PictureBoxInfoGambarKoleksi.Load(FormPerpustakaan.dataKoleksi.GSDirGambarBuku)
            PictureBoxInfoGambarKoleksi.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        LabelInfoNamaKoleksi.Text = FormPerpustakaan.dataKoleksi.GSNamaKoleksi
        LabelInfoJenisKoleksi.Text = FormPerpustakaan.dataKoleksi.GSJenisKoleksi
        LabelInfoDeskripsi.Text = FormPerpustakaan.dataKoleksi.GSDeskripsiKoleksi
        LabelInfoPenerbit.Text = FormPerpustakaan.dataKoleksi.GSPenerbit

        If FormPerpustakaan.dataKoleksi.GSTahunTerbit.ToString IsNot "0" Then
            LabelInfoTahunTerbit.Text = FormPerpustakaan.dataKoleksi.GSTahunTerbit
        Else
            LabelInfoTahunTerbit.Text = "Tahun terbit belum diset"
        End If

        LabelInfoLokasiRak.Text = FormPerpustakaan.dataKoleksi.GSLokasi
        LabelInfoTanggalMasukKoleksi.Text = FormPerpustakaan.dataKoleksi.GSTanggalMasukKoleksi

        If FormPerpustakaan.dataKoleksi.GSStock.ToString IsNot "0" Then
            LabelInfoStok.Text = FormPerpustakaan.dataKoleksi.GSStock
        Else
            LabelInfoStok.Text = "Stok belum diset"
        End If


        LabelInfoBahasa.Text = FormPerpustakaan.dataKoleksi.GSBahasa

        ListBoxInfoKategori.Items.Clear()

        For Each kategori In FormPerpustakaan.dataKoleksi.GSKategori
            ListBoxInfoKategori.Items.Add(kategori)
        Next

        FormPerpustakaan.dataKoleksi.GSKategori.Clear()
    End Sub

    Private Sub ButtonTambahKoleksi_Click(sender As Object, e As EventArgs) Handles ButtonTambahKoleksi.Click
        FormPerpustakaan.ListBoxKoleksi.Items.Add(LabelInfoNamaKoleksi.Text)
        FormPerpustakaan.Show()
        Me.Close()
    End Sub
End Class
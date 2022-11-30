﻿Public Class FormUpdateKoleksi
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PictureBoxGambarKoleksi.Load(FormPerpustakaan.dataKoleksi.GSDirGambarBuku)
        PictureBoxGambarKoleksi.SizeMode = PictureBoxSizeMode.StretchImage
        DateTimePickerInputTanggalMasukKoleksi.Format = DateTimePickerFormat.Custom
        DateTimePickerInputTanggalMasukKoleksi.CustomFormat = "yyyy/MM/dd"
        TextBoxInputNamaKoleksi.Text = FormPerpustakaan.dataKoleksi.GSNamaKoleksi
        ComboBoxInputJenisKoleksi.SelectedItem() = FormPerpustakaan.dataKoleksi.GSJenisKoleksi
        RichTextBoxInputDeskripsi.Text = FormPerpustakaan.dataKoleksi.GSDeskripsiKoleksi
        TextBoxInputPenerbit.Text = FormPerpustakaan.dataKoleksi.GSPenerbit
        TextBoxInputTahunTerbit.Text = FormPerpustakaan.dataKoleksi.GSTahunTerbit
        TextBoxInputLokasiRak.Text = FormPerpustakaan.dataKoleksi.GSLokasi
        DateTimePickerInputTanggalMasukKoleksi.Value = FormPerpustakaan.dataKoleksi.GSTanggalMasukKoleksi
        TextBoxInputStock.Text = FormPerpustakaan.dataKoleksi.GSStock

        If String.Compare(FormPerpustakaan.dataKoleksi.GSBahasa, "Indonesia") = 0 Then
            RadioButtonBahasaIndonesia.Checked = True
        ElseIf String.Compare(FormPerpustakaan.dataKoleksi.GSBahasa, "Inggris") = 0 Then
            RadioButtonBahasaInggris.Checked = True
        End If

        For Each kategoriItem In FormPerpustakaan.dataKoleksi.getKategoriItem
            If String.Compare(kategoriItem, "Sains") = 0 Then
                CheckBoxSains.Checked = True
            ElseIf String.Compare(kategoriItem, "Sosial") = 0 Then
                CheckBoxSosial.Checked = True
            ElseIf String.Compare(kategoriItem, "Teknologi") = 0 Then
                CheckBoxTeknologi.Checked = True
            ElseIf String.Compare(kategoriItem, "Budaya") = 0 Then
                CheckBoxBudaya.Checked = True
            End If
        Next

        FormPerpustakaan.dataKoleksi.ResetKategori()
    End Sub

    Private Sub ButtonUpdateGambar_Click(sender As Object, e As EventArgs) Handles ButtonUpdateGambar.Click
        OpenFileDialogGambarKoleksi.Title = "Open Gambar Koleksi"
        OpenFileDialogGambarKoleksi.Filter = "All Format|*.*|Image|*bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif"
        OpenFileDialogGambarKoleksi.ShowDialog()


        If OpenFileDialogGambarKoleksi.FileName.ToString IsNot "OpenFileDialog1" Then
            Dim picKoleksiDir As String = OpenFileDialogGambarKoleksi.FileName
            PictureBoxGambarKoleksi.Load(picKoleksiDir)
            PictureBoxGambarKoleksi.SizeMode = PictureBoxSizeMode.StretchImage

            FormPerpustakaan.dataKoleksi.GSDirGambarBuku = picKoleksiDir.ToString()
            FormPerpustakaan.dataKoleksi.GSDirGambarBuku = FormPerpustakaan.dataKoleksi.GSDirGambarBuku.Replace("\", "/")
        End If
    End Sub
    Private Sub FormUpdateKoleksi_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormPerpustakaan.Show()
    End Sub
End Class
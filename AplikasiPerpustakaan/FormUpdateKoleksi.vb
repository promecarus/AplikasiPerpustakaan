Public Class FormUpdateKoleksi
    Dim jenisKoleksi As New List(Of String) From {"Buku", "Ensiklopedia", "Koran", "Majalah", "Publikasi", "Penelitian"}

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ComboBoxInputJenisKoleksi.DataSource = jenisKoleksi

        If Not String.IsNullOrEmpty(FormPerpustakaan.dataKoleksi.GSDirGambarBuku) Then
            PictureBoxGambarKoleksi.Load(FormPerpustakaan.dataKoleksi.GSDirGambarBuku)
        End If

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

        If String.Compare(FormPerpustakaan.dataKoleksi.GSBahasa, "Bahasa Indonesia") = 0 Then
            RadioButtonBahasaIndonesia.Checked = True
        ElseIf String.Compare(FormPerpustakaan.dataKoleksi.GSBahasa, "Bahasa Inggris") = 0 Then
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

    Private Sub ButtonUpdateKoleksi_Click(sender As Object, e As EventArgs) Handles ButtonUpdateKoleksi.Click
        FormPerpustakaan.dataKoleksi.GSNamaKoleksi = TextBoxInputNamaKoleksi.Text.ToString()
        FormPerpustakaan.dataKoleksi.GSJenisKoleksi = ComboBoxInputJenisKoleksi.SelectedItem().ToString()
        FormPerpustakaan.dataKoleksi.GSDeskripsiKoleksi = RichTextBoxInputDeskripsi.Text.ToString()
        FormPerpustakaan.dataKoleksi.GSPenerbit = TextBoxInputPenerbit.Text.ToString()
        FormPerpustakaan.dataKoleksi.GSTahunTerbit = Integer.Parse(TextBoxInputTahunTerbit.Text)


        FormPerpustakaan.dataKoleksi.GSLokasi = TextBoxInputLokasiRak.Text.ToString()
        FormPerpustakaan.dataKoleksi.GSTanggalMasukKoleksi = DateTimePickerInputTanggalMasukKoleksi.Value.ToString("yyyy/MM/dd")
        FormPerpustakaan.dataKoleksi.GSStock = Integer.Parse(TextBoxInputStock.Text)

        If RadioButtonBahasaIndonesia.Checked Then
            FormPerpustakaan.dataKoleksi.GSBahasa = "Bahasa Indonesia"
        ElseIf RadioButtonBahasaInggris.Checked Then
            FormPerpustakaan.dataKoleksi.GSBahasa = "Bahasa Inggris"
        End If

        If CheckBoxSains.Checked Then
            FormPerpustakaan.dataKoleksi.AddKategori("Sains")
        End If

        If CheckBoxSosial.Checked Then
            FormPerpustakaan.dataKoleksi.AddKategori("Sosial")
        End If

        If CheckBoxTeknologi.Checked Then
            FormPerpustakaan.dataKoleksi.AddKategori("Teknologi")
        End If

        If CheckBoxBudaya.Checked Then
            FormPerpustakaan.dataKoleksi.AddKategori("Budaya")
        End If

        'sus 63
        FormPerpustakaan.dataKoleksi.AddKoleksi(TextBoxInputNamaKoleksi.Text.ToString())

        Dim convertedKoleksi = FormPerpustakaan.dataKoleksi.ConvertKoleksiToString(FormPerpustakaan.dataKoleksi.getKategoriItem)

        FormPerpustakaan.dataKoleksi.UpdateDataKoleksiByIDDatabase(FormPerpustakaan.selectedTableKoleksi,
                                                                    FormPerpustakaan.dataKoleksi.GSDirGambarBuku,
                                                                    FormPerpustakaan.dataKoleksi.GSNamaKoleksi,
                                                                    FormPerpustakaan.dataKoleksi.GSJenisKoleksi,
                                                                    FormPerpustakaan.dataKoleksi.GSPenerbit,
                                                                    FormPerpustakaan.dataKoleksi.GSDeskripsiKoleksi,
                                                                    FormPerpustakaan.dataKoleksi.GSTahunTerbit,
                                                                    FormPerpustakaan.dataKoleksi.GSLokasi,
                                                                    FormPerpustakaan.dataKoleksi.GSTanggalMasukKoleksi,
                                                                    FormPerpustakaan.dataKoleksi.GSStock,
                                                                    FormPerpustakaan.dataKoleksi.GSBahasa,
                                                                    convertedKoleksi)
        FormPerpustakaan.Show()
        Me.Close()
    End Sub

    Private Sub FormUpdateKoleksi_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormPerpustakaan.Show()
    End Sub
End Class
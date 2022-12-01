Public Class FormTambahKoleksi

    Dim jenisKoleksi As New List(Of String) From {"Buku", "Ensiklopedia", "Koran", "Majalah", "Publikasi", "Penelitian"}
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ComboBoxInputJenisKoleksi.DataSource = jenisKoleksi

        DateTimePickerInputTanggalMasukKoleksi.Format = DateTimePickerFormat.Custom
        DateTimePickerInputTanggalMasukKoleksi.CustomFormat = "yyyy/MM/dd"
    End Sub

    Private Sub ButtonTambahGambar_Click(sender As Object, e As EventArgs) Handles ButtonTambahGambar.Click
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

    Private Sub ButtonTambahKoleksi_Click(sender As Object, e As EventArgs) Handles ButtonTambahKoleksi.Click
        FormPerpustakaan.dataKoleksi.GSNamaKoleksi = TextBoxInputNamaKoleksi.Text
        FormPerpustakaan.dataKoleksi.GSJenisKoleksi = ComboBoxInputJenisKoleksi.SelectedItem
        FormPerpustakaan.dataKoleksi.GSDeskripsiKoleksi = RichTextBoxInputDeskripsi.Text
        FormPerpustakaan.dataKoleksi.GSPenerbit = TextBoxInputPenerbit.Text

        If TextBoxInputTahunTerbit.Text.Length > 0 And IsNumeric(TextBoxInputTahunTerbit.Text) Then
            FormPerpustakaan.dataKoleksi.GSTahunTerbit = Integer.Parse(TextBoxInputTahunTerbit.Text)
        End If

        FormPerpustakaan.dataKoleksi.GSLokasi = TextBoxInputLokasiRak.Text
        FormPerpustakaan.dataKoleksi.GSTanggalMasukKoleksi = DateTimePickerInputTanggalMasukKoleksi.Value.ToShortDateString

        If TextBoxInputTahunTerbit.Text.Length > 0 And IsNumeric(TextBoxInputTahunTerbit.Text) Then
            FormPerpustakaan.dataKoleksi.GSStock = Integer.Parse(TextBoxInputStock.Text)
        End If

        If RadioButtonBahasaIndonesia.Checked Then
            FormPerpustakaan.dataKoleksi.GSBahasa = RadioButtonBahasaIndonesia.Text
        End If
        If RadioButtonBahasaInggris.Checked Then
            FormPerpustakaan.dataKoleksi.GSBahasa = RadioButtonBahasaInggris.Text
        End If

        If CheckBoxSains.Checked() Then
            FormPerpustakaan.dataKoleksi.getKategoriItem.Add(CheckBoxSains.Text)
        End If
        If CheckBoxSosial.Checked() Then
            FormPerpustakaan.dataKoleksi.getKategoriItem.Add(CheckBoxSosial.Text)
        End If
        If CheckBoxTeknologi.Checked() Then
            FormPerpustakaan.dataKoleksi.getKategoriItem.Add(CheckBoxTeknologi.Text)
        End If
        If CheckBoxBudaya.Checked() Then
            FormPerpustakaan.dataKoleksi.getKategoriItem.Add(CheckBoxBudaya.Text)
        End If

        If String.IsNullOrEmpty(FormPerpustakaan.dataKoleksi.GSNamaKoleksi) Then
            FormPerpustakaan.listDataKoleksi.Add(FormPerpustakaan.dataKoleksi.GSNamaKoleksi)
        End If

        FormPerpustakaan.ListBoxKoleksi.Items.Add(TextBoxInputNamaKoleksi.Text)

        'FormPerpustakaan.listDataKoleksi.Add(New KoleksiData(FormPerpustakaan.dataKoleksi.GSNamaKoleksi))
        Dim convertedKoleksi = FormPerpustakaan.dataKoleksi.ConvertKoleksiToString(FormPerpustakaan.dataKoleksi.getKategoriItem)
        'FormPerpustakaan.dataKoleksi.AddKoleksiDataTable(FormPerpustakaan.dataKoleksi.GSDirGambarBuku,
        '                                                 FormPerpustakaan.dataKoleksi.GSNamaKoleksi,
        '                                                 FormPerpustakaan.dataKoleksi.GSJenisKoleksi,
        '                                                 FormPerpustakaan.dataKoleksi.GSPenerbit,
        '                                                 FormPerpustakaan.dataKoleksi.GSDeskripsiKoleksi,
        '                                                 FormPerpustakaan.dataKoleksi.GSTahunTerbit,
        '                                                 FormPerpustakaan.dataKoleksi.GSLokasi,
        '                                                 FormPerpustakaan.dataKoleksi.GSTanggalMasukKoleksi,
        '                                                 FormPerpustakaan.dataKoleksi.GSStock,
        '                                                 FormPerpustakaan.dataKoleksi.GSBahasa,
        '                                                 convertedKoleksi)

        FormPerpustakaan.dataKoleksi.AddDataKoleksiDatabase(FormPerpustakaan.dataKoleksi.GSDirGambarBuku,
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

        Dim formInfoTambahKoleksi = New FormInfoTambahKoleksi()
        Me.Close()
        formInfoTambahKoleksi.Show()
    End Sub

    Private Sub FormTambahKoleksi_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormPerpustakaan.Show()
    End Sub
End Class
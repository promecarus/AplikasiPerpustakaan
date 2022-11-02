Public Class FormTambahKoleksi

    Dim jenisKoleksi As New List(Of String) From {"Buku", "Ensiklopedia", "Koran", "Majalah", "Publikasi", "Penelitian"}

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ComboBoxInputJenisKoleksi.DataSource = jenisKoleksi
    End Sub

    Private Sub ButtonTambahGambar_Click(sender As Object, e As EventArgs) Handles ButtonTambahGambar.Click
        OpenFileDialogGambarKoleksi.Title = "Open Gambar Koleksi"
        OpenFileDialogGambarKoleksi.Filter = "All Format|*.*|Image|*bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif"
        OpenFileDialogGambarKoleksi.ShowDialog()

        If OpenFileDialogGambarKoleksi.FileName.ToString IsNot "OpenFileDialog1" Then
            PictureBoxGambarKoleksi.Load(OpenFileDialogGambarKoleksi.FileName)
            PictureBoxGambarKoleksi.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub ButtonTambahKoleksi_Click(sender As Object, e As EventArgs) Handles ButtonTambahKoleksi.Click
        If OpenFileDialogGambarKoleksi.FileName.ToString IsNot "OpenFileDialog1" Then
            FormPerpustakaan.dataKoleksi.GSGambarKoleksi = OpenFileDialogGambarKoleksi.FileName
        End If

        FormPerpustakaan.dataKoleksi.GSNamaKoleksi = TextBoxInputNamaKoleksi.Text
        FormPerpustakaan.dataKoleksi.GSJenisKoleksi = ComboBoxInputJenisKoleksi.SelectedItem
        FormPerpustakaan.dataKoleksi.GSDeskripsi = RichTextBoxInputDeskripsi.Text
        FormPerpustakaan.dataKoleksi.GSPenerbit = TextBoxInputPenerbit.Text

        If TextBoxInputTahunTerbit.Text.Length > 0 And IsNumeric(TextBoxInputTahunTerbit.Text) Then
            FormPerpustakaan.dataKoleksi.GSTahunTerbit = Integer.Parse(TextBoxInputTahunTerbit.Text)
        End If

        FormPerpustakaan.dataKoleksi.GSLokasiRak = TextBoxInputLokasiRak.Text
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
            FormPerpustakaan.dataKoleksi.GSKategoriList.Add(CheckBoxSains.Text)
        End If
        If CheckBoxSosial.Checked() Then
            FormPerpustakaan.dataKoleksi.GSKategoriList.Add(CheckBoxSosial.Text)
        End If
        If CheckBoxTeknologi.Checked() Then
            FormPerpustakaan.dataKoleksi.GSKategoriList.Add(CheckBoxTeknologi.Text)
        End If
        If CheckBoxBudaya.Checked() Then
            FormPerpustakaan.dataKoleksi.GSKategoriList.Add(CheckBoxBudaya.Text)
        End If

        If String.IsNullOrEmpty(FormPerpustakaan.dataKoleksi.GSNamaKoleksi) Then
            FormPerpustakaan.listDataKoleksi.Add(FormPerpustakaan.dataKoleksi.GSNamaKoleksi)
        End If

        'FormPerpustakaan.listDataKoleksi.Add(New KoleksiData(FormPerpustakaan.dataKoleksi.GSNamaKoleksi))

        Dim formInfoTambahKoleksi = New FormInfoTambahKoleksi()
        Me.Hide()
        formInfoTambahKoleksi.Show()
    End Sub

End Class
Public Class FormPerpustakaan
    Public Shared dataKoleksi As ClassKoleksi
    Public Shared listDataKoleksi As List(Of String)
    Dim selectedTableKoleksi

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dataKoleksi = New ClassKoleksi
        UpdateTableDataArrayList()
    End Sub

    Public Sub tambahKoleksi(nama As String)
        ListBoxKoleksi.Items.Add(nama)
    End Sub

    Private Sub TambahKoleksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKoleksiToolStripMenuItem.Click
        FormTambahKoleksi.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripButtonPlus_Click(sender As Object, e As EventArgs) Handles ToolStripButtonPlus.Click
        FormTambahKoleksi.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripButtonMinus_Click(sender As Object, e As EventArgs) Handles ToolStripButtonMinus.Click
        If String.IsNullOrEmpty(ListBoxKoleksi.SelectedItem) Then
            MessageBox.Show("Pilih koleksi yang ingin dihapus")
        Else
            FormHapusKoleksi.LabelKoleksi.Text = ListBoxKoleksi.SelectedItem.ToString
            Me.Hide()
            FormHapusKoleksi.Show()
        End If
    End Sub

    Friend Function BlankImage() As Image
        Dim oBM As New Bitmap(1, 1)
        oBM.SetPixel(0, 0, Color.Transparent)
        Return oBM
    End Function

    Public Sub UpdateTableDataArrayList()
        DataGridViewKoleksi.Rows.Clear()
        For Each rowKoleksi In dataKoleksi.getKoleksiDataTable()
            Dim dataTable = {
                If(rowKoleksi(0) IsNot Nothing, Image.FromFile(rowKoleksi(0)), BlankImage()),
                rowKoleksi(1),
                rowKoleksi(2),
                rowKoleksi(3),
                rowKoleksi(4),
                rowKoleksi(5),
                rowKoleksi(6),
                rowKoleksi(7),
                rowKoleksi(8),
                rowKoleksi(9),
                rowKoleksi(10)
            }
            DataGridViewKoleksi.Rows.Add(dataTable)
        Next
    End Sub

    Private Sub FormPerpustakaan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        UpdateTableDataArrayList()
    End Sub

    Private Sub DataGridViewKoleksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewKoleksi.CellClick
        selectedTableKoleksi = DataGridViewKoleksi.CurrentRow.Index
    End Sub

    Private Sub ButtonShow_Click(sender As Object, e As EventArgs) Handles ButtonShow.Click
        Dim dataSelected = dataKoleksi.getKoleksiDataTable.Item(selectedTableKoleksi)

        dataKoleksi.GSDirGambarBuku = dataSelected(0)
        dataKoleksi.GSNamaKoleksi = dataSelected(1)
        dataKoleksi.GSJenisKoleksi = dataSelected(2)
        dataKoleksi.GSPenerbit = dataSelected(3)
        dataKoleksi.GSDeskripsiKoleksi = dataSelected(4)
        dataKoleksi.GSTahunTerbit = dataSelected(5)
        dataKoleksi.GSLokasi = dataSelected(6)
        dataKoleksi.GSTanggalMasukKoleksi = dataSelected(7)
        dataKoleksi.GSStock = dataSelected(8)
        dataKoleksi.GSBahasa = dataSelected(9)
        Dim data_koleksi As List(Of String) = dataKoleksi.ConvertStringToKoleksi(dataSelected(10))

        For Each info_tambah In data_koleksi
            dataKoleksi.AddKategori(info_tambah)
        Next

        Dim infoTambah = New FormInfoTambahKoleksi()
        infoTambah.Show()
    End Sub

    Private Sub FormPerpustakaan_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormLogin.Show()
    End Sub
End Class

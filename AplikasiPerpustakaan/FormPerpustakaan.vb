Public Class FormPerpustakaan
    Public Shared dataKoleksi As ClassKoleksi
    Public Shared listDataKoleksi As List(Of String)

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dataKoleksi = New ClassKoleksi
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
End Class

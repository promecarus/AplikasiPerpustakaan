Public Class FormHapusKoleksi
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LabelKoleksi.Text = FormPerpustakaan.selectedTableKoleksiNama
    End Sub
    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        'MessageBox.Show(LabelKoleksi.Text.ToString)
        'FormPerpustakaan.ListBoxKoleksi.Items.Remove(LabelKoleksi.Text.ToString)
        FormPerpustakaan.dataKoleksi.DeleteDataKoleksiByIDDatabase(FormPerpustakaan.selectedTableKoleksi)
        FormPerpustakaan.Show()
        Me.Close()
    End Sub

    Private Sub FormHapusKoleksi_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormPerpustakaan.Show()
    End Sub
End Class
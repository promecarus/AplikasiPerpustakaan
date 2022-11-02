<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInfoTambahKoleksi
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
        Me.LabelKategori = New System.Windows.Forms.Label()
        Me.LabelBahasa = New System.Windows.Forms.Label()
        Me.PictureBoxInfoGambarKoleksi = New System.Windows.Forms.PictureBox()
        Me.ButtonTambahKoleksi = New System.Windows.Forms.Button()
        Me.LabelStock = New System.Windows.Forms.Label()
        Me.OpenFileDialogGambarKoleksi = New System.Windows.Forms.OpenFileDialog()
        Me.LabelTanggalMasukKoleksi = New System.Windows.Forms.Label()
        Me.LabelLokasiRak = New System.Windows.Forms.Label()
        Me.LabelTahunTerbit = New System.Windows.Forms.Label()
        Me.LabelPenerbit = New System.Windows.Forms.Label()
        Me.LabelDeskripsi = New System.Windows.Forms.Label()
        Me.LabelJenisKoleksi = New System.Windows.Forms.Label()
        Me.LabelNamaKoleksi = New System.Windows.Forms.Label()
        Me.LabelInfoTambahKoleksi = New System.Windows.Forms.Label()
        Me.LabelInfoNamaKoleksi = New System.Windows.Forms.Label()
        Me.LabelInfoJenisKoleksi = New System.Windows.Forms.Label()
        Me.LabelInfoDeskripsi = New System.Windows.Forms.Label()
        Me.LabelInfoPenerbit = New System.Windows.Forms.Label()
        Me.LabelInfoTahunTerbit = New System.Windows.Forms.Label()
        Me.LabelInfoLokasiRak = New System.Windows.Forms.Label()
        Me.LabelInfoTanggalMasukKoleksi = New System.Windows.Forms.Label()
        Me.LabelInfoStok = New System.Windows.Forms.Label()
        Me.LabelInfoBahasa = New System.Windows.Forms.Label()
        Me.ListBoxInfoKategori = New System.Windows.Forms.ListBox()
        CType(Me.PictureBoxInfoGambarKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelKategori
        '
        Me.LabelKategori.AutoSize = True
        Me.LabelKategori.Location = New System.Drawing.Point(200, 510)
        Me.LabelKategori.Name = "LabelKategori"
        Me.LabelKategori.Size = New System.Drawing.Size(66, 20)
        Me.LabelKategori.TabIndex = 30
        Me.LabelKategori.Text = "Kategori"
        '
        'LabelBahasa
        '
        Me.LabelBahasa.AutoSize = True
        Me.LabelBahasa.Location = New System.Drawing.Point(200, 470)
        Me.LabelBahasa.Name = "LabelBahasa"
        Me.LabelBahasa.Size = New System.Drawing.Size(56, 20)
        Me.LabelBahasa.TabIndex = 29
        Me.LabelBahasa.Text = "Bahasa"
        '
        'PictureBoxInfoGambarKoleksi
        '
        Me.PictureBoxInfoGambarKoleksi.Location = New System.Drawing.Point(20, 50)
        Me.PictureBoxInfoGambarKoleksi.Name = "PictureBoxInfoGambarKoleksi"
        Me.PictureBoxInfoGambarKoleksi.Size = New System.Drawing.Size(160, 200)
        Me.PictureBoxInfoGambarKoleksi.TabIndex = 43
        Me.PictureBoxInfoGambarKoleksi.TabStop = False
        '
        'ButtonTambahKoleksi
        '
        Me.ButtonTambahKoleksi.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonTambahKoleksi.Location = New System.Drawing.Point(0, 808)
        Me.ButtonTambahKoleksi.Name = "ButtonTambahKoleksi"
        Me.ButtonTambahKoleksi.Size = New System.Drawing.Size(620, 29)
        Me.ButtonTambahKoleksi.TabIndex = 41
        Me.ButtonTambahKoleksi.Text = "Tutup"
        Me.ButtonTambahKoleksi.UseVisualStyleBackColor = True
        '
        'LabelStock
        '
        Me.LabelStock.AutoSize = True
        Me.LabelStock.Location = New System.Drawing.Point(200, 430)
        Me.LabelStock.Name = "LabelStock"
        Me.LabelStock.Size = New System.Drawing.Size(45, 20)
        Me.LabelStock.TabIndex = 23
        Me.LabelStock.Text = "Stock"
        '
        'OpenFileDialogGambarKoleksi
        '
        Me.OpenFileDialogGambarKoleksi.FileName = "OpenFileDialog1"
        '
        'LabelTanggalMasukKoleksi
        '
        Me.LabelTanggalMasukKoleksi.AutoSize = True
        Me.LabelTanggalMasukKoleksi.Location = New System.Drawing.Point(200, 390)
        Me.LabelTanggalMasukKoleksi.Name = "LabelTanggalMasukKoleksi"
        Me.LabelTanggalMasukKoleksi.Size = New System.Drawing.Size(158, 20)
        Me.LabelTanggalMasukKoleksi.TabIndex = 22
        Me.LabelTanggalMasukKoleksi.Text = "Tanggal Masuk Koleksi"
        '
        'LabelLokasiRak
        '
        Me.LabelLokasiRak.AutoSize = True
        Me.LabelLokasiRak.Location = New System.Drawing.Point(200, 350)
        Me.LabelLokasiRak.Name = "LabelLokasiRak"
        Me.LabelLokasiRak.Size = New System.Drawing.Size(78, 20)
        Me.LabelLokasiRak.TabIndex = 31
        Me.LabelLokasiRak.Text = "Lokasi Rak"
        '
        'LabelTahunTerbit
        '
        Me.LabelTahunTerbit.AutoSize = True
        Me.LabelTahunTerbit.Location = New System.Drawing.Point(200, 310)
        Me.LabelTahunTerbit.Name = "LabelTahunTerbit"
        Me.LabelTahunTerbit.Size = New System.Drawing.Size(89, 20)
        Me.LabelTahunTerbit.TabIndex = 32
        Me.LabelTahunTerbit.Text = "Tahun Terbit"
        '
        'LabelPenerbit
        '
        Me.LabelPenerbit.AutoSize = True
        Me.LabelPenerbit.Location = New System.Drawing.Point(200, 270)
        Me.LabelPenerbit.Name = "LabelPenerbit"
        Me.LabelPenerbit.Size = New System.Drawing.Size(63, 20)
        Me.LabelPenerbit.TabIndex = 26
        Me.LabelPenerbit.Text = "Penerbit"
        '
        'LabelDeskripsi
        '
        Me.LabelDeskripsi.AutoSize = True
        Me.LabelDeskripsi.Location = New System.Drawing.Point(200, 130)
        Me.LabelDeskripsi.Name = "LabelDeskripsi"
        Me.LabelDeskripsi.Size = New System.Drawing.Size(69, 20)
        Me.LabelDeskripsi.TabIndex = 27
        Me.LabelDeskripsi.Text = "Deskripsi"
        '
        'LabelJenisKoleksi
        '
        Me.LabelJenisKoleksi.AutoSize = True
        Me.LabelJenisKoleksi.Location = New System.Drawing.Point(200, 90)
        Me.LabelJenisKoleksi.Name = "LabelJenisKoleksi"
        Me.LabelJenisKoleksi.Size = New System.Drawing.Size(91, 20)
        Me.LabelJenisKoleksi.TabIndex = 28
        Me.LabelJenisKoleksi.Text = "Jenis Koleksi"
        '
        'LabelNamaKoleksi
        '
        Me.LabelNamaKoleksi.AutoSize = True
        Me.LabelNamaKoleksi.Location = New System.Drawing.Point(200, 50)
        Me.LabelNamaKoleksi.Name = "LabelNamaKoleksi"
        Me.LabelNamaKoleksi.Size = New System.Drawing.Size(100, 20)
        Me.LabelNamaKoleksi.TabIndex = 25
        Me.LabelNamaKoleksi.Text = "Nama Koleksi"
        '
        'LabelInfoTambahKoleksi
        '
        Me.LabelInfoTambahKoleksi.AutoSize = True
        Me.LabelInfoTambahKoleksi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelInfoTambahKoleksi.Location = New System.Drawing.Point(20, 10)
        Me.LabelInfoTambahKoleksi.Name = "LabelInfoTambahKoleksi"
        Me.LabelInfoTambahKoleksi.Size = New System.Drawing.Size(204, 28)
        Me.LabelInfoTambahKoleksi.TabIndex = 20
        Me.LabelInfoTambahKoleksi.Text = "Info Tambah Koleksi"
        '
        'LabelInfoNamaKoleksi
        '
        Me.LabelInfoNamaKoleksi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelInfoNamaKoleksi.Location = New System.Drawing.Point(400, 50)
        Me.LabelInfoNamaKoleksi.Name = "LabelInfoNamaKoleksi"
        Me.LabelInfoNamaKoleksi.Size = New System.Drawing.Size(200, 20)
        Me.LabelInfoNamaKoleksi.TabIndex = 25
        Me.LabelInfoNamaKoleksi.Text = "Info Nama Koleksi"
        '
        'LabelInfoJenisKoleksi
        '
        Me.LabelInfoJenisKoleksi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelInfoJenisKoleksi.Location = New System.Drawing.Point(400, 90)
        Me.LabelInfoJenisKoleksi.Name = "LabelInfoJenisKoleksi"
        Me.LabelInfoJenisKoleksi.Size = New System.Drawing.Size(200, 20)
        Me.LabelInfoJenisKoleksi.TabIndex = 25
        Me.LabelInfoJenisKoleksi.Text = "Info Jenis Koleksi"
        '
        'LabelInfoDeskripsi
        '
        Me.LabelInfoDeskripsi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelInfoDeskripsi.Location = New System.Drawing.Point(400, 130)
        Me.LabelInfoDeskripsi.Name = "LabelInfoDeskripsi"
        Me.LabelInfoDeskripsi.Size = New System.Drawing.Size(200, 120)
        Me.LabelInfoDeskripsi.TabIndex = 25
        Me.LabelInfoDeskripsi.Text = "Info Deskripsi"
        '
        'LabelInfoPenerbit
        '
        Me.LabelInfoPenerbit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelInfoPenerbit.Location = New System.Drawing.Point(400, 270)
        Me.LabelInfoPenerbit.Name = "LabelInfoPenerbit"
        Me.LabelInfoPenerbit.Size = New System.Drawing.Size(200, 20)
        Me.LabelInfoPenerbit.TabIndex = 25
        Me.LabelInfoPenerbit.Text = "Info Penerbit"
        '
        'LabelInfoTahunTerbit
        '
        Me.LabelInfoTahunTerbit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelInfoTahunTerbit.Location = New System.Drawing.Point(400, 310)
        Me.LabelInfoTahunTerbit.Name = "LabelInfoTahunTerbit"
        Me.LabelInfoTahunTerbit.Size = New System.Drawing.Size(200, 20)
        Me.LabelInfoTahunTerbit.TabIndex = 25
        Me.LabelInfoTahunTerbit.Text = "Info Tahun Terbit"
        '
        'LabelInfoLokasiRak
        '
        Me.LabelInfoLokasiRak.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelInfoLokasiRak.Location = New System.Drawing.Point(400, 350)
        Me.LabelInfoLokasiRak.Name = "LabelInfoLokasiRak"
        Me.LabelInfoLokasiRak.Size = New System.Drawing.Size(200, 20)
        Me.LabelInfoLokasiRak.TabIndex = 25
        Me.LabelInfoLokasiRak.Text = "Info Lokasi Rak"
        '
        'LabelInfoTanggalMasukKoleksi
        '
        Me.LabelInfoTanggalMasukKoleksi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelInfoTanggalMasukKoleksi.Location = New System.Drawing.Point(400, 390)
        Me.LabelInfoTanggalMasukKoleksi.Name = "LabelInfoTanggalMasukKoleksi"
        Me.LabelInfoTanggalMasukKoleksi.Size = New System.Drawing.Size(200, 20)
        Me.LabelInfoTanggalMasukKoleksi.TabIndex = 25
        Me.LabelInfoTanggalMasukKoleksi.Text = "Info Tanggal Masuk Koleksi"
        '
        'LabelInfoStok
        '
        Me.LabelInfoStok.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelInfoStok.Location = New System.Drawing.Point(400, 430)
        Me.LabelInfoStok.Name = "LabelInfoStok"
        Me.LabelInfoStok.Size = New System.Drawing.Size(200, 20)
        Me.LabelInfoStok.TabIndex = 25
        Me.LabelInfoStok.Text = "Info Stok"
        '
        'LabelInfoBahasa
        '
        Me.LabelInfoBahasa.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelInfoBahasa.Location = New System.Drawing.Point(400, 470)
        Me.LabelInfoBahasa.Name = "LabelInfoBahasa"
        Me.LabelInfoBahasa.Size = New System.Drawing.Size(200, 20)
        Me.LabelInfoBahasa.TabIndex = 25
        Me.LabelInfoBahasa.Text = "Info Bahasa"
        '
        'ListBoxInfoKategori
        '
        Me.ListBoxInfoKategori.FormattingEnabled = True
        Me.ListBoxInfoKategori.ItemHeight = 20
        Me.ListBoxInfoKategori.Location = New System.Drawing.Point(400, 510)
        Me.ListBoxInfoKategori.Name = "ListBoxInfoKategori"
        Me.ListBoxInfoKategori.Size = New System.Drawing.Size(200, 124)
        Me.ListBoxInfoKategori.TabIndex = 44
        '
        'FormInfoTambahKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 837)
        Me.Controls.Add(Me.ListBoxInfoKategori)
        Me.Controls.Add(Me.LabelKategori)
        Me.Controls.Add(Me.LabelBahasa)
        Me.Controls.Add(Me.PictureBoxInfoGambarKoleksi)
        Me.Controls.Add(Me.ButtonTambahKoleksi)
        Me.Controls.Add(Me.LabelStock)
        Me.Controls.Add(Me.LabelTanggalMasukKoleksi)
        Me.Controls.Add(Me.LabelLokasiRak)
        Me.Controls.Add(Me.LabelTahunTerbit)
        Me.Controls.Add(Me.LabelPenerbit)
        Me.Controls.Add(Me.LabelDeskripsi)
        Me.Controls.Add(Me.LabelJenisKoleksi)
        Me.Controls.Add(Me.LabelInfoDeskripsi)
        Me.Controls.Add(Me.LabelInfoBahasa)
        Me.Controls.Add(Me.LabelInfoStok)
        Me.Controls.Add(Me.LabelInfoTanggalMasukKoleksi)
        Me.Controls.Add(Me.LabelInfoLokasiRak)
        Me.Controls.Add(Me.LabelInfoTahunTerbit)
        Me.Controls.Add(Me.LabelInfoPenerbit)
        Me.Controls.Add(Me.LabelInfoJenisKoleksi)
        Me.Controls.Add(Me.LabelInfoNamaKoleksi)
        Me.Controls.Add(Me.LabelNamaKoleksi)
        Me.Controls.Add(Me.LabelInfoTambahKoleksi)
        Me.Name = "FormInfoTambahKoleksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormInfoTambahKoleksi"
        CType(Me.PictureBoxInfoGambarKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelKategori As Label
    Friend WithEvents LabelBahasa As Label
    Friend WithEvents PictureBoxInfoGambarKoleksi As PictureBox
    Friend WithEvents ButtonTambahKoleksi As Button
    Friend WithEvents LabelStock As Label
    Friend WithEvents OpenFileDialogGambarKoleksi As OpenFileDialog
    Friend WithEvents LabelTanggalMasukKoleksi As Label
    Friend WithEvents LabelLokasiRak As Label
    Friend WithEvents LabelTahunTerbit As Label
    Friend WithEvents LabelPenerbit As Label
    Friend WithEvents LabelDeskripsi As Label
    Friend WithEvents LabelJenisKoleksi As Label
    Friend WithEvents LabelNamaKoleksi As Label
    Friend WithEvents LabelInfoTambahKoleksi As Label
    Friend WithEvents LabelInfoNamaKoleksi As Label
    Friend WithEvents LabelInfoJenisKoleksi As Label
    Friend WithEvents LabelInfoDeskripsi As Label
    Friend WithEvents LabelInfoPenerbit As Label
    Friend WithEvents LabelInfoTahunTerbit As Label
    Friend WithEvents LabelInfoLokasiRak As Label
    Friend WithEvents LabelInfoTanggalMasukKoleksi As Label
    Friend WithEvents LabelInfoStok As Label
    Friend WithEvents LabelInfoBahasa As Label
    Friend WithEvents ListBoxInfoKategori As ListBox
End Class

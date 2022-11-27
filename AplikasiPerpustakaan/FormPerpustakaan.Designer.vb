<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPerpustakaan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPerpustakaan))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.KoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonPlus = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonMinus = New System.Windows.Forms.ToolStripButton()
        Me.ListBoxKoleksi = New System.Windows.Forms.ListBox()
        Me.DataGridViewKoleksi = New System.Windows.Forms.DataGridView()
        Me.ColumnDirGambar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ColumnNamaKoleksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnJenisKoleksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPenerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDeskripsi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTahunTerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnLokasiRak = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTanggalMasuk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnBahasa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnKategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonShow = New System.Windows.Forms.Button()
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        CType(Me.DataGridViewKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KoleksiToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(578, 28)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'KoleksiToolStripMenuItem
        '
        Me.KoleksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahKoleksiToolStripMenuItem})
        Me.KoleksiToolStripMenuItem.Name = "KoleksiToolStripMenuItem"
        Me.KoleksiToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.KoleksiToolStripMenuItem.Text = "Koleksi"
        '
        'TambahKoleksiToolStripMenuItem
        '
        Me.TambahKoleksiToolStripMenuItem.Name = "TambahKoleksiToolStripMenuItem"
        Me.TambahKoleksiToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.TambahKoleksiToolStripMenuItem.Text = "Tambah Koleksi"
        '
        'ToolStrip
        '
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonPlus, Me.ToolStripButtonMinus})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 28)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(578, 27)
        Me.ToolStrip.TabIndex = 1
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'ToolStripButtonPlus
        '
        Me.ToolStripButtonPlus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonPlus.Image = CType(resources.GetObject("ToolStripButtonPlus.Image"), System.Drawing.Image)
        Me.ToolStripButtonPlus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonPlus.Name = "ToolStripButtonPlus"
        Me.ToolStripButtonPlus.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButtonPlus.Text = "Form Tambah Koleksi"
        '
        'ToolStripButtonMinus
        '
        Me.ToolStripButtonMinus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonMinus.Image = CType(resources.GetObject("ToolStripButtonMinus.Image"), System.Drawing.Image)
        Me.ToolStripButtonMinus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonMinus.Name = "ToolStripButtonMinus"
        Me.ToolStripButtonMinus.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButtonMinus.Text = "Form Hapus Koleksi"
        '
        'ListBoxKoleksi
        '
        Me.ListBoxKoleksi.FormattingEnabled = True
        Me.ListBoxKoleksi.ItemHeight = 20
        Me.ListBoxKoleksi.Location = New System.Drawing.Point(12, 58)
        Me.ListBoxKoleksi.Name = "ListBoxKoleksi"
        Me.ListBoxKoleksi.Size = New System.Drawing.Size(554, 144)
        Me.ListBoxKoleksi.TabIndex = 3
        '
        'DataGridViewKoleksi
        '
        Me.DataGridViewKoleksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewKoleksi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnDirGambar, Me.ColumnNamaKoleksi, Me.ColumnJenisKoleksi, Me.ColumnPenerbit, Me.ColumnDeskripsi, Me.ColumnTahunTerbit, Me.ColumnLokasiRak, Me.ColumnTanggalMasuk, Me.ColumnStock, Me.ColumnBahasa, Me.ColumnKategori})
        Me.DataGridViewKoleksi.Location = New System.Drawing.Point(12, 208)
        Me.DataGridViewKoleksi.Name = "DataGridViewKoleksi"
        Me.DataGridViewKoleksi.RowHeadersWidth = 51
        Me.DataGridViewKoleksi.RowTemplate.Height = 29
        Me.DataGridViewKoleksi.Size = New System.Drawing.Size(554, 384)
        Me.DataGridViewKoleksi.TabIndex = 4
        '
        'ColumnDirGambar
        '
        Me.ColumnDirGambar.HeaderText = "Gambar"
        Me.ColumnDirGambar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.ColumnDirGambar.MinimumWidth = 6
        Me.ColumnDirGambar.Name = "ColumnDirGambar"
        Me.ColumnDirGambar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnDirGambar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColumnDirGambar.Width = 125
        '
        'ColumnNamaKoleksi
        '
        Me.ColumnNamaKoleksi.HeaderText = "Nama Koleksi"
        Me.ColumnNamaKoleksi.MinimumWidth = 6
        Me.ColumnNamaKoleksi.Name = "ColumnNamaKoleksi"
        Me.ColumnNamaKoleksi.Width = 125
        '
        'ColumnJenisKoleksi
        '
        Me.ColumnJenisKoleksi.HeaderText = "Jenis Koleksi"
        Me.ColumnJenisKoleksi.MinimumWidth = 6
        Me.ColumnJenisKoleksi.Name = "ColumnJenisKoleksi"
        Me.ColumnJenisKoleksi.Width = 125
        '
        'ColumnPenerbit
        '
        Me.ColumnPenerbit.HeaderText = "Penerbit"
        Me.ColumnPenerbit.MinimumWidth = 6
        Me.ColumnPenerbit.Name = "ColumnPenerbit"
        Me.ColumnPenerbit.Width = 125
        '
        'ColumnDeskripsi
        '
        Me.ColumnDeskripsi.HeaderText = "Deskripsi"
        Me.ColumnDeskripsi.MinimumWidth = 6
        Me.ColumnDeskripsi.Name = "ColumnDeskripsi"
        Me.ColumnDeskripsi.Width = 125
        '
        'ColumnTahunTerbit
        '
        Me.ColumnTahunTerbit.HeaderText = "Tahun Terbit"
        Me.ColumnTahunTerbit.MinimumWidth = 6
        Me.ColumnTahunTerbit.Name = "ColumnTahunTerbit"
        Me.ColumnTahunTerbit.Width = 125
        '
        'ColumnLokasiRak
        '
        Me.ColumnLokasiRak.HeaderText = "Lokasi Rak"
        Me.ColumnLokasiRak.MinimumWidth = 6
        Me.ColumnLokasiRak.Name = "ColumnLokasiRak"
        Me.ColumnLokasiRak.Width = 125
        '
        'ColumnTanggalMasuk
        '
        Me.ColumnTanggalMasuk.HeaderText = "Tanggal Masuk"
        Me.ColumnTanggalMasuk.MinimumWidth = 6
        Me.ColumnTanggalMasuk.Name = "ColumnTanggalMasuk"
        Me.ColumnTanggalMasuk.Width = 125
        '
        'ColumnStock
        '
        Me.ColumnStock.HeaderText = "Stock"
        Me.ColumnStock.MinimumWidth = 6
        Me.ColumnStock.Name = "ColumnStock"
        Me.ColumnStock.Width = 125
        '
        'ColumnBahasa
        '
        Me.ColumnBahasa.HeaderText = "Bahasa"
        Me.ColumnBahasa.MinimumWidth = 6
        Me.ColumnBahasa.Name = "ColumnBahasa"
        Me.ColumnBahasa.Width = 125
        '
        'ColumnKategori
        '
        Me.ColumnKategori.HeaderText = "Kategori"
        Me.ColumnKategori.MinimumWidth = 6
        Me.ColumnKategori.Name = "ColumnKategori"
        Me.ColumnKategori.Width = 125
        '
        'ButtonShow
        '
        Me.ButtonShow.Location = New System.Drawing.Point(473, 603)
        Me.ButtonShow.Name = "ButtonShow"
        Me.ButtonShow.Size = New System.Drawing.Size(94, 29)
        Me.ButtonShow.TabIndex = 5
        Me.ButtonShow.Text = "Show"
        Me.ButtonShow.UseVisualStyleBackColor = True
        '
        'FormPerpustakaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 643)
        Me.Controls.Add(Me.ButtonShow)
        Me.Controls.Add(Me.DataGridViewKoleksi)
        Me.Controls.Add(Me.ListBoxKoleksi)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "FormPerpustakaan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Perpustakaan"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.DataGridViewKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents KoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents ToolStripButtonPlus As ToolStripButton
    Friend WithEvents ToolStripButtonMinus As ToolStripButton
    Friend WithEvents ListBoxKoleksi As ListBox
    Friend WithEvents DataGridViewKoleksi As DataGridView
    Friend WithEvents ColumnDirGambar As DataGridViewImageColumn
    Friend WithEvents ColumnNamaKoleksi As DataGridViewTextBoxColumn
    Friend WithEvents ColumnJenisKoleksi As DataGridViewTextBoxColumn
    Friend WithEvents ColumnPenerbit As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDeskripsi As DataGridViewTextBoxColumn
    Friend WithEvents ColumnTahunTerbit As DataGridViewTextBoxColumn
    Friend WithEvents ColumnLokasiRak As DataGridViewTextBoxColumn
    Friend WithEvents ColumnTanggalMasuk As DataGridViewTextBoxColumn
    Friend WithEvents ColumnStock As DataGridViewTextBoxColumn
    Friend WithEvents ColumnBahasa As DataGridViewTextBoxColumn
    Friend WithEvents ColumnKategori As DataGridViewTextBoxColumn
    Friend WithEvents ButtonShow As Button
End Class

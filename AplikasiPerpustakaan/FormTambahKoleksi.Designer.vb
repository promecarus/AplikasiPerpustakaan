<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTambahKoleksi
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
        Me.LabelTambahKoleksi = New System.Windows.Forms.Label()
        Me.PanelImage = New System.Windows.Forms.Panel()
        Me.LabelNamaKoleksi = New System.Windows.Forms.Label()
        Me.TextBoxInputNamaKoleksi = New System.Windows.Forms.TextBox()
        Me.LabelJenisKoleksi = New System.Windows.Forms.Label()
        Me.ComboBoxInputJenisKoleksi = New System.Windows.Forms.ComboBox()
        Me.LabelDeskripsi = New System.Windows.Forms.Label()
        Me.RichTextBoxInputDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.LabelPenerbit = New System.Windows.Forms.Label()
        Me.TextBoxInputPenerbit = New System.Windows.Forms.TextBox()
        Me.LabelTahunTerbit = New System.Windows.Forms.Label()
        Me.TextBoxInputTahunTerbit = New System.Windows.Forms.TextBox()
        Me.LabelLokasiRak = New System.Windows.Forms.Label()
        Me.TextBoxInputLokasiRak = New System.Windows.Forms.TextBox()
        Me.LabelTanggalMasukKoleksi = New System.Windows.Forms.Label()
        Me.DateTimePickerInputTanggalMasukKoleksi = New System.Windows.Forms.DateTimePicker()
        Me.LabelStock = New System.Windows.Forms.Label()
        Me.TextBoxInputStock = New System.Windows.Forms.TextBox()
        Me.LabelBahasa = New System.Windows.Forms.Label()
        Me.GroupBoxInputBahasa = New System.Windows.Forms.GroupBox()
        Me.RadioButtonBahasaInggris = New System.Windows.Forms.RadioButton()
        Me.RadioButtonBahasaIndonesia = New System.Windows.Forms.RadioButton()
        Me.LabelKategori = New System.Windows.Forms.Label()
        Me.GroupBoxInputKategori = New System.Windows.Forms.GroupBox()
        Me.CheckBoxBudaya = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTeknologi = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSosial = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSains = New System.Windows.Forms.CheckBox()
        Me.ButtonTambahKoleksi = New System.Windows.Forms.Button()
        Me.GroupBoxInputBahasa.SuspendLayout()
        Me.GroupBoxInputKategori.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelTambahKoleksi
        '
        Me.LabelTambahKoleksi.AutoSize = True
        Me.LabelTambahKoleksi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelTambahKoleksi.Location = New System.Drawing.Point(20, 20)
        Me.LabelTambahKoleksi.Name = "LabelTambahKoleksi"
        Me.LabelTambahKoleksi.Size = New System.Drawing.Size(160, 28)
        Me.LabelTambahKoleksi.TabIndex = 0
        Me.LabelTambahKoleksi.Text = "Tambah Koleksi"
        '
        'PanelImage
        '
        Me.PanelImage.Location = New System.Drawing.Point(20, 60)
        Me.PanelImage.Name = "PanelImage"
        Me.PanelImage.Size = New System.Drawing.Size(160, 200)
        Me.PanelImage.TabIndex = 1
        '
        'LabelNamaKoleksi
        '
        Me.LabelNamaKoleksi.AutoSize = True
        Me.LabelNamaKoleksi.Location = New System.Drawing.Point(200, 60)
        Me.LabelNamaKoleksi.Name = "LabelNamaKoleksi"
        Me.LabelNamaKoleksi.Size = New System.Drawing.Size(100, 20)
        Me.LabelNamaKoleksi.TabIndex = 2
        Me.LabelNamaKoleksi.Text = "Nama Koleksi"
        '
        'TextBoxInputNamaKoleksi
        '
        Me.TextBoxInputNamaKoleksi.Location = New System.Drawing.Point(400, 60)
        Me.TextBoxInputNamaKoleksi.Name = "TextBoxInputNamaKoleksi"
        Me.TextBoxInputNamaKoleksi.Size = New System.Drawing.Size(200, 27)
        Me.TextBoxInputNamaKoleksi.TabIndex = 1
        '
        'LabelJenisKoleksi
        '
        Me.LabelJenisKoleksi.AutoSize = True
        Me.LabelJenisKoleksi.Location = New System.Drawing.Point(200, 100)
        Me.LabelJenisKoleksi.Name = "LabelJenisKoleksi"
        Me.LabelJenisKoleksi.Size = New System.Drawing.Size(91, 20)
        Me.LabelJenisKoleksi.TabIndex = 2
        Me.LabelJenisKoleksi.Text = "Jenis Koleksi"
        '
        'ComboBoxInputJenisKoleksi
        '
        Me.ComboBoxInputJenisKoleksi.FormattingEnabled = True
        Me.ComboBoxInputJenisKoleksi.Location = New System.Drawing.Point(400, 100)
        Me.ComboBoxInputJenisKoleksi.Name = "ComboBoxInputJenisKoleksi"
        Me.ComboBoxInputJenisKoleksi.Size = New System.Drawing.Size(200, 28)
        Me.ComboBoxInputJenisKoleksi.TabIndex = 2
        '
        'LabelDeskripsi
        '
        Me.LabelDeskripsi.AutoSize = True
        Me.LabelDeskripsi.Location = New System.Drawing.Point(200, 140)
        Me.LabelDeskripsi.Name = "LabelDeskripsi"
        Me.LabelDeskripsi.Size = New System.Drawing.Size(69, 20)
        Me.LabelDeskripsi.TabIndex = 2
        Me.LabelDeskripsi.Text = "Deskripsi"
        '
        'RichTextBoxInputDeskripsi
        '
        Me.RichTextBoxInputDeskripsi.Location = New System.Drawing.Point(400, 140)
        Me.RichTextBoxInputDeskripsi.Name = "RichTextBoxInputDeskripsi"
        Me.RichTextBoxInputDeskripsi.Size = New System.Drawing.Size(200, 120)
        Me.RichTextBoxInputDeskripsi.TabIndex = 3
        Me.RichTextBoxInputDeskripsi.Text = ""
        '
        'LabelPenerbit
        '
        Me.LabelPenerbit.AutoSize = True
        Me.LabelPenerbit.Location = New System.Drawing.Point(200, 280)
        Me.LabelPenerbit.Name = "LabelPenerbit"
        Me.LabelPenerbit.Size = New System.Drawing.Size(63, 20)
        Me.LabelPenerbit.TabIndex = 2
        Me.LabelPenerbit.Text = "Penerbit"
        '
        'TextBoxInputPenerbit
        '
        Me.TextBoxInputPenerbit.Location = New System.Drawing.Point(400, 280)
        Me.TextBoxInputPenerbit.Name = "TextBoxInputPenerbit"
        Me.TextBoxInputPenerbit.Size = New System.Drawing.Size(200, 27)
        Me.TextBoxInputPenerbit.TabIndex = 4
        '
        'LabelTahunTerbit
        '
        Me.LabelTahunTerbit.AutoSize = True
        Me.LabelTahunTerbit.Location = New System.Drawing.Point(200, 320)
        Me.LabelTahunTerbit.Name = "LabelTahunTerbit"
        Me.LabelTahunTerbit.Size = New System.Drawing.Size(89, 20)
        Me.LabelTahunTerbit.TabIndex = 2
        Me.LabelTahunTerbit.Text = "Tahun Terbit"
        '
        'TextBoxInputTahunTerbit
        '
        Me.TextBoxInputTahunTerbit.Location = New System.Drawing.Point(400, 320)
        Me.TextBoxInputTahunTerbit.Name = "TextBoxInputTahunTerbit"
        Me.TextBoxInputTahunTerbit.Size = New System.Drawing.Size(200, 27)
        Me.TextBoxInputTahunTerbit.TabIndex = 5
        '
        'LabelLokasiRak
        '
        Me.LabelLokasiRak.AutoSize = True
        Me.LabelLokasiRak.Location = New System.Drawing.Point(200, 360)
        Me.LabelLokasiRak.Name = "LabelLokasiRak"
        Me.LabelLokasiRak.Size = New System.Drawing.Size(78, 20)
        Me.LabelLokasiRak.TabIndex = 2
        Me.LabelLokasiRak.Text = "Lokasi Rak"
        '
        'TextBoxInputLokasiRak
        '
        Me.TextBoxInputLokasiRak.Location = New System.Drawing.Point(400, 360)
        Me.TextBoxInputLokasiRak.Name = "TextBoxInputLokasiRak"
        Me.TextBoxInputLokasiRak.Size = New System.Drawing.Size(200, 27)
        Me.TextBoxInputLokasiRak.TabIndex = 6
        '
        'LabelTanggalMasukKoleksi
        '
        Me.LabelTanggalMasukKoleksi.AutoSize = True
        Me.LabelTanggalMasukKoleksi.Location = New System.Drawing.Point(200, 400)
        Me.LabelTanggalMasukKoleksi.Name = "LabelTanggalMasukKoleksi"
        Me.LabelTanggalMasukKoleksi.Size = New System.Drawing.Size(158, 20)
        Me.LabelTanggalMasukKoleksi.TabIndex = 2
        Me.LabelTanggalMasukKoleksi.Text = "Tanggal Masuk Koleksi"
        '
        'DateTimePickerInputTanggalMasukKoleksi
        '
        Me.DateTimePickerInputTanggalMasukKoleksi.Location = New System.Drawing.Point(400, 400)
        Me.DateTimePickerInputTanggalMasukKoleksi.Name = "DateTimePickerInputTanggalMasukKoleksi"
        Me.DateTimePickerInputTanggalMasukKoleksi.Size = New System.Drawing.Size(200, 27)
        Me.DateTimePickerInputTanggalMasukKoleksi.TabIndex = 7
        '
        'LabelStock
        '
        Me.LabelStock.AutoSize = True
        Me.LabelStock.Location = New System.Drawing.Point(200, 440)
        Me.LabelStock.Name = "LabelStock"
        Me.LabelStock.Size = New System.Drawing.Size(45, 20)
        Me.LabelStock.TabIndex = 2
        Me.LabelStock.Text = "Stock"
        '
        'TextBoxInputStock
        '
        Me.TextBoxInputStock.Location = New System.Drawing.Point(400, 440)
        Me.TextBoxInputStock.Name = "TextBoxInputStock"
        Me.TextBoxInputStock.Size = New System.Drawing.Size(200, 27)
        Me.TextBoxInputStock.TabIndex = 8
        '
        'LabelBahasa
        '
        Me.LabelBahasa.AutoSize = True
        Me.LabelBahasa.Location = New System.Drawing.Point(200, 480)
        Me.LabelBahasa.Name = "LabelBahasa"
        Me.LabelBahasa.Size = New System.Drawing.Size(56, 20)
        Me.LabelBahasa.TabIndex = 2
        Me.LabelBahasa.Text = "Bahasa"
        '
        'GroupBoxInputBahasa
        '
        Me.GroupBoxInputBahasa.Controls.Add(Me.RadioButtonBahasaInggris)
        Me.GroupBoxInputBahasa.Controls.Add(Me.RadioButtonBahasaIndonesia)
        Me.GroupBoxInputBahasa.Location = New System.Drawing.Point(400, 480)
        Me.GroupBoxInputBahasa.Name = "GroupBoxInputBahasa"
        Me.GroupBoxInputBahasa.Size = New System.Drawing.Size(200, 110)
        Me.GroupBoxInputBahasa.TabIndex = 9
        Me.GroupBoxInputBahasa.TabStop = False
        Me.GroupBoxInputBahasa.Text = "Bahasa"
        '
        'RadioButtonBahasaInggris
        '
        Me.RadioButtonBahasaInggris.AutoSize = True
        Me.RadioButtonBahasaInggris.Location = New System.Drawing.Point(20, 66)
        Me.RadioButtonBahasaInggris.Name = "RadioButtonBahasaInggris"
        Me.RadioButtonBahasaInggris.Size = New System.Drawing.Size(126, 24)
        Me.RadioButtonBahasaInggris.TabIndex = 1
        Me.RadioButtonBahasaInggris.TabStop = True
        Me.RadioButtonBahasaInggris.Text = "Bahasa Inggris"
        Me.RadioButtonBahasaInggris.UseVisualStyleBackColor = True
        '
        'RadioButtonBahasaIndonesia
        '
        Me.RadioButtonBahasaIndonesia.AutoSize = True
        Me.RadioButtonBahasaIndonesia.Location = New System.Drawing.Point(20, 26)
        Me.RadioButtonBahasaIndonesia.Name = "RadioButtonBahasaIndonesia"
        Me.RadioButtonBahasaIndonesia.Size = New System.Drawing.Size(145, 24)
        Me.RadioButtonBahasaIndonesia.TabIndex = 0
        Me.RadioButtonBahasaIndonesia.TabStop = True
        Me.RadioButtonBahasaIndonesia.Text = "Bahasa Indonesia"
        Me.RadioButtonBahasaIndonesia.UseVisualStyleBackColor = True
        '
        'LabelKategori
        '
        Me.LabelKategori.AutoSize = True
        Me.LabelKategori.Location = New System.Drawing.Point(200, 600)
        Me.LabelKategori.Name = "LabelKategori"
        Me.LabelKategori.Size = New System.Drawing.Size(66, 20)
        Me.LabelKategori.TabIndex = 2
        Me.LabelKategori.Text = "Kategori"
        '
        'GroupBoxInputKategori
        '
        Me.GroupBoxInputKategori.Controls.Add(Me.CheckBoxBudaya)
        Me.GroupBoxInputKategori.Controls.Add(Me.CheckBoxTeknologi)
        Me.GroupBoxInputKategori.Controls.Add(Me.CheckBoxSosial)
        Me.GroupBoxInputKategori.Controls.Add(Me.CheckBoxSains)
        Me.GroupBoxInputKategori.Location = New System.Drawing.Point(400, 600)
        Me.GroupBoxInputKategori.Name = "GroupBoxInputKategori"
        Me.GroupBoxInputKategori.Size = New System.Drawing.Size(200, 190)
        Me.GroupBoxInputKategori.TabIndex = 12
        Me.GroupBoxInputKategori.TabStop = False
        Me.GroupBoxInputKategori.Text = "Kategori"
        '
        'CheckBoxBudaya
        '
        Me.CheckBoxBudaya.AutoSize = True
        Me.CheckBoxBudaya.Location = New System.Drawing.Point(20, 146)
        Me.CheckBoxBudaya.Name = "CheckBoxBudaya"
        Me.CheckBoxBudaya.Size = New System.Drawing.Size(80, 24)
        Me.CheckBoxBudaya.TabIndex = 16
        Me.CheckBoxBudaya.Text = "Budaya"
        Me.CheckBoxBudaya.UseVisualStyleBackColor = True
        '
        'CheckBoxTeknologi
        '
        Me.CheckBoxTeknologi.AutoSize = True
        Me.CheckBoxTeknologi.Location = New System.Drawing.Point(20, 106)
        Me.CheckBoxTeknologi.Name = "CheckBoxTeknologi"
        Me.CheckBoxTeknologi.Size = New System.Drawing.Size(96, 24)
        Me.CheckBoxTeknologi.TabIndex = 15
        Me.CheckBoxTeknologi.Text = "Teknologi"
        Me.CheckBoxTeknologi.UseVisualStyleBackColor = True
        '
        'CheckBoxSosial
        '
        Me.CheckBoxSosial.AutoSize = True
        Me.CheckBoxSosial.Location = New System.Drawing.Point(20, 66)
        Me.CheckBoxSosial.Name = "CheckBoxSosial"
        Me.CheckBoxSosial.Size = New System.Drawing.Size(70, 24)
        Me.CheckBoxSosial.TabIndex = 14
        Me.CheckBoxSosial.Text = "Sosial"
        Me.CheckBoxSosial.UseVisualStyleBackColor = True
        '
        'CheckBoxSains
        '
        Me.CheckBoxSains.AutoSize = True
        Me.CheckBoxSains.Location = New System.Drawing.Point(20, 26)
        Me.CheckBoxSains.Name = "CheckBoxSains"
        Me.CheckBoxSains.Size = New System.Drawing.Size(65, 24)
        Me.CheckBoxSains.TabIndex = 13
        Me.CheckBoxSains.Text = "Sains"
        Me.CheckBoxSains.UseVisualStyleBackColor = True
        '
        'ButtonTambahKoleksi
        '
        Me.ButtonTambahKoleksi.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonTambahKoleksi.Location = New System.Drawing.Point(0, 808)
        Me.ButtonTambahKoleksi.Name = "ButtonTambahKoleksi"
        Me.ButtonTambahKoleksi.Size = New System.Drawing.Size(620, 29)
        Me.ButtonTambahKoleksi.TabIndex = 17
        Me.ButtonTambahKoleksi.Text = "Tambah Koleksi"
        Me.ButtonTambahKoleksi.UseVisualStyleBackColor = True
        '
        'FormTambahKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 837)
        Me.Controls.Add(Me.ButtonTambahKoleksi)
        Me.Controls.Add(Me.GroupBoxInputKategori)
        Me.Controls.Add(Me.GroupBoxInputBahasa)
        Me.Controls.Add(Me.DateTimePickerInputTanggalMasukKoleksi)
        Me.Controls.Add(Me.RichTextBoxInputDeskripsi)
        Me.Controls.Add(Me.ComboBoxInputJenisKoleksi)
        Me.Controls.Add(Me.TextBoxInputStock)
        Me.Controls.Add(Me.TextBoxInputLokasiRak)
        Me.Controls.Add(Me.TextBoxInputTahunTerbit)
        Me.Controls.Add(Me.TextBoxInputPenerbit)
        Me.Controls.Add(Me.TextBoxInputNamaKoleksi)
        Me.Controls.Add(Me.LabelKategori)
        Me.Controls.Add(Me.LabelBahasa)
        Me.Controls.Add(Me.LabelStock)
        Me.Controls.Add(Me.LabelTanggalMasukKoleksi)
        Me.Controls.Add(Me.LabelLokasiRak)
        Me.Controls.Add(Me.LabelTahunTerbit)
        Me.Controls.Add(Me.LabelPenerbit)
        Me.Controls.Add(Me.LabelDeskripsi)
        Me.Controls.Add(Me.LabelJenisKoleksi)
        Me.Controls.Add(Me.LabelNamaKoleksi)
        Me.Controls.Add(Me.PanelImage)
        Me.Controls.Add(Me.LabelTambahKoleksi)
        Me.Name = "FormTambahKoleksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TambahKoleksi"
        Me.GroupBoxInputBahasa.ResumeLayout(False)
        Me.GroupBoxInputBahasa.PerformLayout()
        Me.GroupBoxInputKategori.ResumeLayout(False)
        Me.GroupBoxInputKategori.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTambahKoleksi As Label
    Friend WithEvents PanelImage As Panel
    Friend WithEvents LabelNamaKoleksi As Label
    Friend WithEvents TextBoxInputNamaKoleksi As TextBox
    Friend WithEvents LabelJenisKoleksi As Label
    Friend WithEvents ComboBoxInputJenisKoleksi As ComboBox
    Friend WithEvents LabelDeskripsi As Label
    Friend WithEvents RichTextBoxInputDeskripsi As RichTextBox
    Friend WithEvents LabelPenerbit As Label
    Friend WithEvents TextBoxInputPenerbit As TextBox
    Friend WithEvents LabelTahunTerbit As Label
    Friend WithEvents TextBoxInputTahunTerbit As TextBox
    Friend WithEvents LabelLokasiRak As Label
    Friend WithEvents TextBoxInputLokasiRak As TextBox
    Friend WithEvents LabelTanggalMasukKoleksi As Label
    Friend WithEvents DateTimePickerInputTanggalMasukKoleksi As DateTimePicker
    Friend WithEvents LabelStock As Label
    Friend WithEvents TextBoxInputStock As TextBox
    Friend WithEvents LabelBahasa As Label
    Friend WithEvents GroupBoxInputBahasa As GroupBox
    Friend WithEvents RadioButtonBahasaInggris As RadioButton
    Friend WithEvents RadioButtonBahasaIndonesia As RadioButton
    Friend WithEvents LabelKategori As Label
    Friend WithEvents GroupBoxInputKategori As GroupBox
    Friend WithEvents CheckBoxSosial As CheckBox
    Friend WithEvents CheckBoxSains As CheckBox
    Friend WithEvents CheckBoxBudaya As CheckBox
    Friend WithEvents CheckBoxTeknologi As CheckBox
    Friend WithEvents ButtonTambahKoleksi As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdateKoleksi
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
        Me.RadioButtonBahasaIndonesia = New System.Windows.Forms.RadioButton()
        Me.GroupBoxInputKategori = New System.Windows.Forms.GroupBox()
        Me.CheckBoxBudaya = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTeknologi = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSosial = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSains = New System.Windows.Forms.CheckBox()
        Me.DateTimePickerInputTanggalMasukKoleksi = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxInputStock = New System.Windows.Forms.TextBox()
        Me.TextBoxInputLokasiRak = New System.Windows.Forms.TextBox()
        Me.LabelKategori = New System.Windows.Forms.Label()
        Me.LabelBahasa = New System.Windows.Forms.Label()
        Me.TextBoxInputTahunTerbit = New System.Windows.Forms.TextBox()
        Me.TextBoxInputPenerbit = New System.Windows.Forms.TextBox()
        Me.RichTextBoxInputDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.PictureBoxGambarKoleksi = New System.Windows.Forms.PictureBox()
        Me.ButtonUpdateGambar = New System.Windows.Forms.Button()
        Me.ButtonUpdateKoleksi = New System.Windows.Forms.Button()
        Me.GroupBoxInputBahasa = New System.Windows.Forms.GroupBox()
        Me.RadioButtonBahasaInggris = New System.Windows.Forms.RadioButton()
        Me.ComboBoxInputJenisKoleksi = New System.Windows.Forms.ComboBox()
        Me.TextBoxInputNamaKoleksi = New System.Windows.Forms.TextBox()
        Me.LabelStock = New System.Windows.Forms.Label()
        Me.OpenFileDialogGambarKoleksi = New System.Windows.Forms.OpenFileDialog()
        Me.LabelTanggalMasukKoleksi = New System.Windows.Forms.Label()
        Me.LabelLokasiRak = New System.Windows.Forms.Label()
        Me.LabelTahunTerbit = New System.Windows.Forms.Label()
        Me.LabelPenerbit = New System.Windows.Forms.Label()
        Me.LabelDeskripsi = New System.Windows.Forms.Label()
        Me.LabelJenisKoleksi = New System.Windows.Forms.Label()
        Me.LabelNamaKoleksi = New System.Windows.Forms.Label()
        Me.LabelUpdateKoleksi = New System.Windows.Forms.Label()
        Me.GroupBoxInputKategori.SuspendLayout()
        CType(Me.PictureBoxGambarKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxInputBahasa.SuspendLayout()
        Me.SuspendLayout()
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
        'GroupBoxInputKategori
        '
        Me.GroupBoxInputKategori.Controls.Add(Me.CheckBoxBudaya)
        Me.GroupBoxInputKategori.Controls.Add(Me.CheckBoxTeknologi)
        Me.GroupBoxInputKategori.Controls.Add(Me.CheckBoxSosial)
        Me.GroupBoxInputKategori.Controls.Add(Me.CheckBoxSains)
        Me.GroupBoxInputKategori.Location = New System.Drawing.Point(400, 590)
        Me.GroupBoxInputKategori.Name = "GroupBoxInputKategori"
        Me.GroupBoxInputKategori.Size = New System.Drawing.Size(200, 190)
        Me.GroupBoxInputKategori.TabIndex = 40
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
        'DateTimePickerInputTanggalMasukKoleksi
        '
        Me.DateTimePickerInputTanggalMasukKoleksi.Location = New System.Drawing.Point(400, 390)
        Me.DateTimePickerInputTanggalMasukKoleksi.Name = "DateTimePickerInputTanggalMasukKoleksi"
        Me.DateTimePickerInputTanggalMasukKoleksi.Size = New System.Drawing.Size(200, 27)
        Me.DateTimePickerInputTanggalMasukKoleksi.TabIndex = 37
        '
        'TextBoxInputStock
        '
        Me.TextBoxInputStock.Location = New System.Drawing.Point(400, 430)
        Me.TextBoxInputStock.Name = "TextBoxInputStock"
        Me.TextBoxInputStock.Size = New System.Drawing.Size(200, 27)
        Me.TextBoxInputStock.TabIndex = 38
        '
        'TextBoxInputLokasiRak
        '
        Me.TextBoxInputLokasiRak.Location = New System.Drawing.Point(400, 350)
        Me.TextBoxInputLokasiRak.Name = "TextBoxInputLokasiRak"
        Me.TextBoxInputLokasiRak.Size = New System.Drawing.Size(200, 27)
        Me.TextBoxInputLokasiRak.TabIndex = 36
        '
        'LabelKategori
        '
        Me.LabelKategori.AutoSize = True
        Me.LabelKategori.Location = New System.Drawing.Point(200, 590)
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
        'TextBoxInputTahunTerbit
        '
        Me.TextBoxInputTahunTerbit.Location = New System.Drawing.Point(400, 310)
        Me.TextBoxInputTahunTerbit.Name = "TextBoxInputTahunTerbit"
        Me.TextBoxInputTahunTerbit.Size = New System.Drawing.Size(200, 27)
        Me.TextBoxInputTahunTerbit.TabIndex = 35
        '
        'TextBoxInputPenerbit
        '
        Me.TextBoxInputPenerbit.Location = New System.Drawing.Point(400, 270)
        Me.TextBoxInputPenerbit.Name = "TextBoxInputPenerbit"
        Me.TextBoxInputPenerbit.Size = New System.Drawing.Size(200, 27)
        Me.TextBoxInputPenerbit.TabIndex = 34
        '
        'RichTextBoxInputDeskripsi
        '
        Me.RichTextBoxInputDeskripsi.Location = New System.Drawing.Point(400, 130)
        Me.RichTextBoxInputDeskripsi.Name = "RichTextBoxInputDeskripsi"
        Me.RichTextBoxInputDeskripsi.Size = New System.Drawing.Size(200, 120)
        Me.RichTextBoxInputDeskripsi.TabIndex = 33
        Me.RichTextBoxInputDeskripsi.Text = ""
        '
        'PictureBoxGambarKoleksi
        '
        Me.PictureBoxGambarKoleksi.Location = New System.Drawing.Point(20, 50)
        Me.PictureBoxGambarKoleksi.Name = "PictureBoxGambarKoleksi"
        Me.PictureBoxGambarKoleksi.Size = New System.Drawing.Size(160, 200)
        Me.PictureBoxGambarKoleksi.TabIndex = 43
        Me.PictureBoxGambarKoleksi.TabStop = False
        '
        'ButtonUpdateGambar
        '
        Me.ButtonUpdateGambar.Location = New System.Drawing.Point(20, 256)
        Me.ButtonUpdateGambar.Name = "ButtonUpdateGambar"
        Me.ButtonUpdateGambar.Size = New System.Drawing.Size(160, 29)
        Me.ButtonUpdateGambar.TabIndex = 42
        Me.ButtonUpdateGambar.Text = "Update Gambar"
        Me.ButtonUpdateGambar.UseVisualStyleBackColor = True
        '
        'ButtonUpdateKoleksi
        '
        Me.ButtonUpdateKoleksi.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonUpdateKoleksi.Location = New System.Drawing.Point(0, 808)
        Me.ButtonUpdateKoleksi.Name = "ButtonUpdateKoleksi"
        Me.ButtonUpdateKoleksi.Size = New System.Drawing.Size(620, 29)
        Me.ButtonUpdateKoleksi.TabIndex = 41
        Me.ButtonUpdateKoleksi.Text = "Update Koleksi"
        Me.ButtonUpdateKoleksi.UseVisualStyleBackColor = True
        '
        'GroupBoxInputBahasa
        '
        Me.GroupBoxInputBahasa.Controls.Add(Me.RadioButtonBahasaInggris)
        Me.GroupBoxInputBahasa.Controls.Add(Me.RadioButtonBahasaIndonesia)
        Me.GroupBoxInputBahasa.Location = New System.Drawing.Point(400, 470)
        Me.GroupBoxInputBahasa.Name = "GroupBoxInputBahasa"
        Me.GroupBoxInputBahasa.Size = New System.Drawing.Size(200, 110)
        Me.GroupBoxInputBahasa.TabIndex = 39
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
        'ComboBoxInputJenisKoleksi
        '
        Me.ComboBoxInputJenisKoleksi.FormattingEnabled = True
        Me.ComboBoxInputJenisKoleksi.Location = New System.Drawing.Point(400, 90)
        Me.ComboBoxInputJenisKoleksi.Name = "ComboBoxInputJenisKoleksi"
        Me.ComboBoxInputJenisKoleksi.Size = New System.Drawing.Size(200, 28)
        Me.ComboBoxInputJenisKoleksi.TabIndex = 24
        '
        'TextBoxInputNamaKoleksi
        '
        Me.TextBoxInputNamaKoleksi.Location = New System.Drawing.Point(400, 50)
        Me.TextBoxInputNamaKoleksi.Name = "TextBoxInputNamaKoleksi"
        Me.TextBoxInputNamaKoleksi.Size = New System.Drawing.Size(200, 27)
        Me.TextBoxInputNamaKoleksi.TabIndex = 21
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
        'LabelUpdateKoleksi
        '
        Me.LabelUpdateKoleksi.AutoSize = True
        Me.LabelUpdateKoleksi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelUpdateKoleksi.Location = New System.Drawing.Point(20, 10)
        Me.LabelUpdateKoleksi.Name = "LabelUpdateKoleksi"
        Me.LabelUpdateKoleksi.Size = New System.Drawing.Size(154, 28)
        Me.LabelUpdateKoleksi.TabIndex = 20
        Me.LabelUpdateKoleksi.Text = "Update Koleksi"
        '
        'FormUpdateKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 837)
        Me.Controls.Add(Me.GroupBoxInputKategori)
        Me.Controls.Add(Me.DateTimePickerInputTanggalMasukKoleksi)
        Me.Controls.Add(Me.TextBoxInputStock)
        Me.Controls.Add(Me.TextBoxInputLokasiRak)
        Me.Controls.Add(Me.LabelKategori)
        Me.Controls.Add(Me.LabelBahasa)
        Me.Controls.Add(Me.TextBoxInputTahunTerbit)
        Me.Controls.Add(Me.TextBoxInputPenerbit)
        Me.Controls.Add(Me.RichTextBoxInputDeskripsi)
        Me.Controls.Add(Me.PictureBoxGambarKoleksi)
        Me.Controls.Add(Me.ButtonUpdateGambar)
        Me.Controls.Add(Me.ButtonUpdateKoleksi)
        Me.Controls.Add(Me.GroupBoxInputBahasa)
        Me.Controls.Add(Me.ComboBoxInputJenisKoleksi)
        Me.Controls.Add(Me.TextBoxInputNamaKoleksi)
        Me.Controls.Add(Me.LabelStock)
        Me.Controls.Add(Me.LabelTanggalMasukKoleksi)
        Me.Controls.Add(Me.LabelLokasiRak)
        Me.Controls.Add(Me.LabelTahunTerbit)
        Me.Controls.Add(Me.LabelPenerbit)
        Me.Controls.Add(Me.LabelDeskripsi)
        Me.Controls.Add(Me.LabelJenisKoleksi)
        Me.Controls.Add(Me.LabelNamaKoleksi)
        Me.Controls.Add(Me.LabelUpdateKoleksi)
        Me.Name = "FormUpdateKoleksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUpdateKoleksi"
        Me.GroupBoxInputKategori.ResumeLayout(False)
        Me.GroupBoxInputKategori.PerformLayout()
        CType(Me.PictureBoxGambarKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxInputBahasa.ResumeLayout(False)
        Me.GroupBoxInputBahasa.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadioButtonBahasaIndonesia As RadioButton
    Friend WithEvents GroupBoxInputKategori As GroupBox
    Friend WithEvents CheckBoxBudaya As CheckBox
    Friend WithEvents CheckBoxTeknologi As CheckBox
    Friend WithEvents CheckBoxSosial As CheckBox
    Friend WithEvents CheckBoxSains As CheckBox
    Friend WithEvents DateTimePickerInputTanggalMasukKoleksi As DateTimePicker
    Friend WithEvents TextBoxInputStock As TextBox
    Friend WithEvents TextBoxInputLokasiRak As TextBox
    Friend WithEvents LabelKategori As Label
    Friend WithEvents LabelBahasa As Label
    Friend WithEvents TextBoxInputTahunTerbit As TextBox
    Friend WithEvents TextBoxInputPenerbit As TextBox
    Friend WithEvents RichTextBoxInputDeskripsi As RichTextBox
    Friend WithEvents PictureBoxGambarKoleksi As PictureBox
    Friend WithEvents ButtonUpdateGambar As Button
    Friend WithEvents ButtonUpdateKoleksi As Button
    Friend WithEvents GroupBoxInputBahasa As GroupBox
    Friend WithEvents RadioButtonBahasaInggris As RadioButton
    Friend WithEvents ComboBoxInputJenisKoleksi As ComboBox
    Friend WithEvents TextBoxInputNamaKoleksi As TextBox
    Friend WithEvents LabelStock As Label
    Friend WithEvents OpenFileDialogGambarKoleksi As OpenFileDialog
    Friend WithEvents LabelTanggalMasukKoleksi As Label
    Friend WithEvents LabelLokasiRak As Label
    Friend WithEvents LabelTahunTerbit As Label
    Friend WithEvents LabelPenerbit As Label
    Friend WithEvents LabelDeskripsi As Label
    Friend WithEvents LabelJenisKoleksi As Label
    Friend WithEvents LabelNamaKoleksi As Label
    Friend WithEvents LabelUpdateKoleksi As Label
End Class

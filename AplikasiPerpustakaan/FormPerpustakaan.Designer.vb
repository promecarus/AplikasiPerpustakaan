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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ColumnNamaKoleksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnJenisKoleksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPenerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTahunTerbit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KoleksiToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1080, 28)
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
        Me.ToolStrip.Size = New System.Drawing.Size(1080, 27)
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
        Me.ListBoxKoleksi.Size = New System.Drawing.Size(358, 384)
        Me.ListBoxKoleksi.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnNamaKoleksi, Me.ColumnJenisKoleksi, Me.ColumnPenerbit, Me.ColumnTahunTerbit})
        Me.DataGridView1.Location = New System.Drawing.Point(376, 58)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(556, 384)
        Me.DataGridView1.TabIndex = 4
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
        'ColumnTahunTerbit
        '
        Me.ColumnTahunTerbit.HeaderText = "Tahun Terbit"
        Me.ColumnTahunTerbit.MinimumWidth = 6
        Me.ColumnTahunTerbit.Name = "ColumnTahunTerbit"
        Me.ColumnTahunTerbit.Width = 125
        '
        'FormPerpustakaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 454)
        Me.Controls.Add(Me.DataGridView1)
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ColumnNamaKoleksi As DataGridViewTextBoxColumn
    Friend WithEvents ColumnJenisKoleksi As DataGridViewTextBoxColumn
    Friend WithEvents ColumnPenerbit As DataGridViewTextBoxColumn
    Friend WithEvents ColumnTahunTerbit As DataGridViewTextBoxColumn
End Class

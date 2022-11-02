<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHapusKoleksi
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
        Me.LabelKonfirmasi = New System.Windows.Forms.Label()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.LabelKoleksi = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelKonfirmasi
        '
        Me.LabelKonfirmasi.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelKonfirmasi.Location = New System.Drawing.Point(0, 0)
        Me.LabelKonfirmasi.Name = "LabelKonfirmasi"
        Me.LabelKonfirmasi.Size = New System.Drawing.Size(346, 54)
        Me.LabelKonfirmasi.TabIndex = 0
        Me.LabelKonfirmasi.Text = "Apakah ingin menghapus "
        Me.LabelKonfirmasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonHapus.Location = New System.Drawing.Point(0, 132)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(346, 37)
        Me.ButtonHapus.TabIndex = 1
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'LabelKoleksi
        '
        Me.LabelKoleksi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelKoleksi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelKoleksi.ForeColor = System.Drawing.Color.IndianRed
        Me.LabelKoleksi.Location = New System.Drawing.Point(0, 54)
        Me.LabelKoleksi.Name = "LabelKoleksi"
        Me.LabelKoleksi.Size = New System.Drawing.Size(346, 78)
        Me.LabelKoleksi.TabIndex = 2
        Me.LabelKoleksi.Text = "Koleksi"
        Me.LabelKoleksi.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FormHapusKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 169)
        Me.Controls.Add(Me.LabelKoleksi)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.LabelKonfirmasi)
        Me.Name = "FormHapusKoleksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HapusKoleksi"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelKonfirmasi As Label
    Friend WithEvents ButtonHapus As Button
    Friend WithEvents LabelKoleksi As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Location = New System.Drawing.Point(50, 50)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(75, 20)
        Me.LabelUsername.TabIndex = 0
        Me.LabelUsername.Text = "Username"
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Location = New System.Drawing.Point(50, 100)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(70, 20)
        Me.LabelPassword.TabIndex = 1
        Me.LabelPassword.Text = "Password"
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(150, 50)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(125, 27)
        Me.TextBoxUsername.TabIndex = 0
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(150, 100)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(125, 27)
        Me.TextBoxPassword.TabIndex = 1
        '
        'ButtonLogin
        '
        Me.ButtonLogin.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonLogin.Location = New System.Drawing.Point(0, 141)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(320, 29)
        Me.ButtonLogin.TabIndex = 2
        Me.ButtonLogin.Text = "Login"
        Me.ButtonLogin.UseVisualStyleBackColor = True
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 170)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.LabelUsername)
        Me.Name = "FormLogin"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelUsername As Label
    Friend WithEvents LabelPassword As Label
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents ButtonLogin As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn_FRM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogIn_FRM))
        Me.btn_login = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_login
        '
        Me.btn_login.BackgroundImage = CType(resources.GetObject("btn_login.BackgroundImage"), System.Drawing.Image)
        Me.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_login.Location = New System.Drawing.Point(181, 214)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(93, 27)
        Me.btn_login.TabIndex = 0
        Me.btn_login.Text = "LogIn"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.BackgroundImage = CType(resources.GetObject("btn_cancel.BackgroundImage"), System.Drawing.Image)
        Me.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_cancel.Location = New System.Drawing.Point(290, 214)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(93, 27)
        Me.btn_cancel.TabIndex = 1
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'txt_name
        '
        Me.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_name.Location = New System.Drawing.Point(181, 113)
        Me.txt_name.Multiline = True
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(256, 27)
        Me.txt_name.TabIndex = 2
        Me.txt_name.Text = "chanthou"
        Me.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_password
        '
        Me.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_password.Location = New System.Drawing.Point(181, 170)
        Me.txt_password.Multiline = True
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(256, 27)
        Me.txt_password.TabIndex = 3
        Me.txt_password.Text = "1"
        Me.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LogIn_FRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(487, 278)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_login)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "LogIn_FRM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_login As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_password As System.Windows.Forms.TextBox

End Class

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim path As String = Application.StartupPath & "\noimage.hpg"
        WebBrowser1.Navigate(path)
    End Sub
End Class
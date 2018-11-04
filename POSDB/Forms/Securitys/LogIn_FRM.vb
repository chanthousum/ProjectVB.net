Imports System.Data.SqlClient
Public Class LogIn_FRM

    Private Sub LogIn_FRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_name.Select()
        If CON.State = ConnectionState.Closed Then
            CON.Open()
            'MessageBox.Show("Connected")
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
       
        Try
            ''check verity username
            CMD = New SqlCommand("select * from TblUser where UserName=@username", CON)
            CMD.Parameters.AddWithValue("@username", txt_name.Text.Trim)
            ad = New SqlDataAdapter(CMD)
            tbl = New DataTable
            ad.Fill(tbl)
            'check verify username
            If tbl.Rows.Count = 0 Then
                txt_name.SelectAll()
                txt_name.Focus()
                MessageBox.Show("This Username is invalid", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            ''check verity password
            CMD = New SqlCommand("select * from TblUser where UserName=@username and [Password]=@password", CON)
            CMD.Parameters.AddWithValue("@username", txt_name.Text.Trim)
            CMD.Parameters.AddWithValue("@password", txt_password.Text.Trim)

            ad = New SqlDataAdapter(CMD)
            tbl = New DataTable
            ad.Fill(tbl)
            'check verify username
            If tbl.Rows.Count = 0 Then
                txt_password.SelectAll()
                txt_password.Focus()
                MessageBox.Show("This Password is invalid", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
            userid = tbl.Rows(0)(0)
            username = tbl.Rows(0)(1)
            Main_FRM.lbl_username.Text = tbl.Rows(0)(1)
            Main_FRM.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("connection error", ex.Message)
        End Try
    End Sub
End Class

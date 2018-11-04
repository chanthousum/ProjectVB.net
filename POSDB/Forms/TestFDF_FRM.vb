Imports System.Data.SqlClient
Public Class TestFDF_FRM




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            AxAcroPDF1.src = OpenFileDialog1.FileName
            TextBox1.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pdf() As Byte = IO.File.ReadAllBytes(TextBox1.Text)
        CON.Open()
        CMD = New SqlCommand("Insert into tblpdf(filed)values(@file)", CON)
        CMD.Parameters.AddWithValue("@file", pdf)
        CMD.ExecuteNonQuery()
        MessageBox.Show("Inserted")
    End Sub

    Private Sub TestFDF_FRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ad As New SqlDataAdapter("select * from tblpdf", CON)
        Dim tbl As New DataTable
        ad.Fill(tbl)
        For Each R As DataRow In tbl.Rows
            DataGridView1.Rows.Add(R(0))
        Next
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If DataGridView1.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim DGV As New DataGridViewRow
        DGV = DataGridView1.SelectedRows(0)
        CMD = New SqlCommand("select * from tblpdf where id=@id", CON)
        CMD.Parameters.AddWithValue("@id", DGV.Cells(0).Value)
        Dim ad As New SqlDataAdapter(CMD)
        Dim tbl As New DataTable
        ad.Fill(tbl)
        If tbl.Rows.Count > 0 Then
            If IsDBNull(tbl.Rows(0)(1)) Then
                AxAcroPDF1.src = Nothing
            Else
                Dim path As String = Application.StartupPath & "\Review.pdf"
                System.IO.File.WriteAllBytes(path, tbl.Rows(0)(1))
                AxAcroPDF1.src = path
            End If



        End If
    End Sub
End Class
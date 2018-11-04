Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Data
Public Class AddQty_FRM
    Dim objfunction As New clsFunction
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If objfunction.EmptyTextBox(txt_addqty) = True Then Exit Sub

        Try
            ''add new stock
            Dim tran As SqlTransaction
            tran = CON.BeginTransaction
            CMD = New SqlCommand("", CON, tran)
            CMD.CommandText = "insert into TblAddStock values(@productid,@adddate,@expirdate,@qty,@userid,@username)"
            CMD.Parameters.AddWithValue("@productid", txt_productid.Text.Trim)
            CMD.Parameters.AddWithValue("@adddate", dp_adddate.Value)
            CMD.Parameters.AddWithValue("@expirdate", dp_expiredate.Value)
            CMD.Parameters.AddWithValue("@qty", Convert.ToInt32(txt_addqty.Text.Trim))
            CMD.Parameters.AddWithValue("@userid", userid)
            CMD.Parameters.AddWithValue("@username", Main_FRM.lbl_username.Text)
            CMD.ExecuteNonQuery()
            CMD.Parameters.Clear()

            ''check very qtyInstock
            Dim totalQtyInstock, oldqty, newqty As Integer

            CMD.CommandText = "select QtyInStock from TblProduct where ProductID=@id"
            CMD.Parameters.AddWithValue("@id", txt_productid.Text)
            ad = New SqlDataAdapter(CMD)
            tbl = New DataTable
            ad.Fill(tbl)
            If tbl.Rows.Count > 0 Then
                oldqty = tbl.Rows(0)(0)
            End If

            newqty = txt_addqty.Text.Trim
            totalQtyInstock = oldqty + newqty
            ''update Qtyinstock
            CMD.CommandText = "update tblproduct set QtyInStock=@QtyInStock where productid=@productid"
            CMD.Parameters.AddWithValue("@productid", txt_productid.Text.Trim)
            CMD.Parameters.AddWithValue("@QtyInStock", totalQtyInstock)
            CMD.ExecuteNonQuery()
            CMD.Transaction.Commit()
            MessageBox.Show("Added", "Add", MessageBoxButtons.OK)
            txt_addqty.Clear()
            txt_addqty.Select()
        Catch ex As Exception
            CMD.Transaction.Rollback()
            MessageBox.Show("Error Add Qty " & ex.Message)

        End Try
        'Me.DialogResult = System.Windows.Forms.DialogResult.OK
        'Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        'Me.Close()
    End Sub

    Private Sub AddQty_FRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_addqty.Select()
    End Sub
End Class

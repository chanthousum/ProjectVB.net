Imports System.Data.SqlClient
Public Class clsOrder
    Private objfunction As New clsFunction
#Region "Scan Barcode after that add data into datagriedview"
    Public Sub AddData()
        CMD = New SqlCommand("select *from TblProduct where Barcode=@Barcode", CON)
        CMD.Parameters.AddWithValue("@Barcode", Sale_FRM.txt_barcode.Text.Trim)
        ad = New SqlDataAdapter(CMD)
        tbl = New DataTable
        ad.Fill(tbl)
        Try
            Dim X As Integer = 1
            Dim total As Double = 0
            Dim qty As Integer
            Dim productid As Integer
            Dim productname As String
            Dim sellprice As Double
            Dim st() As String
            If tbl.Rows.Count > 0 Then
                productid = tbl.Rows(0)("Productid")
                productname = tbl.Rows(0)("ProductName")
                sellprice = tbl.Rows(0)("SellPrice")

                For Each DGV As DataGridViewRow In Sale_FRM.dg_order.Rows
                    If DGV.Cells(1).Value = productid Then
                        Dim qty1 As Integer = Convert.ToInt32(DGV.Cells(3).Value) + 1
                        DGV.Cells(3).Value = qty1
                        DGV.Cells(5).Value = Format(sellprice * qty1, "#0.00")
                        Sale_FRM.txt_barcode.Clear()
                        Sale_FRM.txt_barcode.Focus()
                        Exit Sub
                    End If
                Next

                ''Add first row
                qty = 1
                total = sellprice * qty
                X = X + 1
                st = {X, productid, productname, qty, Format(sellprice, "#0.00"), Format(total, "#0.00")}
                Sale_FRM.dg_order.Rows.Add(st)
                Sale_FRM.txt_barcode.Clear()
                Sale_FRM.txt_barcode.Focus()
            Else
                MessageBox.Show("Not found barcode", "Found", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub
#End Region
#Region "to make subtotal when sale product"
    Public Sub SubTotal()
        Dim total As Double = 0
        For Each DGV As DataGridViewRow In Sale_FRM.dg_order.Rows
            total += DGV.Cells(5).Value
            Sale_FRM.lbl_subtotal.Text = Format(Math.Round(total, 2), "#0.00")
        Next
    End Sub
#End Region

#Region "For Discount"
    Public Sub AfterDiscount()
        Dim subtotal As Double = Convert.ToDouble(Sale_FRM.lbl_subtotal.Text) * Convert.ToDouble(Sale_FRM.txt_discount.Text) / 100
        Dim afterdiscount As Double = Convert.ToDouble(Sale_FRM.lbl_subtotal.Text) - Convert.ToDouble(subtotal)
        Sale_FRM.lbl_afterdiscount.Text = Format(afterdiscount, "#0.00")
    End Sub
#End Region
#Region "Save data"
    Public Sub SaveData()
        objfunction.AutomaticID("tblorder", "orderid")
        Dim tran As SqlTransaction
        tran = CON.BeginTransaction
        CMD = New SqlCommand("", CON, tran)
        Try
            CMD.CommandText = "insert into TblOrder(OrderID)values(@id)"
            CMD.Parameters.AddWithValue("@id", objfunction.AutoID)
            CMD.Parameters.AddWithValue("@Orderdate", objfunction.AutoID)
            CMD.Parameters.AddWithValue("@userid", userid)
            CMD.Parameters.AddWithValue("@userinput", Main_FRM.lbl_username.Text)
            CMD.Parameters.AddWithValue("@totalamount", objfunction.AutoID)
            CMD.Parameters.AddWithValue("@cashrecieve", objfunction.AutoID)
            CMD.Parameters.AddWithValue("@cashreturn", objfunction.AutoID)
            CMD.ExecuteNonQuery()
            tran.Commit()
            MessageBox.Show("OK", "Print", MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show("Error Save Data" & ex.Message)
            tran.Rollback()
        End Try
    End Sub
#End Region
End Class

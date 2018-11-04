Imports System.Data.SqlClient
Public Class clsProduct
    Implements infAction

    Public productid As Integer
    Public productname As String
    Public barcode As Integer
    Public unitprice As Double
    Public sellprice As Double
    Public categoryid As Integer
    Public photo() As Byte
    Public result As Integer
    Public sql As String = "sp_product"

    Public Sub Delete() Implements infAction.Delete
        Try
            CMD = New SqlCommand("delete from tblproduct where productid=@productid", CON)
            CMD.Parameters.AddWithValue("@productid", productid)
            result = CMD.ExecuteNonQuery
            If result > 0 Then
                MessageBox.Show("Deleted", "Delete", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MessageBox.Show("Product Delete Error", ex.Message)
        End Try
    End Sub

    Public Sub Insert() Implements infAction.Insert
        Try
            'CMD = New SqlCommand("insert into TblProduct(ProductName,Barcode,UnitPrice,SellPrice,CategoryID,Photo)values(@ProductName,@Barcode,@UnitPrice,@SellPrice,@CategoryID,@Photo)", CON)
            CMD = New SqlCommand(sql, CON)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@ProductName", productname)
            CMD.Parameters.AddWithValue("@Barcode", barcode)
            CMD.Parameters.AddWithValue("@UnitPrice", unitprice)
            CMD.Parameters.AddWithValue("@SellPrice", sellprice)
            CMD.Parameters.AddWithValue("@CategoyrID", categoryid)
            CMD.Parameters.AddWithValue("@Photo", photo)
            CMD.Parameters.AddWithValue("@QtyInstock", 0)
            CMD.Parameters.AddWithValue("@action", "insert")
            result = CMD.ExecuteNonQuery
            If result > 0 Then
                MessageBox.Show("Inserted", "Insert", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MessageBox.Show("Product Insert Error" & ex.Message)
        End Try
    End Sub
    Public Sub InsertNoPhoto()
        Try
            CMD = New SqlCommand("insert into TblProduct(ProductName,Barcode,UnitPrice,SellPrice,CategoryID)values(@ProductName,@Barcode,@UnitPrice,@SellPrice,@CategoryID)", CON)
            CMD.Parameters.AddWithValue("@productname", productname)
            CMD.Parameters.AddWithValue("@Barcode", barcode)
            CMD.Parameters.AddWithValue("@UnitPrice", unitprice)
            CMD.Parameters.AddWithValue("@SellPrice", sellprice)
            CMD.Parameters.AddWithValue("@CategoryID", categoryid)
            result = CMD.ExecuteNonQuery
            If result > 0 Then
                MessageBox.Show("Inserted", "Insert", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MessageBox.Show("Product Insert Error", ex.Message)
        End Try
    End Sub

    Public Sub PrintCrystal() Implements infAction.PrintCrystal

    End Sub

    Public Sub PrintExcel() Implements infAction.PrintExcel

    End Sub

    Public Sub Search() Implements infAction.Search

    End Sub

    Public Sub Update() Implements infAction.Update
        Try
            CMD = New SqlCommand("update TblProduct set ProductName=@ProductName,Barcode=@Barcode,UnitPrice=@UnitPrice,SellPrice=@SellPrice,CategoryID=@CategoryID,Photo=@Photo where productid=@productid", CON)
            CMD.Parameters.AddWithValue("@productid", productid)
            CMD.Parameters.AddWithValue("@productname", productname)
            CMD.Parameters.AddWithValue("@Barcode", barcode)
            CMD.Parameters.AddWithValue("@UnitPrice", unitprice)
            CMD.Parameters.AddWithValue("@SellPrice", sellprice)
            CMD.Parameters.AddWithValue("@CategoryID", categoryid)
            CMD.Parameters.AddWithValue("@Photo", photo)
            result = CMD.ExecuteNonQuery
            If result > 0 Then
                MessageBox.Show("Updated", "Update", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MessageBox.Show("Product Update Error" & ex.Message)
        End Try
    End Sub
    Public Sub UpdateNoPhoto()
        Try
            CMD = New SqlCommand("update TblProduct set ProductName=@ProductName,Barcode=@Barcode,UnitPrice=@UnitPrice,SellPrice=@SellPrice,CategoryID=@CategoryID,Photo=null where productid=@productid", CON)
            CMD.Parameters.AddWithValue("@productid", productid)
            CMD.Parameters.AddWithValue("@productname", productname)
            CMD.Parameters.AddWithValue("@Barcode", barcode)
            CMD.Parameters.AddWithValue("@UnitPrice", unitprice)
            CMD.Parameters.AddWithValue("@SellPrice", sellprice)
            CMD.Parameters.AddWithValue("@CategoryID", categoryid)

            result = CMD.ExecuteNonQuery
            If result > 0 Then
                MessageBox.Show("Updated", "Update", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            MessageBox.Show("Product Update Error" & ex.Message)
        End Try
    End Sub
End Class

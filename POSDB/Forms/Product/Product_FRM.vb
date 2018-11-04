Imports System.Data.SqlClient
Public Class Product_FRM
    Dim objproduct As New clsProduct
    Dim DGV As New DataGridViewRow
    Dim objfunction As New clsFunction
   

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        ''check text box empty
        If objfunction.EmptyTextBox(txt_productname, txt_barcode, txt_unitprice, txt_sellprice) = True Then Exit Sub
        If objfunction.EmptyComboBox(cbo_categoryname) = True Then Exit Sub

        ' ''check verify product name douplicate
        If objfunction.CheckDoubleName("tblproduct", "productname", txt_productname, "Name") = True Then Exit Sub

        ''check verify no photo
        If pic_image.ImageLocation = Nothing Then
            With objproduct
                .productname = txt_productname.Text.Trim
                .barcode = txt_barcode.Text.Trim
                .unitprice = txt_unitprice.Text.Trim
                .sellprice = txt_sellprice.Text.Trim
                .categoryid = txt_categoryid.Text.Trim
                .InsertNoPhoto()
                objfunction.ClearControll(GroupBox1)
            End With
        Else
            With objproduct
                .productname = txt_productname.Text.Trim
                .barcode = txt_barcode.Text.Trim
                .unitprice = txt_unitprice.Text.Trim
                .sellprice = txt_sellprice.Text.Trim
                .categoryid = txt_categoryid.Text.Trim
                Dim img() As Byte
                img = System.IO.File.ReadAllBytes(pic_image.ImageLocation)
                .photo = img
                .Insert()
                objfunction.ClearControll(GroupBox1)
            End With
        End If


    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        objfunction.SetImage(pic_image)
    End Sub

    Private Sub lbl_clear_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_clear.LinkClicked
        objfunction.ClearImage(pic_image)
    End Sub
    Private Sub Product_FRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        btn_update.Enabled = False
        objfunction.AddDataCoboBox(cbo_categoryname, "categoryname", "tblcategory")
        ''load data grid
        Dim sql As String = "select * from v_product"
        objfunction.LoadDataGridView(dg_product, Sql)
    End Sub

    Private Sub cbo_categoryname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_categoryname.SelectedIndexChanged
        objfunction.GetIdCombobox("tblcategory", "categoryname", cbo_categoryname, txt_categoryid)
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If dg_product.Rows.Count = 0 Then
            Exit Sub
        End If
        If MessageBox.Show("Do you want to delete recore ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            DGV = dg_product.SelectedRows(0)
            With objproduct
                .productid = DGV.Cells(0).Value
                .Delete()
                dg_product.Rows.Remove(DGV)
            End With
        End If

    End Sub

    Private Sub dg_product_DoubleClick(sender As Object, e As EventArgs) Handles dg_product.DoubleClick
        If dg_product.Rows.Count = 0 Then
            Exit Sub
        End If

        Try
            DGV = dg_product.SelectedRows(0)
            txt_productname.Text = DGV.Cells(1).Value
            txt_barcode.Text = DGV.Cells(2).Value
            txt_unitprice.Text = DGV.Cells(3).Value
            txt_sellprice.Text = DGV.Cells(4).Value
            txt_categoryid.Text = DGV.Cells(5).Value
            cbo_categoryname.Text = DGV.Cells(6).Value
            If IsNothing(DGV.Cells(7).Value) Or IsDBNull(DGV.Cells(7).Value) Then
                pic_image.ImageLocation = Nothing
            Else
                Dim path As String = Application.StartupPath & "\noimage.png"
                System.IO.File.WriteAllBytes(path, DGV.Cells(7).Value)
                pic_image.ImageLocation = path
            End If

            'If IsNothing(DGV.Cells(7).Value) Or IsDBNull(DGV.Cells(7).Value) Then
            '    pic_image.ImageLocation = Nothing
            'Else

            '    Dim path As String = Application.StartupPath & "\noimage.png"
            '    System.IO.File.WriteAllBytes(path, DGV.Cells(7).Value)
            '    pic_image.ImageLocation = path

            'End If
            btn_save.Enabled = False
            btn_update.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Error transfer data to text box" & ex.Message)
        End Try


    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        ''load data grid
        Dim sql As String = "select * from v_product"
        objfunction.LoadDataGridView(dg_product, sql)
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If dg_product.Rows.Count = 0 Then
            Exit Sub
        End If
        DGV = dg_product.SelectedRows(0)
        ''check text box empty
        If objfunction.EmptyTextBox(txt_productname, txt_barcode, txt_unitprice, txt_sellprice) = True Then Exit Sub
        If objfunction.EmptyComboBox(cbo_categoryname) = True Then Exit Sub

        ' ''check verify product name douplicate
        'If objfunction.CheckDoubleName("tblproduct", "productname", txt_productname, "NAME") = True Then Exit Sub

        ''check verify no photo
        If pic_image.ImageLocation = Nothing Then
            With objproduct
                .productid = DGV.Cells(0).Value
                .productname = txt_productname.Text.Trim
                .barcode = txt_barcode.Text.Trim
                .unitprice = txt_unitprice.Text.Trim
                .sellprice = txt_sellprice.Text.Trim
                .categoryid = txt_categoryid.Text.Trim
                .UpdateNoPhoto()
                btn_save.Enabled = True
                btn_update.Enabled = False
                objfunction.ClearControll(GroupBox1)
            End With
        Else
            With objproduct
                .productid = DGV.Cells(0).Value
                .productname = txt_productname.Text.Trim
                .barcode = txt_barcode.Text.Trim
                .unitprice = txt_unitprice.Text.Trim
                .sellprice = txt_sellprice.Text.Trim
                .categoryid = txt_categoryid.Text.Trim
                Dim img() As Byte
                img = System.IO.File.ReadAllBytes(pic_image.ImageLocation)
                .photo = img
                .Update()
                btn_save.Enabled = True
                btn_update.Enabled = False
                objfunction.ClearControll(GroupBox1)

            End With
        End If
    End Sub


    Private Sub txt_unitprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_unitprice.KeyPress
        objfunction.InputNumber(e)
    End Sub

    Private Sub txt_sellprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_sellprice.KeyPress
        objfunction.InputNumber(e)
    End Sub

    Private Sub txt_search_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_search.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim sql As String = "select p.ProductID,p.ProductName,p.Barcode,p.UnitPrice,p.SellPrice,c.CategoryID,c.CategoryName,p.Photo,p.QtyInStock from TblProduct p inner join TblCategory c on p.CategoryID=c.CategoryID where ProductID=@fielname"
            objfunction.SearchItem(dg_product, sql, txt_search.Text.Trim)
        End If

    End Sub

    Private Sub btn_addqty_Click(sender As Object, e As EventArgs)
        AddQty_FRM.ShowDialog()
    End Sub

    Private Sub AddQtyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddQtyToolStripMenuItem.Click
        dg_product_DoubleClick(sender, e)
            DGV = dg_product.SelectedRows(0)
            AddQty_FRM.txt_productid.Text = DGV.Cells(0).Value
            AddQty_FRM.ShowDialog()
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs)
        objfunction.ClearControll(GroupBox1)
        txt_productname.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim xa As New Excel.Application ''Create application from excell
        Dim wb As Excel.Workbook ''Create workbook
        Dim ws As Excel.Worksheet ''Create worksheet
        Try
            wb = xa.Workbooks.Add
            ws = wb.Worksheets("sheet1")
            'Header
            For c As Integer = 0 To dg_product.Columns.Count - 1
                If TypeOf dg_product.Columns(c) Is DataGridViewImageColumn Then
                    Continue For
                End If
                ws.Cells(1, c + 1) = dg_product.Columns(c).HeaderText
            Next

            Dim row = 2
            For Each DGV1 As DataGridViewRow In dg_product.Rows
                For c As Integer = 0 To dg_product.Columns.Count - 1
                    If TypeOf dg_product.Columns(c) Is DataGridViewImageColumn Then
                        Continue For
                    End If
                    ws.Cells(row, c + 1) = DGV1.Cells(c).Value
                Next
                row += 1
            Next

            xa.Visible = True
            ws.Columns.AutoFit()
            xa = Nothing : wb = Nothing : ws = Nothing
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub
End Class
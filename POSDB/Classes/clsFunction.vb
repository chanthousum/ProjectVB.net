Imports System.Windows.Forms
Imports System.Drawing
Imports System.Data.SqlClient
Public Class clsFunction
    Public AutoID As Integer
#Region ""
    Public Function AutomaticID(tablename As String, fieldname As String) As Boolean

        Try
            ad = New SqlDataAdapter("select " & fieldname & " from  " & tablename & " order by " & fieldname & " desc", CON)
            tbl = New DataTable
            ad.Fill(tbl)
            If tbl.Rows.Count > 0 Then
                AutoID = tbl.Rows(0)(0) + 1
                'MessageBox.Show(AutoID)
            Else
                AutoID = 1
                'MessageBox.Show(AutoID)
            End If
        Catch ex As Exception
            MessageBox.Show("Error Autonumber ID" & ex.Message)
        End Try
        Return False
    End Function
    'How to use
    'objfunction.AutomaticID("tblorder", "orderid")
    'MessageBox.Show(objfunction.AutoID)
#End Region

    Public Function NoImage(pic As PictureBox)
        pic.ImageLocation = Application.StartupPath & "\no image.png"
        Return False
    End Function
#Region "Input on number"
    Public Function InputNumber(ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only !", "Input Number", MessageBoxButtons.OK)
            e.Handled = True

        End If
        ''Using 
        ''obj.InputNumber(e) on keypress
        Return True
    End Function
#End Region
    Public Function InputText(txt As TextBox)
        If IsNumeric(txt.Text) Then
            txt.Clear()
            txt.Focus()
        End If
        Return False
    End Function
#Region "Clear Control"
    Public Function ClearControll(frm As GroupBox)
        For Each ct As Control In frm.Controls
            If TypeOf ct Is TextBox Or TypeOf ct Is MaskedTextBox Then
                If ct.Tag = Nothing Then
                    ct.Text = ""
                End If
            ElseIf TypeOf ct Is PictureBox Then
                DirectCast(ct, PictureBox).Image = Nothing
            ElseIf TypeOf ct Is RadioButton Then
                DirectCast(ct, RadioButton).Checked = False
            ElseIf TypeOf ct Is DateTimePicker Then
                DirectCast(ct, DateTimePicker).CustomFormat = ""
            End If

        Next
        Return True
    End Function
#End Region

#Region "Check Verify Mask tex box empty"
    Public Function EmptyMaskedTextBox(ParamArray txt() As MaskedTextBox) As Boolean
        For Each t As MaskedTextBox In txt
            If t.Text = "" Then
                t.BackColor = Color.Red
                MessageBox.Show("Please input filed !", "Error", MessageBoxButtons.OK)
                t.BackColor = Color.White
                t.Focus()
                Return True
            End If
        Next
        Return False
        ''Using  Dim obj As New clsFunction
        '' If obj.EmptyComboBox(ComboBox1) = True Then Exit Sub
    End Function
#End Region

#Region "Check Verify Com bo box empty"
    Public Function EmptyComboBox(ParamArray txt() As ComboBox) As Boolean
        For Each t As ComboBox In txt
            If t.Text = "" Then
                t.BackColor = Color.Red
                MessageBox.Show("Please select field combobox !", "Error", MessageBoxButtons.OK)
                t.BackColor = Color.White
                t.Focus()
                Return True
            End If
        Next
        Return False

    End Function
    ''Using  Dim obj As New clsFunction
    '' If obj.EmptyComboBox(ComboBox1) = True Then Exit Sub
#End Region

#Region "Check verify text box empty"
    Public Function EmptyTextBox(ParamArray txt() As TextBox) As Boolean
        For Each t As TextBox In txt
            If t.Text = "" Then
                t.BackColor = Color.Red
                MessageBox.Show("Please input filed !", "Error", MessageBoxButtons.OK)
                t.BackColor = Color.White
                t.Focus()
                Return True
            End If
        Next
        Return False

    End Function
    ''Using  Dim obj As New clsFunction
    ''If obj.EmptyTextBox(TextBox1, TextBox2) = True Then Exit Function
#End Region
#Region "Set image"
    Public Sub SetImage(pic As PictureBox)
        Dim o As New OpenFileDialog
        o.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.png)|*.BMP;*.JPG;*.GIF;*.jpeg,*.png"
        If o.ShowDialog = Windows.Forms.DialogResult.OK Then
            pic.Image = System.Drawing.Image.FromFile(o.FileName)
            pic.ImageLocation = o.FileName
        End If

    End Sub
#End Region
#Region "Clear Image"
    Public Sub ClearImage(pic As PictureBox)
        pic.Image = Nothing
        pic.ImageLocation = Nothing
    End Sub
#End Region
#Region "Check verify douplicate name"
    Public Function CheckDoubleName(tblname As String, fieldname As String, txt As TextBox, sms As String) As Boolean
        ad = New SqlDataAdapter("select * from " & tblname & " where " & fieldname & "='" & txt.Text.Trim & "'", CON)
        tbl = New DataTable
        ad.Fill(tbl)
        If tbl.Rows.Count >= 1 Then
            MsgBox("Have already " & sms & "")
            txt.Clear()
            txt.Focus()
            Return True
        Else
            Return False
        End If

    End Function
    '' If DoubleName(tblname, fieldname, txt_name, "NAME") = True Then Exit Sub
#End Region
#Region "Load Data grid view"
    Public Function LoadDataGridView(dg As DataGridView, sql As String) As String ''Function ShowData all Datagrid
        dg.Rows.Clear()
        Try
            ad = New SqlDataAdapter(sql, CON)
            tbl = New DataTable
            ad.Fill(tbl)
            Dim R As DataRow
            For Each R In tbl.Rows
                Dim t As Integer = dg.Rows.Add(R(0))
                For c As Integer = 1 To tbl.Columns.Count - 1
                    dg.Rows(t).Cells(c).Value = R(c)
                Next
            Next


        Catch ex As Exception
            MessageBox.Show("Error load Data" & ex.Message)
        End Try
        Return True

    End Function
    ''load data grid
    'Dim sql As String = "select p.ProductID,p.ProductName,p.Barcode,p.UnitPrice,p.SellPrice,c.CategoryID,c.CategoryName,p.Photo,p.QtyInStock from TblProduct p inner join TblCategory c on p.CategoryID=c.CategoryID"
    'objfunction.LoadDataGridView(dg_product, Sql)
#End Region
#Region ""
    Public Function GetIdCombobox(tblname As String, fieldname As String, cbo As ComboBox, txt As TextBox) As String
        Try
            CMD = New SqlCommand("Select * from " & tblname & " where " & fieldname & "=@CategoryName", CON)
            CMD.Parameters.AddWithValue("@CategoryName", cbo.Text)
            ad = New SqlDataAdapter(CMD)
            tbl = New DataTable
            ad.Fill(tbl)
            If tbl.Rows.Count > 0 Then
                txt.Text = tbl.Rows(0)(0)
            End If
        Catch ex As Exception
            MessageBox.Show("Error load data in combo box category name")
        End Try
        Return False
    End Function
    'objfunction.GetIdCombobox(cbo_categoryname, txt_categoryid)
#End Region
#Region "AddDataCoboBox"
    Public Function AddDataCoboBox(cbo As ComboBox, fieldname As String, tblname As String) As String ''Function ShowData all Datagrid
        cbo.Items.Clear()
        ad = New SqlDataAdapter("select " & fieldname & " From " & tblname & "", CON)
        tbl = New DataTable
        ad.Fill(tbl)
        Dim R As DataRow
        For Each R In tbl.Rows
            cbo.Items.Add(R(0))
        Next

        Return True

    End Function
    'objfunction.AddDataCoboBox(cbo_categoryname, "categoryname", "tblcategory")
#End Region
#Region "Use for Search Item"
    Public Function SearchItem(dg As DataGridView, sql As String, fieldname As String) As String
        dg.Rows.Clear()
        Try
            CMD = New SqlCommand(sql, CON)
            CMD.Parameters.AddWithValue("@fielname", fieldname)
            ad = New SqlDataAdapter(CMD)
            tbl = New DataTable
            ad.Fill(tbl)
            Dim R As DataRow
            For Each R In tbl.Rows
                Dim t As Integer = dg.Rows.Add(R(0))
                For c As Integer = 1 To tbl.Columns.Count - 1
                    dg.Rows(t).Cells(c).Value = R(c)
                Next
            Next
        Catch ex As Exception
            MessageBox.Show("Error Search Data" & ex.Message)
        End Try
        Return True

    End Function
    'Dim sql As String = "select p.ProductID,p.ProductName,p.Barcode,p.UnitPrice,p.SellPrice,c.CategoryID,c.CategoryName,p.Photo,p.QtyInStock from TblProduct p inner join TblCategory c on p.CategoryID=c.CategoryID where ProductID=@fielname"
    '        objfunction.SearchItem(dg_product, sql, txt_search.Text.Trim)
#End Region
End Class

Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient
Public Class ReportProduct_FRM

    Private Sub ReportProduct_FRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Dim rptDoc As New ReportDocument
        Dim DS As New ReportProduct_DS
        ad = New SqlDataAdapter("select * from TblProduct p inner join TblCategory c on p.CategoryID=c.CategoryID", CON)
        Try

            ad.Fill(DS, "tblproduct")
            rptDoc.Load(Application.StartupPath & "\Reports\CrystalReport1.rpt")
            rptDoc.SetDataSource(DS)
            rptDoc.SetParameterValue("username", username) ''set parameter into crystal report
            CrystalReportViewer1.ReportSource = rptDoc
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rptDoc As New ReportDocument
        Dim DS As New ReportProduct_DS
        CMD = New SqlCommand("select * from TblProduct p inner join TblCategory c on p.CategoryID=c.CategoryID where p.productid=@id", CON)
        CMD.Parameters.AddWithValue("@id", TextBox1.Text)
        ad = New SqlClient.SqlDataAdapter(CMD)
        Try
            ad.Fill(DS, "tblproduct")
            rptDoc.Load(Application.StartupPath & "\Reports\CrystalReport1.rpt")
            rptDoc.SetDataSource(DS)
            rptDoc.SetParameterValue("username", username) ''set parameter into crystal report
            CrystalReportViewer1.ReportSource = rptDoc
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim xa As New Excel.Application
        Dim wb As Excel.Workbook
        Dim ws As Excel.Worksheet
        Try
            wb = xa.Workbooks.Add
            ws = wb.Worksheets("sheet1")
            'Header
            ws.Cells(1, 1) = "Product ID"
            ws.Cells(1, 2) = "Product Name"
            ws.Cells(1, 3) = "Unit Price"
           
           
           



            xa.Visible = True
            xa = Nothing : wb = Nothing : ws = Nothing
        Catch ex As Exception

        End Try





    End Sub
End Class

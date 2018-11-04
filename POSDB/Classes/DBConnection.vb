Imports System.Data.SqlClient
Module DBConnection
    Public CON As New SqlConnection("Data Source=.;Initial Catalog=POSDB;User ID=sa;Password=1")
    Public CMD As SqlCommand
    Public ad As New SqlDataAdapter()
    Public tbl As New DataTable
    Public userid As Integer
    Public username As String




End Module

Imports System.Data.SqlClient

Public Class Rank
    Public Function getListRank() As DataTable
        Dim Sql As String = "select * from rank"

        Dim connectStr As New SQLDatabase()
        Dim connect = New SqlConnection(connectStr.getConnection())
        Dim adapter As New SqlDataAdapter()
        connect.Open()
        adapter.SelectCommand = New SqlCommand(Sql, connect)
        Dim dt As New DataTable()
        adapter.Fill(dt)
        adapter.Dispose()
        connect.Close()
        Return dt
    End Function

End Class

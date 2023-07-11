Public Class SQLDatabase
    Dim connection As String
    Public Sub New()
        connection = ConfigurationManager.ConnectionStrings("connectDB").ConnectionString
    End Sub

    Public Function getConnection() As String
        Return connection
    End Function
End Class

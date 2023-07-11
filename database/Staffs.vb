Imports System.Data.SqlClient

Public Class Staffs
    Public Sub New()
    End Sub

    Public Function getStaffById(ByVal idStaff As Integer) As DataTable
        Dim Sql As String = "select firstName, lastName, birthday ,age, sex, address, r.name as rank, di.name as division
                            from employee as em LEFT JOIN rank as r on em.idRank = r.idRank
					                            LEFT JOIN division as di on em.idDivision = di.idDivision
                            Where idStaff = @IdStaff
                            "
        Dim connectStr As New SQLDatabase()
        Dim connect = New SqlConnection(connectStr.getConnection())
        Dim adapter As New SqlDataAdapter()
        connect.Open()
        adapter.SelectCommand = New SqlCommand(Sql, connect)
        adapter.SelectCommand.Parameters.AddWithValue("@IdStaff", idStaff)
        Dim dt As New DataTable()
        adapter.Fill(dt)
        adapter.Dispose()
        connect.Close()
        Return dt
    End Function

    Public Function createStaff(ByVal firstName As String, ByVal lastName As String, ByVal birthday As Date, ByVal age As Integer, ByVal sex As Boolean, ByVal address As String, ByVal idRank As Integer, ByVal idDivision As Integer) As String
        Dim Sql As String
        If (idRank = 0 And idDivision = 0) Then
            Sql = "insert into employee(firstName, lastName, birthday, age, sex, address)
                   values
                   (@FirstName, @LastName, @Birthday, @Age , @Sex, @Address)"
        ElseIf (idRank <> 0 And idDivision = 0) Then
            Sql = "insert into employee(firstName, lastName, birthday, age, sex, address, idRank)
                   values
                   (@FirstName, @LastName, '@Birthday, @Age , @Sex, @Address, @IdRank)"
        ElseIf (idRank = 0 And idDivision <> 0) Then
            Sql = "insert into employee(firstName, lastName, birthday, age, sex, address, idDivision)
                   values
                   (@FirstName, @LastName, @Birthday, @Age , @Sex, @Address, @IdDivision)"
        Else
            Sql = "insert into employee(firstName, lastName, birthday, age, sex, address, idRank ,idDivision)
                   values
                   (@FirstName, @LastName, @Birthday, @Age , @Sex, @Address, @IdRank, @IdDivision)"
        End If

        Dim connectStr As New SQLDatabase()
        Dim connect = New SqlConnection(connectStr.getConnection())
        Dim SelectCommand As SqlCommand = New SqlCommand(Sql, connect)
        SelectCommand.Parameters.AddWithValue("@FirstName", firstName)
        SelectCommand.Parameters.AddWithValue("@LastName", lastName)
        SelectCommand.Parameters.AddWithValue("@Birthday", birthday)
        SelectCommand.Parameters.AddWithValue("@Age", age)
        SelectCommand.Parameters.AddWithValue("@Sex", sex)
        SelectCommand.Parameters.AddWithValue("@Address", address)
        If (idRank <> 0) Then
            SelectCommand.Parameters.AddWithValue("@IdRank", idRank)
        End If
        If (idDivision <> 0) Then
            SelectCommand.Parameters.AddWithValue("@IdDivision", idDivision)
        End If
        connect.Open()
        SelectCommand.ExecuteNonQuery()
        connect.Close()
        Return "Success"
    End Function

    Public Function editStaff(ByRef idStaff As Integer, ByVal firstName As String, ByVal lastName As String, ByVal birthday As Date, ByVal age As Integer, ByVal sex As Boolean, ByVal address As String, ByVal idRank As Integer, ByVal idDivision As Integer) As String
        Dim Sql As String = "UPDATE employee
                SET firstName = @FirstName, lastName = @LastName, birthday= @Birthday,
                age = @Age, sex = @Sex, address = @Address,idRank = @IdRank, idDivision = @IdDivision
                WHERE idStaff = @IdStaff;"

        Dim connectStr As New SQLDatabase()
        Dim connect = New SqlConnection(connectStr.getConnection())
        Dim SelectCommand As SqlCommand = New SqlCommand(Sql, connect)
        SelectCommand.Parameters.AddWithValue("@x", firstName)
        SelectCommand.Parameters.AddWithValue("@LastName", lastName)
        SelectCommand.Parameters.AddWithValue("@Birthday", birthday)
        SelectCommand.Parameters.AddWithValue("@Age", age)
        SelectCommand.Parameters.AddWithValue("@Sex", sex)
        SelectCommand.Parameters.AddWithValue("@Address", address)
        If (idRank <> 0) Then
            SelectCommand.Parameters.AddWithValue("@IdRank", idRank)
        End If
        If (idDivision <> 0) Then
            SelectCommand.Parameters.AddWithValue("@IdDivision", idDivision)
        End If
        SelectCommand.Parameters.AddWithValue("@IdStaff", idStaff)
        connect.Open()
        SelectCommand.ExecuteNonQuery()
        connect.Close()
        Return "Success"
    End Function

    Public Function deleteStaff(ByRef idStaff As Integer) As String
        Dim Sql As String = "DELETE From employee
                                Where idStaff = @IdStaff;"
        Dim connectStr As New SQLDatabase()
        Dim connect = New SqlConnection(connectStr.getConnection())
        Dim SelectCommand As SqlCommand = New SqlCommand(Sql, connect)
        SelectCommand.Parameters.AddWithValue("@IdStaff", idStaff)
        connect.Open()
        SelectCommand.ExecuteNonQuery()
        connect.Close()
        Return "Success"
    End Function
End Class

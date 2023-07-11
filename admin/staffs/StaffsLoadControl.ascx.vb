Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class staffsLoadControl
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (IsPostBack = False) Then
            Dim Sql As String = "select idStaff, firstName, lastName, age, sex, r.name as rank, di.name as division
                    from employee as em LEFT JOIN rank as r on em.idRank = r.idRank
					LEFT JOIN division as di on em.idDivision = di.idDivision"

            Dim connectStr As New SQLDatabase()
            Dim connect = New SqlConnection(connectStr.getConnection())
            Dim adapter As New SqlDataAdapter()
            connect.Open()
            adapter.SelectCommand = New SqlCommand(Sql, connect)
            'adapter.SelectCommand.Parameters.AddWithValue("@Id", ID)
            Dim dt As New DataTable()

            adapter.Fill(dt)
            adapter.Dispose()
            connect.Close()
            If (dt.Rows.Count > 0) Then
                For i As Integer = 0 To dt.Rows.Count - 1 Step 1
                    LiteralStaff.Text += "
            <tr>
                <td>" + dt.Rows(i)("idStaff").ToString() + "</td>
                <td>" + dt.Rows(i)("firstName").ToString() + "</td>
                <td>" + dt.Rows(i)("lastName").ToString() + "</td>
                <td>" + dt.Rows(i)("age").ToString() + "</td>
                <td>" + dt.Rows(i)("sex").ToString() + "</td>
                <td>" + dt.Rows(i)("rank").ToString() + "</td>
                <td>" + dt.Rows(i)("division").ToString() + "</td>
                <td style='text-aligncenter' class='staffs-setting'>
                    <a href='admin.aspx?modul=DetailStaff&idStaff=" + dt.Rows(i)("idStaff").ToString() + "'>Detail</a>
                </td>
            </tr>"
                Next
            End If

        End If
    End Sub

    Protected Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        Dim Sql As String = "select idStaff, firstName, lastName, age, sex, r.name as rank, di.name as division
                    from employee as em LEFT JOIN rank as r on em.idRank = r.idRank
					LEFT JOIN division as di on em.idDivision = di.idDivision
                    where firstName LIKE '%' + @Name + '%' OR lastName LIKE '%' + @LastName + '%'"

        Dim connectStr As New SQLDatabase()
        Dim connect = New SqlConnection(connectStr.getConnection())
        Dim adapter As New SqlDataAdapter()
        connect.Open()
        adapter.SelectCommand = New SqlCommand(Sql, connect)
        adapter.SelectCommand.Parameters.AddWithValue("@Name", TextBoxSearch.Text)
        adapter.SelectCommand.Parameters.AddWithValue("@LastName", TextBoxSearch.Text)
        Dim dt As New DataTable()

        adapter.Fill(dt)
        adapter.Dispose()
        connect.Close()
        LiteralStaff.Text = ""
        If (dt.Rows.Count > 0) Then
            For i As Integer = 0 To dt.Rows.Count - 1 Step 1
                LiteralStaff.Text += "
            <tr>
                <td>" + dt.Rows(i)("idStaff").ToString() + "</td>
                <td>" + dt.Rows(i)("firstName").ToString() + "</td>
                <td>" + dt.Rows(i)("lastName").ToString() + "</td>
                <td>" + dt.Rows(i)("age").ToString() + "</td>
                <td>" + dt.Rows(i)("sex").ToString() + "</td>
                <td>" + dt.Rows(i)("rank").ToString() + "</td>
                <td>" + dt.Rows(i)("division").ToString() + "</td>
                <td style='text-aligncenter' class='staffs-setting'>
                    <a href='admin.aspx?modul=DetailStaff&idStaff=" + dt.Rows(i)("idStaff").ToString() + "'>Detail</a>
                </td>
            </tr>"
            Next
        End If
    End Sub
End Class
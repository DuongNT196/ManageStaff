Public Class CreateStaffControl
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim rank As New Rank()
        Dim dtRank As DataTable = rank.getListRank()
        Dim itemsRank As New List(Of ListItem)
        itemsRank.Add(New ListItem("--- choose rank ---", "0"))
        If (dtRank.Rows.Count > 0) Then
            For i As Integer = 0 To dtRank.Rows.Count - 1 Step 1
                itemsRank.Add(New ListItem(dtRank.Rows(i)("name").ToString(), dtRank.Rows(i)("idRank").ToString()))
            Next
        End If
        DropDownListRank.DataSource = itemsRank
        DropDownListRank.DataBind()

        Dim division As New Division()
        Dim dtDivision As DataTable = division.getListDivision()
        Dim itemsDivision As New List(Of ListItem)
        itemsDivision.Add(New ListItem("--- choose division ---", "0"))
        If (dtDivision.Rows.Count > 0) Then
            For i As Integer = 0 To dtDivision.Rows.Count - 1 Step 1
                itemsDivision.Add(New ListItem(dtDivision.Rows(i)("name").ToString(), dtDivision.Rows(i)("idDivision").ToString()))
            Next
        End If
        DropDownListDivision.DataSource = itemsDivision
        DropDownListDivision.DataBind()
    End Sub

    Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim firstName As String = txtFirstname.Text
        Dim lastName As String = txtLastname.Text
        Dim birthday As Date = DateTime.Parse(txtBrithday.Text)
        Dim age As Integer = Convert.ToInt32(txtAge.Text)
        Dim sex As Boolean = True
        If (radioBoy.Checked) Then
            sex = True
        ElseIf (radioGirl.Checked) Then
            sex = False
        End If
        Dim address As String = txtAddress.Text
        Dim idRank As Integer = Convert.ToInt32(DropDownListRank.SelectedIndex.ToString())
        Dim idDivision As Integer = Convert.ToInt32(DropDownListDivision.SelectedIndex.ToString())
        Dim newStaff As New Staffs()
        Dim result = newStaff.createStaff(firstName, lastName, birthday, age, sex, address, idRank, idDivision)
        Response.Redirect("./admin.aspx?modul=Staffs")
    End Sub
End Class
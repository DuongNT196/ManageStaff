Public Class DetailStaffControl
    Inherits System.Web.UI.UserControl

    Dim idStaff As Integer = 0
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim rank As New Rank()
        Dim dtRank = rank.getListRank()
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

        Dim staffDeatail As New Staffs()
        If (Request.QueryString("idStaff") IsNot Nothing) Then
            idStaff = Convert.ToInt32(Request.QueryString("idStaff").ToString())
            Dim dt = staffDeatail.getStaffById(idStaff)
            If (dt.Rows.Count > 0) Then
                For i As Integer = 0 To dt.Rows.Count - 1 Step 1
                    txtFristname.Text = dt.Rows(i)("firstName").ToString()
                    txtLastname.Text = dt.Rows(i)("lastName").ToString()
                    txtBirthday.Text = dt.Rows(i)("birthday").ToString().Split(" ")(0)
                    txtAge.Text = dt.Rows(i)("age").ToString()
                    If (dt.Rows(i)("sex")) Then
                        radioBoy.Checked = True
                    Else
                        radioGirl.Checked = True
                    End If
                    txtAddress.Text = dt.Rows(i)("address").ToString()
                    Dim item As ListItem = DropDownListRank.Items.FindByText(dt.Rows(i)("rank").ToString())
                    If item IsNot Nothing Then
                        item.Selected = True
                    End If

                    Dim itemDiv As ListItem = DropDownListDivision.Items.FindByText(dt.Rows(i)("division").ToString())
                    If itemDiv IsNot Nothing Then
                        itemDiv.Selected = True
                    End If
                Next
            End If
        End If

    End Sub

    Protected Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Dim firstName As String = txtFristname.Text
        Dim lastName As String = txtLastname.Text
        Dim birthday As Date = DateTime.Parse(txtBirthday.Text)
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
        newStaff.editStaff(idStaff, firstName, lastName, birthday, age, sex, address, idRank, idDivision)
        Response.Redirect("./admin.aspx?modul=Staffs")
    End Sub

    Protected Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim newStaff As New Staffs()
        newStaff.deleteStaff(idStaff)
        Response.Redirect("./admin.aspx?modul=Staffs")
    End Sub
End Class
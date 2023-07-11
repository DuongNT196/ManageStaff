Public Class adminLoadControl

    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim modul As String = ""
        If (Request.QueryString("modul") IsNot Nothing) Then
            modul = Request.QueryString("modul")
        End If

        Select Case modul
            Case "Staffs"
                PlaceHolder1.Controls.Add(LoadControl("staffs/StaffsLoadControl.ascx"))
            Case "CreateStaff"
                PlaceHolder1.Controls.Add(LoadControl("staffs/CreateStaffControl.ascx"))
            Case "DetailStaff"
                PlaceHolder1.Controls.Add(LoadControl("staffs/DetailStaffControl.ascx"))
        End Select
    End Sub

End Class
<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="StaffsLoadControl.ascx.vb" Inherits="QuanLyNhanVienEmty.staffsLoadControl" %>

<div class="staffs">
    <div class="head" style="margin-bottom: 20px">
        <p class="staff-head-context">Danh sách nhân viên </p>
    </div>
    <div class="form-actions">
        <div>
            <label> Search: </label>
            <asp:TextBox ID="TextBoxSearch" runat="server" placehoder="firstname" style="margin: 0 15px"></asp:TextBox>
            <asp:Button ID="ButtonSearch" runat="server" Text="Search" />
        </div>
        <div>
            <p><a href="admin.aspx?modul=CreateStaff"> Create staff </a></p>
        </div>
    </div>
    <div class="staff-table" style="margin-top: 20px">
        <table class="staff-list-nhan-vien">
            <tr>
                <th>Id</th>
                <th>Firstname</th>
                <th>Lastname</th>
                <!-- <th>Birthday</th> -->
                <th>Age</th>
                <th>Sex</th>
                <!-- <th>Address</th> -->
                <th>Rank</th>
                <th>Division</th>
            </tr>
            <asp:Literal ID="LiteralStaff" runat="server"></asp:Literal>
        </table>
    </div>
</div>
<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="DetailStaffControl.ascx.vb" Inherits="QuanLyNhanVienEmty.DetailStaffControl" %>

<div class="staffs">
    <div>
        <p>Thông tin nhân viên</p>
    </div>
    <div>
        <table>
            <tr>
                <td>Firstname: </td>
                <td>
                    <asp:TextBox ID="txtFristname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Lastname: </td>
                <td>
                    <asp:TextBox ID="txtLastname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Birthday: </td>
                <td>
                    <asp:TextBox ID="txtBirthday" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Age: </td>
                <td>
                    <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Sex: </td>
                <td>
                    <asp:RadioButton ID="radioBoy" runat="server" GroupName="radio-sex" value="1" /> <label for="radioBoy">Nam</label>
                    <asp:RadioButton ID="radioGirl" runat="server" GroupName="radio-sex" value="0" /> <label for="radioGirl">Nữ</label>
                </td>
            </tr>
            <tr>
                <td>Address: </td>
                <td>
                    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Rank:</td>
                <td>
                    <asp:DropDownList ID="DropDownListRank" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Division:</td>
                <td>
                    <asp:DropDownList ID="DropDownListDivision" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
    </div>
    <div style="display: flex; justify-content: space-between; margin-top: 30px">
        <div>
            <asp:Button ID="ButtonEdit" runat="server" Text="Edit" style="width: 80px; height: 30px; text-align: center;" />
            <asp:Button ID="ButtonDelete" runat="server" Text="Delete" style="width: 80px; height: 30px; text-align: center; margin-left: 15px;" />
        </div>
        <div>
            <a href="admin.aspx?modul=Staffs" >Back</a>
        </div>
    </div>
</div>
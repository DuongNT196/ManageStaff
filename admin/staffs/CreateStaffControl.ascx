<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="CreateStaffControl.ascx.vb" Inherits="QuanLyNhanVienEmty.CreateStaffControl" %>

<div class="staffs">
    <div class="head" style="margin-bottom: 20px">
        Thêm mới nhân viên
    </div>
    <div>
        <table>
            <tr>
                <td>Firstname:</td>
                <td><asp:TextBox ID="txtFirstname" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Lastname:</td>
                <td><asp:TextBox ID="txtLastname" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Birthday:</td>
                <td><asp:TextBox ID="txtBrithday" runat="server" placeholder="dd/mm/yyyy"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Age:</td>
                <td><asp:TextBox ID="txtAge" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Sex:</td>
                <td>
                    <asp:RadioButton ID="radioBoy" runat="server" GroupName="radio-sex" value="1" /> <label for="radioBoy">Nam</label>
                    <asp:RadioButton ID="radioGirl" runat="server" GroupName="radio-sex" value="0" /> <label for="radioGirl">Nữ</label>
                </td>
            </tr>
            <tr>
                <td>Address:</td>
                <td><asp:TextBox ID="txtAddress" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Rank:</td>
                <td>
                    <asp:DropDownList ID="DropDownListRank" runat="server">
                        <asp:ListItem Text="--- choose rank ---" />
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Division:</td>
                <td>
                    <asp:DropDownList ID="DropDownListDivision" runat="server">
                        <asp:ListItem Text="--- choose division ---" />
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        <asp:Button ID="btnAdd" runat="server" Text="Add" style="padding: 5px 25px; margin-top: 20px" />
    </div>
</div>
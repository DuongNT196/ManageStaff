<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="admin.aspx.vb" Inherits="QuanLyNhanVienEmty.admin" %>

<%@ Register Src="~/admin/adminLoadControl.ascx" TagPrefix="uc1" TagName="adminLoadControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang quản lý nhân viên</title>
    <link href="./admin/css/header.css" rel="stylesheet" type="text/css" />
    <link href="./admin/css/staffs.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="Menu">
            <div>
                <ul>
                    <li> <a href="admin.aspx" title="Home">Home</a> </li>
                    <li> <a href="admin.aspx?modul=Staffs" title="Staffs">Staffs</a> </li>
                </ul>
            </div>
            <div class="avataImg"></div>
        </div>
        <uc1:AdminLoadControl runat="server" id="AdminLoadControl" />
    </form>
</body>
</html>

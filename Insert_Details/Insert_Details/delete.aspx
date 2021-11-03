﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="delete.aspx.cs" Inherits="Insert_Details.delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" StaticSubMenuIndent="16px">
                <Items>
                    <asp:MenuItem NavigateUrl="~/default.aspx.cs" Text="Student Detail" Value="Student Detail">
                        <asp:MenuItem NavigateUrl="~/default.aspx" Text="Add Detail" Value="Add Detail"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/Update_student.aspx" Text="Update Detail" Value="Update Detail"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/delete.aspx" Text="Delete Detail" Value="Delete Detail"></asp:MenuItem>
                    </asp:MenuItem>
                </Items>
            </asp:Menu>
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="DeleteStudentDetail"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="EnterRollNo"></asp:Label>
            <asp:TextBox ID="txtrollno" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update_student.aspx.cs" Inherits="Insert_Details.Update_student" %>

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
            <br />
            <asp:Label ID="Label1" runat="server" Text="UpdateStudentDetail"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Entertherollno"></asp:Label>
            <asp:TextBox ID="rollno" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
            <br />
            <asp:Label ID="Label3" runat="server" Text="The student Details are"></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Text="RollNo"></asp:Label>
            <asp:TextBox ID="rollno_edit" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="name_edit" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" />
        </div>
    </form>
</body>
</html>

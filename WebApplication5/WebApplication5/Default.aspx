<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication5._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
    <div class="row">
        <div class="col-md-4">
            <h2>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Student Detail</h2>
            <p>
               
                <table style="width:100%;">
                    <tr>
                        <td style="height: 20px">
                            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                        </td>
                        <td style="height: 20px">
                            <asp:TextBox ID="txtname" runat="server" ValidationGroup="v1"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtname" ErrorMessage="Enter the name" ValidationGroup="v1"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Rollno"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtrollno" runat="server" ValidationGroup="v1"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtrollno" ErrorMessage="Enter the rollno" ValidationGroup="v1"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 22px">
                            <asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label>
                        </td>
                        <td style="height: 22px">
                            <asp:DropDownList ID="DropDownList1" runat="server">
                                <asp:ListItem>Male</asp:ListItem>
                                <asp:ListItem>Female</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 22px"></td>
                        <td style="height: 22px"></td>
                    </tr>
                    <tr>
                        <td style="height: 22px">
                            <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label>
                        </td>
                        <td style="height: 22px">
                            <asp:TextBox ID="txtaddress" runat="server" Height="148px" Width="278px" ValidationGroup="v1"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtaddress" ErrorMessage="Enter the address" ValidationGroup="v1"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 22px">Qualification</td>
                        <td style="height: 22px">
                            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                                <asp:ListItem>SSLC</asp:ListItem>
                                <asp:ListItem>HSC</asp:ListItem>
                                <asp:ListItem>BE</asp:ListItem>
                            </asp:CheckBoxList>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="height: 22px" align ="center">&nbsp; &nbsp;<asp:Button ID="Submt" runat="server" OnClick="Button1_Click" Text="Submit" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="height: 22px">
                            <asp:Label ID="result" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                </table>
               
            </p>
            
        </div>
        
        
    </div>

</asp:Content>

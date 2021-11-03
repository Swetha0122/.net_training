<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SWETHA_EF.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h1>Faculty Detail </h1>
             <asp:GridView ID="GVfaculty" runat="server"   
                            AutoGenerateColumns="False" ShowFooter="True" AllowPaging="True"  
                            OnRowCommand="GVfaculty_RowCommand"  
                            DataKeyNames="id" CellPadding="4" ForeColor="#333333"  
                            GridLines="None" OnRowCancelingEdit="GVStudent_RowCancelingEdit"  
                            OnRowEditing="GVfaculty_RowEditing"  
                            OnRowUpdating="GVfaculty_RowUpdating"  
                            OnRowDeleting="GVfaculty_RowDeleting"  
                            OnPageIndexChanging="GVfaculty_OnPageIndexChanging">  
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />  
                            <Columns>                                
                                <asp:TemplateField HeaderText="Faculty Code" HeaderStyle-HorizontalAlign="Left">  
                                    <EditItemTemplate>  
                                        <asp:TextBox ID="txtfacultycode" runat="server" Text='<%# Bind("facultycode") %>'></asp:TextBox>  
                                        <asp:RequiredFieldValidator ID="valfacultycode" runat="server" ControlToValidate="txtfacultycode"  
                                            Display="Dynamic" ErrorMessage="Faculty code is required." ForeColor="Red" SetFocusOnError="True"  
                                            ValidationGroup="vldEditRecord">*</asp:RequiredFieldValidator>  
                                    </EditItemTemplate>  
                                    <ItemTemplate>  
                                        <asp:Label ID="lblfacultycode" runat="server" Text='<%# Bind("facultycode") %>'></asp:Label>  
                                    </ItemTemplate>  
                                    <FooterTemplate>  
                                        <asp:TextBox ID="txtfacultycodenew" runat="server"></asp:TextBox>  
                                        <asp:RequiredFieldValidator ID="valfacultycodeNew" runat="server" ControlToValidate="txtfacultycodenew"  
                                            Display="Dynamic" ErrorMessage="Faculty code is required." ForeColor="Red" SetFocusOnError="True"  
                                            ValidationGroup="vldNewRecord">*</asp:RequiredFieldValidator>  
                                    </FooterTemplate>  

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                </asp:TemplateField>

                                  <asp:TemplateField HeaderText="Facultyname" HeaderStyle-HorizontalAlign="Left">  
                                    <EditItemTemplate>  
                                        <asp:TextBox ID="txtfacultyname" runat="server" Text='<%# Bind("facultyname") %>'></asp:TextBox>  
                                        <asp:RequiredFieldValidator ID="valfacultyname" runat="server" ControlToValidate="txtfacultyname"  
                                            Display="Dynamic" ErrorMessage="Faculty Name is required." ForeColor="Red" SetFocusOnError="True"  
                                            ValidationGroup="vldEditRecord">*</asp:RequiredFieldValidator>  
                                    </EditItemTemplate>  
                                    <ItemTemplate>  
                                        <asp:Label ID="lblfacultyname" runat="server" Text='<%# Bind("facultyname") %>'></asp:Label>  
                                    </ItemTemplate>  
                                    <FooterTemplate>  
                                        <asp:TextBox ID="txtfacultynamenew" runat="server"></asp:TextBox>  
                                        <asp:RequiredFieldValidator ID="valfacultynameNew" runat="server" ControlToValidate="txtfacultynamenew"  
                                            Display="Dynamic" ErrorMessage="Faculty Name is required." ForeColor="Red" SetFocusOnError="True"  
                                            ValidationGroup="vldNewRecord">*</asp:RequiredFieldValidator>  
                                    </FooterTemplate>  

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                </asp:TemplateField>    
                                

                                  <asp:TemplateField HeaderText="Email" HeaderStyle-HorizontalAlign="Left">  
                                    <EditItemTemplate>  
                                        <asp:TextBox ID="txtemail" runat="server" Text='<%# Bind("email") %>'></asp:TextBox>  
                                        <asp:RequiredFieldValidator ID="valemail" runat="server" ControlToValidate="txtemail"  
                                            Display="Dynamic" ErrorMessage="Email is required." ForeColor="Red" SetFocusOnError="True"  
                                            ValidationGroup="vldEditRecord">*</asp:RequiredFieldValidator>  
                                    </EditItemTemplate>  
                                    <ItemTemplate>  
                                        <asp:Label ID="lblemail" runat="server" Text='<%# Bind("email") %>'></asp:Label>  
                                    </ItemTemplate>  
                                    <FooterTemplate>  
                                        <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>  
                                        <asp:RequiredFieldValidator ID="valemail" runat="server" ControlToValidate="txtemailnew"  
                                            Display="Dynamic" ErrorMessage="Email is required." ForeColor="Red" SetFocusOnError="True"  
                                            ValidationGroup="vldNewRecord">*</asp:RequiredFieldValidator>  
                                    </FooterTemplate>  

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                </asp:TemplateField>  
  
                                     <asp:TemplateField HeaderText="">  
                                    <ItemTemplate>  
                                        <asp:LinkButton ID="lnkEdit" runat="server" Text="Edit" CommandName="Edit" ToolTip="Edit" >  
                                        </asp:LinkButton>  
                                        <asp:LinkButton ID="lnkDelete" runat="server" Text="Delete" CommandName="Delete"  
                                            ToolTip="Delete" OnClientClick='return confirm("Are you sure you want to delete Student Details?");'>  
                                            
                                        </asp:LinkButton>  
                                    </ItemTemplate>  
  
                                    <EditItemTemplate>  
                                        <asp:LinkButton ID="lnkInsert" runat="server" Text="Update" ValidationGroup="vldEditRecord"   
                                            CommandName="Update" ToolTip="Save"  
                                            OnClientClick='return confirm("Student Detail Saved Successfully.");'>  
                                                  
                                        </asp:LinkButton>  
                                        <asp:LinkButton ID="lnkCancel" runat="server" Text="Cancel" CommandName="Cancel" ToolTip="Cancel">  
                                              
                                        </asp:LinkButton>  
                                    </EditItemTemplate>  
  
                                    <FooterTemplate>  
                                        <asp:LinkButton ID="lnkInsert" runat="server" Text="Insert" ValidationGroup="vldNewRecord"   
                                            CommandName="InsertNew" ToolTip="Add New Employee"  
                                            OnClientClick='return confirm("Employee Record addedd Successfully.");'>  
                                             
                                        </asp:LinkButton>  
                                        <asp:LinkButton ID="lnkCancel" runat="server" Text="Cancel" CommandName="CancelNew" ToolTip="Cancel">  
                                            
                                        </asp:LinkButton>  
                                    </FooterTemplate>  
  
                                </asp:TemplateField>  
  
                            </Columns>  
                            <EditRowStyle BackColor="#999999" />  
                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />  
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />  
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />  
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />  
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />  
                            <SortedAscendingCellStyle BackColor="#E9E7E2" />  
                            <SortedAscendingHeaderStyle BackColor="#506C8C" />  
                            <SortedDescendingCellStyle BackColor="#FFFDF8" />  
                            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />  
                        </asp:GridView>
        </div>
    </form>
</body>
</html>

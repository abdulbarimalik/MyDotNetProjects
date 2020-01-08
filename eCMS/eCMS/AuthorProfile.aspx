<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AuthorProfile.aspx.cs" Inherits="eCMS.AuthorProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style2
        {
            color: #999999;
        }
        .style3
        {
            color: #0000FF;
        }
        .style4
        {
            font-size: large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Menu" runat="server">
    <asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
                   <Items>
                        <asp:MenuItem NavigateUrl="~/Default.aspx" Text="Home"/>
                        <asp:MenuItem NavigateUrl="~/UploadPaper.aspx" Text="Upload Paper"/>
                        <asp:MenuItem NavigateUrl="~/EditProfile.aspx" Text="Edit Profile"/>
                        <asp:MenuItem NavigateUrl="~/Change Password.aspx" Text="Change Password"/>                                                
                    </Items>
</asp:Menu>
</asp:Content> 
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="style3">
        <strong><em>Author Main Page</em></strong></h2><br>

    <h2 class="style2">
        
        <strong>History</strong></h2>
    <hr />
    <h2>
        <br />
        <strong>
        <span class="style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>Name:&nbsp;&nbsp;&nbsp;<asp:Label ID="namelbl" runat="server" Text="Label"></asp:Label>
        </strong></h2>
    <h2>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <strong><span class="style4">Join Date:&nbsp;&nbsp;&nbsp;<asp:Label ID="joindatelbl" runat="server" Text="Label"></asp:Label>
        </span></strong></h2>
    <h2>
        <strong>Paper Details</strong></h2>
    <hr />
    <br />
    <%--<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        EmptyDataText = "No files uploaded" BackColor="White" BorderColor="#E7E7FF" 
        BorderStyle="None" BorderWidth="1px" CellPadding="3" 
        GridLines="Horizontal" Width="618px">
    <AlternatingRowStyle BackColor="#F7F7F7" />
    <Columns>
        <asp:BoundField DataField="Text" HeaderText="File Name" />

        <asp:TemplateField HeaderText="Download">
            <ItemTemplate>
                <asp:LinkButton ID="lnkDownload" Text = "Download" CommandArgument = '<%# Eval("Value") %>' runat="server" OnClick = "DownloadFile"></asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Delete">
            <ItemTemplate>
                <asp:LinkButton ID = "lnkDelete" Text = "Delete" CommandArgument = '<%# Eval("Value") %>' runat = "server" OnClick = "DeleteFile" />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
    <SortedAscendingCellStyle BackColor="#F4F4FD" />
    <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
    <SortedDescendingCellStyle BackColor="#D8D8F0" />
    <SortedDescendingHeaderStyle BackColor="#3E3277" />
</asp:GridView>--%>&nbsp;<br />
<%--<asp:GridView ID="GridView" runat="server" AllowSorting="True" 
        AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Width="269px">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" 
                ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="Paper Title" HeaderText="Paper Title" 
                SortExpression="Paper Title" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="lnkDownload" runat="server" 
                        CommandArgument='<%# Eval("Value") %>' OnClick="DownloadFile" Text="Download"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                    <ItemTemplate>
                    <asp:LinkButton ID="lnkDelete" runat="server" 
                        CommandArgument='<%# Eval("Value") %>' OnClick="DeleteFile" Text="Delete"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:eCMSConnectionString %>" 
        SelectCommand="SELECT * FROM [Paper]"></asp:SqlDataSource>
    <br />
--%>        
    <asp:GridView ID="GridView1" runat="server" BackColor="White" 
    BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
    Width="500px">
    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
    <RowStyle BackColor="White" ForeColor="#330099" />
    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
    <SortedAscendingCellStyle BackColor="#FEFCEB" />
    <SortedAscendingHeaderStyle BackColor="#AF0101" />
    <SortedDescendingCellStyle BackColor="#F6F0C0" />
    <SortedDescendingHeaderStyle BackColor="#7E0000" />
    </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
        <br />
    </asp:Content>

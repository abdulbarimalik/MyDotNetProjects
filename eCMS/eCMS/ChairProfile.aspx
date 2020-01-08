<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChairProfile.aspx.cs" Inherits="eCMS.ChairProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            color: #0000FF;
        }
        .style3
        {
            color: #0000FF;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Menu" runat="server">
    <asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
                   <Items>
                        <asp:MenuItem NavigateUrl="~/Default.aspx" Text="Home"/>
                        <asp:MenuItem NavigateUrl="~/Default.aspx" Text="Assign Paper"/>
                        <asp:MenuItem NavigateUrl="~/EditProfile.aspx" Text="Edit Profile"/>
                        <asp:MenuItem NavigateUrl="~/Change Password.aspx" Text="Change Password"/>
                        
                        
                    </Items>
</asp:Menu>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        <strong><em class="style1">Chair Main Page</em></strong></h1><br>

    <h2 class="style2">
        
        <strong>History</strong></h2>
    <hr />
    <h2>
        <br />
        <strong>
        <span class="style3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>Name:&nbsp;&nbsp;&nbsp;<asp:Label 
            ID="namelbl" runat="server" Text="Sajid Malik"></asp:Label>
        </strong></h2>
    <h2>
        <strong>Review Details</strong></h2>
    <hr />
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReviewerProfile.aspx.cs" Inherits="eCMS.ReviewerProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">

        .style3
        {
            color: #0000FF;
        }
        .style4
        {
            font-size: large;
        }
        .style5
        {
            color: #999999;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Menu" runat="server">
    <asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
                   <Items>
                        <asp:MenuItem NavigateUrl="~/Default.aspx" Text="Home"/>
                        <asp:MenuItem NavigateUrl="~/ReviewPaper.aspx" Text="Review Paper"/>
                        <asp:MenuItem NavigateUrl="~/EditProfile.aspx" Text="Edit Profile"/>
                        <asp:MenuItem NavigateUrl="~/Change Password.aspx" Text="Change Password"/>                                                
                    </Items>
</asp:Menu>
&nbsp;
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        <strong><em style="color: #0000FF">Reviewer Main Page</em></strong></h1>

    <h2 class="style5">
        
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
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
       <strong> &nbsp;&nbsp;&nbsp; No. of Paper Reviews:</strong></h2>
    <h2>
        &nbsp;</h2>
    <h2 class="style5">
        <strong>Paper Details</strong></h2>&nbsp;<hr 
        style="height: 3px" />

</asp:Content>

<%@ Page Title="eCMS" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="eCMS._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            color: #6600CC;
        }
        .style2
        {
            font-family: "Times New Roman", Times, serif;
        }
        .style4
        {
            color: #000000;
        }
        .style5
        {
            font-size: medium;
        }
        .style6
        {
            font-size: medium;
            color: #000000;
        }
        .style7
        {
            font-family: "Times New Roman", Times, serif;
            font-size: medium;
            color: #9900FF;
        }
        .style8
        {
            font-size: medium;
            color: #CC00CC;
        }
        .style9
        {
            color: #CC00CC;
        }
        .style10
        {
            font-family: "Times New Roman", Times, serif;
            font-size: large;
        }
    </style>
</asp:Content>


<asp:Content ID="Navigation" runat="server" ContentPlaceHolderID="Menu">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
                   <Items>
                        <asp:MenuItem NavigateUrl="~/Default.aspx" Text="Home"/>
                        <asp:MenuItem NavigateUrl="~/Login.aspx" Text="Author"/>
                        <asp:MenuItem NavigateUrl="~/Login.aspx" Text="Reviewer"/>
                        <asp:MenuItem NavigateUrl="~/Login.aspx" Text="Chair"/>
                    </Items>
</asp:Menu>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2 class="style1">
        <u><strong>Welcome to Conference Management System</strong></u></h2>
    <p class="MsoNormal">
        <span style="mso-bidi-font-size:12.0pt;line-height:107%">
        <span 
            class="style2"> <span class="style5">&nbsp;</span><span class="style6">eCMS 
        – Easy Conference Management System is a comprehensive, richly featured and 
        fully mature online conference management system. It handles abstract 
        submission, the review process and the selection of papers</span>.</span></span></p>
    <p>
    <span style="font-size:12.0pt;line-height:107%;font-family:&quot;Times New Roman&quot;,&quot;serif&quot;;
mso-fareast-font-family:Calibri;mso-ansi-language:EN-US;mso-fareast-language:
EN-US;mso-bidi-language:AR-SA"><span 
        class="style4"> Easy 
    Conference Management System is a conference management system that is flexible, 
    easy to use, and has many features to make it suitable&nbsp; for various conference 
    models. It has currently probably the most commonly used conference management 
    system. It includes Author registration, submitting the paper, Reviewer 
    selection, paper review and submitting</span></span></p>
    <br />
    <p class="style7">
        <strong>Login is necessary for using this site.</strong></p>
    <p class="style7">
        <asp:HyperLink ID="Login" runat="server" NavigateUrl="~/Login.aspx">Login</asp:HyperLink>
    </p>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <strong><span class="style9"><span class="style10"><em>Thank you for visiting 
    Conference Management System</em></span></span><em><span class="style8">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </span></em></strong>
</asp:Content>

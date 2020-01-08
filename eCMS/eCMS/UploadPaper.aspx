<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UploadPaper.aspx.cs" Inherits="eCMS.UploadPaper" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            color: #0000FF;
            font-weight: normal;
        }
        .style2
        {
            font-size: medium;
        }
        .style3
        {
            color: #999999;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Menu" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="style1">
        <strong>Submit Paper </strong>
    </h1>
    <p class="style2">
        Enter Paper title, paper description, select paper and click &quot;Submit&quot; Button to 
        upload paper for review.</p>
    <h2>
        <br />
        <span class="style3"><strong>Paper Details</strong></span></h2><hr />
    <h2>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <strong>Title:</strong>&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="paperTitle" runat="server" Width="492px" 
            style="margin-left: 0px"></asp:TextBox>
    </h2>
    <h2>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>Description:&nbsp;
        <asp:TextBox ID="paperDescription" runat="server" Height="64px" Width="492px"></asp:TextBox>
        </strong>
    </h2>
    <h2>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>&nbsp;Select File: </strong>
        <asp:FileUpload ID="FileUpload" runat="server" />
        <asp:Button ID="paperSubBtn" runat="server" Text="Submit" Width="82px" 
            onclick="paperSubBtn_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </h2>
    <h2>
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="txtlabel" runat="server" ForeColor="Red" Text="Label"></asp:Label>
       <hr />
</asp:Content>

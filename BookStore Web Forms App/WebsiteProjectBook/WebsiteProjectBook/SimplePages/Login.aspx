<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebsiteProjectBook.SimplePages.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .style1
    {
        font-size: x-large;
        font-family: "Times New Roman", Times, serif;
        text-align: left;
    }
    .style2
    {
        width: 100%;
    }
    .style3
    {
        font-size: large;
        font-family: "Times New Roman", Times, serif;
        width: 204px;
        text-align: right;
    }
    .style4
    {
        width: 204px;
        text-align: right;
    }
    .style5
    {
            width: 228px;
            text-align: center;
        }
    .style6
    {
        font-size: large;
        font-family: "Times New Roman", Times, serif;
    }
  .style7
  {
      width: 307px;
      background-color: Gray;
  }
    .style8
    {
        color: #000000;
        font-size: medium;
        font-family: "Times New Roman", Times, serif;
    }
 
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<p class="style7" style="background-position: center center;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    <span class="style8"><strong>Login&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label 
            ID="Label1" runat="server" ForeColor="Red" style="font-size: medium" 
            Visible="False"></asp:Label>
        </strong></span></p>

    <p class="style1" style="color: #000000">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
<table class="style2">
    <tr>
        <td class="style3">
            UserName</td>
        <td class="style5" style="text-align: center">
            <asp:TextBox ID="txtUN" runat="server" Width="180px"></asp:TextBox>
        </td>
        <td class="style6" style="color: #FF0000">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="txtUN" ErrorMessage="Please Enter User Name"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style3">
            Password</td>
        <td class="style5">
            <asp:TextBox ID="txtPassword" runat="server" style="text-align: left" 
                Width="180px" TextMode="Password"></asp:TextBox>
        </td>
        <td class="style6" style="color: #FF0000">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="txtPassword" 
                ErrorMessage="Please Enter Password in Correct Format"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style4">
            &nbsp;</td>
        <td class="style5">
            <asp:Button ID="btnLogin" runat="server" Text="Login" 
                onclick="btnLogin_Click" />
        </td>
        <td class="style6">
            Not a Member,<asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Blue" 
                NavigateUrl="~/SimplePages/SignUp.aspx">SignUp</asp:HyperLink>
        </td>
    </tr>
</table>
</asp:Content>

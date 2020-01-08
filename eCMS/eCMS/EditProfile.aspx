<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditProfile.aspx.cs" Inherits="eCMS.EditProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">

        .style9
        {
            color: #0000FF;
        }
        .style1
        {
            width: 100%;
            height: 80px;
        }
        .style4
        {
            width: 180px;
            margin-left: 40px;
        }
        .style5
        {
            text-align: left;
        }
        .style16
        {
            text-decoration: underline;
            color: #0000FF;
        }
        .style17
        {
            width: 100%;
        }
        .style19
        {
            width: 264px;
            text-align: right;
            height: 26px;
            text-decoration: underline;
            font-weight: bold;
            color: #000000;
        }
        .style20
        {
            height: 26px;
            width: 172px;
        }
        .style18
        {
            width: 264px;
            text-align: right;
            text-decoration: underline;
            font-weight: bold;
            color: #000000;
        }
        .style21
        {
            width: 172px;
        }
        #Reset1
        {
            width: 72px;
        }
        .style22
        {
            color: #9900CC;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Menu" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="style22">
        <strong>Edit Profile</strong></h2>
    <hr />
    <p class="style12">
        <strong>Existing user update profile here.</strong></p>
    <p style="margin-left: 40px">
        Please fill the form and click on the &quot;Submit&quot; button.</p>
    <h2 style="margin-left: 40px">
        &nbsp;<span class="style9"><strong><em>Registration details </em></strong>
        </span>
    </h2>
    <br />
    <table class="style1">
        <tr>
            <td class="style18">
                E-Mail Address</td>
            <td class="style4">
                <asp:TextBox ID="txt_Email" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td class="style5">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txt_Email" ErrorMessage="E-Mail is Required" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="txt_Email" ErrorMessage="You must enter the valid E-mail Id" 
                    ForeColor="Red" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
    </table>
    <h2>
        <span class="style16"><em>Personal Details</em></span><br />
    </h2>
    <table class="style17">
        <tr>
            <td class="style19">
                Full Name</td>
            <td class="style20">
                <asp:TextBox ID="fName" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                    ControlToValidate="fName" ErrorMessage="Please Enter First Name" 
                    ForeColor="Red" style="text-align: left"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style18">
                Contact No</td>
            <td class="style21">
                <asp:TextBox ID="cNo" runat="server" Width="180px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style18">
                Address</td>
            <td class="style21">
                <asp:TextBox ID="address" runat="server" Width="180px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style18">
                Country</td>
            <td class="style21">
                <asp:TextBox ID="country" runat="server" Width="180px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style18">
                City</td>
            <td class="style21">
                <asp:TextBox ID="city" runat="server" Width="180px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style18">
                Zip</td>
            <td class="style21">
                <asp:TextBox ID="zip" runat="server" Width="180px"></asp:TextBox>
            </td>
        </tr>
    </table>
    <p>
        <br style="margin-left: 120px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnsubreg" runat="server" 
                    style="text-align: left" Text="Submit" Width="72px" 
                    onclick="btnsubreg_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <input id="Reset1" type="reset" value="reset" /></p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="txtlabel" runat="server" ForeColor="Red" Text="Label"></asp:Label>
        <br />
    </p>
</asp:Content>

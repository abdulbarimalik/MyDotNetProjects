<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Change Password.aspx.cs" Inherits="eCMS.Change_Password1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style2
        {
            color: #3333FF;
        }
        .style3
        {
            color: #000000;
        }
        .style1
        {
            width: 100%;
        }
        .style4
        {
            width: 207px;
        }
        .style5
        {
            color: #000000;
            text-align: right;
        }
        #Reset1
        {
            width: 62px;
        }
    </style>
</asp:Content>
<asp:Content ID="Navigation" runat="server" ContentPlaceHolderID="Menu">
<asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
                   <Items>
                        <asp:MenuItem NavigateUrl="~/Default.aspx" Text="Home"/>
                        
                    </Items>
</asp:Menu>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="style2">
        <strong>Change Password</strong></h2><hr />
    <p class="style3">
            <strong>To Change the Password, Please fill the following Form.</strong></p>
    <br />
        <table class="style1">
            <tr>
                <td class="style5">
                    <strong>Existing E-mail Id</strong></td>
                <td class="style4">
                    <asp:TextBox ID="txtopass" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    <strong>New Password</strong></td>
                <td class="style4">
                    <asp:TextBox ID="txtnpass" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    <strong>Confirm Password</strong></td>
                <td class="style4">
                    <asp:TextBox ID="txtcpass" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtcpass" ErrorMessage="Confirm password is required" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToCompare="txtnpass" ControlToValidate="txtcpass" 
                        ErrorMessage="Both password must be same" ForeColor="Red"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style4">
                    <asp:Button ID="btnsubcpass" runat="server" Text="Submit" />
&nbsp;&nbsp;&nbsp;
                    <input id="Reset1" type="reset" value="reset" /></td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </asp:Content>

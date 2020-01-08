<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="eCMS.Log" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style2
    {
        color: #000000;
    }
        .style9
        {
            width: 100%;
        }
        .style10
        {
            width: 130px;
        }
        .style13
        {
            color: #6600CC;
        }
        .style14
        {
            width: 130px;
            text-align: right;
            height: 26px;
            font-weight: bold;
            color: #000000;
        }
        .style16
        {
            height: 26px;
            width: 180px;
        }
        .style17
        {
            width: 180px;
        }
        .style18
        {
            height: 26px;
            width: 268px;
            text-align: left;
        }
        .style19
        {
            width: 268px;
        }
        .style21
        {
            width: 268px;
            text-align: left;
        }
        .style23
        {
            width: 130px;
            height: 85px;
        }
        .style24
        {
            width: 180px;
            height: 85px;
        }
        .style25
        {
            width: 268px;
            height: 85px;
        }
        .style26
        {
            width: 130px;
            text-align: right;
            font-weight: bold;
            color: #000000;
        }
        </style>

        <!-- code for disable browser back button after logout -->
        <script type="text/javascript">

            {

                function DisableBackButton() {

                    window.history.forward()

                }

                DisableBackButton();

                window.onload = DisableBackButton;

                window.onpageshow = function (evt) { if (evt.persisted) DisableBackButton() }

                window.onunload = function () { void (0) }

            }
    
        </script> 
</asp:Content>
<asp:Content ID="Navigation" runat="server" ContentPlaceHolderID="Menu">
<asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
                   <Items>
                        <asp:MenuItem NavigateUrl="~/Default.aspx" Text="Home"/>
                        
                    </Items>
</asp:Menu>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="style13">
        <strong>Registration and Login</strong></h2><hr />
    <p class="style2">
        <strong>Existing User Login </strong></p>
<p class="style2">
        For Exixting Users, Please enter the E-mail address and Password then click 
        &#39;Login&#39; .</p>
<br />
    <table class="style9">
        <tr>
            <td class="style14">
                E-mail Id</td>
            <td class="style16">
                <asp:TextBox ID="txtUN" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td class="style18">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtUN" ErrorMessage="Please Enter  Email Id" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style26">
                Password</td>
            <td class="style17">
                <asp:TextBox ID="txtpassword" runat="server" Width="180px" TextMode="Password"></asp:TextBox>
            </td>
            <td class="style21">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtpassword" ErrorMessage="Please Enter Password" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style10">
                &nbsp;</td>
            <td class="style17">
                &nbsp;</td>
            <td class="style19">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style23">
                </td>
            <td class="style24">
                    &nbsp;<asp:Button ID="login" runat="server" 
                        onclick="login_Click" Text="Login" 
                        Width="62px" ForeColor="Blue" />
                    <asp:HyperLink ID="forgetpassword" runat="server" ForeColor="Red" 
                        NavigateUrl="~/Change Password.aspx"><strong>Forget Password?</strong></asp:HyperLink>
                    <br />
                    <br />
                    &nbsp;<asp:Label ID="txtlabel" runat="server" ForeColor="Red" Text="Label"></asp:Label>
            </td>
            <td class="style25">
                    </td>
        </tr>
    </table>
    <br />
        <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong>
<p class="style2">
    &nbsp;For New Users, Rergistration is Required.</p>
    <p class="style2">
        <strong>For Registration</strong> click on
        <asp:HyperLink ID="signup" runat="server" ForeColor="Blue" 
            NavigateUrl="~/Registration.aspx">SignUp</asp:HyperLink>
    </p>
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
</asp:Content>

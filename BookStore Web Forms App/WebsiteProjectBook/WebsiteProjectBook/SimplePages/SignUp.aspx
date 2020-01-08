<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Site1.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="WebsiteProjectBook.SimplePages.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
       
  .style1
  {
      width: 307px;
      background-color: Gray;
  }
    .style2
    {
        color: #000000;
        font-size: medium;
        font-family: "Times New Roman", Times, serif;
    }
       .style23
        {
            width: 245px;
            font-family: "Times New Roman", Times, serif;
            font-size: large;
            text-align: right;
        }
        .style18
        {
            width: 252px;
            text-align: center;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="style1" style="background-position: center center;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    <span class="style2"><strong>Registration</strong></span></p>
<asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
   <asp:Panel ID="Panel1" GroupingText="Registration " runat="server" style="margin-left: 126px; text-align: left; margin-top: 24px;" 
        Width="541px" Height="683px" BackColor="#999999">
       <asp:Label ID="Label1" runat="server" Font-Bold="True" 
           Font-Names="Times New Roman" Font-Size="Medium" Text="UserName"></asp:Label>
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:TextBox ID="txtUserName" runat="server" Height="23px" 
           style="text-align: left; margin-left: 11px; margin-right: 9px" Width="174px"></asp:TextBox>
       <br />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtUserName" ErrorMessage="Please Enter User Name" 
                        ForeColor="Red" 
                        style="font-size: large; font-family: 'Times New Roman', Times, serif"></asp:RequiredFieldValidator>
                </td>
                <td class="style23">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" 
                        Font-Names="Times New Roman" Font-Size="Medium" Text="Gender"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DDLGender" runat="server" 
                        Width="170px">
                        <asp:ListItem Selected="True">Select One</asp:ListItem>
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="DDLGender" ErrorMessage="You Must Select your Gender" 
                        ForeColor="Red" 
                        style="font-size: large; font-family: 'Times New Roman', Times, serif"></asp:RequiredFieldValidator>
       </td>
       </tr>
       <tr>
           <td class="style23">
               &nbsp;&nbsp;
               <td class="style18">
                   &nbsp;<br /> &nbsp;<asp:Label ID="Label3" runat="server" Font-Bold="True" 
                       Font-Names="Times New Roman" Font-Size="Medium" Text="Birthdate"></asp:Label>
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   <asp:TextBox ID="txtBirthDate" runat="server" Width="174px"></asp:TextBox>
                   <br />
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               </td>
               <td>
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                       ControlToValidate="txtBirthDate" ErrorMessage="Please Enter your Birthday" 
                       ForeColor="Red" 
                       style="font-size: large; font-family: 'Times New Roman', Times, serif"></asp:RequiredFieldValidator>
                   <br />
                   <asp:Label ID="Label12" runat="server" Font-Bold="True" 
                       Font-Names="Times New Roman" Font-Size="Medium" Text="Country"></asp:Label>
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               </td>
           </td>
       </tr>
       <tr>
           <td class="style23">
               <td class="style23">
                   &nbsp;
                   <td class="style18">
                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                       <asp:DropDownList ID="DDLCountry" runat="server" AutoPostBack="True" 
                           onselectedindexchanged="DDLCountry_SelectedIndexChanged" Width="170px">
                       </asp:DropDownList>
                       <br />
                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   </td>
                   <td>
                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                           ControlToValidate="DDLCountry" ErrorMessage="You must Select your Country" 
                           ForeColor="Red" 
                           style="font-size: large; font-family: 'Times New Roman', Times, serif"></asp:RequiredFieldValidator>
                       <br />
                       <asp:Label ID="Label4" runat="server" Font-Bold="True" 
                           Font-Names="Times New Roman" Font-Size="Medium" Text="City"></asp:Label>
                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                       <asp:DropDownList ID="DDLCity" runat="server" Width="170px">
                       </asp:DropDownList>
                   </td>
                   <td>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" 
                           ControlToValidate="DDLCity" ErrorMessage="Error" ForeColor="Red" 
                           style="font-size: large; font-family: 'Times New Roman', Times, serif"></asp:RequiredFieldValidator>
                       &nbsp;
                       <br />
                       <br />
                       <asp:Label ID="Label5" runat="server" Font-Bold="True" 
                           Font-Names="Times New Roman" Font-Size="Medium" Text="Language"></asp:Label>
                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                       <asp:DropDownList ID="DDLLanguage" runat="server" Width="170px">
                           <asp:ListItem Selected="True">Select One</asp:ListItem>
                           <asp:ListItem>Urdu</asp:ListItem>
                           <asp:ListItem>English</asp:ListItem>
                           <asp:ListItem>French</asp:ListItem>
                           <asp:ListItem>Germen</asp:ListItem>
                       </asp:DropDownList>
                       &nbsp;</td>
                   <br />
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   <td>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                           ControlToValidate="DDLLanguage" ErrorMessage="You must Select your Language" 
                           ForeColor="Red" 
                           style="font-size: large; font-family: 'Times New Roman', Times, serif"></asp:RequiredFieldValidator>
                   </td>
               </td>
           </td>
       </tr>
       </table>
       </table>
       &nbsp;<br />
       <asp:Label ID="Label6" runat="server" Font-Bold="True" 
           Font-Names="Times New Roman" Font-Size="Medium" Text="Email"></asp:Label>
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:TextBox ID="txtEmail" runat="server" Width="180px"></asp:TextBox>
       <br />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:RequiredFieldValidator 
           ID="RequiredFieldValidator15" runat="server" ControlToValidate="txtEmail" 
           ErrorMessage="Please Enter your Valid Email" ForeColor="#CC0000" 
           style="font-size: large; font-family: 'Times New Roman', Times, serif"></asp:RequiredFieldValidator>
       <br />
       <asp:Label ID="Label7" runat="server" Font-Bold="True" 
           Font-Names="Times New Roman" Font-Size="Medium" Text="Password"></asp:Label>
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
       <br />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:RequiredFieldValidator 
           ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtPassword" 
           ErrorMessage="Please Enter your Password" ForeColor="#CC0000" 
           style="font-size: large; font-family: 'Times New Roman', Times, serif"></asp:RequiredFieldValidator>
       <br />
       <asp:Label ID="Label8" runat="server" Font-Bold="True" 
           Font-Names="Times New Roman" Font-Size="Medium" Text="RetypePassword"></asp:Label>
       &nbsp;&nbsp;&nbsp;&nbsp;
       <asp:TextBox ID="txtRePassword" runat="server" TextMode="Password" 
           Width="180px"></asp:TextBox>
       <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
           ControlToValidate="txtRePassword" ErrorMessage="Both Password Must Match" 
           ForeColor="#CC0000" 
           style="font-size: large; font-family: 'Times New Roman', Times, serif"></asp:RequiredFieldValidator>
       <br />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
           ControlToValidate="txtRePassword" 
           ErrorMessage="Please Enter your Password for Confirmation" ForeColor="#CC0000" 
           style="font-size: large; font-family: 'Times New Roman', Times, serif"></asp:RequiredFieldValidator>
       <br />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
       <asp:Label ID="Label9" runat="server" Font-Bold="True" 
           Font-Names="Times New Roman" Font-Size="Medium" Text="Alternate Email"></asp:Label>
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:TextBox ID="txtAEmail" runat="server" Width="180px"></asp:TextBox>
       <br />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" 
           ControlToValidate="txtAEmail" 
           ErrorMessage="Pleasr Enter Alternate Email Address" ForeColor="Red" 
           style="font-size: large; font-family: 'Times New Roman', Times, serif"></asp:RequiredFieldValidator>
       <br />
       <asp:Label ID="Label10" runat="server" Font-Bold="True" 
           Font-Names="Times New Roman" Font-Size="Medium" Text="Sceret Question"></asp:Label>
       &nbsp;&nbsp;&nbsp;&nbsp;
       <asp:DropDownList ID="DDLSecurityQuest" runat="server" Width="170px">
           <asp:ListItem Selected="True">Select One</asp:ListItem>
           <asp:ListItem>What is your Phone Number?</asp:ListItem>
           <asp:ListItem>What is your PC Password?</asp:ListItem>
           <asp:ListItem>What is your best Friend Name?</asp:ListItem>
           <asp:ListItem>What is your Nick Name?</asp:ListItem>
       </asp:DropDownList>
       <br />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
           ControlToValidate="DDLSecurityQuest" 
           ErrorMessage="You must Enter your Secret Question" ForeColor="#CC0000" 
           style="font-size: large; font-family: 'Times New Roman', Times, serif"></asp:RequiredFieldValidator>
       <br />
       <asp:Label ID="Label11" runat="server" Font-Bold="True" 
           Font-Names="Times New Roman" Font-Size="Medium" Text="YourAnswer"></asp:Label>
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:TextBox ID="txtYAns" runat="server" Width="180px"></asp:TextBox>
       <br />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" 
           ControlToValidate="txtYAns" ErrorMessage="You must select your Answer" 
           ForeColor="#CC0000" 
           style="font-size: large; font-family: 'Times New Roman', Times, serif"></asp:RequiredFieldValidator>
       <br />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <br />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:Button ID="btnSubmit" runat="server" onclick="btnSubmit_Click" 
           Text="Submit" Width="70px" OnClientClick="return confirm('Do You Want to Register Your Account');" />
       <asp:CheckBox ID="CheckBox1" runat="server" Text="Set Cookies" 
           oncheckedchanged="CheckBox1_CheckedChanged" />
       <asp:Button ID="btnReset" runat="server" Text="Reset" Width="73px" />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br /> &nbsp;&nbsp; 
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:Label ID="LabelRU" runat="server" Font-Names="Times New Roman" 
           Font-Size="Medium" ForeColor="#CC0000" 
           Text="Your Account is Registered Successfully!.."></asp:Label>
       <br />
        </asp:panel>
</ContentTemplate>
</asp:UpdatePanel>
</asp:Content>

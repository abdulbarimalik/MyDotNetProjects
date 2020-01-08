<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Site1.Master" AutoEventWireup="true" CodeBehind="ViewBooks.aspx.cs" Inherits="WebsiteProjectBook.SimplePages.ViewBooks" %>
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
    .style3
  {
     overflow:scroll;
     width:528px;
     height:353px;
         margin-left: 0px;
     }
</style> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <p class="style1" style="background-position: center;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    <span class="style2"><strong>View Books</strong></span></p>
  
<asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
     <asp:Timer ID="Timer1" OnTick="Timer1_Tick" runat="server" Interval="3000" />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <Triggers>
            <asp:AsyncPostBackTrigger ControlID="Timer1" />
        </Triggers>
    <ContentTemplate>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br /> 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:Image ID="BannerImage" 
            runat="server" ImageUrl="../images/banner_1.gif" 
            Height="80px" Width="499px" />&nbsp;<br /> &nbsp;
            <asp:Panel ID="Panel1" GroupingText="View Books " runat="server" style="margin-left: 125px; text-align: left;" 
        Width="512px" Height="189px">
     <div class="style3">
    <br />
       
         <asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" 
             GridLines="None" style="margin-left: 2px" Width="503px" Height="314px">
             <AlternatingRowStyle BackColor="White" />
             <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
             <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
             <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
             <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
             <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
             <SortedAscendingCellStyle BackColor="#FDF5AC" />
             <SortedAscendingHeaderStyle BackColor="#4D0000" />
             <SortedDescendingCellStyle BackColor="#FCF6C0" />
             <SortedDescendingHeaderStyle BackColor="#820000" />
         </asp:GridView>
       
   </div>
</asp:Panel>
   </ContentTemplate>
</asp:UpdatePanel>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Site1.Master" AutoEventWireup="true" CodeBehind="ReportQuoteByAuthors.aspx.cs" Inherits="WebsiteProjectBook.SimplePages.ReportQuoteByAuthors" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
    .style1
  {
      width: 372px;
      background-color: Gray;
  }
    .style2
    {
        color: #000000;
        font-size: medium;
        font-family: "Times New Roman", Times, serif;
    }
    </style> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
<p class="style1" style="background-position: center center; height: 21px;">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <span class="style2"><strong>Report Quotation By Authors</strong></span></p>
<asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <br />
    <asp:Panel ID="Panel1" GroupingText="Report Quotation By Authors " runat="server" style="margin-left: 119px; text-align: left;" 
        Width="546px" Height="247px" BackColor="White" ForeColor="Black">
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" 
            Font-Size="8pt" Height="230px" InteractiveDeviceInfos="(Collection)" 
            WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="532px">
            <LocalReport ReportPath="SimplePages\Report2.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="SqlDataSource1" Name="DataSet1" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            InsertCommand="SPRptQuoteByAuthor" InsertCommandType="StoredProcedure" 
            SelectCommand="SPRptQuoteByAuthor" SelectCommandType="StoredProcedure">
        </asp:SqlDataSource>
        </asp:Panel>&nbsp;</p>&nbsp;&nbsp;&nbsp;&nbsp; 
</ContentTemplate>
</asp:UpdatePanel>
</asp:Content>

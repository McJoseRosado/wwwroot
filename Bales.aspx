<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true" CodeFile="Bales.aspx.cs" Inherits="RenuOil.Bales" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageHeadingContent" runat="server">
     <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <a id="lnkBales" runat="server" href="/NewBale.aspx">New Bale</a>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="sideBarContent" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="bottomContent" runat="server">
    
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="mainContent2" runat="server">
    <img src="http://i.imgur.com/0Ra2b99.png"/>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date"></asp:BoundField>
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"></asp:BoundField>
            <asp:BoundField DataField="Dock Name" HeaderText="Dock Name" SortExpression="Dock Name"></asp:BoundField>
            <asp:BoundField DataField="Commodity" HeaderText="Commodity" SortExpression="Commodity"></asp:BoundField>
            <asp:BoundField DataField="Initial Weight" HeaderText="Initial Weight" SortExpression="Initial Weight"></asp:BoundField>
            <asp:BoundField DataField="Bale Number" HeaderText="Bale Number" SortExpression="Bale Number"></asp:BoundField>
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:ConnectionString %>' SelectCommand="SELECT * FROM [Bales]"></asp:SqlDataSource>
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="sideBarContent2" runat="server">
</asp:Content>
<asp:Content ID="Content8" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>

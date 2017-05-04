<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/Main.Master" CodeFile="NewBale.aspx.cs" Inherits="RenuOil.NewBale" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    <telerik:RadGrid ID="RadGrid1" runat="server" CellSpacing="-1" DataSourceID="SqlDataSource1" GridLines="Both">
        <MasterTableView DataSourceID="SqlDataSource1" AutoGenerateColumns="False">
            <Columns>
                <telerik:GridBoundColumn DataField="Date" HeaderText="Date" SortExpression="Date" UniqueName="Date" DataType="System.DateTime" FilterControlAltText="Filter Date column"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Name" HeaderText="Name" SortExpression="Name" UniqueName="Name" FilterControlAltText="Filter Name column"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Dock Name" HeaderText="Dock Name" SortExpression="Dock Name" UniqueName="Dock_Name" FilterControlAltText="Filter Dock Name column"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Commodity" HeaderText="Commodity" SortExpression="Commodity" UniqueName="Commodity" FilterControlAltText="Filter Commodity column"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Initial Weight" HeaderText="Initial Weight" SortExpression="Initial Weight" UniqueName="Initial_Weight" FilterControlAltText="Filter Initial Weight column"></telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Bale Number" HeaderText="Bale Number" SortExpression="Bale Number" UniqueName="Bale_Number" FilterControlAltText="Filter Bale Number column"></telerik:GridBoundColumn>
            </Columns>
        </MasterTableView>
    </telerik:RadGrid>
    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:ConnectionString %>' SelectCommand="SELECT * FROM [Bales]"></asp:SqlDataSource>
        </asp:ScriptManager>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="sideBarContent" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="bottomContent" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="mainContent2" runat="server">
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="sideBarContent2" runat="server">
</asp:Content>
<asp:Content ID="Content8" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>

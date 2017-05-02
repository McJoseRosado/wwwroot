<%@ Page Title="Portal" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true"
    CodeFile="Loads.aspx.cs" Inherits="RenuOil.Loads" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" />
    <h3 style="vertical-align: middle; text-align: center;">Existing Loads</h3>
    <div>
        <table>
            <tr>
                <td style="vertical-align: middle;">Range:
                </td>
                <td style="vertical-align: middle;">8/12/2015:
                </td>
                <td style="vertical-align: middle;">8/13/2015:
                </td>
            </tr>
        </table>
    </div>
    <div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:ConnectionString %>' SelectCommand="SELECT * FROM [Load]">
        </asp:SqlDataSource>
<%-        <telerik:RadGrid ID="RGExisitingLoads" runat="server" OnNeedDataSource="RGExisitingLoads_NeedDataSource" AutoGenerateColumns="false" AllowSorting="true" AllowFilteringByColumn="true" AllowMultiRowEdit="false" AutoGenerateEditColumn="true" OnUpdateCommand="RGExisitingLoads_UpdateCommand">
            <MasterTableView TableLayout="Auto" EditMode="InPlace" DataKeyNames="LoadID">
                <Columns>
                    <telerik:GridBoundColumn DataField="LoadID" HeaderText="LoadId" AllowSorting="true" AllowFiltering="true"
                        UniqueName="LoadID" Visible="false" SortExpression="LoadId">
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="LoadDate" HeaderText="Date" AllowSorting="true" AllowFiltering="true"
                        UniqueName="Date" DataFormatString="{0:d}" SortExpression="LoadDate">
                        <ItemStyle Width="100px"></ItemStyle>
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="Driver" HeaderText="Driver" AllowSorting="true" AllowFiltering="true"
                        UniqueName="Driver"  SortExpression="Driver">
                        <ItemStyle Width="150px"></ItemStyle>
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="LoadNumber" DataType="System.Int32" HeaderText="Load Number" AllowSorting="true" AllowFiltering="true"
                        UniqueName="Load">
                        <ItemStyle Width="70px"></ItemStyle>
                    </telerik:GridBoundColumn>
                </Columns>
            </MasterTableView>
        </telerik:RadGrid>
         <asp:GridView ID="GVExisitingLoads" runat="server" AutoGenerateColumns="false" CssClass="grid" AllowPaging="true" PageSize="10" AllowSorting="true" >
            <Columns>
                <asp:BoundField HeaderText="Date" DataField="LoadDate" dataformatstring="{0:d}" SortExpression="LoadDate">
                    <ItemStyle Width="100px"></ItemStyle>
                 </asp:BoundField>
                <asp:BoundField HeaderText="Driver" DataField="Driver">
                    <ItemStyle Width="150px"></ItemStyle>
                </asp:BoundField>
               <asp:BoundField HeaderText="Load Number" DataField="LoadNumber">
                    <ItemStyle Width="70px"></ItemStyle>
                </asp:BoundField>
            </Columns>
        </asp:GridView> --%>
    </div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="sideBarContent" runat="server">
    <div class="sidebar nospace">
        <div class="sidebartop">
        </div>
        <div class="sidebarmain">
            <div class="sidebarcontent">
                <h4 class="sidebarheading">Side Note</h4>
                <p>
                </p>
                <div class="clear">
                </div>
            </div>
        </div>
        <div class="sidebarbottom">
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="bottomContent" runat="server">
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>

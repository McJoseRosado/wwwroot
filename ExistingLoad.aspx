<%@ Page Title="Portal" Language="C#" MasterPageFile="~/MasterPages/Portal.Master" AutoEventWireup="true"
    CodeBehind="ExistingLoad.aspx.cs" Inherits="RenuOil.ExistingLoad" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="slideshowContent" runat="server">
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
 <%--       <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:YBRDemoConnectionString %>" SelectCommand="SELECT * FROM [Load]" UpdateCommand="Update [Load] SET LoadDate=@LoadDate,Driver=@Driver,LoadNumber=@LoadNumber WHERE LoadID=@LoadID">
            <UpdateParameters>
                <asp:Parameter Name="LoadDate" />
                <asp:Parameter Name="Driver" />
                <asp:Parameter Name="LoadNumber" />
                <asp:Parameter Name="LoadID" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <telerik:RadGrid ID="RGExisitingLoads" 
            runat="server"
            OnNeedDataSource="RGExisitingLoads_NeedDataSource"
            AutoGenerateColumns="false"
            AllowSorting="true"
            AllowFilteringByColumn="true" 
            AllowMultiRowEdit="false" 
            AutoGenerateEditColumn="true" OnUpdateCommand="RGExisitingLoads_UpdateCommand"
            >
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
        </telerik:RadGrid>--%>
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
        </asp:GridView>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="featuresContent" runat="server">
    <ul>
        <!-- Features Box #1 -->
        <li class="first">
            <img src="images/bar-chart.png" class="alignleft" alt="" />
            <h4>
                <a href="#">Proof of Concept</a></h4>
            <div class="clear">
            </div>
            <p>
                These pages present the Chain of Custody - Proof of Concept.
            </p>
        </li>
        <!-- Features Box #2 -->
        <li>
            <img src="images/fancy-globe.png" class="alignleft" alt="" />
            <h4>
                <a href="#">Load</a></h4>
            <div class="clear">
            </div>
            <p>
                Page with controls to Create New Load, or edit existing load.
            </p>
        </li>
        <!-- Features Box #3 -->
        <li>
            <img src="images/processing.png" class="alignleft" alt="" />
            <h4>
                <a href="#">COC</a></h4>
            <div class="clear">
            </div>
            <p>
                Page with Controls to display / edit complete Chain of Custody
            </p>
        </li>
        <!-- Features Box #4 -->
        <li class="last">
            <img src="images/connections.png" class="alignleft" alt="" />
            <h4>
                <a href="#">Receiver</a></h4>
            <div class="clear">
            </div>
            <p>
                Page with Controls for Receiver data entry.
            </p>
        </li>
    </ul>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="mainContent" runat="server">
    <h3>COC Proof of concept.</h3>
    <p>
        UI for managing all aspects of materials handling (Chain of custody):
    </p>
    <div class="itemlist">
        <ul>
            <li>Load</li>
            <li>Existing Load</li>
            <li>COC</li>
            <li>Receiver View </li>
            <li>Validation</li>
        </ul>
    </div>
    <div class="spacer">
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

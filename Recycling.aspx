<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true" CodeBehind="Recycling.aspx.cs" Inherits="RenuOil.Recycling" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <h4><a href="#">Recycling</a></h4>
    <div style="float: left; padding-bottom: 10px;">
        <asp:Button ID="btnAddNewWorkOrder" runat="server" CssClass="button" Text="Add New Entry" UseSubmitBehavior="true" OnClick="btnAddNewWorkOrder_Click" />
        <br />
    </div>
    <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Always">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="rptRecyclingWorkOrders" />
            <asp:AsyncPostBackTrigger ControlID="btnUpdateWorkOrderList" />
        </Triggers>
        <ContentTemplate>
            <asp:Label ID="lblFromDate" Text="From:" CssClass="label" runat="server"></asp:Label>
            <telerik:RadDatePicker CssClass="radDatePicker" ID="rdFromDate" runat="server"></telerik:RadDatePicker>
            <asp:Label ID="lblToDate" Text="To:" CssClass="label" runat="server"></asp:Label>
            <telerik:RadDatePicker CssClass="radDatePicker" ID="rdToDate" runat="server"></telerik:RadDatePicker>
            <asp:Button ID="btnUpdateWorkOrderList" runat="server" CssClass="button" Text="Update" UseSubmitBehavior="true" OnClick="btnUpdateWorkOrderList_Click" />
            <div class="spacer">
                <hr />
            </div>
            <div id="messages" runat="server">
            </div>
            <div class="section" style="margin-top: 5px">
                <asp:MultiView ID="multiView" runat="server">
                    <asp:View ID="recyclingView" runat="server">
                        <asp:Repeater ID="rptRecyclingWorkOrders" runat="server" OnItemDataBound="rptWorkOrders_ItemDataBound" OnItemCommand="rptWorkOrders_ItemCommand">
                            <HeaderTemplate>
                                <table id="accountTable" cellspacing="0" class="repeater" width="600px">
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <table>
                                            <tr>
                                                <th>
                                                    <asp:Label ID="lblAccountName" runat="server"></asp:Label>
                                                </th>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Repeater ID="rptAcctWorkOrders" runat="server" OnItemDataBound="rptAcctWorkOrders_ItemDataBound" OnItemCommand="rptAcctWorkOrders_ItemCommand">
                                                        <HeaderTemplate>
                                                            <table id="accountWorkOrderTable" cellspacing="0" class="repeater">
                                                            </table>
                                                        </HeaderTemplate>
                                                        <ItemTemplate>
                                                            <tr>
                                                                <td>
                                                                    <asp:Label ID="lblAppointmentDate" runat="server">
                                                                    </asp:Label>
                                                                </td>
                                                                <td>
                                                                    <asp:Label ID="lblActionType" runat="server"></asp:Label>
                                                                </td>
                                                            </tr>
                                                        </ItemTemplate>
                                                    </asp:Repeater>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </ItemTemplate>
                            <FooterTemplate></table> </FooterTemplate>
                        </asp:Repeater>
                    </asp:View>
                </asp:MultiView>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="sideBarContent" runat="server"></asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="bottomContent" runat="server"></asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="mainContent2" runat="server"></asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="sideBarContent2" runat="server"></asp:Content>
<asp:Content ID="Content8" ContentPlaceHolderID="footerContent" runat="server"></asp:Content>

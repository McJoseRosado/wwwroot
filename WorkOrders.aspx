<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true" CodeBehind="WorkOrders.aspx.cs" Inherits="RenuOil.WorkOrders" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .selected {
            background-color: #D8D8D8;
            color: White;
        }

        .unselected {
            background-color: inherit;
        }

        .tab {
            font-size: 1em;
            padding: 5px 5px 5px 5px;
            margin: 6px 0;
            height: 70px;
            width: 120px;
            color: White;
            white-space: normal;
            border: 2px solid #D8D8D8;
            border-top-right-radius: 10px;
            border-top-left-radius: 10px;
        }

        .section {
            padding: 5px;
            border: 2px solid #D8D8D8;
            border-bottom-right-radius: 10px;
            border-bottom-left-radius: 10px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <h4><a href="#">Work Orders</a></h4>
    <div style="float: right; padding-bottom: 10px;">
        <asp:Button ID="btnAddNewWorkOrder" runat="server" CssClass="button" Text="Add New Work Order" UseSubmitBehavior="true" OnClick="btnAddNewWorkOrder_Click" />
        <br />
        <%--        <asp:Label ID="lblShowCompleted" CssClass="label" runat="server" Visible="false">Show completed work orders</asp:Label>        
        <asp:CheckBox ID="chkShowCompleted" CssClass="checkbox" runat="server" AutoPostBack="true" Visible="false" />--%>
    </div>
    <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Always">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="rptOilFiltrationWorkOrders" />
            <asp:AsyncPostBackTrigger ControlID="rptRecyclingWorkOrders" />
            <asp:AsyncPostBackTrigger ControlID="rptAssetWorkOrders" />
            <asp:AsyncPostBackTrigger ControlID="btnUpdateWorkOrderList" />
            <asp:AsyncPostBackTrigger ControlID="lnkBtnOilFiltration" />
            <asp:AsyncPostBackTrigger ControlID="lnkBtnRecycling" />
            <asp:AsyncPostBackTrigger ControlID="lnkBtnAsset" />
        </Triggers>
        <ContentTemplate>
            <asp:Label ID="lblFromDate" Text="From:" CssClass="label" runat="server"></asp:Label>
            <telerik:RadDatePicker CssClass="radDatePicker" ID="rdFromDate" runat="server"></telerik:RadDatePicker>
            <asp:Label ID="lblToDate" Text="To:" CssClass="label" runat="server"></asp:Label>
            <telerik:RadDatePicker CssClass="radDatePicker" ID="rdToDate" runat="server"></telerik:RadDatePicker>
            <asp:Label ID="lblAccount" Text="Account:" CssClass="label" runat="server"></asp:Label>
            <asp:DropDownList ID="ddlAccount" runat="server"></asp:DropDownList>
            <asp:Button ID="btnUpdateWorkOrderList" runat="server" CssClass="button" Text="Update" UseSubmitBehavior="true" OnClick="btnUpdateWorkOrderList_Click" />
            <div class="spacer">
                <hr />
            </div>
            <asp:LinkButton ID="lnkBtnOilFiltration" OnClick="changeToOilFiltrationView" CssClass="tab selected" Text="Oil Filtration" runat="server"></asp:LinkButton>
            <asp:LinkButton ID="lnkBtnRecycling" OnClick="changeToRecyclingView" CssClass="tab" Text="Recycling" runat="server"></asp:LinkButton>
            <asp:LinkButton ID="lnkBtnAsset" OnClick="changeToAssetView" CssClass="tab" Text="Asset" runat="server"></asp:LinkButton>
            <div class="section" style="margin-top: 5px">
                <asp:MultiView ID="multiView" runat="server">
                    <asp:View ID="oilFiltrationView" runat="server">
                        <asp:Repeater ID="rptOilFiltrationWorkOrders" runat="server" OnItemDataBound="rptWorkOrders_ItemDataBound" OnItemCommand="rptWorkOrders_ItemCommand">
                            <HeaderTemplate>
                                <table id="accountTable" cellspacing="0" class="repeater" width="600px">
                                    <tr>
                                        <th>Account </th>
                                        <th>Date </th>
                                        <th>Day of Week </th>
                                        <%--<th>Is Complete</th>--%>
                                        <th></th>
                                    </tr>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <strong>
                                            <asp:LinkButton ID="lnkBtnEditWorkOrder" Text="" CssClass="repeater" ToolTip="View Work Order" CommandName="Edit" CommandArgument='<%# Eval("WorkOrderId") %>' runat="server"></asp:LinkButton></strong>
                                    </td>
                                    <td style="width: 120px; text-align: center">
                                        <asp:Label ID="lblDate" runat="server"></asp:Label>
                                    </td>
                                    <td style="width: 120px; text-align: center">
                                        <asp:Label ID="lblDayOfWeek" runat="server"></asp:Label>
                                    </td>
                                    <%--<td style="width: 120px; text-align: center">
                                        <asp:Label ID="lblIsComplete" runat="server"></asp:Label>
                                    </td>--%>
                                    <%--<td style="width: 45px; text-align: center">
                                        <asp:LinkButton ID="lnkBtnDelete" Text="Delete" CssClass="repeater" CommandName="Delete" CommandArgument='<%# Eval("WorkOrderId") %>' runat="server" OnClientClick="javascript:return confirm('Are you sure you want to delete?');"></asp:LinkButton></center> </strong>
                                    </td>--%>
                                </tr>
                            </ItemTemplate>
                            <FooterTemplate></table> </FooterTemplate>
                        </asp:Repeater>
                    </asp:View>
                    <asp:View ID="recyclingView" runat="server">
                        <asp:Repeater ID="rptRecyclingWorkOrders" runat="server" OnItemDataBound="rptWorkOrders_ItemDataBound" OnItemCommand="rptWorkOrders_ItemCommand">
                            <HeaderTemplate>
                                <table id="accountTable" cellspacing="0" class="repeater" width="600px">
                                    <tr>
                                        <th>Account </th>
                                        <th>Date </th>
                                        <th>Day of Week </th>
                                        <%--<th>Is Complete? </th>--%>
                                        <th></th>
                                    </tr>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <strong>
                                            <asp:LinkButton ID="lnkBtnEditWorkOrder" Text="" CssClass="repeater" ToolTip="View Work Order" CommandName="Edit" CommandArgument='<%# Eval("WorkOrderId") %>' runat="server"></asp:LinkButton></strong>
                                    </td>
                                    <td style="width: 120px; text-align: center">
                                        <asp:Label ID="lblDate" runat="server"></asp:Label>
                                    </td>
                                    <td style="width: 120px; text-align: center">
                                        <asp:Label ID="lblDayOfWeek" runat="server"></asp:Label>
                                    </td>
                                    <%--<td style="width: 120px; text-align: center">
                                        <asp:Label ID="lblIsComplete" runat="server"></asp:Label>--%>
                                    </td>
                                    <td style="width: 45px; text-align: center">
                                        <asp:LinkButton ID="lnkBtnDelete" Text="Delete" CssClass="repeater" CommandName="Delete" CommandArgument='<%# Eval("WorkOrderId") %>' runat="server" OnClientClick="javascript:return confirm('Are you sure you want to delete?');"></asp:LinkButton></center> </strong>
                                    </td>
                                </tr>
                            </ItemTemplate>
                            <FooterTemplate></table> </FooterTemplate>
                        </asp:Repeater>
                    </asp:View>
                    <asp:View ID="assetView" runat="server">
                        <asp:Repeater ID="rptAssetWorkOrders" runat="server" OnItemDataBound="rptWorkOrders_ItemDataBound" OnItemCommand="rptWorkOrders_ItemCommand">
                            <HeaderTemplate>
                                <table id="accountTable" cellspacing="0" class="repeater" width="600px">
                                    <tr>
                                        <th>Account </th>
                                        <th>Date </th>
                                        <th>Day of Week</th>
                                        <%--<th>Is Complete? </th>--%>
                                        <th></th>
                                    </tr>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <strong>
                                            <asp:LinkButton ID="lnkBtnEditWorkOrder" Text="" CssClass="repeater" ToolTip="View Work Order" CommandName="Edit" CommandArgument='<%# Eval("WorkOrderId") %>' runat="server"></asp:LinkButton></strong>
                                    </td>
                                    <td style="width: 120px; text-align: center">
                                        <asp:Label ID="lblDate" runat="server"></asp:Label>
                                    </td>
                                    <td style="width: 120px; text-align: center">
                                        <asp:Label ID="lblDayOfWeek" runat="server"></asp:Label>
                                    </td>
                                    <%--                                    <td style="width: 120px; text-align: center">
                                        <asp:Label ID="lblIsComplete" runat="server"></asp:Label>
                                    </td>
                                    --%>
                                    <td style="width: 45px; text-align: center">
                                        <asp:LinkButton ID="lnkBtnDelete" Text="Delete" CssClass="repeater" CommandName="Delete" CommandArgument='<%# Eval("WorkOrderId") %>' runat="server" OnClientClick="javascript:return confirm('Are you sure you want to delete?');"></asp:LinkButton></center> </strong>
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
<asp:Content ID="Content5" ContentPlaceHolderID="bottomContent" runat="server"></asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="sideBarContent" runat="server">
    <div class="sidebar nospace">
        <div class="sidebartop">
        </div>
        <div class="sidebarmain">
            <div class="sidebarcontent">
                <h4 class="sidebarheading">Work Orders</h4>
                <p>This is a list of work orders within the specified date range.</p>
                <div class="clear">
                </div>
                <%--                <a href="#" class="button-more">View All News</a>--%>
            </div>
        </div>
        <div class="sidebarbottom">
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="footerContent" runat="server">
    <script type="text/javascript">
        function redirect(path) {
            //some code here
            window.location.href = window.location.origin.toString() + "/" + path;
        }
    </script>
</asp:Content>

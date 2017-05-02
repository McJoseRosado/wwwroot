<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true" CodeBehind="EditWorkOrder.aspx.cs" Inherits="RenuOil.EditWorkOrder" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .selected { background-color: #D8D8D8; color: White; }
        .unselected { background-color: inherit; }
        .tab { font-size: 1em; padding: 5px 5px 5px 5px; margin: 6px 0; height: 70px; width: 120px; color: White; white-space: normal; border: 2px solid #D8D8D8; border-top-right-radius: 10px; border-top-left-radius: 10px; }
        .section { padding: 5px; border: 2px solid #D8D8D8; border-bottom-right-radius: 10px; border-bottom-left-radius: 10px; }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <telerik:RadAjaxManager ID="RadAjaxManager2" runat="server"></telerik:RadAjaxManager>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="clear">
    </div>
    <br />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="sideBarContent" runat="server"></asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="bottomContent" runat="server">
    <h4><a id="workOrderTitle" runat="server"></a></h4>
    <asp:DropDownList ID="ddlEmailWorkOrder" runat="server" CssClass="dropdown" />
    <asp:Button ID="btnEmailWorkOrder" runat="server" CssClass="button" Text="Email" OnClick="btnEmailWorkOrder_Click" />
    <asp:Button ID="btnPrintWorkOrder" runat="server" CssClass="button" Text="Print Work Order" OnClick="btnPrintWorkOrder_Click" />
    <div class="clear">
    </div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="ddlAccount" />
            <asp:AsyncPostBackTrigger ControlID="rdServiceLocationsGrid" />
            <asp:AsyncPostBackTrigger ControlID="rdAssetTypeGrid" />
            <asp:AsyncPostBackTrigger ControlID="ddlWorkOrderType" />
            <asp:AsyncPostBackTrigger ControlID="rdDateWorkOrderDate" />
            <asp:PostBackTrigger ControlID="lbPrevious" />
        </Triggers>
        <ContentTemplate>
            <asp:UpdateProgress ID="upProgress" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                <ProgressTemplate>
                    <div class="info status-floater">
                        <br />
                        Processing, please wait...
                    </div>
                </ProgressTemplate>
            </asp:UpdateProgress>
            <div id="messages" runat="server">
                <div class="clear">
                </div>
            </div>
            <asp:Label ID="lblWorkOrderType" Text="Select Type:" CssClass="label" runat="server"></asp:Label>
            <asp:DropDownList ID="ddlWorkOrderType" runat="server" CssClass="title" AutoPostBack="true" Width="300px" OnSelectedIndexChanged="ddlWorkOrderType_OnSelectedIndexChanged">
                <asp:ListItem Text=" " Value=""></asp:ListItem>
                <asp:ListItem Text="Oil Filtration" Value="1"></asp:ListItem>
                <asp:ListItem Text="Recycling" Value="3"></asp:ListItem>
                <asp:ListItem Text="Asset Reclamation" Value="2"></asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="lblAcctName" Text="Select Account:" CssClass="label" runat="server"></asp:Label>
            <asp:DropDownList ID="ddlAccount" runat="server" CssClass="title" AutoPostBack="true" Width="300px" OnSelectedIndexChanged="ddlAccount_OnSelectedIndexChanged"></asp:DropDownList>
            <div id="divSelectDock" runat="server">
                <asp:Label ID="Label2" Text="Select Dock:" CssClass="label" runat="server" AutoPostBack="true"></asp:Label>
                <asp:DropDownList ID="ddlDocks" runat="server" AutoPostBack="true" Width="300px" OnSelectedIndexChanged="ddlDocks_OnSelectedIndexChanged"></asp:DropDownList>
            </div>
            <asp:Label ID="lblDate" Text="Date of Service:" CssClass="label" runat="server"></asp:Label>
            <telerik:RadDatePicker CssClass="radDatePicker" ID="rdDateWorkOrderDate" Width="300px" runat="server" OnSelectedDateChanged="radDatePicker_OnSelectedDateChanged"></telerik:RadDatePicker>
            <asp:Label ID="lblApptTime" Text="Time:" CssClass="label" runat="server"></asp:Label>
            <telerik:RadTimePicker ID="rdTimeApptTime" CssClass="radTimePicker" Width="300px" TimeView-Interval="00:30:00" runat="server"></telerik:RadTimePicker>
            <asp:Label ID="lblTechnician" Text="Select Technician:" CssClass="label" runat="server"></asp:Label>
            <asp:DropDownList ID="ddlTechnician" runat="server" Width="300px" CssClass="title"></asp:DropDownList>
            <%--            <asp:Label ID="lblCompleted" Text="Is Complete?" CssClass="label" runat="server"></asp:Label>
            <asp:CheckBox ID="chkCompleted" CssClass="checkbox" runat="server" />--%>
            <asp:Label ID="lblNotes" Text="Notes:" CssClass="label" runat="server"></asp:Label>
            <asp:TextBox ID="txtNotes" CssClass="multilineTextbox" Width="300px" runat="server" TextMode="MultiLine" MaxLength="200"></asp:TextBox>
            <asp:Label ID="lblPrevious" Text="Previous Work Order:" CssClass="label" runat="server"></asp:Label>
            <asp:LinkButton ID="lbPrevious" Text="Click to Open" runat="server" CssClass="linkButton" OnClick="lbPrevious_OnClick"></asp:LinkButton>
            <asp:Label ID="lblSignature" Text="Signature:" CssClass="label" runat="server"></asp:Label>
            <img alt="" id="imgSignature" class="signature" runat="server" width="250" height="60">
            <div id="divSaveCancel1" runat="server" style="float: right; padding-bottom: 10px;">
                <asp:Button ID="btnSaveWorkOrder" runat="server" CssClass="button" Text="Save Work Order" OnClick="btnSaveWorkOrder_Click" />
                <asp:Button ID="btnCancel" runat="server" CssClass="button" Text="Cancel" OnClick="btnCancel_Click" />
            </div>
            <div class="clear">
            </div>
            <hr />
            <div id="divFryerAccount" runat="server">
                <div class="clear">
                </div>
                <br />
                <telerik:RadGrid ID="rdServiceLocationsGrid" CssClass="" AllowPaging="false" ShowFooter="false" ShowGroupPanel="true" runat="server" Skin="" AutoGenerateColumns="False" AllowSorting="False" PageSize="3" GridLines="Both" BorderColor="ActiveBorder" OnItemDataBound="rdServiceLocationsGrid_OnItemDataBound" OnDetailTableDataBind="rdServiceLocationsGrid_DetailTableDataBind" CellPadding="0" AllowAutomaticUpdates="true">
                    <MasterTableView Name="MasterView" DataKeyNames="ServiceLocationId" AutoGenerateColumns="false" HorizontalAlign="Right" HierarchyDefaultExpanded="true" Width="900" EditMode="InPlace" ShowHeader="false" ShowFooter="false" NoDetailRecordsText="" NoMasterRecordsText="">
                        <Columns>
                            <telerik:GridBoundColumn HeaderText="ServiceLocationId" Visible="false" DataField="ServiceLocationId"></telerik:GridBoundColumn>
                            <telerik:GridTemplateColumn UniqueName="chkBoxSelectServiceLocation" HeaderText="" HeaderStyle-HorizontalAlign="Center" ItemStyle-Width="780" ItemStyle-HorizontalAlign="Left">
                                <ItemTemplate>
                                    <div style="margin-left: 15px; text-align: left; padding-bottom: 5px; vertical-align: middle">
                                        <asp:CheckBox ID="chkSelectServiceLocation" CssClass="title" Text="" runat="server" />
                                    </div>
                                    <div style="margin-bottom: 2px; vertical-align: top;">
                                        <asp:TextBox ID="txtServiceLocationNotes" runat="server" MaxLength="200" CssClass="multilineTextbox italic lightgray" Placeholder="Enter notes here." TextMode="SingleLine" ToolTip="Notes" Height="28" Width="98%"></asp:TextBox>
                                    </div>
                                    </script>
                                </ItemTemplate>
                                <ItemStyle CssClass="gridHeader gray" Height="30px" BorderColor="ActiveBorder" BorderWidth="1" VerticalAlign="Top" />
                            </telerik:GridTemplateColumn>
                            <%--                            <telerik:GridTemplateColumn UniqueName="assign" HeaderText="" HeaderStyle-HorizontalAlign="Center"
                                ItemStyle-Width="110" ItemStyle-HorizontalAlign="Left">
                                <ItemTemplate>
                                    <div style="vertical-align: bottom; text-align: center;">
                                        <div id="serviceAllByLabel" runat="server" class="italic">
                                            Service All By:
                                        </div>
                                        <br />
                                        <div style="float: right; margin-right: 10px; margin-bottom: 2px; vertical-align: middle">
                                            <asp:DropDownList ID="ddlAssignAllTo" runat="server" CssClass="workOrderDropdown"
                                                AutoPostBack="true" OnSelectedIndexChanged="ddlAssignAllTo_OnSelectedIndexChanged">
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </ItemTemplate>
                                <ItemStyle CssClass="gridHeader gray" Height="30px" Font-Bold="true" BorderColor="ActiveBorder"
                                    BorderWidth="1" VerticalAlign="Bottom" />
                            </telerik:GridTemplateColumn>--%>
                        </Columns>
                        <DetailTables>
                            <telerik:GridTableView DataKeyNames="DeepFryerId" Name="FryersView" Width="100%" HorizontalAlign="Right" Visible="true" ExpandCollapseColumn-Visible="false" ExpandCollapseColumn-Display="false" ShowHeader="true" ShowHeadersWhenNoRecords="false" HierarchyLoadMode="Client" FooterStyle-Height="10px" ShowFooter="true" EditMode="InPlace">
                                <Columns>
                                    <telerik:GridBoundColumn SortExpression="DeepFryerId" HeaderText="DeepFryerId" Visible="false" HeaderButtonType="TextButton" DataField="DeepFryerId" Display="false" ReadOnly="false" HeaderStyle-HorizontalAlign="Center"></telerik:GridBoundColumn>
                                    <telerik:GridTemplateColumn UniqueName="fryerName" HeaderText="" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Left">
                                        <ItemTemplate>
                                            <div style="margin-left: 50px">
                                                <asp:Label ID="lblName" Text="" runat="server"></asp:Label>
                                            </div>
                                        </ItemTemplate>
                                        <ItemStyle BorderColor="ActiveBorder" Font-Bold="true" CssClass="gridTextItalic gray" HorizontalAlign="Center" Width="250" />
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn UniqueName="Filter" HeaderText="Filter" HeaderStyle-HorizontalAlign="Center" ItemStyle-Width="45" ItemStyle-HorizontalAlign="Left">
                                        <ItemTemplate>
                                            <div>
                                                <asp:RadioButton ID="rdBtnFilter" runat="server" GroupName="fryerService" />
                                            </div>
                                        </ItemTemplate>
                                        <ItemStyle BorderColor="ActiveBorder" CssClass="gridTextItalic gray" HorizontalAlign="Center" />
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn UniqueName="Discard" HeaderText="Discard" HeaderStyle-HorizontalAlign="Center" ItemStyle-Width="45" ItemStyle-HorizontalAlign="Left">
                                        <ItemTemplate>
                                            <div>
                                                <asp:RadioButton ID="rdBtnDiscard" runat="server" GroupName="fryerService" />
                                            </div>
                                        </ItemTemplate>
                                        <ItemStyle BorderColor="ActiveBorder" CssClass="gridTextItalic gray" HorizontalAlign="Center" />
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn UniqueName="Relocate" HeaderText="Move" HeaderStyle-HorizontalAlign="Center" ItemStyle-Width="45" ItemStyle-HorizontalAlign="Left">
                                        <ItemTemplate>
                                            <div>
                                                <asp:RadioButton ID="rdBtnRelocate" runat="server" GroupName="fryerService" />
                                            </div>
                                        </ItemTemplate>
                                        <ItemStyle BorderColor="ActiveBorder" CssClass="gridTextItalic gray" HorizontalAlign="Center" />
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn UniqueName="Clean" HeaderText="Clean" HeaderStyle-HorizontalAlign="Center" ItemStyle-Width="45" ItemStyle-HorizontalAlign="Left">
                                        <ItemTemplate>
                                            <div>
                                                <asp:RadioButton ID="rdBtnClean" runat="server" GroupName="fryerService" />
                                            </div>
                                        </ItemTemplate>
                                        <ItemStyle BorderColor="ActiveBorder" CssClass="gridTextItalic gray" HorizontalAlign="Center" />
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn UniqueName="NoService" HeaderText="No Service" HeaderStyle-HorizontalAlign="Center" ItemStyle-Width="45" ItemStyle-HorizontalAlign="Left">
                                        <ItemTemplate>
                                            <div>
                                                <asp:RadioButton ID="rdBtnNoService" runat="server" GroupName="fryerService" />
                                            </div>
                                        </ItemTemplate>
                                        <ItemStyle BorderColor="ActiveBorder" CssClass="gridTextItalic gray" HorizontalAlign="Center" />
                                    </telerik:GridTemplateColumn>
                                    <%--                                    <telerik:GridTemplateColumn UniqueName="RelocateTo" HeaderText="Relocated To" HeaderStyle-HorizontalAlign="Center"
                                        ItemStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                            <div>
                                                <div style="float: none;">
                                                    <asp:DropDownList ID="ddlRelocateToServiceLocation" CssClass="workOrderDropdown"
                                                        runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlRelocateToServiceLocation_OnSelectedIndexChanged">
                                                    </asp:DropDownList>
                                                </div>
                                                <%--<asp:TextBox ID="txtRelocateTo" CssClass="gridtextbox" runat="server" Height="23px"></asp:TextBox>
                                            </div>
                                        </ItemTemplate>
                                        <ItemStyle BorderColor="ActiveBorder" CssClass="gridTextItalic gray" HorizontalAlign="Center" />
                                    </telerik:GridTemplateColumn>
                                    <telerik:GridTemplateColumn UniqueName="Service By" HeaderText="Serviced By" HeaderStyle-HorizontalAlign="Center"
                                        ItemStyle-Width="110" ItemStyle-HorizontalAlign="Left">
                                        <ItemTemplate>
                                            <div style="float: right; margin-right: 10px;">
                                                <asp:DropDownList ID="ddlEmployees" CssClass="workOrderDropdown" runat="server">
                                                </asp:DropDownList>
                                            </div>
                                        </ItemTemplate>
                                        <ItemStyle BorderColor="ActiveBorder" CssClass="gridText gray" HorizontalAlign="Center" />
                                    </telerik:GridTemplateColumn>--%>
                                </Columns>
                                <ItemStyle BorderColor="ActiveBorder" Height="22px" BackColor="#E8E8E8" CssClass="gridTextItalic gray" HorizontalAlign="Left" />
                                <AlternatingItemStyle Height="22px" BackColor="#E8E8E8" CssClass="gridTextItalic" HorizontalAlign="Left" BorderWidth="1" />
                                <HeaderStyle BorderColor="ActiveBorder" Font-Bold="true" CssClass="gridTextItalic gray" BorderWidth="1" />
                                <FooterStyle BackColor="#ffffff" Height="35px" BorderWidth="0" />
                                <NoRecordsTemplate>
                                    <br />
                                </NoRecordsTemplate>
                            </telerik:GridTableView>
                        </DetailTables>
                        <ItemStyle VerticalAlign="Middle" />
                    </MasterTableView>
                </telerik:RadGrid>
            </div>
            <div id="divAssetReclamationAccount" runat="server">
                <div class="clear">
                </div>
                <br />
                <%--                <asp:Menu ID="menu" Orientation="Horizontal" runat="server" OnMenuItemClick="menu_MenuItemClick">
                    <Items>
                        <asp:MenuItem Text="Asset Types" Value="AssetTypes" ></asp:MenuItem>
                        <asp:MenuItem Text="Recycling" Value="Recycling"></asp:MenuItem>
                    </Items>
                    <StaticMenuItemStyle BorderWidth="1" VerticalPadding="2" HorizontalPadding="2" ItemSpacing="5" />
                </asp:Menu>--%>
                <%--<asp:LinkButton ID="lnkBtnRecycling" OnClick="changeToRecyclingView" CssClass="tab selected"
                  Text="Recycling" runat="server"></asp:LinkButton>
                <asp:LinkButton ID="lnkBtnAssetTypes" OnClick="changeToAssetTypeView" CssClass="tab"
                    Text="Asset Reclamation" runat="server"></asp:LinkButton>--%>
                <div class="section" style="margin-top: 5px">
                    <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Always">
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="rdAssetTypeGrid" />
                        </Triggers>
                        <ContentTemplate>
                            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                            <asp:MultiView ID="multiView" runat="server">
                                <asp:View ID="assetTypeView" runat="server">
                                    <telerik:RadGrid ID="rdAssetTypeGrid" Skin="" AllowPaging="false" ShowFooter="true" GridLines="Both" runat="server" AutoGenerateColumns="False" AllowSorting="False" PageSize="3" OnItemDataBound="rdAssetTypeGrid_OnItemDataBound" OnDetailTableDataBind="rdAssetTypeGrid_DetailTableDataBind" AllowAutomaticUpdates="true" OnNeedDataSource="rdAssetTypeGrid_NeedDataSource">
                                        <MasterTableView DataKeyNames="AssetCategoryId" AutoGenerateColumns="false" HierarchyDefaultExpanded="true" EditMode="InPlace" OnDataBinding="rdAssetTypeGrid_OnDataBinding" ShowHeader="false" ShowFooter="false">
                                            <Columns>
                                                <telerik:GridBoundColumn SortExpression="AssetCategoryId" HeaderText="AssetCategoryId" Visible="false" ReadOnly="false" DataField="AssetCategoryId"></telerik:GridBoundColumn>
                                                <telerik:GridTemplateColumn UniqueName="AssetCategory" HeaderText="" HeaderStyle-HorizontalAlign="Center" ReadOnly="true">
                                                    <ItemTemplate>
                                                        <div style="text-align: left">
                                                            <%# Eval("Name") %></div>
                                                    </ItemTemplate>
                                                    <ItemStyle CssClass="gridHeader" />
                                                    <%--<ItemStyle Font-Bold="true" HorizontalAlign="Left" />--%>
                                                    <FooterStyle BorderColor="ActiveBorder" />
                                                </telerik:GridTemplateColumn>
                                            </Columns>
                                            <DetailTables>
                                                <telerik:GridTableView DataKeyNames="ServiceLocationAssetTypeId" Name="AssetTypeView" Width="100%" Visible="true" ShowHeader="true" ShowHeadersWhenNoRecords="false" HierarchyLoadMode="Client" HierarchyDefaultExpanded="true" FooterStyle-Height="10px" ShowFooter="false" EditMode="InPlace">
                                                    <Columns>
                                                        <telerik:GridBoundColumn SortExpression="ServiceLocationAssetTypeId" HeaderText="ServiceLocationAssetTypeId" Visible="false" ReadOnly="false" HeaderButtonType="TextButton" DataField="ServiceLocationAssetTypeId" Display="false" HeaderStyle-HorizontalAlign="Center"></telerik:GridBoundColumn>
                                                        <telerik:GridTemplateColumn UniqueName="AssetTypeName" HeaderText="Name" HeaderStyle-HorizontalAlign="Center">
                                                            <ItemTemplate>
                                                                <div style="text-align: center">
                                                                    <asp:Label ID="lblName" runat="server"></asp:Label>
                                                            </ItemTemplate>
                                                            <ItemStyle CssClass="gridTextItalic gray" Width="425px" BorderColor="ActiveBorder" />
                                                        </telerik:GridTemplateColumn>
                                                        <telerik:GridTemplateColumn UniqueName="AssetTypeSpanishName" HeaderText="Spanish Label" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center">
                                                            <ItemTemplate>
                                                                <div style="text-align: center">
                                                                    <asp:Label ID="lblSpanishName" runat="server"></asp:Label>
                                                            </ItemTemplate>
                                                            <ItemStyle CssClass="gridTextItalic gray" Width="425px" BorderColor="ActiveBorder" />
                                                        </telerik:GridTemplateColumn>
                                                        <telerik:GridTemplateColumn UniqueName="AssetTypePrice" HeaderText="Price Per Unit" DataField="PricePerUnit" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="100px">
                                                            <ItemTemplate>
                                                                <div style="text-align: center">
                                                                    <asp:Label ID="lblPricePerUnit" runat="server"></asp:Label>
                                                                </div>
                                                            </ItemTemplate>
                                                            <ItemStyle CssClass="gridText gray" BorderColor="ActiveBorder" Width="150" />
                                                        </telerik:GridTemplateColumn>
                                                        <telerik:GridTemplateColumn UniqueName="Quantity" HeaderText="Quantity" DataField="" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="100px">
                                                            <ItemTemplate>
                                                                <div style="text-align: center">
                                                                    <asp:TextBox ID="txtQuantity" runat="server" CssClass="quantityTextBox"></asp:TextBox>
                                                                </div>
                                                            </ItemTemplate>
                                                            <ItemStyle CssClass="gridText gray" BorderColor="ActiveBorder" />
                                                        </telerik:GridTemplateColumn>
                                                    </Columns>
                                                    <HeaderStyle Font-Bold="true" CssClass="gridTextItalic" BorderWidth="0" />
                                                </telerik:GridTableView>
                                            </DetailTables>
                                        </MasterTableView>
                                    </telerik:RadGrid>
                                    <div class="spacer">
                                    </div>
                                    <div style="margin-left: 20px; margin-top: 20px;">
                                        <div class="gridHeader">
                                            UNCATEGORIZED ITEMS:</div>
                                        <asp:TextBox ID="txtUncategorizedItems" runat="server" TextMode="MultiLine" Width="98%" CssClass="textbox">
                                        </asp:TextBox>
                                    </div>
                                </asp:View>
                            </asp:MultiView>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <div class="spacer">
                    </div>
                </div>
            </div>
            <div id="divRecycle" runat="server">
                <div class="clear">
                </div>
                <br />
                <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Always">
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="btnOpenAct" />
                        <asp:AsyncPostBackTrigger ControlID="btnSaveAct" />
                        <asp:AsyncPostBackTrigger ControlID="btnCncAct" />
                    </Triggers>
                    <ContentTemplate>
                        <span id="actionMessages" runat="server"></span>
                        <div id="addAction" runat="server" visible="true">
                            <asp:Button ID="btnOpenAct" runat="server" CssClass="button" Text="Add Action" OnClick="btnopenAction_Click" Style="float: none !important;" />
                        </div>
                        <br />
                        <div id="infoAction" runat="server" visible="false" style="background-color: #ddd; margin-bottom: 10px;">
                            <table>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblActTime" Text="Action Date" CssClass="label" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <telerik:RadDatePicker CssClass="radDatePicker" ID="rdpActionDate" runat="server"></telerik:RadDatePicker>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="Label1" Text="Action Time" CssClass="label" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <telerik:RadTimePicker ID="rtpActionTime" CssClass="radTimePicker" TimeView-Interval="00:30:00" runat="server"></telerik:RadTimePicker>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblNoBags" Text="Number of Bags:" CssClass="label" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtNoBags" CssClass="textbox" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblNoBales" Text="Number of Bales:" CssClass="label" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtNoBales" CssClass="textbox" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblWtBag" Text="Weight of Bags:" CssClass="label" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtWtBag" CssClass="textbox" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblWtBale" Text="Weight of Bales:" CssClass="label" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtWtBale" CssClass="textbox" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="label">Recycle Type:</span>
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlRecycleType" runat="server"></asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblEstimate" Text="Action:" CssClass="label" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlActionType" runat="server">
                                            <asp:ListItem Selected="True" Value="O">Observed</asp:ListItem>
                                            <asp:ListItem Value="A">Actual</asp:ListItem>
                                            <asp:ListItem Value="P">Picked Up</asp:ListItem>
                                            <asp:ListItem Value="D">Facility Drop</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <%-- <tr>
                                    <td>
                                        <asp:Label ID="Label3" Text="Dock:" CssClass="label" runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="ddlDocks1" runat="server">
                                        </asp:DropDownList>
                                    </td>
                                </tr>--%>
                            </table>
                            <br />
                            <asp:Button ID="btnCncAct" runat="server" CssClass="button" Text="Cancel Action" Style="float: none !important; margin-left: 10px;" OnClick="btnCnclAction_Click" />
                            <asp:Button ID="btnSaveAct" runat="server" CssClass="button" Text="Save Action" OnClick="btnSaveAction_Click" Style="float: none !important;" />
                        </div>
                        <div>
                            <table>
                                <thead>
                                    <tr align="center">
                                        <td align="center" style="font-size: medium">
                                            Time
                                        </td>
                                        <td align="center" style="font-size: medium">
                                            Number of Bags
                                        </td>
                                        <td align="center" style="font-size: medium">
                                            Weight of Bags
                                        </td>
                                        <td align="center" style="font-size: medium">
                                            Number of Bales
                                        </td>
                                        <td align="center" style="font-size: medium">
                                            Weight of Bales
                                        </td>
                                        <td align="center" style="font-size: medium">
                                            Recycle Type
                                        </td>
                                        <td align="center" style="font-size: medium">
                                            Action
                                        </td>
                                        <td align="center" style="font-size: medium">
                                            Edit
                                        </td>
                                    </tr>
                                </thead>
                                <tbody>
                                    <asp:Repeater ID="rptActionListing" runat="server" OnItemCommand="rptActionListing_OnItemCommand">
                                        <HeaderTemplate></HeaderTemplate>
                                        <ItemTemplate>
                                            <tr>
                                                <td align="center">
                                                    <span class="label" style="width: 120px !important">
                                                        <%# Eval("ActionTime", "{0:MM/dd/yyyy hh:mm tt}") %></span>
                                                </td>
                                                <td align="center">
                                                    <span class="label" style="width: 90px !important">
                                                        <%# Eval("NumberOfBags") %></span>
                                                </td>
                                                <td align="center">
                                                    <span class="label" style="width: 90px !important">
                                                        <%# Eval("BagsWeight") %></span>
                                                </td>
                                                <td align="center">
                                                    <span class="label" style="width: 90px !important">
                                                        <%# Eval("NumberOfBales") %></span>
                                                </td>
                                                <td align="center">
                                                    <span class="label" style="width: 100px !important">
                                                        <%# Eval("BalesWeight") %></span>
                                                </td>
                                                <td align="center">
                                                    <span class="label" style="width: 90px !important">
                                                        <%# Eval("RecycleTypeName") %></span>
                                                </td>
                                                <td align="center">
                                                    <span class="label" style="width: 90px !important">
                                                        <%# Eval("Action") %></span>
                                                </td>
                                                <td align="center">
                                                    <asp:LinkButton ID="lnkBtnEdit" Text="Edit" CssClass="linkButton" Style="width: 90px !important" CommandName="Edit" CommandArgument='<%# Eval("recycleServiceActionId") %>' runat="server"></asp:LinkButton>
                                                </td>
                                            </tr>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </tbody>
                            </table>
                        </div>
                        <div class="spacer">
                            <br />
                        </div>
                        <hr />
                        <div id="previousValues" runat="server" visible="false">
                            <h5>Previous Data:</h5>
                            <asp:Label ID="lblPrevEnteredBy" Text="Entered By:  " CssClass="longlabel" runat="server"></asp:Label>
                            <asp:Label ID="lblPrevNumberOfBales" Text="Number of Bales:  " CssClass="longlabel" runat="server"></asp:Label>
                            <asp:Label ID="lblPrevBalesWeight" Text="Weight of Bales:  " CssClass="longlabel" runat="server"></asp:Label>
                            <asp:Label ID="lblPrevNumberOfBags" Text="Number of Bags:  " CssClass="longlabel" runat="server"></asp:Label>
                            <asp:Label ID="lblPrevBagsWeight" Text="Weight of Bags:  " CssClass="longlabel" runat="server"></asp:Label>
                        </div>
                        <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
                        <div>
                            <h4>Summary Totals</h4>
                            <table>
                                <thead>
                                    <tr align="center">
                                        <td align="center" style="font-size: medium">
                                            Action Type
                                        </td>
                                        <td align="center" style="font-size: medium">
                                            Number of Bags
                                        </td>
                                        <td align="center" style="font-size: medium">
                                            Weight of Bags
                                        </td>
                                        <td align="center" style="font-size: medium">
                                            Number of Bales
                                        </td>
                                        <td align="center" style="font-size: medium">
                                            Weight of Bales
                                        </td>
                                    </tr>
                                </thead>
                                <tbody>
                                    <asp:Repeater ID="rptTotals" runat="server">
                                        <HeaderTemplate></HeaderTemplate>
                                        <ItemTemplate>
                                            <tr>
                                                <td align="center">
                                                    <span class="label" style="width: 110px !important">
                                                        <%# Eval("Action") %></span>
                                                </td>
                                                <td align="center">
                                                    <span class="label" style="width: 110px !important">
                                                        <%# Eval("NumberOfBags")%></span>
                                                </td>
                                                <td align="center">
                                                    <span class="label" style="width: 110px !important">
                                                        <%# Eval("WeightOfBags")%></span>
                                                </td>
                                                <td align="center">
                                                    <span class="label" style="width: 110px !important">
                                                        <%# Eval("NumberOfBales")%></span>
                                                </td>
                                                <td align="center">
                                                    <span class="label" style="width: 110px !important">
                                                        <%# Eval("WeightOfBales")%></span>
                                                </td>
                                            </tr>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </tbody>
                            </table>
                        </div>
                        <%--<asp:Label ID="lblNumberOfBales" Text="Number of Bales:" CssClass="label" Visible="false"
                            runat="server"></asp:Label>
                        <asp:TextBox ID="txtNumberOfBales" CssClass="textbox" Visible="false" runat="server"></asp:TextBox>
                        <asp:Label ID="lblWeightOfBales" Text="Weight of Bales:" Visible="false" CssClass="label"
                            runat="server"></asp:Label>
                        <asp:TextBox ID="txtWeightOfBales" CssClass="textbox" Visible="false" runat="server"></asp:TextBox>
                        <div class="spacer">
                            <br />
                        </div>
                        <asp:Label ID="lblNumberOfBags" Text="Number of Bags:" Visible="false" CssClass="label"
                            runat="server"></asp:Label>
                        <asp:TextBox ID="txtNumberOfBags" CssClass="textbox" Visible="false" runat="server"></asp:TextBox>
                        <asp:Label ID="lblWeightOfBags" Text="Weight of Bags:" Visible="false" CssClass="label"
                            runat="server"></asp:Label>
                        <asp:TextBox ID="txtWeightOfBags" CssClass="textbox" Visible="false" runat="server"></asp:TextBox>--%>
                        <div class="spacer">
                            <br />
                        </div>
                        <hr />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <div id="divSaveCancel2" runat="server" style="float: right; padding-bottom: 10px;">
                <asp:Button ID="btnSaveWorkOrder2" runat="server" CssClass="button" Text="Save Work Order" OnClick="btnSaveWorkOrder_Click" />
                <asp:Button ID="btnCancel2" runat="server" CssClass="button" Text="Cancel" OnClick="btnCancel_Click" />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="footerContent" runat="server"></asp:Content>

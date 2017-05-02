<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true" CodeBehind="EditOilFiltrationWorkOrder.aspx.cs" Inherits="RenuOil.EditOilFiltrationWorkOrder" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="include/bootstrap/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="include/css/coc_style.css" rel="stylesheet" type="text/css" />
    <link href="include/datetimepicker/bootstrap-datetimepicker.css" rel="stylesheet"
        type="text/css" />

    <style type="text/css">
        .hidden {
            display: none;
        }

        body {
            background-color: #2888BF;
        }

        .row {
            margin-bottom: 10px;
        }

        .panel-heading {
            cursor: pointer;
        }

        a.btn-danger {
            text-decoration:none;
            color:white;
        }
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

    <div class="container-fluid">
        <div class="row">
            <div class="col-sm-12">
                <h3 runat="server" id="workOrderTitle">Work Orders</h3>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <hr />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <div class="col-sm-5">
                    <select class="form-control" runat="server" id="ddlEmailWorkOrder">
                    </select>
                </div>
                <div class="col-sm-3">
                    <button class="btn btn-info">EMAIL</button>
                </div>
                <div class="col-sm-4">
                    <button class="btn btn-success" runat="server" onserverclick="btnPrintWorkOrder_Click">PRINT WORK ORDER</button>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-sm-12">
                <hr />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <select class="form-control workOrderTypeInput" runat="server" id="selectedWorkOrderType">
                </select>
            </div>
        </div>


        <div class="row">
            <div class="col-sm-12">
                <select class="form-control accountInput" runat="server" id="accountsList" >
                </select>
            </div>
        </div>

        <div class="row">
            <div class="col-sm-6">
                <input class="form-control datetimepicker dateInput" placeholder="" runat="server" id="selectedDate" />
            </div>
            <div class="col-sm-6">
                <input type='text' class="form-control datetimepicker timeInput"  runat="server" id="selectedTime" />
            </div>
        </div>

        <div class="row">
            <div class="col-sm-12">
                <select class="form-control technicanIdInput" runat="server" id="techniciansList">
                </select>
            </div>
        </div>

        <div class="row">
            <div class="col-sm-12">
                <input type="text" class="form-control notesInput" placeholder="Notes" runat="server" id="notes"/>
            </div>
        </div>

        <div class="row">
            <div class="col-sm-12">
                    <button class="btn btn-success btnSaveWorkOrderBtn">Save Work Order</button>
                    <a href="WorkOrders.aspx" class="btn btn-danger">Cancel</a>
            </div>
        </div>
    </div>
    <!--end content-fuild-->
    <hr />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="sideBarContent" runat="server">
    <div class="sidebar nospace">
        <div class="sidebartop">
        </div>
        <div class="sidebarmain">
            <div class="sidebarcontent">
                <h4 class="sidebarheading">Edit Work Order</h4>
                <p></p>
                <div class="clear">
                </div>
            </div>
        </div>
        <div class="sidebarbottom">
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="bottomContent" runat="server">

    <div class="container-fluid">
        <!--start content-->
        <div class="row">
            <div class="col-sm-12">
                <div class="panel-group" id="accordion" role="tablist" aria-multiselectable="true">

                    <% 
                        for (int i = 0; i < ServiceLocations.Count; i++)
                        {
                            var location = ServiceLocations[i];
                    %>
                    <div class="panel panel-default" serviceLocationTitle="<%= location.Name %>" serviceLocationId="<%= location.ServiceLocationId %>" >
                        <div class="panel-heading" role="tab" id="heading<%= i.ToString() %>" data-toggle="collapse" href="#collapse<%= i.ToString() %>" aria-expanded="true" aria-controls="collapse<%= i.ToString() %>">
                            <h4 class="panel-title"><%= location.Name %></h4>
                        </div>
                        <div id="collapse<%= i.ToString() %>" class="panel-collapse collapse in" role="tabpanel" aria-labelledby="heading<%= i.ToString() %>">
                            <div class="panel-body">
                                <div class="panel-body">
                                    <div class="row">
                                        <div class="col-sm-12">
                                            <input class="form-control serviceLocationNotes" type="text" placeholder="" value="<%= location.Notes %>" />
                                        </div>
                                    </div>

                                    <table class="table table-bordered serviceTable deepFryTable">
                                        <thead>
                                            <tr>
                                                <td></td>
                                                <td>Filter</td>
                                                <td>Discard</td>
                                                <td>Move</td>
                                                <td>Clean</td>
                                                <td>No Service</td>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <%
                                                var activeFryers = location.DeepFryer.Where(d => d.IsActive == true).ToList();
                                                for (int x = 0; x < activeFryers.Count; x++)
                                                {
                                                    var deepFryer = activeFryers[x];
                                                    
                                                    var workOrderServiceLocation = WorkOrderServiceLocations.Single(s => s.ServiceLocationId == deepFryer.ServiceLocationId 
                                                        && s.WorkOrderId == _workOrderId);

                                                    var deepFryerService = DeepFryerServices.FirstOrDefault(d =>
                                                            d.DeepFryerId == deepFryer.DeepFryerId &&
                                                            d.WorkOrderServiceLocationId == workOrderServiceLocation.WorkOrderServiceLocationId
                                                        );
                                                    
                                                    %>                                                 
                                                    <tr deepFryerWorkServiceId="<%= deepFryerService.DeepFryerServiceId %>" deepFryId="<%= deepFryer.DeepFryerId %>">
                                                        <td><%= deepFryer.Name %></td>
                                                        <td class="radioCell">
                                                            <% if (deepFryerService.Filtered.HasValue && deepFryerService.Filtered.Value)
                                                               {%>
                                                                   <input optionName="filter" type="radio" name="group<%= i.ToString() + x.ToString() %>" checked="checked"/>
                                                               <%}else{ %>
                                                                    <input optionName="filter" type="radio" name="group<%= i.ToString() + x.ToString() %>"/>
                                                            <%} %>                                                            
                                                        </td>
                                                        <td class="radioCell">
                                                            <% if (deepFryerService.Discarded.HasValue && deepFryerService.Discarded.Value)
                                                               {%>
                                                                   <input optionName="discard" type="radio" name="group<%= i.ToString() + x.ToString() %>" checked="checked"/>
                                                               <%}else{ %>
                                                                    <input optionName="discard" type="radio" name="group<%= i.ToString() + x.ToString() %>"/>
                                                            <%} %>
                                                        </td>
                                                        <td class="radioCell">
                                                            <% if (deepFryerService.Relocated.HasValue && deepFryerService.Relocated.Value)
                                                               {%>
                                                                   <input optionName="move" type="radio" name="group<%= i.ToString() + x.ToString() %>" checked="checked"/>
                                                               <%}else{ %>
                                                                    <input optionName="move" type="radio" name="group<%= i.ToString() + x.ToString() %>"/>
                                                            <%} %>
                                                        </td>
                                                        <td class="radioCell">
                                                            <% if (deepFryerService.Cleaned.HasValue && deepFryerService.Cleaned.Value)
                                                               {%>
                                                                   <input optionName="clean" type="radio" name="group<%= i.ToString() + x.ToString() %>" checked="checked"/>
                                                               <%}else{ %>
                                                                    <input optionName="clean" type="radio" name="group<%= i.ToString() + x.ToString() %>"/>
                                                            <%} %>
                                                        </td>
                                                        <td class="radioCell">
                                                            <% if (deepFryerService.NoService.HasValue && deepFryerService.NoService.Value)
                                                               {%>
                                                                   <input optionName="no service" type="radio" name="group<%= i.ToString() + x.ToString() %>" checked="checked"/>
                                                               <%}else{ %>
                                                                    <input optionName="no service" type="radio" name="group<%= i.ToString() + x.ToString() %>"/>
                                                            <%} %>
                                                        </td>
                                                </tr>
                                            <%} %>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                    <%} %>
                </div>
            </div>
        </div>
    </div>



    <%--<h4><a id="workOrderTitle" runat="server"></a></h4>
    <asp:DropDownList ID="ddlEmailWorkOrder" runat="server" CssClass="dropdown" />
    <asp:Button ID="btnEmailWorkOrder" runat="server" CssClass="button" Text="Email" OnClick="btnEmailWorkOrder_Click" />
    <asp:Button ID="btnPrintWorkOrder" runat="server" CssClass="button" Text="Print Work Order" OnClick="btnPrintWorkOrder_Click" />
    <div class="clear">
    </div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
           <ContentTemplate>
            <div id="divAssetReclamationAccount" runat="server">
                <div class="clear">
                </div>
                <br />
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
                                                            <%# Eval("Name") %>
                                                        </div>
                                                    </ItemTemplate>
                                                    <ItemStyle CssClass="gridHeader" />
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
                                            UNCATEGORIZED ITEMS:
                                        </div>
                                        <asp:TextBox ID="txtUncategorizedItems" runat="server" TextMode="MultiLine" Width="98%" CssClass="textbox uncategorizedTextInput">
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
                            </table>
                            <br />
                            <asp:Button ID="btnCncAct" runat="server" CssClass="button" Text="Cancel Action" Style="float: none !important; margin-left: 10px;" OnClick="btnCnclAction_Click" />
                            <asp:Button ID="btnSaveAct" runat="server" CssClass="button" Text="Save Action" OnClick="btnSaveAction_Click" Style="float: none !important;" />
                        </div>
                        <div>
                            <table>
                                <thead>
                                    <tr align="center">
                                        <td align="center" style="font-size: medium">Time
                                        </td>
                                        <td align="center" style="font-size: medium">Number of Bags
                                        </td>
                                        <td align="center" style="font-size: medium">Weight of Bags
                                        </td>
                                        <td align="center" style="font-size: medium">Number of Bales
                                        </td>
                                        <td align="center" style="font-size: medium">Weight of Bales
                                        </td>
                                        <td align="center" style="font-size: medium">Recycle Type
                                        </td>
                                        <td align="center" style="font-size: medium">Action
                                        </td>
                                        <td align="center" style="font-size: medium">Edit
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
                                        <td align="center" style="font-size: medium">Action Type
                                        </td>
                                        <td align="center" style="font-size: medium">Number of Bags
                                        </td>
                                        <td align="center" style="font-size: medium">Weight of Bags
                                        </td>
                                        <td align="center" style="font-size: medium">Number of Bales
                                        </td>
                                        <td align="center" style="font-size: medium">Weight of Bales
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
                        <div class="spacer">
                            <br />
                        </div>
                        <hr />
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <div id="divSaveCancel2" runat="server" style="float: right; padding-bottom: 10px;">
                <asp:Button ID="btnSaveWorkOrder2" runat="server" CssClass="button btnSaveWorkOrderBtn" Text="Save Work Order" OnClick="btnSaveWorkOrder_Click" />
                <asp:Button ID="btnCancel2" runat="server" CssClass="button" Text="Cancel" OnClick="btnCancel_Click" />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>--%>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="footerContent" runat="server">
    <script type="text/javascript" src="js/jquery.js"></script>
    <script type="text/javascript" src="include/datetimepicker/moment.min.js"></script>
    <script type="text/javascript" src="include/bootstrap/js/bootstrap.min.js"></script>
    <script type="text/javascript" src="include/datepicker/js/bootstrap-datepicker.min.js"></script>
    <script type="text/javascript" src="include/datetimepicker/bootstrap-datetimepicker.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $('.datetimepicker').datetimepicker({
            });

            //click cell to select radio
            $( "body" ).on( "click", ".radioCell",function (e) {
                $(this).find("input[type=radio]").prop("checked", "checked");
            });

            var getUrlParameter = function getUrlParameter(sParam) {
                var sPageURL = decodeURIComponent(window.location.search.substring(1)),
                    sURLVariables = sPageURL.split('&'),
                    sParameterName,
                    i;

                for (i = 0; i < sURLVariables.length; i++) {
                    sParameterName = sURLVariables[i].split('=');

                    if (sParameterName[0] === sParam) {
                        return sParameterName[1] === undefined ? true : sParameterName[1];
                    }
                }
            };

            $( "body" ).on( "click", ".btnSaveWorkOrderBtn",function (e) {
                e.preventDefault();

                var accountId = $(".accountInput").val();
                var workOrderId = getUrlParameter('id');
                var technicanId = $(".technicanIdInput").val();
                var orderTypeId = $(".workOrderTypeInput").val();
                var dockId = $(".dockIdInput").val();
                var notes = $(".notesInput").val();
                var uncategorizedText = $(".uncategorizedTextInput").val();
                var date = $(".dateInput").val();
                var time = $(".timeInput").val();

                if (dockId == undefined) {
                    dockId = null;
                }
                if (uncategorizedText == undefined) {
                    uncategorizedText = null;
                }

                var deepFryerItems = [];

                $.each($(".panel-default"), function (index, table) {
                    var item = {};
                    item.ServiceLocationId = $(this).attr("serviceLocationId");
                    item.deepFryDetailItemServiceLocationTitle = $(this).attr("serviceLocationTitle");
                    item.deepFryDetailItemServiceLocationNotes = $(this).find(".serviceLocationNotes").val();
                    item.isSelected = true; // all true for now
                    //item.isSelected = $(this).find(".deepFryDetailItemServiceLocationTitle input").is(":checked") == true ? true : false;
                    item.deepFryServices = [];

                    var services = $(this).find(".deepFryTable tbody tr");

                    if (services.length > 0) {
                        $.each($(services), function (index2, table) {

                            var deepFryService = {};
                            deepFryService.deepFryServiceId = $(this).attr("deepFryerWorkServiceId");
                            deepFryService.DeepFryId = $(this).attr("deepFryId");

                            if (deepFryService.deepFryServiceId != undefined) {
                                deepFryService.FliterChecked = false;
                                deepFryService.DiscardChecked = false;
                                deepFryService.RelocatedChecked = false;
                                deepFryService.CleanChecked = false;
                                deepFryService.NoServiceChecked = false;

                                var checkedCheckBox = $(this).find("input[type=radio]:checked")[0];
                                var checkedCheckBoxName = $(checkedCheckBox).attr("optionName");

                                switch (checkedCheckBoxName) {
                                    case "filter":
                                        deepFryService.FliterChecked = true;
                                        break;
                                    case "discard":
                                        deepFryService.DiscardChecked = true;
                                        break;
                                    case "move":
                                        deepFryService.RelocatedChecked = true;
                                        break;
                                    case "clean":
                                        deepFryService.CleanChecked = true;
                                        break;
                                    case "no service":
                                        deepFryService.NoServiceChecked = true;
                                        break;
                                    default:
                                        return;
                                        break;
                                }

                                item.deepFryServices.push(deepFryService);
                            }
                        });
                    }

                    if (item.ServiceLocationId != undefined) {
                        deepFryerItems.push(item);
                    }
                });

                var jsonData =
                JSON.stringify({
                    accountId: accountId,
                    workOrderId: workOrderId,
                    technicanId: technicanId,
                    orderTypeId: orderTypeId,
                    dockId: dockId,
                    date: date,
                    time: time,
                    notes: notes,
                    uncategorizedText: uncategorizedText,
                    deepFryerItems: JSON.stringify(deepFryerItems)
                });

                $.ajax({
                    url: "EditOilFiltrationWorkOrder.aspx/SaveWorkOrder",
                    data: jsonData,
                    contentType: "application/json",
                    type: "post",
                    dataType: "json",
                    success: function (data) {
                        var result = jQuery.parseJSON(data.d);
                        if (result.Success) {
                            window.location.href = window.location.origin.toString() + "/" + result.Path;
                        } else {
                            console.log("Failed.");
                        }
                    }
                })
            });


        });
    </script>
</asp:Content>

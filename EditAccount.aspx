<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="True" CodeBehind="EditAccount.aspx.cs" Inherits="RenuOil.EditAccount" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .selected { background-color: #D8D8D8; color: White; }
        .unselected { background-color: inherit; }
        .tab { font-size: 1em; padding: 5px 5px 5px 5px; margin: 6px 0; height: 70px; width: 120px; color: White; white-space: normal; border: 2px solid #D8D8D8; border-top-right-radius: 10px; border-top-left-radius: 10px; }
        .section { padding: 5px; border: 2px solid #D8D8D8; border-bottom-right-radius: 10px; border-bottom-left-radius: 10px; }
        .recyclingTable { width: 50%; padding: 10px; }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <asp:ScriptManager ID="scriptMgr" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
        <Triggers>
            <%--<asp:AsyncPostBackTrigger ControlID="btnSaveAccount" />--%>
        </Triggers>
        <ContentTemplate>
            <h4><a id="accountNameTitle" runat="server"></a></h4>
            <div id="messages" runat="server">
                <div class="clear">
                </div>
            </div>
            <asp:Label ID="lblAcctName" Text="Account Name:" CssClass="label" runat="server"></asp:Label>
            <asp:TextBox ID="txtAcctName" CssClass="textbox" runat="server"></asp:TextBox>
            <asp:Label ID="lblAcctNo" Text="Account No:" CssClass="label" runat="server"></asp:Label>
            <asp:TextBox ID="txtAcctNo" CssClass="textbox" runat="server"></asp:TextBox>
            <asp:Label ID="lblAddress1" Text="Address 1:" CssClass="label" runat="server"></asp:Label>
            <asp:TextBox ID="txtAddress1" CssClass="textbox" runat="server"></asp:TextBox>
            <asp:Label ID="lblAddress2" Text="Address 2:" CssClass="label" runat="server"></asp:Label>
            <asp:TextBox ID="txtAddress2" CssClass="textbox" runat="server"></asp:TextBox>
            <asp:Label ID="lblCity" Text="City:" CssClass="label" runat="server"></asp:Label>
            <asp:TextBox ID="txtCity" CssClass="textbox" runat="server"></asp:TextBox>
            <asp:Label ID="lblState" Text="State:" CssClass="label" runat="server"></asp:Label>
            <asp:DropDownList ID="ddlState" runat="server" onkeypress="setFocus(this, event)">
                <asp:ListItem Value="" Selected="True"></asp:ListItem>
                <asp:ListItem Value="AL">AL</asp:ListItem>
                <asp:ListItem Value="AK">AK</asp:ListItem>
                <asp:ListItem Value="AZ">AZ</asp:ListItem>
                <asp:ListItem Value="AR">AR</asp:ListItem>
                <asp:ListItem Value="CA">CA</asp:ListItem>
                <asp:ListItem Value="CO">CO</asp:ListItem>
                <asp:ListItem Value="CT">CT</asp:ListItem>
                <asp:ListItem Value="DC">DC</asp:ListItem>
                <asp:ListItem Value="DE">DE</asp:ListItem>
                <asp:ListItem Value="FL">FL</asp:ListItem>
                <asp:ListItem Value="GA">GA</asp:ListItem>
                <asp:ListItem Value="HI">HI</asp:ListItem>
                <asp:ListItem Value="ID">ID</asp:ListItem>
                <asp:ListItem Value="IL">IL</asp:ListItem>
                <asp:ListItem Value="IN">IN</asp:ListItem>
                <asp:ListItem Value="IA">IA</asp:ListItem>
                <asp:ListItem Value="KS">KS</asp:ListItem>
                <asp:ListItem Value="KY">KY</asp:ListItem>
                <asp:ListItem Value="LA">LA</asp:ListItem>
                <asp:ListItem Value="ME">ME</asp:ListItem>
                <asp:ListItem Value="MD">MD</asp:ListItem>
                <asp:ListItem Value="MA">MA</asp:ListItem>
                <asp:ListItem Value="MI">MI</asp:ListItem>
                <asp:ListItem Value="MN">MN</asp:ListItem>
                <asp:ListItem Value="MS">MS</asp:ListItem>
                <asp:ListItem Value="MO">MO</asp:ListItem>
                <asp:ListItem Value="MT">MT</asp:ListItem>
                <asp:ListItem Value="NE">NE</asp:ListItem>
                <asp:ListItem Value="NV">NV</asp:ListItem>
                <asp:ListItem Value="NH">NH</asp:ListItem>
                <asp:ListItem Value="NJ">NJ</asp:ListItem>
                <asp:ListItem Value="NM">NM</asp:ListItem>
                <asp:ListItem Value="NY">NY</asp:ListItem>
                <asp:ListItem Value="NC">NC</asp:ListItem>
                <asp:ListItem Value="ND">ND</asp:ListItem>
                <asp:ListItem Value="OH">OH</asp:ListItem>
                <asp:ListItem Value="OK">OK</asp:ListItem>
                <asp:ListItem Value="OR">OR</asp:ListItem>
                <asp:ListItem Value="PA">PA</asp:ListItem>
                <asp:ListItem Value="RI">RI</asp:ListItem>
                <asp:ListItem Value="SC">SC</asp:ListItem>
                <asp:ListItem Value="SD">SD</asp:ListItem>
                <asp:ListItem Value="TN">TN</asp:ListItem>
                <asp:ListItem Value="TX">TX</asp:ListItem>
                <asp:ListItem Value="UT">UT</asp:ListItem>
                <asp:ListItem Value="VT">VT</asp:ListItem>
                <asp:ListItem Value="VA">VA</asp:ListItem>
                <asp:ListItem Value="WA">WA</asp:ListItem>
                <asp:ListItem Value="WV">WV</asp:ListItem>
                <asp:ListItem Value="WI">WI</asp:ListItem>
                <asp:ListItem Value="WY">WY</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="lblZip" Text="Zip/Postal:" CssClass="label" runat="server"></asp:Label>
            <asp:TextBox ID="txtZip" CssClass="textbox" runat="server"></asp:TextBox>
            <asp:Label ID="lblPhone" Text="Phone:" CssClass="label" runat="server"></asp:Label>
            <asp:TextBox ID="txtPhone" CssClass="textbox" runat="server"></asp:TextBox>
            <asp:Label ID="lblMainContact" Text="Main Contact:" CssClass="label" runat="server"></asp:Label>
            <asp:TextBox ID="txtMainContact" CssClass="textbox" runat="server"></asp:TextBox>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="bottomContent" runat="server">
    <div class="clear">
    </div>
    <hr />
    <br />
    <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Always">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="rdAssetTypeGrid" />
            <asp:AsyncPostBackTrigger ControlID="btnSaveAssetTypePrices" />
            <asp:AsyncPostBackTrigger ControlID="btnCancelAssetTypePrices" />
            <asp:AsyncPostBackTrigger ControlID="btnSaveAssetTypePrices2" />
            <asp:AsyncPostBackTrigger ControlID="btnCancelAssetTypePrices2" />
        </Triggers>
        <ContentTemplate>
            <asp:LinkButton ID="lnkBtnOilFiltration" OnClick="changeToOilFiltrationView" CssClass="tab selected" Text="Oil Filtration" runat="server"></asp:LinkButton>
            <asp:LinkButton ID="lnkBtnAssetReclamation" OnClick="changeToAssetReclamationView" CssClass="tab" Text="Asset Reclamation" runat="server"></asp:LinkButton>
            <asp:LinkButton ID="lnkBtnRecycling" OnClick="changeToRecyclingView" CssClass="tab" Text="Recycling" runat="server"></asp:LinkButton>
            <asp:LinkButton ID="linkBtnDocks" OnClick="changeToDockView" CssClass="tab" Text="Docks" runat="server"></asp:LinkButton>
            <div class="section" style="margin-top: 5px">
                <asp:MultiView ID="multiView" runat="server">
                    <asp:View ID="oilFiltrationView" runat="server">
                        <br />
                        <h4>Restaurant Outlets</h4>
                        <asp:BulletedList ID="blServiceLocations" runat="server" class="list"></asp:BulletedList>
                        <telerik:RadGrid ID="rgServiceLocations" runat="server" AutoGenerateColumns="false">
                            <MasterTableView>
                            <Columns>
                                <telerik:GridBoundColumn HeaderText="ServiceLocationId" Visible="false" DataField="ServiceLocationId" />
                                <telerik:GridBoundColumn HeaderText="#" DataField="Ordinal" />
                                
                                <telerik:GridTemplateColumn HeaderText="Name">
                                    <ItemTemplate>
                                    <asp:LinkButton ID="btnEdit" runat="server" Text='<%# Eval("Name") %>' CommandArgument='<%# Eval("ServiceLocationId") %>' OnClick="btnEdit_OnClick" />
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>
                                <telerik:GridTemplateColumn UniqueName="reorderColumn" HeaderText="">
                                    <ItemTemplate>
                                        <asp:Button ID="btnMoveUp" runat="server" Text="↑" CommandArgument='<%# Eval("ServiceLocationId") %>' OnClick="btnMoveUp_OnClick" />
                                        <asp:Button ID="btnMoveDown" runat="server" Text="↓" CommandArgument='<%# Eval("ServiceLocationId") %>' OnClick="btnMoveDown_OnClick" />
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>
                            </Columns>
                            </MasterTableView>
                        </telerik:RadGrid>
                        <br />
                        <asp:Button ID="btnAddNewOutlet" runat="server" CssClass="button" Text="Add New Outlet" UseSubmitBehavior="true" OnClick="btnAddNewOutlet_Click" Style="float: none !important;" />
                    </asp:View>
                    <asp:View ID="assetReclamationView" runat="server">
                        <%--<asp:LinkButton ID="lnkSetupAsset" runat="server" Visible="true" OnClick="lnkSetupAsset_Click">Click here to setup asset reclamation</asp:LinkButton>--%>
                        <div id="assetFiltrationConfiguration" runat="server" visible="false">
                            <%--                            <h4>
                                Docks
                            </h4>
                            <div style="float: left; padding-bottom: 10px;">
                                <asp:Button ID="btnAddNewAssetDock" runat="server" CssClass="button" Text="Add New Dock"
                                    OnClick="btnAddNewAssetDock_Click" />
                            </div>
                            <asp:HiddenField ID="hdnAssetDockId" Value="0" runat="server" />
                            <div id="divAddNewAssetDock" runat="server" visible="false">
                                <div id="Div1" runat="server">
                                    <div class="clear">
                                    </div>
                                </div>
                                <asp:Label ID="Label1" Text="Name:" CssClass="label" runat="server"></asp:Label>
                                <asp:TextBox ID="txtAssetDockName" CssClass="textbox" runat="server"></asp:TextBox>
                                <div style="margin-right: 310px; float: right; padding-bottom: 10px;">
                                    <asp:Button ID="btnSaveAssetDock" runat="server" CssClass="button" Text="Save Dock"
                                        UseSubmitBehavior="true" OnClick="btnSaveAssetDock_Click" />
                                </div>
                            </div>
                            <div class="clear">
                            </div>
                            <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
                            <telerik:RadGrid ID="rgAssetDocks" Skin="" AllowPaging="false" ShowFooter="true"
                                GridLines="Both" runat="server" AutoGenerateColumns="False" AllowSorting="False"
                                PageSize="3" OnItemCommand="rgAssetDocks_OnItemCommand" AllowAutomaticUpdates="true"
                                OnNeedDataSource="rgAssetDocks_NeedDataSource">
                                <MasterTableView DataKeyNames="ServiceLocationId" AutoGenerateColumns="false" HierarchyDefaultExpanded="true"
                                    EditMode="InPlace" ShowHeader="true" ShowFooter="false">
                                    <Columns>
                                        <telerik:GridBoundColumn SortExpression="ServiceLocationId" HeaderText="ServiceLocationId"
                                            Visible="false" HeaderButtonType="TextButton" DataField="ServiceLocationId" Display="false"
                                            ReadOnly="true" HeaderStyle-HorizontalAlign="Center">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridTemplateColumn UniqueName="Name" HeaderText="Name" HeaderStyle-HorizontalAlign="Center">
                                            <ItemTemplate>
                                                <div style="text-align: center">
                                                    <asp:HiddenField ID="hdnAssetDockId" Value='<%# Eval("ServiceLocationId") %>' runat="server" />
                                                    <asp:TextBox ID="txtAssetDockName" runat="server" CssClass="gridtextbox" Text='<%# Eval("Name") %>'></asp:TextBox></div>
                                            </ItemTemplate>
                                            <ItemStyle CssClass="gridTextItalic gray" Width="450px" BorderColor="ActiveBorder" />
                                        </telerik:GridTemplateColumn>
                                        <telerik:GridTemplateColumn UniqueName="Delete" HeaderText="" HeaderStyle-HorizontalAlign="Center"
                                            ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50px">
                                            <ItemTemplate>
                                                <div style="text-align: center">
                                                    <asp:Button ID="btnDeleteAssetDock" runat="server" CssClass="delete" CommandName="delete"
                                                        CommandArgument='<%# Eval("ServiceLocationId") %>' UseSubmitBehavior="true" />
                                            </ItemTemplate>
                                            <ItemStyle BorderColor="ActiveBorder" CssClass="gridTextItalic gray" HorizontalAlign="Center" />
                                        </telerik:GridTemplateColumn>
                                    </Columns>
                                    <HeaderStyle Font-Bold="true" CssClass="gridTextItalic" BorderWidth="0" />
                                </MasterTableView>
                            </telerik:RadGrid>
                            <div class="clear">
                            </div>
                            <div style="float: right; padding-bottom: 10px;">
                                <asp:Button ID="btnSaveAssetDocks" runat="server" CssClass="button" Text="Save Docks"
                                    UseSubmitBehavior="true" OnClick="btnSaveAssetDocks_Click" />
                                <asp:Button ID="btnCancelAssetDocks" runat="server" CssClass="button" Text="Cancel"
                                    OnClick="btnCancelAssetDocks_Click" />
                            </div>--%>
                            <br />
                            <div class="spacer">
                            </div>
                            <h4>Asset Types and Prices</h4>
                            <div style="float: right; padding-bottom: 10px;">
                                <asp:Button ID="btnSaveAssetTypePrices" runat="server" CssClass="button" Text="Save Prices" UseSubmitBehavior="true" OnClick="btnSaveAssetTypePrices_Click" />
                                <asp:Button ID="btnCancelAssetTypePrices" runat="server" CssClass="button" Text="Undo Changes" OnClick="btnCancelAssetTypePrices_Click" />
                            </div>
                            <div class="clear">
                            </div>
                            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                            <telerik:RadGrid ID="rdAssetTypeGrid" Skin="" AllowPaging="false" ShowFooter="true" GridLines="Both" runat="server" AutoGenerateColumns="False" AllowSorting="False" PageSize="3" OnItemDataBound="rdAssetTypeGrid_OnItemDataBound" OnDetailTableDataBind="rdAssetTypeGrid_DetailTableDataBind" AllowAutomaticUpdates="true" OnNeedDataSource="rdAssetTypeGrid_NeedDataSource">
                                <MasterTableView DataKeyNames="AssetCategoryId" Name="CategoryView" AutoGenerateColumns="false" HierarchyDefaultExpanded="true" EditMode="InPlace" OnDataBinding="rdAssetTypeGrid_OnDataBinding" ShowHeader="false" ShowFooter="false">
                                    <Columns>
                                        <telerik:GridBoundColumn SortExpression="AssetCategoryId" HeaderText="AssetCategoryId" Visible="false" DataField="AssetCategoryId"></telerik:GridBoundColumn>
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
                                                <telerik:GridBoundColumn SortExpression="ServiceLocationAssetTypeId" HeaderText="ServiceLocationAssetTypeId" Visible="false" HeaderButtonType="TextButton" DataField="ServiceLocationAssetTypeId" Display="false" ReadOnly="false" HeaderStyle-HorizontalAlign="Center"></telerik:GridBoundColumn>
                                                <telerik:GridTemplateColumn UniqueName="AssetTypeName" HeaderText="Name" HeaderStyle-HorizontalAlign="Center">
                                                    <ItemTemplate>
                                                        <div style="text-align: center">
                                                            <%# Eval("AssetType.Name") %></div>
                                                    </ItemTemplate>
                                                    <ItemStyle CssClass="gridTextItalic" Width="450px" BorderColor="ActiveBorder" />
                                                </telerik:GridTemplateColumn>
                                                <telerik:GridTemplateColumn UniqueName="AssetTypeSpanishName" HeaderText="Spanish Label" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center">
                                                    <ItemTemplate>
                                                        <div style="text-align: center">
                                                            <%# Eval("AssetType.SpanishLabel") %></div>
                                                    </ItemTemplate>
                                                    <ItemStyle CssClass="gridTextItalic" Width="450px" BorderColor="ActiveBorder" />
                                                </telerik:GridTemplateColumn>
                                                <telerik:GridTemplateColumn UniqueName="AssetTypePrice" HeaderText="Price Per Unit" DataField="PricePerUnit" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="100px">
                                                    <ItemTemplate>
                                                        <div style="text-align: right">
                                                            <asp:HiddenField ID="hdnOrigPrice" runat="server" />
                                                            <asp:TextBox ID="txtPricePerUnit" runat="server" CssClass="moneytextbox"></asp:TextBox>
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
                            <div style="float: right; padding-bottom: 10px;">
                                <asp:Button ID="btnSaveAssetTypePrices2" runat="server" CssClass="button" Text="Save Prices" UseSubmitBehavior="true" OnClick="btnSaveAssetTypePrices_Click" />
                                <asp:Button ID="btnCancelAssetTypePrices2" runat="server" CssClass="button" Text="Undo Changes" OnClick="btnCancelAssetTypePrices_Click" />
                            </div>
                            <div class="spacer">
                            </div>
                            <div>
                                <hr />
                                <h4>Latest Price Changes:</h4>
                                <asp:Repeater ID="rptChanges" runat="server" OnItemDataBound="rptChanges_ItemDataBound">
                                    <HeaderTemplate>
                                        <table id="accountTable" cellspacing="0" class="repeater" width="850px">
                                            <tr>
                                                <th>Date </th>
                                                <th>User </th>
                                                <th>Change </th>
                                            </tr>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <%--<tr class="<%# ((bool)Eval("IsActive") ? "" : "error") %>">--%>
                                        <tr>
                                            <td style="text-align: right; width: 150px">
                                                <asp:Label ID="lblDate" runat="server"></asp:Label>
                                            </td>
                                            <td style="text-align: center">
                                                <asp:Label ID="lblUsername" runat="server"></asp:Label>
                                            </td>
                                            <td style="text-align: left">
                                                <asp:Label ID="lblRevisionInfo" runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                    </ItemTemplate>
                                    <FooterTemplate></table> </FooterTemplate>
                                </asp:Repeater>
                            </div>
                        </div>
                    </asp:View>
                    <asp:View ID="recyclingView" runat="server">
                        <%--<asp:LinkButton ID="lnkbtnSetupRecycling" runat="server" Text="Click here to setup recycling"
                            OnClick="lnkbtnSetupRecycling_Click"></asp:LinkButton>--%>
                        <div id="recyclingTypes" runat="server" visible="false">
                            <br />
                           
                            <h5>Recycling Types</h5>
                            <table style="width: 30%; padding: 10px;">
                                <thead>
                                    <tr style="background-color: #ccc; height: 25px;">
                                        <td style="text-align: center; vertical-align: middle;">
                                            Name
                                        </td>
                                        <td style="text-align: center; vertical-align: middle;">
                                            Selected
                                        </td>
                                    </tr>
                                </thead>
                                <tbody>
                                    <asp:Repeater ID="rptRecyclingTypes" runat="server" OnItemDataBound="rptRecyclingTypes_OnItemDataBound">
                                        <ItemTemplate>
                                            <tr style="height: 20px;">
                                                <td>
                                                    <asp:Label ID="lblRecyclingTypeId" runat="server" Text='<%# Eval("RecycleTypeId")%>' Visible="true" Style="display: none;" />
                                                    <%# Eval("Name")%>
                                                </td>
                                                <td style="text-align: center;">
                                                    <asp:CheckBox ID="cbRecycleTypeSelected" runat="server" />
                                                </td>
                                            </tr>
                                        </ItemTemplate>
                                        <AlternatingItemTemplate>
                                            <tr style="background-color: #eee; height: 20px;">
                                                <td>
                                                    <asp:Label ID="lblRecyclingTypeId" runat="server" Text='<%# Eval("RecycleTypeId")%>' Visible="true" Style="display: none;" />
                                                    <%# Eval("Name")%>
                                                </td>
                                                <td style="text-align: center;">
                                                    <asp:CheckBox ID="cbRecycleTypeSelected" runat="server" />
                                                </td>
                                            </tr>
                                        </AlternatingItemTemplate>
                                    </asp:Repeater>
                                </tbody>
                            </table>
                            <asp:Button ID="btnSaveRecycleTypes" runat="server" Text="Save Types" CssClass="button" Style="float: none !important;" OnClick="btnSaveRecycleTypes_Click" />
                        </div>
                    </asp:View>
                    <asp:View ID="docksView" runat="server">
                        <%--<asp:LinkButton ID="lnkbtnSetupRecycling" runat="server" Text="Click here to setup recycling"
                            OnClick="lnkbtnSetupRecycling_Click"></asp:LinkButton>--%>
                        <div id="docks" runat="server" visible="false">
                            <br />
                             <h4>Docks </h4>
                            <div style="float: right; padding-bottom: 10px;">
                                <asp:Button ID="btnAddNewRecyclingDock" runat="server" CssClass="button" Text="Add New Dock" OnClick="btnAddNewRecyclingDock_Click" />
                            </div>
                            <asp:HiddenField ID="hdnRecyclingDockId" Value="0" runat="server" />
                            <div id="divRecyclingDockDetails" runat="server" visible="false">
                                <div id="Div3" runat="server">
                                    <div class="clear">
                                    </div>
                                </div>
                                <asp:Label ID="Label2" Text="Name:" CssClass="label" runat="server"></asp:Label>
                                <asp:TextBox ID="txtRecylingDockName" CssClass="textbox" runat="server"></asp:TextBox>
                                <div style="margin-right: 310px; float: right; padding-bottom: 10px;">
                                    <asp:Button ID="btnSaveRecyclingDock" runat="server" CssClass="button" Text="Save Dock" UseSubmitBehavior="true" OnClick="btnSaveRecyclingDock_Click" />
                                </div>
                            </div>
                            <div class="clear">
                            </div>
                            <asp:PlaceHolder ID="PlaceHolder3" runat="server"></asp:PlaceHolder>
                            <telerik:RadGrid ID="rgRecyclingDocks" Skin="" AllowPaging="false" ShowFooter="true" GridLines="Both" runat="server" AutoGenerateColumns="False" AllowSorting="False" PageSize="3" OnItemCommand="rgRecyclingDocks_OnItemCommand" AllowAutomaticUpdates="true" OnNeedDataSource="rgRecyclingDocks_NeedDataSource">
                                <MasterTableView DataKeyNames="ServiceLocationId" AutoGenerateColumns="false" HierarchyDefaultExpanded="true" EditMode="InPlace" ShowHeader="true" ShowFooter="false">
                                    <Columns>
                                        <telerik:GridBoundColumn SortExpression="ServiceLocationId" HeaderText="ServiceLocationId" Visible="false" HeaderButtonType="TextButton" DataField="ServiceLocationId" Display="false" ReadOnly="true" HeaderStyle-HorizontalAlign="Center"></telerik:GridBoundColumn>
                                        <telerik:GridTemplateColumn UniqueName="Name" HeaderText="Name" HeaderStyle-HorizontalAlign="Center">
                                            <ItemTemplate>
                                                <div style="text-align: center">
                                                    <asp:HiddenField ID="hdnRecyclingDockId" Value='<%# Eval("ServiceLocationId") %>' runat="server" />
                                                    <asp:TextBox ID="txtRecyclingDockName" runat="server" CssClass="gridtextbox" Text='<%# Eval("Name") %>'></asp:TextBox></div>
                                            </ItemTemplate>
                                            <ItemStyle CssClass="gridTextItalic gray" Width="450px" BorderColor="ActiveBorder" />
                                        </telerik:GridTemplateColumn>
                                        <telerik:GridTemplateColumn UniqueName="Delete" HeaderText="" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50px">
                                            <ItemTemplate>
                                                <div style="text-align: center">
                                                    <asp:Button ID="btnDeleteAssetDock" runat="server" CssClass="delete" CommandName="delete" CommandArgument='<%# Eval("ServiceLocationId") %>' UseSubmitBehavior="true" />
                                            </ItemTemplate>
                                            <ItemStyle BorderColor="ActiveBorder" CssClass="gridTextItalic gray" HorizontalAlign="Center" />
                                        </telerik:GridTemplateColumn>
                                    </Columns>
                                    <HeaderStyle Font-Bold="true" CssClass="gridTextItalic" BorderWidth="0" />
                                </MasterTableView>
                            </telerik:RadGrid>
                            <div class="clear">
                            </div>
                            <div style="float: right; padding-bottom: 10px;">
                                <asp:Button ID="btnSaveRecyclingDocks" runat="server" CssClass="button" Text="Save Docks" UseSubmitBehavior="true" OnClick="btnSaveRecyclingDocks_Click" />
                                <asp:Button ID="btnCancelRecyclingDocks" runat="server" CssClass="button" Text="Cancel" OnClick="btnCancelRecyclingDocks_Click" />
                            </div>
                            <br />
                            <div class="spacer">
                            </div>
                            <hr />
                            </div>
                            <hr />                         
                        </div>
                    </asp:View>
                </asp:MultiView>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="sideBarContent" runat="server">
    <div class="sidebar nospace">
        <div class="sidebartop">
        </div>
        <div class="sidebarmain">
            <div class="sidebarcontent">
                <h4 class="sidebarheading">Notes</h4>
                <div class="clear">
                </div>
                <asp:TextBox ID="txtNotes" CssClass="sidebarTextbox" runat="server" TextMode="MultiLine" Height="90px"></asp:TextBox>
                <div class="clear">
                </div>
            </div>
        </div>
        <div class="sidebarbottom">
        </div>
        <div class="clear">
        </div>
        <div id="instructions" class="info" runat="server">
            <p>Enter information for the new account and then click Save.</p>
            <p>You will be able to add a service location after you save.</p>
            <p>You will be able to enter asset type prices after you save.</p>
        </div>
        <div style="float: right; padding-bottom: 10px;">
            <asp:Button ID="btnSaveAccount" runat="server" CssClass="button" Text="Save Account" OnClick="btnSaveAccount_Click" />
            <asp:Button ID="btnCancel" runat="server" CssClass="button" Text="Cancel" OnClick="btnCancel_Click" />
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="footerContent" runat="server"></asp:Content>

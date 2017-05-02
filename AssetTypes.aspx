<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true" CodeBehind="AssetTypes.aspx.cs" Inherits="RenuOil.AssetTypes" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="bottomContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnAddNewAssetCategory" />
            <asp:AsyncPostBackTrigger ControlID="btnAddNewAssetType" />
            <asp:AsyncPostBackTrigger ControlID="btnSaveAssetCategory" />
            <asp:AsyncPostBackTrigger ControlID="btnCancelAssetCategory" />
            <asp:AsyncPostBackTrigger ControlID="btnSaveAssetType" />
            <asp:AsyncPostBackTrigger ControlID="btnCancelAssetType" />
            <asp:AsyncPostBackTrigger ControlID="rdAssetTypeGrid" />
        </Triggers>
        <ContentTemplate>
            <div style="float: right; padding-bottom: 10px;">
                <asp:Button ID="btnAddNewAssetCategory" runat="server" CssClass="button" Text="Add New Category" OnClick="btnAddNewAssetCategory_Click" />
                <asp:Button ID="btnAddNewAssetType" runat="server" CssClass="button" Text="Add New Asset Type" OnClick="btnAddNewAssetType_Click" />
            </div>
            <div class="clear">
            </div>
            <div id="divAddNewAssetCategory" runat="server">
                <hr />
                <h4 class="title">Add New Asset Category:</h4>
                <asp:HiddenField ID="hdnAssetCategoryId" runat="server" />
                <asp:Label ID="lblAssetCategory" CssClass="label" Text="Category Name:" runat="server"></asp:Label>
                <asp:TextBox ID="txtAssetCategoryName" runat="server" CssClass="textbox"></asp:TextBox>
                <asp:Label ID="lblAssetCategoryDescription" CssClass="label" Text="Description:" runat="server"></asp:Label>
                <asp:TextBox ID="txtAssetCategoryDescription" runat="server" CssClass="textbox"></asp:TextBox>
                <asp:Label ID="lblAssetCategorySpanishLabel" CssClass="label" Text="Spanish Label:" runat="server"></asp:Label>
                <asp:TextBox ID="txtAssetCategorySpanishLabel" runat="server" CssClass="textbox"></asp:TextBox>
                <div style="float: right; padding-bottom: 10px;">
                    <asp:Button ID="btnSaveAssetCategory" runat="server" CssClass="button" Text="Save" OnClick="btnSaveAssetCategory_Click" />
                    <asp:Button ID="btnCancelAssetCategory" runat="server" CssClass="button" Text="Cancel" OnClick="btnCancelAssetCategory_Click" />
                </div>
            </div>
            <div id="divAddNewAssetType" runat="server">
                <hr />
                <h4 class="title">Add New Asset Type:</h4>
                <asp:HiddenField ID="hdnAssetTypeId" runat="server" />
                <asp:Label ID="lblAssetType" CssClass="label" Text="Asset Type Name:" runat="server"></asp:Label>
                <asp:TextBox ID="txtAssetTypeName" runat="server" CssClass="textbox"></asp:TextBox>
                <asp:Label ID="lblCategory" CssClass="label" Text="Category:" runat="server"></asp:Label>
                <asp:DropDownList ID="ddlAssetCategory" runat="server"></asp:DropDownList>
                <asp:Label ID="lblDescription" CssClass="label" Text="Description:" runat="server"></asp:Label>
                <asp:TextBox ID="txtAssetTypeDescription" runat="server" CssClass="textbox"></asp:TextBox>
                <asp:Label ID="lblSpanishLabel" CssClass="label" Text="Spanish Label:" runat="server"></asp:Label>
                <asp:TextBox ID="txtAssetTypeSpanishLabel" runat="server" CssClass="textbox"></asp:TextBox>
                <div style="float: right; padding-bottom: 10px;">
                    <asp:Button ID="btnSaveAssetType" runat="server" CssClass="button" Text="Save" OnClick="btnSaveAssetType_Click" />
                    <asp:Button ID="btnCancelAssetType" runat="server" CssClass="button" Text="Cancel" OnClick="btnCancelAssetType_Click" />
                </div>
            </div>
            <div class="clear">
                <br />
            </div>
            <hr />
            <center>
                <h4 class="title">All Asset Types</h4>
            </center>
            <div style="float: right; padding-bottom: 10px;">
                <asp:Button ID="btnSaveAssetTypeChanges" runat="server" CssClass="button" Text="Save" OnClick="btnSaveAssetTypeChanges_Click" />
                <asp:Button ID="btnCancelAssetTypeChanges" runat="server" CssClass="button" Text="Cancel" OnClick="btnCancelAssetTypeChanges_Click" />
            </div>
            <div class="clear">
            </div>
            <asp:ScriptManager ID="scriptMgr" runat="server"></asp:ScriptManager>
            <telerik:RadGrid ID="rdAssetTypeGrid" AllowPaging="false" ShowFooter="true" runat="server" Skin="" AutoGenerateColumns="False" AllowSorting="False" PageSize="3" GridLines="Both" BorderColor="ActiveBorder" OnItemDataBound="rdAssetTypeGrid_OnItemDataBound" OnDetailTableDataBind="rdAssetTypeGrid_DetailTableDataBind" CellPadding="0" AllowAutomaticUpdates="true" OnNeedDataSource="rdAssetTypeGrid_NeedDataSource">
                <MasterTableView DataKeyNames="AssetCategoryId" AutoGenerateColumns="false" HierarchyDefaultExpanded="true" EditMode="InPlace" ShowHeader="false" ShowFooter="false" NoDetailRecordsText="" NoMasterRecordsText="">
                    <Columns>
                        <telerik:GridBoundColumn SortExpression="AssetCategoryId" HeaderText="AssetCategoryId" Visible="false" DataField="AssetCategoryId"></telerik:GridBoundColumn>
                        <telerik:GridTemplateColumn UniqueName="AssetCategory" HeaderText="" HeaderStyle-HorizontalAlign="Center" ReadOnly="true">
                            <ItemTemplate>
                                <div style="text-align: left">
                                    <%# Eval("Name") %></div>
                            </ItemTemplate>
                            <ItemStyle CssClass="gridHeader" />
                            <FooterStyle BorderColor="ActiveBorder" />
                        </telerik:GridTemplateColumn>
                    </Columns>
                    <DetailTables>
                        <telerik:GridTableView DataKeyNames="AssetTypeId" Name="AssetTypeView" Width="100%" Visible="true" ShowHeader="true" ShowHeadersWhenNoRecords="false" HierarchyLoadMode="Client" HierarchyDefaultExpanded="true" FooterStyle-Height="10px" ShowFooter="false" EditMode="InPlace">
                            <Columns>
                                <telerik:GridBoundColumn SortExpression="AssetTypeId" HeaderText="AssetTypeId" Visible="false" HeaderButtonType="TextButton" DataField="AssetTypeId" Display="false" ReadOnly="false" HeaderStyle-HorizontalAlign="Center"></telerik:GridBoundColumn>
                                <telerik:GridTemplateColumn UniqueName="AssetTypeName" HeaderText="Name" HeaderStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <div style="text-align: center">
                                            <asp:TextBox ID="txtName" runat="server" CssClass="gridtextbox" Text='<%# Eval("Name") %>' Width="218px"></asp:TextBox></div>
                                    </ItemTemplate>
                                    <ItemStyle CssClass="gridText gray" Width="280px" BorderColor="ActiveBorder" />
                                </telerik:GridTemplateColumn>
                                <telerik:GridTemplateColumn UniqueName="AssetTypeDescription" HeaderText="Description" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <div style="text-align: center">
                                            <asp:TextBox ID="txtAssetTypeDescription" runat="server" CssClass="gridtextbox" Text='<%# Eval("Description") %>' Width="218px"></asp:TextBox></div>
                                    </ItemTemplate>
                                    <ItemStyle CssClass="gridText gray" Width="280px" BorderColor="ActiveBorder" />
                                </telerik:GridTemplateColumn>
                                <telerik:GridTemplateColumn UniqueName="AssetTypeSpanishName" HeaderText="Spanish Label" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <div style="text-align: center">
                                            <asp:TextBox ID="txtSpanishLabel" runat="server" CssClass="gridtextbox" Text='<%# Eval("SpanishLabel") %>' Width="218px"></asp:TextBox></div>
                                    </ItemTemplate>
                                    <ItemStyle CssClass="gridText gray" Width="280px" BorderColor="ActiveBorder" />
                                </telerik:GridTemplateColumn>
                                <telerik:GridTemplateColumn UniqueName="AssetTypeCategory" HeaderText="Category" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="300px">
                                    <ItemTemplate>
                                        <div style="text-align: center">
                                            <asp:DropDownList ID="ddlAssetTypeCategory" runat="server"></asp:DropDownList>
                                    </ItemTemplate>
                                    <ItemStyle BorderColor="ActiveBorder" CssClass="gridTextItalic gray" HorizontalAlign="Center" />
                                </telerik:GridTemplateColumn>
                                <telerik:GridTemplateColumn UniqueName="Delete" HeaderText="" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50px">
                                    <ItemTemplate>
                                        <div style="text-align: center">
                                            <asp:Button ID="btnDeleteAssetType" runat="server" CssClass="delete" CommandName="delete" CommandArgument='<%# Eval("AssetTypeId") %>' UseSubmitBehavior="true" />
                                    </ItemTemplate>
                                    <ItemStyle BorderColor="ActiveBorder" CssClass="gridTextItalic gray" HorizontalAlign="Center" />
                                </telerik:GridTemplateColumn>
                            </Columns>
                            <HeaderStyle Font-Bold="true" CssClass="gridTextItalic" BorderWidth="0" />
                            <%--<ItemStyle Height="30px" HorizontalAlign="Center" />--%>
                            <%--<AlternatingItemStyle Height="30px" BorderStyle="Double" CssClass="rgRow" HorizontalAlign="Center" />--%>
                        </telerik:GridTableView>
                    </DetailTables>
                </MasterTableView>
            </telerik:RadGrid>
            <div class="clear"></div>
            <div style="float: right; padding-bottom: 10px;">
                <asp:Button ID="btnSaveAssetTypeChanges2" runat="server" CssClass="button" Text="Save" OnClick="btnSaveAssetTypeChanges_Click" />
                <asp:Button ID="btnCancelAssetTypeChanges2" runat="server" CssClass="button" Text="Cancel" OnClick="btnCancelAssetTypeChanges_Click" />
            </div>            
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="footerContent" runat="server"></asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true"
    CodeBehind="Vendors.aspx.cs" Inherits="RenuOil.Vendors" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="bottomContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnAddNewVendor" />
            <asp:AsyncPostBackTrigger ControlID="btnSaveVendor" />
            <asp:AsyncPostBackTrigger ControlID="btnCancelVendor" />
            <asp:AsyncPostBackTrigger ControlID="btnSaveVendorChanges" />
            <asp:AsyncPostBackTrigger ControlID="btnCancelVendorChanges" />
            <asp:AsyncPostBackTrigger ControlID="rdVendors" />
        </Triggers>
        <ContentTemplate>
            <div style="float: right; padding-bottom: 10px;">
                <asp:Button ID="btnAddNewVendor" runat="server" CssClass="button" Text="Add New Vendor"
                    OnClick="btnAddNewVendor_Click" />
            </div>
            <div class="clear">
            </div>
            <div id="divAddNewVendor" runat="server">
                <hr />
                <h4 class="title">
                    Add New Vendor:</h4>
                <asp:HiddenField ID="hdnVendorId" runat="server" />
                <asp:Label ID="lblName" CssClass="label" Text="Name:" runat="server"></asp:Label>
                <asp:TextBox ID="txtName" runat="server" CssClass="textbox"></asp:TextBox>
                <asp:Label ID="lblType" CssClass="label" Text="Type:" runat="server"></asp:Label>
                <asp:DropDownList ID="ddlType" runat="server">
                    <asp:ListItem Text="Landfill Compactors" Value="L"></asp:ListItem>
                    <asp:ListItem Text="Open-top Landfill" Value="O"></asp:ListItem>
                </asp:DropDownList>
                <div style="float: right; padding-bottom: 10px;">
                    <asp:Button ID="btnSaveVendor" runat="server" CssClass="button" Text="Save" OnClick="btnSaveVendor_Click" />
                    <asp:Button ID="btnCancelVendor" runat="server" CssClass="button" Text="Cancel" OnClick="btnCancelVendor_Click" />
                </div>
            </div>
            <div class="clear">
                <br />
            </div>
            <hr />
            <center>
                <h4 class="title">All Vendors</h4>
            </center>
            <div style="float: right; padding-bottom: 10px;">
                <asp:Button ID="btnSaveVendorChanges" runat="server" CssClass="button" Text="Save"
                    OnClick="btnSaveVendorChanges_Click" />
                <asp:Button ID="btnCancelVendorChanges" runat="server" CssClass="button" Text="Cancel"
                    OnClick="btnCancelVendorChanges_Click" />
            </div>
            <div class="clear">
            </div>
            <asp:ScriptManager ID="scriptMgr" runat="server">
            </asp:ScriptManager>
            <telerik:RadGrid ID="rdVendors" AllowPaging="false" ShowFooter="true" runat="server"
                Skin="" AutoGenerateColumns="False" AllowSorting="False" PageSize="3" GridLines="Both"
                BorderColor="ActiveBorder" OnNeedDataSource="rdVendors_NeedDataSource" OnDeleteCommand="rdVendors_DeleteCommand" OnItemDataBound="rdVendors_OnItemDataBound"
                CellPadding="0" AllowAutomaticUpdates="true">
                <MasterTableView DataKeyNames="RecycleVendorId" AutoGenerateColumns="false" EditMode="InPlace"
                    ShowHeader="true" ShowFooter="false" NoDetailRecordsText="" NoMasterRecordsText="">
                    <Columns>
                        <telerik:GridBoundColumn SortExpression="RecycleVendorId" HeaderText="RecycleVendorId"
                            Visible="false" HeaderButtonType="TextButton" DataField="RecycleVendorId" Display="false"
                            ReadOnly="false" HeaderStyle-HorizontalAlign="Center">
                        </telerik:GridBoundColumn>
                        <telerik:GridTemplateColumn UniqueName="Name" HeaderText="Name" HeaderStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <div style="text-align: center">
                                    <asp:TextBox ID="txtName" runat="server" CssClass="gridtextbox" Text='<%# Eval("Name") %>'
                                        Width="218px"></asp:TextBox></div>
                            </ItemTemplate>
                            <ItemStyle CssClass="gridText gray" Width="280px" BorderColor="ActiveBorder" />
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn UniqueName="Type" HeaderText="Type" HeaderStyle-HorizontalAlign="Center"
                            ItemStyle-HorizontalAlign="Center" ItemStyle-Width="300px">
                            <ItemTemplate>
                                <div style="text-align: center">
                                    <asp:DropDownList ID="ddlType" runat="server">
                                        <asp:ListItem Text="Landfill Compactors" Value="L"></asp:ListItem>
                                        <asp:ListItem Text="Open-top Landfill" Value="O"></asp:ListItem>
                                    </asp:DropDownList>
                            </ItemTemplate>
                            <ItemStyle BorderColor="ActiveBorder" CssClass="gridTextItalic gray" HorizontalAlign="Center" />
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn UniqueName="Delete" HeaderText="" HeaderStyle-HorizontalAlign="Center"
                            ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50px">
                            <ItemTemplate>
                                <div style="text-align: center">
                                    <asp:Button ID="btnDeleteVendor" runat="server" CssClass="delete" CommandName="delete"
                                        CommandArgument='<%# Eval("RecycleVendorId") %>' UseSubmitBehavior="true" />
                            </ItemTemplate>
                            <ItemStyle BorderColor="ActiveBorder" CssClass="gridTextItalic gray" HorizontalAlign="Center" />
                        </telerik:GridTemplateColumn>
                    </Columns>
                </MasterTableView>
            </telerik:RadGrid>
            <div class="clear">
            </div>
            <div style="float: right; padding-bottom: 10px;">
                <asp:Button ID="btnSaveVendorChanges2" runat="server" CssClass="button" Text="Save"
                    OnClick="btnSaveVendorChanges_Click" />
                <asp:Button ID="btnCancelVendorChanges2" runat="server" CssClass="button" Text="Cancel"
                    OnClick="btnCancelVendorChanges_Click" />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>

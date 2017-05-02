<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="True"
    CodeBehind="RebateTypes.aspx.cs" Inherits="RenuOil.RebateTypes" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="bottomContent" runat="server">
    <%--    <div style="float: right; padding-bottom: 10px;">
        <asp:Button ID="btnAddNewRebateType" runat="server" CssClass="button" Text="Add New Rebate Type"
            OnClick="btnAddNewRebateType_Click" />
    </div>
    <div class="clear">
    </div>
    <div id="divAddNewRebateType" runat="server">
        <hr />
        <h4 class="title">
            Add New Rebate Type:</h4>
        <asp:HiddenField ID="hdnRebateTypeId" runat="server" />
        <asp:Label ID="lblName" CssClass="label" Text="Name:" runat="server"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" CssClass="textbox"></asp:TextBox>
        <div style="float: right; padding-bottom: 10px;">
            <asp:Button ID="btnSaveRebateType" runat="server" CssClass="button" Text="Save" OnClick="btnSaveRebateType_Click" />
            <asp:Button ID="btnCancelRebateType" runat="server" CssClass="button" Text="Cancel"
                OnClick="btnCancelRebateType_Click" />
        </div>
    </div>
    <div class="clear">
        <br />
    </div>
    <hr />
    <center>
                <h4 class="title">All Rebate Types</h4>
            </center>
    <div style="float: right; padding-bottom: 10px;">
        <asp:Button ID="btnSaveRebateTypeChanges" runat="server" CssClass="button" Text="Save Changes"
            OnClick="btnSaveRebateTypeChanges_Click" />
        <asp:Button ID="btnCancelRebateTypeChanges" runat="server" CssClass="button" Text="Cancel"
            OnClick="btnCancelRebateTypeChanges_Click" />
    </div>
    <div class="clear">
    </div>
    <asp:ScriptManager ID="scriptMgr" runat="server">
    </asp:ScriptManager>
    <telerik:RadGrid ID="rdRebateTypeGrid" AllowPaging="false" ShowFooter="true" runat="server"
        Skin="" AutoGenerateColumns="False" AllowSorting="False" PageSize="3" GridLines="Both"
        BorderColor="ActiveBorder" OnNeedDataSource="rdRebateTypeGrid_NeedDataSource"
        OnDeleteCommand="rdRebateTypeGrid_DeleteCommand" CellPadding="0" AllowAutomaticUpdates="true">
        <MasterTableView DataKeyNames="RebateTypeId" AutoGenerateColumns="false" EditMode="InPlace"
            ShowHeader="true" ShowFooter="false" NoDetailRecordsText="" NoMasterRecordsText="">
            <Columns>
                <telerik:GridBoundColumn SortExpression="RebateTypeId" HeaderText="RebateTypeId"
                    Visible="false" HeaderButtonType="TextButton" DataField="RebateTypeId" Display="false"
                    ReadOnly="false" HeaderStyle-HorizontalAlign="Center">
                </telerik:GridBoundColumn>
                <telerik:GridTemplateColumn UniqueName="RebateTypeName" HeaderText="Name" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <div style="text-align: center">
                            <asp:TextBox ID="txtRebateTypeName" runat="server" CssClass="gridtextbox" Text='<%# Eval("Name") %>'
                                Width="218px"></asp:TextBox></div>
                    </ItemTemplate>
                    <ItemStyle CssClass="gridText gray" Width="280px" BorderColor="ActiveBorder" />
                </telerik:GridTemplateColumn>
                <telerik:GridTemplateColumn UniqueName="Delete" HeaderText="" HeaderStyle-HorizontalAlign="Center"
                    ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50px">
                    <ItemTemplate>
                        <div style="text-align: center">
                            <asp:Button ID="btnDeleteRebateType" runat="server" CssClass="delete" CommandName="delete"
                                CommandArgument='<%# Eval("RebateTypeId") %>' UseSubmitBehavior="true" />
                    </ItemTemplate>
                    <ItemStyle BorderColor="ActiveBorder" CssClass="gridTextItalic gray" HorizontalAlign="Center" />
                </telerik:GridTemplateColumn>
            </Columns>
        </MasterTableView>
    </telerik:RadGrid>
    <div class="clear">
    </div>
    <div style="float: right; padding-bottom: 10px;">
        <asp:Button ID="btnSaveRebateTypeChanges2" runat="server" CssClass="button" Text="Save Changes"
            OnClick="btnSaveRebateTypeChanges_Click" />
        <asp:Button ID="btnCancelRebateTypeChanges2" runat="server" CssClass="button" Text="Cancel"
            OnClick="btnCancelRebateTypeChanges_Click" />
    </div>--%>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnAddNewRebateType" />
            <asp:AsyncPostBackTrigger ControlID="btnSaveRebateType" />
            <asp:AsyncPostBackTrigger ControlID="btnCancelRebateType" />
            <asp:AsyncPostBackTrigger ControlID="btnSaveRebateTypeChanges" />
            <asp:AsyncPostBackTrigger ControlID="btnCancelRebateTypeChanges" />
            <asp:AsyncPostBackTrigger ControlID="rdRebateTypeGrid" />
        </Triggers>
        <ContentTemplate>
            <div style="float: right; padding-bottom: 10px;">
                <asp:Button ID="btnAddNewRebateType" runat="server" CssClass="button" Text="Add New Rebate Type"
                    OnClick="btnAddNewRebateType_Click" />
            </div>
            <div class="clear">
            </div>
            <div id="divAddNewRebateType" runat="server">
                <hr />
                <h4 class="title">
                    Add New Rebate Type:</h4>
                <asp:HiddenField ID="hdnRebateTypeId" runat="server" />
                <asp:Label ID="lblName" CssClass="label" Text="Name:" runat="server"></asp:Label>
                <asp:TextBox ID="txtName" runat="server" CssClass="textbox"></asp:TextBox>
                <div style="float: right; padding-bottom: 10px;">
                    <asp:Button ID="btnSaveRebateType" runat="server" CssClass="button" Text="Save" OnClick="btnSaveRebateType_Click" />
                    <asp:Button ID="btnCancelRebateType" runat="server" CssClass="button" Text="Cancel"
                        OnClick="btnCancelRebateType_Click" />
                </div>
            </div>
            <div class="clear">
                <br />
            </div>
            <hr />
            <center>
                <h4 class="title">All Rebate Types</h4>
            </center>
            <div style="float: right; padding-bottom: 10px;">
                <asp:Button ID="btnSaveRebateTypeChanges" runat="server" CssClass="button" Text="Save"
                    OnClick="btnSaveRebateTypeChanges_Click" />
                <asp:Button ID="btnCancelRebateTypeChanges" runat="server" CssClass="button" Text="Cancel"
                    OnClick="btnCancelRebateTypeChanges_Click" />
            </div>
            <div class="clear">
            </div>
            <asp:ScriptManager ID="scriptMgr" runat="server">
            </asp:ScriptManager>
            <telerik:RadGrid ID="rdRebateTypeGrid" AllowPaging="false" ShowFooter="true" runat="server"
                Skin="" AutoGenerateColumns="False" AllowSorting="False" PageSize="3" GridLines="Both"
                BorderColor="ActiveBorder" OnNeedDataSource="rdRebateTypeGrid_NeedDataSource"
                OnDeleteCommand="rdRebateTypeGrid_DeleteCommand" CellPadding="0" AllowAutomaticUpdates="true">
                <MasterTableView DataKeyNames="RebateTypeId" AutoGenerateColumns="false" EditMode="InPlace"
                    ShowHeader="true" ShowFooter="false" NoDetailRecordsText="" NoMasterRecordsText="">
                    <Columns>
                        <telerik:GridBoundColumn SortExpression="RebateTypeId" HeaderText="RebateTypeId"
                            Visible="false" HeaderButtonType="TextButton" DataField="RebateTypeId" Display="false"
                            ReadOnly="false" HeaderStyle-HorizontalAlign="Center">
                        </telerik:GridBoundColumn>
                        <telerik:GridTemplateColumn UniqueName="RebateTypeName" HeaderText="Name" HeaderStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <div style="text-align: center">
                                    <asp:TextBox ID="txtRebateTypeName" runat="server" CssClass="gridtextbox" Text='<%# Eval("Name") %>'
                                        Width="218px"></asp:TextBox></div>
                            </ItemTemplate>
                            <ItemStyle CssClass="gridText gray" Width="280px" BorderColor="ActiveBorder" />
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn UniqueName="Delete" HeaderText="" HeaderStyle-HorizontalAlign="Center"
                            ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50px">
                            <ItemTemplate>
                                <div style="text-align: center">
                                    <asp:Button ID="btnDeleteRebateType" runat="server" CssClass="delete" CommandName="delete"
                                        CommandArgument='<%# Eval("RebateTypeId") %>' UseSubmitBehavior="true" />
                            </ItemTemplate>
                            <ItemStyle BorderColor="ActiveBorder" CssClass="gridTextItalic gray" HorizontalAlign="Center" />
                        </telerik:GridTemplateColumn>
                    </Columns>
                </MasterTableView>
            </telerik:RadGrid>
            <div class="clear">
            </div>
            <div style="float: right; padding-bottom: 10px;">
                <asp:Button ID="btnSaveRebateTypeChanges2" runat="server" CssClass="button" Text="Save"
                    OnClick="btnSaveRebateTypeChanges_Click" />
                <asp:Button ID="btnCancelRebateTypeChanges2" runat="server" CssClass="button" Text="Cancel"
                    OnClick="btnCancelRebateTypeChanges_Click" />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true"
    CodeBehind="RecycleTypes.aspx.cs" Inherits="RenuOil.RecycleTypes" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="bottomContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnAddNewRecycleType" />
            <asp:AsyncPostBackTrigger ControlID="btnSaveRecycleType" />
            <asp:AsyncPostBackTrigger ControlID="btnCancelRecycleType" />
            <asp:AsyncPostBackTrigger ControlID="btnSaveRecycleTypeChanges" />
            <asp:AsyncPostBackTrigger ControlID="btnCancelRecycleTypeChanges" />
            <asp:AsyncPostBackTrigger ControlID="rdRecycleTypeGrid" />
        </Triggers>
        <ContentTemplate>
            <div style="float: right; padding-bottom: 10px;">
                <asp:Button ID="btnAddNewRecycleType" runat="server" CssClass="button" Text="Add New Recycle Type"
                    OnClick="btnAddNewRecycleType_Click" />
            </div>
            <div class="clear">
            </div>
            <div id="divAddNewRecycleType" runat="server">
                <hr />
                <h4 class="title">
                    Add New Recycle Type:</h4>
                <asp:HiddenField ID="hdnRecycleTypeId" runat="server" />
                <asp:Label ID="lblName" CssClass="label" Text="Name:" runat="server"></asp:Label>
                <asp:TextBox ID="txtName" runat="server" CssClass="textbox"></asp:TextBox>
                <asp:Label ID="lblDescription" CssClass="label" Text="Description:" runat="server"></asp:Label>
                <asp:TextBox ID="txtDescription" runat="server" CssClass="textbox"></asp:TextBox>
                <asp:Label ID="lblSpanishLabel" CssClass="label" Text="Spanish Label:" runat="server"></asp:Label>
                <asp:TextBox ID="txtSpanishLabel" runat="server" CssClass="textbox"></asp:TextBox>
                <div style="float: right; padding-bottom: 10px;">
                    <asp:Button ID="btnSaveRecycleType" runat="server" CssClass="button" Text="Save"
                        OnClick="btnSaveRecycleType_Click" />
                    <asp:Button ID="btnCancelRecycleType" runat="server" CssClass="button" Text="Cancel"
                        OnClick="btnCancelRecycleType_Click" />
                </div>
            </div>
            <div class="clear">
                <br />
            </div>
            <hr />
            <center>
                <h4 class="title">All Recycle Types</h4>
            </center>
            <div style="float: right; padding-bottom: 10px;">
                <asp:Button ID="btnSaveRecycleTypeChanges" runat="server" CssClass="button" Text="Save"
                    OnClick="btnSaveRecycleTypeChanges_Click" />
                <asp:Button ID="btnCancelRecycleTypeChanges" runat="server" CssClass="button" Text="Cancel"
                    OnClick="btnCancelRecycleTypeChanges_Click" />
            </div>
            <div class="clear">
            </div>
            <asp:ScriptManager ID="scriptMgr" runat="server">
            </asp:ScriptManager>
            <telerik:RadGrid ID="rdRecycleTypeGrid" AllowPaging="false" ShowFooter="true" runat="server"
                Skin="" AutoGenerateColumns="False" AllowSorting="False" PageSize="3" GridLines="Both"
                BorderColor="ActiveBorder" OnNeedDataSource="rdRecycleTypeGrid_NeedDataSource" OnDeleteCommand="rdRecycleTypeGrid_DeleteCommand"
                 CellPadding="0" AllowAutomaticUpdates="true">
                <MasterTableView DataKeyNames="RecycleTypeId" AutoGenerateColumns="false"
                    EditMode="InPlace" ShowHeader="true" ShowFooter="false" NoDetailRecordsText=""
                    NoMasterRecordsText="">
                    <Columns>
                        <telerik:GridBoundColumn SortExpression="RecycleTypeId" HeaderText="RecycleTypeId" Visible="false"
                            HeaderButtonType="TextButton" DataField="RecycleTypeId" Display="false" ReadOnly="false"
                            HeaderStyle-HorizontalAlign="Center">
                        </telerik:GridBoundColumn>
                        <telerik:GridTemplateColumn UniqueName="RecycleTypeName" HeaderText="Name" HeaderStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <div style="text-align: center">
                                    <asp:TextBox ID="txtRecycleTypeName" runat="server" CssClass="gridtextbox" Text='<%# Eval("Name") %>'
                                        Width="218px"></asp:TextBox></div>
                            </ItemTemplate>
                            <ItemStyle CssClass="gridText gray" Width="280px" BorderColor="ActiveBorder" />
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn UniqueName="RecycleTypeDescription" HeaderText="Description"
                            HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <div style="text-align: center">
                                    <asp:TextBox ID="txtRecycleTypeDescription" runat="server" CssClass="gridtextbox" Text='<%# Eval("Description") %>'
                                        Width="218px"></asp:TextBox></div>
                            </ItemTemplate>
                            <ItemStyle CssClass="gridText gray" Width="280px" BorderColor="ActiveBorder" />
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn UniqueName="RecycleTypeSpanishName" HeaderText="Spanish Label"
                            HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <div style="text-align: center">
                                    <asp:TextBox ID="txtSpanishLabel" runat="server" CssClass="gridtextbox" Text='<%# Eval("SpanishLabel") %>'
                                        Width="218px"></asp:TextBox></div>
                            </ItemTemplate>
                            <ItemStyle CssClass="gridText gray" Width="280px" BorderColor="ActiveBorder" />
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn UniqueName="Delete" HeaderText="" HeaderStyle-HorizontalAlign="Center"
                            ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50px">
                            <ItemTemplate>
                                <div style="text-align: center">
                                    <asp:Button ID="btnDeleteRecycleType" runat="server" CssClass="delete" CommandName="delete"
                                        CommandArgument='<%# Eval("RecycleTypeId") %>' UseSubmitBehavior="true" />
                            </ItemTemplate>
                            <ItemStyle BorderColor="ActiveBorder" CssClass="gridTextItalic gray" HorizontalAlign="Center" />
                        </telerik:GridTemplateColumn>
                    </Columns>
                </MasterTableView>
            </telerik:RadGrid>
            <div class="clear">
            </div>
            <div style="float: right; padding-bottom: 10px;">
                <asp:Button ID="btnSaveRecycleTypeChanges2" runat="server" CssClass="button" Text="Save"
                    OnClick="btnSaveRecycleTypeChanges_Click" />
                <asp:Button ID="btnCancelRecycleTypeChanges2" runat="server" CssClass="button" Text="Cancel"
                    OnClick="btnCancelRecycleTypeChanges_Click" />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>

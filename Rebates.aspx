<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true"
    CodeBehind="Rebates.aspx.cs" Inherits="RenuOil.Rebates" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="bottomContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnAddNewRebate" />
            <asp:AsyncPostBackTrigger ControlID="btnSaveRebate" />
            <asp:AsyncPostBackTrigger ControlID="btnCancelRebate" />
            <asp:AsyncPostBackTrigger ControlID="btnSaveRebateChanges" />
            <asp:AsyncPostBackTrigger ControlID="btnCancelRebateChanges" />
            <asp:AsyncPostBackTrigger ControlID="rdRebate" />
        </Triggers>
        <ContentTemplate>
            <div style="float: right; padding-bottom: 10px;">
                <asp:Button ID="btnAddNewRebate" runat="server" CssClass="button" Text="Add New Rebate Service"
                    OnClick="btnAddNewRebate_Click" />
            </div>
            <div class="clear">
            </div>
            <div id="divAddNewRebate" runat="server">
                <hr />
                <h4 class="title">
                    Add New Rebate:</h4>
                <asp:HiddenField ID="hdnRebateId" runat="server" />
                <asp:Label ID="lblDate" CssClass="label" Text="Date:" runat="server"></asp:Label>
                <telerik:RadDatePicker ID="rdpDate" runat="server" CssClass="textbox">
                </telerik:RadDatePicker>
                <asp:Label ID="lblType" CssClass="label" Text="Type:" runat="server"></asp:Label>
                <asp:DropDownList ID="ddlRebateType" runat="server">
                </asp:DropDownList>
                <asp:Label ID="lblAccount" CssClass="label" Text="Account:" runat="server"></asp:Label>
                <asp:DropDownList ID="ddlRebateAccount" runat="server">
                </asp:DropDownList>
                <asp:Label ID="lblAmount" CssClass="label" Text="Account:" runat="server"></asp:Label>
                <asp:TextBox ID="txtRebateAmount" runat="server" CssClass="textbox" Width="180px"></asp:TextBox>
                <div style="float: right; padding-bottom: 10px;">
                    <asp:Button ID="btnSaveRebate" runat="server" CssClass="button" Text="Save" OnClick="btnSaveRebate_Click" />
                    <asp:Button ID="btnCancelRebate" runat="server" CssClass="button" Text="Cancel" OnClick="btnCancelRebate_Click" />
                </div>
            </div>
            <div class="clear">
                <br />
            </div>
            <hr />
            <center>
                <h4 class="title">This Month's Rebates</h4>
            </center>
            <div style="float: right; padding-bottom: 10px;">
                <asp:Button ID="btnSaveRebateChanges" runat="server" CssClass="button" Text="Save Changes"
                    OnClick="btnSaveRebateChanges_Click" />
                <asp:Button ID="btnCancelRebateChanges" runat="server" CssClass="button" Text="Cancel"
                    OnClick="btnCancelRebateChanges_Click" />
            </div>
            <div class="clear">
            </div>
            <asp:ScriptManager ID="scriptMgr" runat="server">
            </asp:ScriptManager>
            <telerik:RadGrid ID="rdRebate" AllowPaging="false" ShowFooter="true" runat="server"
                Skin="" AutoGenerateColumns="False" AllowSorting="False" PageSize="3" GridLines="Both"
                BorderColor="ActiveBorder" OnNeedDataSource="rdRebate_NeedDataSource" OnDeleteCommand="rdRebate_DeleteCommand"
                OnItemDataBound="rdRebate_OnItemDataBound" CellPadding="0" AllowAutomaticUpdates="true">
                <MasterTableView DataKeyNames="RebateId" AutoGenerateColumns="false" EditMode="InPlace"
                    ShowHeader="true" ShowFooter="false" NoDetailRecordsText="" NoMasterRecordsText="">
                    <Columns>
                        <telerik:GridBoundColumn SortExpression="RebateId" HeaderText="RebateId"
                            Visible="false" HeaderButtonType="TextButton" DataField="RebateId" Display="false"
                            ReadOnly="false" HeaderStyle-HorizontalAlign="Center">
                        </telerik:GridBoundColumn>
                        <telerik:GridTemplateColumn UniqueName="RebateDate" HeaderText="Rebate Date" HeaderStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <div style="text-align: center">
                                    <telerik:RadDatePicker ID="rdpDate" runat="server" CssClass="textbox" Width="218px"
                                        SelectedDate='<%# Eval("RebateDate") %>'>
                                    </telerik:RadDatePicker>
                            </ItemTemplate>
                            <ItemStyle CssClass="gridText gray" Width="280px" BorderColor="ActiveBorder" />
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn UniqueName="Type" HeaderText="Rebate Type" HeaderStyle-HorizontalAlign="Center"
                            ItemStyle-HorizontalAlign="Center" ItemStyle-Width="300px">
                            <ItemTemplate>
                                <div style="text-align: center">
                                    <asp:DropDownList ID="ddlType" runat="server" Width="180px">
                                    </asp:DropDownList>
                            </ItemTemplate>
                            <ItemStyle BorderColor="ActiveBorder" CssClass="gridTextItalic gray" HorizontalAlign="Center" />
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn UniqueName="Account" HeaderText="Account" HeaderStyle-HorizontalAlign="Center"
                            ItemStyle-HorizontalAlign="Center" ItemStyle-Width="300px">
                            <ItemTemplate>
                                <div style="text-align: center">
                                    <asp:DropDownList ID="ddlAccount" runat="server">
                                    </asp:DropDownList>
                            </ItemTemplate>
                            <ItemStyle BorderColor="ActiveBorder" CssClass="gridTextItalic gray" HorizontalAlign="Center" />
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn UniqueName="Amount" HeaderText="Amount" HeaderStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <div style="text-align: center">
                                    <asp:TextBox ID="txtAmount" runat="server" CssClass="gridtextbox" Text='<%# Eval("Amount") %>'
                                        Width="118px"></asp:TextBox></div>
                            </ItemTemplate>
                            <ItemStyle CssClass="gridText gray" Width="280px" BorderColor="ActiveBorder" />
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn UniqueName="Delete" HeaderText="" HeaderStyle-HorizontalAlign="Center"
                            ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50px">
                            <ItemTemplate>
                                <div style="text-align: center">
                                    <asp:Button ID="btnDeleteRebate" runat="server" CssClass="delete" CommandName="delete"
                                        CommandArgument='<%# Eval("RebateId") %>' UseSubmitBehavior="true" />
                            </ItemTemplate>
                            <ItemStyle BorderColor="ActiveBorder" CssClass="gridTextItalic gray" HorizontalAlign="Center" />
                        </telerik:GridTemplateColumn>
                    </Columns>
                </MasterTableView>
            </telerik:RadGrid>
            <div class="clear">
            </div>
            <div style="float: right; padding-bottom: 10px;">
                <asp:Button ID="btnSaveRebateChanges2" runat="server" CssClass="button" Text="Save Changes"
                    OnClick="btnSaveRebateChanges_Click" />
                <asp:Button ID="btnCancelRebateChanges2" runat="server" CssClass="button" Text="Cancel"
                    OnClick="btnCancelRebateChanges_Click" />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>

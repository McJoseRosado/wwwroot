<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true"
    CodeBehind="VendorService.aspx.cs" Inherits="RenuOil.VendorService" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="bottomContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnAddNewVendorService" />
            <asp:AsyncPostBackTrigger ControlID="btnSaveVendorService" />
            <asp:AsyncPostBackTrigger ControlID="btnCancelVendorService" />
            <asp:AsyncPostBackTrigger ControlID="btnSaveVendorChanges" />
            <asp:AsyncPostBackTrigger ControlID="btnCancelVendorChanges" />
            <asp:AsyncPostBackTrigger ControlID="rdVendorService" />
        </Triggers>
        <ContentTemplate>
            <div style="float: right; padding-bottom: 10px;">
                <asp:Button ID="btnAddNewVendorService" runat="server" CssClass="button" Text="Add New Vendor Service"
                    OnClick="btnAddNewVendorService_Click" />
            </div>
            <div class="clear">
            </div>
            <div id="divAddNewVendorService" runat="server">
                <hr />
                <h4 class="title">
                    Add New Vendor:</h4>
                <asp:HiddenField ID="hdnVendorServiceId" runat="server" />
                <asp:Label ID="lblDate" CssClass="label" Text="Date:" runat="server"></asp:Label>
                <telerik:RadDatePicker ID="rdpDate" runat="server" CssClass="textbox">
                </telerik:RadDatePicker>
                <asp:Label ID="lblType" CssClass="label" Text="Type:" runat="server"></asp:Label>
                <asp:DropDownList ID="ddlRecycleType" runat="server">
                </asp:DropDownList>
                <asp:Label ID="lblVendor" CssClass="label" Text="Vendor:" runat="server"></asp:Label>
                <asp:DropDownList ID="ddlRecycleVendor" runat="server">
                </asp:DropDownList>
                <asp:Label ID="lblAccount" CssClass="label" Text="Account:" runat="server"></asp:Label>
                <asp:DropDownList ID="ddlRecycleAccount" runat="server">
                </asp:DropDownList>
                <asp:Label ID="lblWeight" CssClass="label" Text="Weight:" runat="server"></asp:Label>
                <asp:TextBox ID="txtWeight" CssClass="textbox" runat="server" Width="100">0</asp:TextBox>
                <asp:Label ID="lblTotalMonthlyPulls" CssClass="label" Text="Total Monthly Pulls:"
                    runat="server"></asp:Label>
                <asp:TextBox ID="txtTotalMonthlyPulls" CssClass="textbox" runat="server" Width="100">0</asp:TextBox>
                <asp:Label ID="lblTotalMonthlyWeight" CssClass="label" Text="Total Monthly Weight (in tons):"
                    runat="server"></asp:Label>
                <asp:TextBox ID="txtTotalMonthlyWeight" CssClass="textbox" runat="server" Width="100">0</asp:TextBox>
                <div style="float: right; padding-bottom: 10px;">
                    <asp:Button ID="btnSaveVendorService" runat="server" CssClass="button" Text="Save"
                        OnClick="btnSaveVendorService_Click" />
                    <asp:Button ID="btnCancelVendorService" runat="server" CssClass="button" Text="Cancel"
                        OnClick="btnCancelVendorService_Click" />
                </div>
            </div>
            <div class="clear">
                <br />
            </div>
            <hr />
            <center>
                <h4 class="title">This Month's Vendor Service</h4>
            </center>
            <div style="float: right; padding-bottom: 10px;">
                <asp:Button ID="btnSaveVendorChanges" runat="server" CssClass="button" Text="Save Changes"
                    OnClick="btnSaveVendorChanges_Click" />
                <asp:Button ID="btnCancelVendorChanges" runat="server" CssClass="button" Text="Cancel"
                    OnClick="btnCancelVendorChanges_Click" />
            </div>
            <div class="clear">
            </div>
            <asp:ScriptManager ID="scriptMgr" runat="server">
            </asp:ScriptManager>
            <telerik:RadGrid ID="rdVendorService" AllowPaging="false" ShowFooter="true" runat="server"
                Skin="" AutoGenerateColumns="False" AllowSorting="False" PageSize="3" GridLines="Both"
                BorderColor="ActiveBorder" OnNeedDataSource="rdVendorService_NeedDataSource"
                OnDeleteCommand="rdVendorService_DeleteCommand" OnItemDataBound="rdVendorService_OnItemDataBound"
                CellPadding="0" AllowAutomaticUpdates="true">
                <MasterTableView DataKeyNames="RecycleVendorServiceId" AutoGenerateColumns="false"
                    EditMode="InPlace" ShowHeader="true" ShowFooter="false" NoDetailRecordsText=""
                    NoMasterRecordsText="">
                    <Columns>
                        <telerik:GridBoundColumn SortExpression="RecycleVendorServiceId" HeaderText="RecycleVendorServiceId"
                            Visible="false" HeaderButtonType="TextButton" DataField="RecycleVendorServiceId"
                            Display="false" ReadOnly="false" HeaderStyle-HorizontalAlign="Center">
                        </telerik:GridBoundColumn>
                        <telerik:GridTemplateColumn UniqueName="ServiceDate" HeaderText="Service Date" HeaderStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <div style="text-align: center">
                                    <telerik:RadDatePicker ID="rdpDate" runat="server" CssClass="textbox" Width="115px"
                                        SelectedDate='<%# Eval("ServiceDate") %>'>
                                    </telerik:RadDatePicker>
                            </ItemTemplate>
                            <ItemStyle CssClass="gridText gray" Width="280px" BorderColor="ActiveBorder" />
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn UniqueName="Type" HeaderText="Recycle Type" HeaderStyle-HorizontalAlign="Center"
                            ItemStyle-HorizontalAlign="Center" ItemStyle-Width="300px">
                            <ItemTemplate>
                                <div style="text-align: center">
                                    <asp:DropDownList ID="ddlType" runat="server">
                                    </asp:DropDownList>
                            </ItemTemplate>
                            <ItemStyle BorderColor="ActiveBorder" CssClass="gridTextItalic gray" HorizontalAlign="Center" />
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn UniqueName="Vendor" HeaderText="Vendor Name" HeaderStyle-HorizontalAlign="Center"
                            ItemStyle-HorizontalAlign="Center" ItemStyle-Width="300px">
                            <ItemTemplate>
                                <div style="text-align: center">
                                    <asp:DropDownList ID="ddlVendor" runat="server">
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
                        <telerik:GridTemplateColumn UniqueName="Weight" HeaderText="Weight" HeaderStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <div style="text-align: center">
                                    <asp:TextBox ID="txtWeight" runat="server" CssClass="gridtextbox" Text='<%# Eval("Weight") %>'
                                        Width="75px"></asp:TextBox></div>
                            </ItemTemplate>
                            <ItemStyle CssClass="gridText gray" Width="280px" BorderColor="ActiveBorder" />
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn UniqueName="TotalMonthlyPulls" HeaderText="Total Monthly Pulls"
                            HeaderStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <div style="text-align: center">
                                    <asp:TextBox ID="txtTotalMonthlyPulls" runat="server" CssClass="gridtextbox" Text='<%# Eval("TotalMonthlyPulls") %>'
                                        Width="100px"></asp:TextBox></div>
                            </ItemTemplate>
                            <ItemStyle CssClass="gridText gray" Width="280px" BorderColor="ActiveBorder" />
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn UniqueName="TotalMonthlyWeight" HeaderText="Total Monthly Weight"
                            HeaderStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <div style="text-align: center">
                                    <asp:TextBox ID="txtTotalMonthlyWeight" runat="server" CssClass="gridtextbox" Text='<%# Eval("TotalMonthlyWeight") %>'
                                        Width="100px"></asp:TextBox></div>
                            </ItemTemplate>
                            <ItemStyle CssClass="gridText gray" Width="280px" BorderColor="ActiveBorder" />
                        </telerik:GridTemplateColumn>
                        <telerik:GridTemplateColumn UniqueName="Delete" HeaderText="" HeaderStyle-HorizontalAlign="Center"
                            ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50px">
                            <ItemTemplate>
                                <div style="text-align: center">
                                    <asp:Button ID="btnDeleteVendor" runat="server" CssClass="delete" CommandName="delete"
                                        CommandArgument='<%# Eval("RecycleVendorServiceId") %>' UseSubmitBehavior="true" />
                            </ItemTemplate>
                            <ItemStyle BorderColor="ActiveBorder" CssClass="gridTextItalic gray" HorizontalAlign="Center" />
                        </telerik:GridTemplateColumn>
                    </Columns>
                </MasterTableView>
            </telerik:RadGrid>
            <div class="clear">
            </div>
            <div style="float: right; padding-bottom: 10px;">
                <asp:Button ID="btnSaveVendorChanges2" runat="server" CssClass="button" Text="Save Changes"
                    OnClick="btnSaveVendorChanges_Click" />
                <asp:Button ID="btnCancelVendorChanges2" runat="server" CssClass="button" Text="Cancel"
                    OnClick="btnCancelVendorChanges_Click" />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true" CodeBehind="FiltrationSchedules.aspx.cs" Inherits="RenuOil.FiltrationSchedules" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <telerik:RadAjaxManager ID="RadAjaxManager2" runat="server"></telerik:RadAjaxManager>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="sideBarContent" runat="server"></asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="bottomContent" runat="server">
    <h4><a id="title" runat="server">Filtration Schedules</a></h4>
    <div id="messages" runat="server">
        <div class="clear">
        </div>
    </div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="rdAccountGrid" />
            <asp:PostBackTrigger ControlID="btnSaveSchedule" />
            <asp:PostBackTrigger ControlID="btnSaveSchedule2" />
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
            <div style="float: right; padding-bottom: 10px;">
                <asp:Button ID="btnSaveSchedule" runat="server" CssClass="button" Text="Save Schedule" OnClick="btnSaveSchedule_Click" />
                <asp:Button ID="btnCancel" runat="server" CssClass="button" Text="Cancel" OnClick="btnCancel_Click" />
            </div>
            <div class="clear">
            </div>
            <telerik:RadGrid ID="rdAccountGrid" CssClass="" AllowPaging="false" ShowFooter="false" ShowGroupPanel="true" runat="server" Skin="" AutoGenerateColumns="False" AllowSorting="False" PageSize="3" GridLines="Both" BorderColor="ActiveBorder" OnItemDataBound="rdAccountGrid_OnItemDataBound" OnDetailTableDataBind="rdAccountGrid_DetailTableDataBind" CellPadding="0" AllowAutomaticUpdates="true">
                <MasterTableView Name="MasterView" DataKeyNames="AccountId" AutoGenerateColumns="false" HorizontalAlign="Right" HierarchyDefaultExpanded="true" Width="900" EditMode="InPlace" ShowHeader="false" ShowFooter="false" NoDetailRecordsText="" NoMasterRecordsText="">
                    <Columns>
                        <telerik:GridBoundColumn SortExpression="AccountId" HeaderText="AccountId" Visible="false" DataField="AccountId"></telerik:GridBoundColumn>
                        <telerik:GridTemplateColumn UniqueName="AccountName" HeaderText="" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <h4>
                                    <asp:Label ID="lblAccountName" CssClass="title" runat="server"></asp:Label></h4>
                            </ItemTemplate>
                            <ItemStyle CssClass="gridHeader gray" Height="30px" BorderColor="ActiveBorder" BorderWidth="1" VerticalAlign="Top" />
                        </telerik:GridTemplateColumn>
                    </Columns>
                    <DetailTables>
                        <telerik:GridTableView DataKeyNames="AccountId" Name="WeekView" Width="100%" HorizontalAlign="Right" Visible="true" ExpandCollapseColumn-Visible="false" ExpandCollapseColumn-Display="false" ShowHeader="true" ShowHeadersWhenNoRecords="false" HierarchyLoadMode="Client" FooterStyle-Height="10px" ShowFooter="true" EditMode="InPlace">
                            <Columns>
                                <telerik:GridBoundColumn SortExpression="AccountEmployeeAssignmentId" HeaderText="" Visible="false" HeaderButtonType="TextButton" DataField="AccountEmployeeAssignmentId" Display="false" ReadOnly="false" HeaderStyle-HorizontalAlign="Center"></telerik:GridBoundColumn>
                                <telerik:GridTemplateColumn UniqueName="Monday" HeaderText="Monday" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Width="95" ItemStyle-Width="95" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <asp:DropDownList ID="ddlEmployeesMonday" CssClass="employeeDropdown" runat="server"></asp:DropDownList>
                                    </ItemTemplate>
                                    <ItemStyle BorderColor="ActiveBorder" CssClass="gridText gray" />
                                </telerik:GridTemplateColumn>
                                <telerik:GridTemplateColumn UniqueName="Tuesday" HeaderText="Tuesday" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Width="95" ItemStyle-Width="95" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <div>
                                            <asp:DropDownList ID="ddlEmployeesTuesday" CssClass="employeeDropdown" runat="server"></asp:DropDownList>
                                        </div>
                                    </ItemTemplate>
                                    <ItemStyle BorderColor="ActiveBorder" CssClass="gridText gray" />
                                </telerik:GridTemplateColumn>
                                <telerik:GridTemplateColumn UniqueName="Wednesday" HeaderText="Wednesday" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Width="95" ItemStyle-Width="95" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <div>
                                            <asp:DropDownList ID="ddlEmployeesWednesday" CssClass="employeeDropdown" runat="server"></asp:DropDownList>
                                        </div>
                                    </ItemTemplate>
                                    <ItemStyle BorderColor="ActiveBorder" CssClass="gridText gray" />
                                </telerik:GridTemplateColumn>
                                <telerik:GridTemplateColumn UniqueName="Thursday" HeaderText="Thursday" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Width="95" ItemStyle-Width="95" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <div>
                                            <asp:DropDownList ID="ddlEmployeesThursday" CssClass="employeeDropdown" runat="server"></asp:DropDownList>
                                        </div>
                                    </ItemTemplate>
                                    <ItemStyle BorderColor="ActiveBorder" CssClass="gridText gray" />
                                </telerik:GridTemplateColumn>
                                <telerik:GridTemplateColumn UniqueName="Friday" HeaderText="Friday" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Width="95" ItemStyle-Width="95" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <div>
                                            <asp:DropDownList ID="ddlEmployeesFriday" CssClass="employeeDropdown" runat="server"></asp:DropDownList>
                                        </div>
                                    </ItemTemplate>
                                    <ItemStyle BorderColor="ActiveBorder" CssClass="gridText gray" />
                                </telerik:GridTemplateColumn>
                                <telerik:GridTemplateColumn UniqueName="Saturday" HeaderText="Saturday" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Width="95" ItemStyle-Width="95" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <div>
                                            <asp:DropDownList ID="ddlEmployeesSaturday" CssClass="employeeDropdown" runat="server"></asp:DropDownList>
                                        </div>
                                    </ItemTemplate>
                                    <ItemStyle BorderColor="ActiveBorder" CssClass="gridText gray" />
                                </telerik:GridTemplateColumn>
                                <telerik:GridTemplateColumn UniqueName="Sunday" HeaderText="Sunday" HeaderStyle-HorizontalAlign="Center" HeaderStyle-Width="95" ItemStyle-Width="95" ItemStyle-HorizontalAlign="Center">
                                    <ItemTemplate>
                                        <div>
                                            <asp:DropDownList ID="ddlEmployeesSunday" CssClass="employeeDropdown" runat="server"></asp:DropDownList>
                                        </div>
                                    </ItemTemplate>
                                    <ItemStyle BorderColor="ActiveBorder" CssClass="gridText gray" />
                                </telerik:GridTemplateColumn>
                            </Columns>
                            <ItemStyle BorderColor="ActiveBorder" Height="22px" BackColor="#E8E8E8" CssClass="gridTextItalic gray" />
                            <AlternatingItemStyle Height="22px" BackColor="#E8E8E8" CssClass="gridTextItalic" BorderWidth="1" />
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
            <div class="clear">
            </div>
            <div style="float: right; padding-bottom: 10px;">
                <asp:Button ID="btnSaveSchedule2" runat="server" CssClass="button" Text="Save Schedule" OnClick="btnSaveSchedule_Click" />
                <asp:Button ID="btnCancel2" runat="server" CssClass="button" Text="Cancel" OnClick="btnCancel_Click" />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="footerContent" runat="server"></asp:Content>

<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/Main.Master" CodeFile="DockWorkers.aspx.cs" Inherits="RenuOil.DockWorkers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <h4><a href="#">All Employees</a></h4>
    <div style="float: right; padding-bottom: 10px;">
        <asp:Button ID="btnAddNewEmployee" runat="server" CssClass="button" Text="Add New Employee" UseSubmitBehavior="true" OnClick="btnAddNewEmployee_Click" />
    </div>
    <asp:Repeater runat="server" OnItemDataBound="rptEmployees_ItemDataBound" OnItemCommand="rptEmployees_ItemCommand" DataSourceID="SqlDataSource1">
        <HeaderTemplate>
            <table id="employeeTable" cellspacing="0" class="repeater" width="650px">
                <tr>
                    <th>Name </th>
                    <th>Employee No. </th>
                    <th>Phone</th>
                    <th>Delete</th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <strong>
                        <asp:LinkButton ID="lnkBtnEditEmployee" Text="" CssClass="repeater" CommandName="Edit" CommandArgument='<%# Eval("EmployeeId") %>' runat="server"></asp:LinkButton></center> </strong>
                </td>
                <td style="width: 120px; text-align: center;">
                    <asp:Label ID="lblEmployeeNo" runat="server"></asp:Label>
                </td>
                <td style="width: 120px; text-align: center;">
                    <asp:Label ID="lblPhone" runat="server"></asp:Label>
                </td>
                <td style="width: 120px; text-align: center;">
                    <asp:LinkButton ID="lbDelete" runat="server" Text="Delete" CommandName="Delete" CommandArgument='<%# Eval("EmployeeId") %>' OnClick="lbDelete_OnClick">
                    </asp:LinkButton>
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate></table> </FooterTemplate>
    </asp:Repeater>
    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:ConnectionString %>' SelectCommand="SELECT [First Name] AS First_Name, [Middle Name] AS Middle_Name, [Last Name] AS Last_Name, [Property Name] AS Property_Name FROM [DockWorkers]"></asp:SqlDataSource>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="sideBarContent" runat="server">
    <div class="sidebar nospace">
        <div class="sidebartop">
        </div>
        <div class="sidebarmain">
            <div class="sidebarcontent">
                <h4 class="sidebarheading">Employees</h4>
                <p>These are the employees that are involved in servicing our outlets.</p>
                <div class="clear">
                </div>
                <%--                <a href="#" class="button-more">View All News</a>--%>
            </div>
        </div>
        <div class="sidebarbottom">
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="footerContent" runat="server"></asp:Content>

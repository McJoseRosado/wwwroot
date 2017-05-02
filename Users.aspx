<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="RenuOil.Users" EnableEventValidation="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <h4><a href="#"> General Users</a></h4>
    <div style="float: right; padding-bottom: 10px;">
        <asp:Button ID="btnAddNewUser" runat="server" CssClass="button" Text="Add New User" UseSubmitBehavior="true" OnClick="btnAddNewUser_Click" />
    </div>
    <asp:Repeater ID="rptUsers" runat="server" OnItemDataBound="rptUsers_ItemDataBound" OnItemCommand="rptUsers_ItemCommand">
        <HeaderTemplate>
            <table id="userTable" cellspacing="0" class="repeater" width="650px">
                <tr>
                    <th>Name </th>
                    <th>Username </th>
                    <th></th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <strong>
                        <asp:LinkButton ID="lnkBtnEditUser" Text="" CssClass="repeater" CommandName="Edit" CommandArgument='<%# Eval("UserId") %>' runat="server"></asp:LinkButton></center> </strong>
                </td>
                <td style="width: 120px; text-align: center">
                    <asp:Label ID="lblUsername" runat="server"></asp:Label>
                </td>
                <td style="width:70px; text-align:center">
                    <asp:LinkButton ID="btnDeleteUser" runat="server" CssClass="repeater" Text="Delete" CommandName="Delete" CommandArgument='<%# Eval("UserId") %>' />
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate></table> </FooterTemplate>
    </asp:Repeater>
    <br />
    <br />
    <br />

    <h4><a href="#">Facility Users</a></h4>
    <div style="float: right; padding-bottom: 10px;">
        <asp:Button ID="Button1" runat="server" CssClass="button" Text="Add New User" UseSubmitBehavior="true" OnClick="btnAddNewUser_Click" />
    </div>
    <asp:Repeater ID="rptFacilityUsers" runat="server" OnItemDataBound="rptFacilityUsers_ItemDataBound" OnItemCommand="rptFacilityUsers_ItemCommand">
        <HeaderTemplate>
            <table id="facilityUserTable" cellspacing="0" class="repeater" width="650px">
                <tr>
                    <th>Name </th>
                    <th>Username </th>
                    <th></th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <strong>
                        <asp:LinkButton ID="lnkBtnEditFacilityUser" Text="" CssClass="repeater" CommandName="Edit" CommandArgument='<%# Eval("UserId") %>' runat="server"></asp:LinkButton></center> </strong>
                </td>
                <td style="width: 120px; text-align: center">
                    <asp:Label ID="lblUsername" runat="server"></asp:Label>
                </td>
                <td style="width:70px; text-align:center">
                    <asp:LinkButton ID="btnDeleteUser" runat="server" CssClass="repeater" Text="Delete" CommandName="Delete" CommandArgument='<%# Eval("UserId") %>' />
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate></table> </FooterTemplate>
    </asp:Repeater>



</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="sideBarContent" runat="server">
    <div class="sidebar nospace">
        <div class="sidebartop">
        </div>
        <div class="sidebarmain">
            <div class="sidebarcontent">
                <h4 class="sidebarheading">Users</h4>
                <p>Listed are the portal administrators responsible for the maintenance and update of the portal.</p>
                <div class="clear">
                </div>
                <%--                <a href="#" class="button-more">View All News</a>--%>
            </div>
        </div>
        <div class="sidebarbottom">
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="bottomContent" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true" CodeBehind="FacilityUsers.aspx.cs" Inherits="RenuOil.FacilityUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <h4><a href="#">Facility Users</a></h4>
    <div style="float: right; padding-bottom: 10px;">
        <asp:Button ID="btnAddNewUser" runat="server" CssClass="button" Text="Add New User" UseSubmitBehavior="true" OnClick="btnAddNewUser_Click" />
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
                    <asp:Button ID="btnDeleteUser" runat="server" CssClass="delete" CommandName="Delete" CommandArgument='<%# Eval("UserId") %>' UseSubmitBehavior="true" />
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
                <h4 class="sidebarheading">Sidebar Notes</h4>
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque condimentum dui quis sem fermentum a mattis ipsum ultrices. </p>
                <p>Integer eu lacus sit amet mauris hendrerit egestas et eget neque. Mauris ac justo tempus velit imperdiet placerat. Nullam dolor lectus, sollicitudin sed dictum nec, consequat in erat. Quisque nibh ligula.</p>
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque condimentum dui quis sem fermentum a mattis ipsum ultrices. </p>
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

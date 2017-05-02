<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true"
    CodeFile="RecyclingAccounts.aspx.cs" Inherits="RenuOil.RecyclingAccounts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <h4>
        <a href="#">Recycling Accounts</a></h4>
    <div style="float: right; padding-bottom: 10px;">
        <asp:Button ID="btnAddNewAccount" runat="server" CssClass="button" Text="Add New Account"
            UseSubmitBehavior="true" OnClick="btnAddNewAccount_Click" />
    </div>
    <asp:Repeater ID="rptAccounts" runat="server" OnItemDataBound="rptAccounts_ItemDataBound"
        OnItemCommand="rptAccounts_ItemCommand">
        <HeaderTemplate>
            <table id="accountTable" cellspacing="0" class="repeater" width="650px">
                <tr>
                    <th>
                        Name
                    </th>
                    <th>
                        Account No.
                    </th>
                    <th>
                        Phone
                    </th>
                    <th>
                    </th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <strong>
                        <asp:LinkButton ID="lnkBtnEditAccount" Text="" CssClass="repeater" CommandName="Edit"
                            CommandArgument='<%# Eval("AccountId") %>' runat="server"></asp:LinkButton></center>
                    </strong>
                </td>
                <td style="width: 120px; text-align: center">
                    <asp:Label ID="lblAcctNo" runat="server"></asp:Label>
                </td>
                <td style="width: 120px; text-align: center">
                    <asp:Label ID="lblPhone" runat="server"></asp:Label>
                </td>
                <td style="width: 45px; text-align: center">
                    <asp:LinkButton ID="lnkBtnDelete" Text="Delete" CssClass="repeater" CommandName="Delete"
                        CommandArgument='<%# Eval("AccountId") %>' runat="server" OnClientClick="javascript:return confirm('Are you sure you want to delete?');"></asp:LinkButton></center>
                    </strong>
                </td>
            </tr>
        </ItemTemplate>
        <AlternatingItemTemplate>
            <tr style="background-color: #F0F0F0;">
                <td>
                    <strong>
                        <asp:LinkButton ID="lnkBtnEditAccount" Text="" CssClass="repeater" CommandName="Edit"
                            CommandArgument='<%# Eval("AccountId") %>' runat="server"></asp:LinkButton></center>
                    </strong>
                </td>
                <td style="width: 120px; text-align: center">
                    <asp:Label ID="lblAcctNo" runat="server"></asp:Label>
                </td>
                <td style="width: 120px; text-align: center">
                    <asp:Label ID="lblPhone" runat="server"></asp:Label>
                </td>
                <td style="width: 45px; text-align: center">
                    <asp:LinkButton ID="LinkButton1" Text="Delete" CssClass="repeater" CommandName="Delete"
                        CommandArgument='<%# Eval("AccountId") %>' runat="server"></asp:LinkButton></center>
                    </strong>
                </td>
            </tr>
        </AlternatingItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="sideBarContent" runat="server">
    <div class="sidebar nospace">
        <div class="sidebartop">
        </div>
        <div class="sidebarmain">
            <div class="sidebarcontent">
                <h4 class="sidebarheading">
                    Sidebar Notes</h4>
                <p>
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque condimentum
                    dui quis sem fermentum a mattis ipsum ultrices.
                </p>
                <p>
                    Integer eu lacus sit amet mauris hendrerit egestas et eget neque. Mauris ac justo
                    tempus velit imperdiet placerat. Nullam dolor lectus, sollicitudin sed dictum nec,
                    consequat in erat. Quisque nibh ligula.</p>
                <p>
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque condimentum
                    dui quis sem fermentum a mattis ipsum ultrices.
                </p>
                <div class="clear">
                </div>
                <%--                <a href="#" class="button-more">View All News</a>--%>
            </div>
        </div>
        <div class="sidebarbottom">
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>

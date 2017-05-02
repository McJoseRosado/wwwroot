<%@ Page Title="Accounts" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true"
    CodeBehind="Accounts.aspx.cs" Inherits="RenuOil.Accounts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <h4>
        <a href="#">All Accounts</a></h4>
    <div style="float: right; padding-bottom: 10px;">
        <asp:Button ID="btnAddNewAccount" runat="server" CssClass="button" Text="Add New Account"
            UseSubmitBehavior="true" OnClick="btnAddNewAccount_Click" />
    </div>
    <table>
        <tr>
            <td style="vertical-align: middle;">
                Filter by type:
            </td>
            <td>
                <asp:DropDownList ID="ddlType" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlType_SelectedIndexChanged"
                    Style="margin-left: 5px;">
                </asp:DropDownList>
            </td>
        </tr>
    </table>
    <br />
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
                    Main accounts are listed here.  To view the sub-accounts for each main account, simply click a link to view the sub-accounts (satellite dock, kitchens, etc.) 
                    for each main account.
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

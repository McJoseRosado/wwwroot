<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true" CodeBehind="BeginWorkOrder.aspx.cs" Inherits="RenuOil.BeginWorkOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <h4>
        <a href="#">Begin Work Order</a>
    </h4>
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
                        Last Service
                    </th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <strong>
                        <asp:LinkButton ID="lnkBtnEditAccount" Text="" CssClass="repeater" CommandName="BeginWorkOrder"
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
                    <asp:Label ID="lblLastService" runat="server"></asp:Label></center>
                    </strong>
                </td>
            </tr>
        </ItemTemplate>
        <AlternatingItemTemplate>
            <tr style="background-color: #F0F0F0;">
                <td>
                    <strong>
                        <asp:LinkButton ID="lnkBtnEditAccount" Text="" CssClass="repeater" CommandName="BeginWorkOrder"
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
                    <asp:Label ID="lblLastService" runat="server"></asp:Label></center>
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
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="bottomContent" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="mainContent2" runat="server">
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="sideBarContent2" runat="server">
</asp:Content>
<asp:Content ID="Content8" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>

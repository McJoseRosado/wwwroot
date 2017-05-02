<%@ Page Title="Portal" Language="C#" MasterPageFile="/MasterPages/Main.Master" AutoEventWireup="true" CodeBehind="Receiver.aspx.cs" Inherits="RenuOil.MasterPages.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
       <h3 style="vertical-align: middle; text-align: center;">Receiver View</h3>
    <div>
        <table>
            <tr>
                <td style="vertical-align: middle;">Load Date: 1/15/2016 &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                </td>
                <td style="vertical-align: middle;">Driver: Jonathan&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                </td>
                <td style="vertical-align: middle;">Load: 3&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                </td>
            </tr>
        </table>
    </div>
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" CssClass="grid" AllowPaging="true" PageSize="8" AllowSorting="true" AlternatingRowStyle-CssClass="alt">
            <Columns>
                 <asp:BoundField HeaderText="Property" DataField="Property">
                    <ItemStyle Width="90px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="Dock" DataField="Dock">
                    <ItemStyle Width="90px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="Bale #" DataField="Bale">
                    <ItemStyle Width="70px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="Commidity" DataField="Comm">
                    <ItemStyle Width="70px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="Initial Weight" DataField="InitWt">
                    <ItemStyle Width="90px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="Warehouse Weight" DataField="WharehouseWt">
                    <ItemStyle Width="90px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="Calculated Final Weight" DataField="FinalWt">
                    <ItemStyle Width="90px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="Notes" DataField="Notes">
                    <ItemStyle Width="210px"></ItemStyle>
                </asp:BoundField>
            </Columns>
        </asp:GridView>
        <table width="300">
            <tr>
                <td align="center">
                    <asp:Button ID="Button1" runat="server" Text="Save" Width="100" CssClass="button" /></td>
                <td align="center">
                    <asp:Button ID="Button2" runat="server" Text="Cancel" Width="100" CssClass="button" /></td>
            </tr>
        </table>
    </div>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="mainContent2" runat="server">
    <h3>COC Proof of concept.</h3>
    <p>
        UI for managing all aspects of materials handling (Chain of custody):
    </p>
    <div class="itemlist">
        <ul>
            <li>Load</li>
            <li>Existing Load</li>
            <li>COC</li>
            <li>Receiver View </li>
            <li>Validation</li>
        </ul>
    </div>
    <div class="spacer">
    </div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="sideBarContent" runat="server">
    <div class="sidebar nospace">
        <div class="sidebartop">
        </div>
        <div class="sidebarmain">
            <div class="sidebarcontent">
                <h4 class="sidebarheading">Side Note</h4>
                <p>
                </p>
                <div class="clear">
                </div>
            </div>
        </div>
        <div class="sidebarbottom">
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="bottomContent" runat="server">
</asp:Content>
<asp:Content ID="Content8" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>

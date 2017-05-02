<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true" CodeFIle="Load.aspx.cs"  Inherits="RenuOil.Load"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <h3 style="vertical-align: middle; text-align:center;">SELECT NEW OR EXISTING LOAD PROCESSING</h3>
    <div>
         <table width="500" style="text-align:center;">
            <tr>
                <td align="center">
                    <asp:Button ID="NewLoadButton" runat="server" Text="New Load" Width="100" OnClick="NewLoadButton_Click" CssClass="button" /></td>
                <td align="center">
                    <asp:Button ID="ExistingButton" runat="server" Text="Existing Load" Width="100" OnClick="ExistingButton_Click" CssClass="button"/></td>
            </tr>
        </table>
    </div>
</asp:Content>


<asp:Content ID="Content5" ContentPlaceHolderID="sideBarContent" runat="server">
    <div class="sidebar nospace">
        <div class="sidebartop">
        </div>
        <div class="sidebarmain">
            <div class="sidebarcontent">
                <h4 class="sidebarheading">
                    Side Note</h4>
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
<asp:Content ID="Content6" ContentPlaceHolderID="bottomContent" runat="server">
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>

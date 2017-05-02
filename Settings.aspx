<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true" CodeBehind="Settings.aspx.cs" Inherits="RenuOil.Settings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <h4 class="title">Settings Administration</h4>
    <div class="spacer">
    </div>
    <div id="errormessages" runat="server" class="error" visible="false">
    </div>
    <asp:Label ID="lblBaleWeight" Text="Bale Weight (lbs):" CssClass="label" runat="server"></asp:Label>
    <asp:TextBox ID="txtBaleWeight" CssClass="textbox" runat="server"></asp:TextBox>
    <asp:Label ID="lblNumberOfBagsInBale" Text="# of bags per bale:" CssClass="label" runat="server"></asp:Label>
    <asp:TextBox ID="txtNumberOfBagsInBale" CssClass="textbox" runat="server"></asp:TextBox>
    <div style="float: right; padding-bottom: 10px;">
        <asp:Button ID="btnSaveSettings" runat="server" CssClass="button" Text="Save Settings" UseSubmitBehavior="true" OnClick="btnSaveSettingss_Click" />
        <asp:Button ID="btnCancel" runat="server" CssClass="button" Text="Cancel" OnClick="btnCancel_Click" />
    </div>
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
<asp:Content ID="Content5" ContentPlaceHolderID="bottomContent" runat="server"></asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="footerContent" runat="server"></asp:Content>

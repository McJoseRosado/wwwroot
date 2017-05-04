<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="RenuOil.Home" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content3" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
    <%--        <div class="heading-text">
          <h3>FAQ</h3>
          <p>Lorem ipsum dolor sit amet, rutrum lectus non libero molestie pellentesque</p>
        </div>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server"></asp:Content>
<%--<asp:Content ID="Content5" ContentPlaceHolderID="sideBarContent" runat="server">
    <div class="sidebar nospace">
        <div class="sidebartop">
        </div>
        <div class="sidebarmain">
            <div class="sidebarcontent">
                <h4 class="sidebarheading">Today's Notes</h4>
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque condimentum dui quis sem fermentum a mattis ipsum ultrices. </p>
                <p>Integer eu lacus sit amet mauris hendrerit egestas et eget neque. Mauris ac justo tempus velit imperdiet placerat. Nullam dolor lectus, sollicitudin sed dictum nec, consequat in erat. Quisque nibh ligula.</p>
                <div class="clear">
                </div>
                <%--                <a href="#" class="button-more">View All News</a>
            </div>
        </div>
        <div class="sidebarbottom">
        </div>
    </div>
</asp:Content>--%>
<asp:Content ID="Content6" ContentPlaceHolderID="bottomContent" runat="server">
    <div id="mainView" runat="server">
        <div class="mainbox2">
            <h4 class="title">Oil Filtration</h4>
            <div id="oilFiltrationBox" runat="server" class="boximg2">
                <a href="NewOrExistingOilFiltration.aspx">
                    <img src="images/service-img8.jpg" class="boximg-pad" alt="" /></a></div>
            <div id="oilFiltrationNoAccessBox" runat="server" visible="false" class="boximg2">
                <img src="images/noaccess.jpg" class="boximg-pad" alt="" /></div>
        </div>
        <div class="mainbox2">
            <h4 class="title">Asset Recovery</h4>
            <div id="assetBox" runat="server" class="boximg2">
                <a href="AssetReclamationAccounts.aspx">
                    <img src="images/service-img4.jpg" class="boximg-pad" alt="" /></a></div>
            <div id="assetNoAccessBox" runat="server" visible="false" class="boximg2">
                <img src="images/noaccess.jpg" class="boximg-pad" alt="" /></div>
        </div>
        <div class="mainbox2 box">
            <h4 class="title">Schedules</h4>
            <div id="schedulesBox" runat="server" class="boximg2">
                <a href="FiltrationSchedules.aspx">
                    <img src="images/service-img4.jpg" class="boximg-pad" alt="" /></a></div>
            <div id="schedulesNoAccessBox" runat="server" visible="false" class="boximg2">
                <img src="images/noaccess.jpg" class="boximg-pad" alt="" /></div>
        </div>
         <div class="mainbox2 box-last">
            <h4 class="title">COC</h4>
            <div id="usersBox" runat="server" class="boximg2">
                <a href="COC3.aspx">
                    <img src="images/service-img6.jpg" class="boximg-pad" alt="" /></a></div>
            <div id="usersNoAccessBox" runat="server" visible="false" class="boximg2">
                <img src="images/noaccess.jpg" class="boximg-pad" alt="" /></div>
        </div>
        <div class="spacer">
        </div>
        <div class="mainbox2 box">
            <h4 class="title">Settings</h4>
            <div id="settingsBox" runat="server" class="boximg2">
                <a href="Settings.aspx">
                    <img src="images/service-img4.jpg" class="boximg-pad" alt="" /></a></div>
            <div id="settingsNoAccessBox" runat="server" visible="false" class="boximg2">
                <img src="images/noaccess.jpg" class="boximg-pad" alt="" /></div>
        </div>
    </div>
    <div id="companyView" runat="server" visible="false">
        <div class="mainbox2">
            <h4 class="title">Work Orders</h4>
            <div id="Div2" runat="server" class="boximg2">
                <a href="WorkOrders.aspx">
                    <img src="images/service-img5.jpg" class="boximg-pad" alt="" /></a></div>
            <div id="Div3" runat="server" visible="false" class="boximg2">
                <img src="images/noaccess.jpg" class="boximg-pad" alt="" /></div>
        </div>
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true" CodeBehind="ReleaseNotes.aspx.cs" Inherits="RenuOil.ReleaseNotes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="sideBarContent" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="bottomContent" runat="server">
    <center>
        <h4>
            <a id="title" runat="server">Release Notes</a></h4>
    </center>
    <div class="spacer">
    </div>
    <div class="itemlist">
         <h4 class="title">
            Febuary 23,2017</h4>
        <ul>
            <li>Creation of COC and Production pages</li>
            <li>Fixed accounts bug</li>
        </ul>
         <h4 class="title">
            July 11, 2012</h4>
        <ul>
            <li>Initial changes to viewing and creating work orders.  Allow user to choose by type.</li>
        </ul>
        <h4 class="title">
            March 1, 2012</h4>
        <ul>
            <li>Fixed bug in creating new Asset Reclamation / Recycling accounts.</li>
            <li>On accounts and work order pages, there are now links to allow you to delete the account or work order. </li>
            <li>Added tracking of admin changes.  The system will now log who made the following changes:  fryer size changed, fryer added, fryer deleted, and asset type price changes. 
            The fryer revisions are shown on the restaurant outlet pages and the asset type price changes are shown on the asset reclamation account page.</li>
        </ul>
        <h4 class="title">
            February 17, 2012</h4>
        <ul>
            <li>Made changes to Schedules editor. Now called "Filtration Schedules" and presents one employee dropdown list per day per location as requested. </li>
            <li>Miscellaneous text changes. </li>
        </ul>
        <h4 class="title">
            February 17, 2012</h4>
        <ul>
            <li>Made changes to Schedules editor. Now called "Filtration Schedules" and presents one employee dropdown list per day per location as requested. </li>
            <li>Miscellaneous text changes. </li>
        </ul>
        <h4 class="title">
            February 6, 2012</h4>
        <ul>
            <li>
                <p>
                    Added functionality for user types (Administrator, Manager, Loader / Driver). Manager type has same privileges as the administrator user type, but does not have access to the web user administration. Loader / Driver will only have access to the Dock and Pull Schedules (not complete yet, links available only).
                </p>
            </li>
        </ul>
    </div>
    <div class="spacer">
    </div>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>

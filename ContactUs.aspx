<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Blueprint.Master" AutoEventWireup="true"
    CodeBehind="ContactUs.aspx.cs" Inherits="RenuOil.ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="slideshowContent" runat="server">
    <div id="slider">
        <a href="#">
            <img src="images/slideimage15.jpg" alt="slide image" /></a>
        <!-- Slide Item #6 -->
        <a href="#">
            <img src="images/slideimage9.jpg" alt="slide image" /></a>
        <!-- Slide Item #1 -->
        <a href="#">
            <img src="images/slideimage11.jpg" alt="slide image" /></a>
        <!-- Slide Item #3 -->
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="featuresContent" runat="server">
    <ul>
        <!-- Features Box #1 -->
        <li class="first">
            <img src="images/bar-chart.png" class="alignleft" alt="" />
            <h4>
                <a href="#">Economy</a></h4>
            <div class="clear">
            </div>
            <p>
                About 80% of what Americans throw away is recyclable.</p>
        </li>
        <!-- Features Box #2 -->
        <li>
            <img src="images/fancy-globe.png" class="alignleft" alt="" />
            <h4>
                <a href="#">Ecology</a></h4>
            <div class="clear">
            </div>
            <p>
                If all newspaper was recycled, we could save about 250,000,000 trees each year!</p>
        </li>
        <!-- Features Box #3 -->
        <li>
            <img src="images/processing.png" class="alignleft" alt="" />
            <h4>
                <a href="#">Green Fuel</a></h4>
            <div class="clear">
            </div>
            <p>
                Biodiesel is biodegradable, nontoxic, and essentially free of sulfur and aromatics.</p>
        </li>
        <!-- Features Box #4 -->
        <li class="last">
            <img src="images/connections.png" class="alignleft" alt="" />
            <h4>
                <a href="#">Connectivity</a></h4>
            <div class="clear">
            </div>
            <p>
                We'll collect 100% of your recyclables.</p>
        </li>
    </ul>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="mainContent" runat="server">
    <ul class="itemlist">
        <li>
            <h3>
                Mailing Address:</h3>
            <p>
                P.O. Box 93453
                <br />
                Las Vegas, NV 89193</p>
        </li>
        <li>
            <h3>
                Phone:</h3>
            <p>
                (702) 263-0078
            </p>
        </li>
        <li>
            <h3>
                Email:</h3>
            <p>
                <a href="mailto:info@gogreenwithrenuoil.com">info@gogreenwithrenuoil.com</a></p>
        </li>
        <li>
            <h3>
                Website:</h3>
            <p>
                <a href="http://www.gogreenwithrenuoil.com">http://www.gogreenwithrenuoil.com</a></p>
        </li>
    </ul>
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
                    If you’re looking to change your energy bill and lower your carbon footprint, consider
                    solar panels for your home. There are federal initiatives that offer tax deductions
                    for residents who decide to implement energy-efficient methods to their homes. Also,
                    solar panel technology has advanced greatly and has lowered the costs of implementing
                    solar panels to every home. If you’re looking to get some help with this, visit
                    the <a href="http://www.energystar.gov/index.cfm?c=tax_credits.tx_index">Energy Star
                    </a>website for further information and assistance regarding solar panels.
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

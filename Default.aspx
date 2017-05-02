<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Blueprint.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="RenuOil.Pages_Default" %>

<%@ MasterType VirtualPath="~/MasterPages/Blueprint.master" %>
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
                In 2015, we created 662,062 gallons of biodiesel.</p>
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
<asp:Content ContentPlaceHolderID="mainContent" ID="mainContent" runat="server">
    <h3>
        Renu Your Green!</h3>
    <p>
        Welcome to our site where you can explore all the services we offer and how you
        can join us in our sustainability efforts to improve our environment and our local
        community. We are committed to providing an wide array of
        recycling services and sustainability programs for hotels, casinos and local businesses.</p>
    <div class="spacer">
    </div>
    <h3>
        Why Recycle?</h3>
    <p>
        Annually, approximately three million tons of waste is produced by Clark County,
        with nearly 60% coming from Hotels/Casinos. Almost all of it is sent to landfills
        ­it is estimated that only 18% is recycled, as of 2015, (better than the 17% reported 2011, but not as much as the national average of 34.3%) Source: <a href="http://www.southernnevadahealthdistrict.org/download/eh/2015-recycling-report.pdf">Southern Nevada Health District</a>.
        In addition, restaurants in Clark County produce at least twice the national average
        of three gallons of cooking grease per resident annually.
    </p>
    <p>
        RENUoil of America, Inc.
        encompasses a complete array of comprehensive services which have extensive ecological
        benefits by maximizing sustainability initiatives and minimizing waste handling
        costs. Our goal as a business is to assist our partners in their efforts to reduce
        their carbon footprint and pollution as well as to increase awareness among the
        local community in the “Green” movement.
    </p>
    <%--    <!-- Content Box #1 -->
    <div class="mainbox">
        <h4><a href="#">About Us</a></h4>
        <img src="images/icon1.png" class="alignleft" alt="" />
        <p>Integer eu lacus mauris hendrerit egestas imperdiet placerat ullam dolor lectus sollicitudin sed dictum uisque nibh ligula, pharetra sit amet euismod.</p>
    </div>
    <!-- Content Box #2 -->
    <div class="mainbox box-last">
        <h4><a href="#">Our Services</a></h4>
        <img src="images/icon2.png" class="alignleft" alt="" />
        <p>We specialize in the following commercial recycling services: Oil Filtration, Yellow Grease Removal, Asset Reclamation </p>
    </div>
    <div class="spacer">
    </div>
    <!-- Content Box #3 -->
    <div class="mainbox">
        <h4><a href="#">Our Works</a></h4>
        <img src="images/icon3.png" class="alignleft" alt="" />
        <p>Integer eu lacus mauris hendrerit egestas imperdiet placerat ullam dolor lectus sollicitudin sed dictum uisque nibh ligula, pharetra sit amet euismod.</p>
    </div>
    <!-- Content Box #4 -->
    <div class="mainbox box-last">
        <h4><a href="#">Our Products</a></h4>
        <img src="images/icon4.png" class="alignleft" alt="" />
        <p>Integer eu lacus mauris hendrerit egestas imperdiet placerat ullam dolor lectus sollicitudin sed dictum uisque nibh ligula, pharetra sit amet euismod.</p>
    </div>--%>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="sideBarContent" runat="server">
    <div class="sidebar nospace">
        <div class="sidebartop">
        </div>
        <div class="sidebarmain">
            <div class="sidebarcontent">
                <h4 class="sidebarheading">
                    Latest News</h4>
                <div class="itemlist">
                    <ul>
                        <li><a href="https://www.unlv.edu/sites/default/files/24/Foundation-RenuOil.pdf" target="_blank">
                            Unrestricted support
for UNLV provides
unique educational
opportunities
for our students.</a>
                        </li>
                        <li><a href="https://www.theguardian.com/sustainable-business/2015/may/29/las-vegas-casinos-gamble-their-reputations-on-sustainability"
                            target="_blank">Las Vegas casinos gamble their reputations on sustainability</a>
                           </li>
                        <li><a href="http://caesarscorporate.com/caesars-wines-and-dines-at-uncorkd/" target="_blank">Caesars Wines and Dines at Uncork’d</a>
                        </li>
                        <li><a href="http://www.nytimes.com/2011/12/03/us/politics/obama-announces-backing-for-energy-efficiency-initiative.html?_r=1&ref=energy-environment"
                            target="_blank">Obama Announces Backing for Energy-Efficiency Initiative</a>
                        </li>
                        <li><a href="http://content.time.com/time/nation/article/0,8599,2110350,00.html"
                            target="_blank">After the Bubble Burst: How America's Wimpy Recovery Has Reshaped Las Vegas</a>
                        </li>
                    </ul>
                </div>
                <div class="spacer">
                </div>
                <a href="News.aspx" class="button-more">View All News</a>
            </div>
        </div>
        <div class="sidebarbottom">
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>

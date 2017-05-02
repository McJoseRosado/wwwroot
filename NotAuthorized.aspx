<%@ Page Language="C#" MasterPageFile="~/MasterPages/Main.master" AutoEventWireup="true" CodeBehind="NotAuthorized.aspx.cs" Inherits="RenuOil.NotAuthorized" %>

<%@ MasterType VirtualPath="~/MasterPages/Main.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ContentPlaceHolderID="mainContent" ID="mainContent" runat="server">
 
    <%--    <h3>
        Go Green with RENUoil!</h3>
    <p>
        Welcome to our site where you can explore all the services we offer and how you
        can join us in our sustainability efforts to improve our environment and our local
        community. We are committed to the “Green” movement by providing a wide range of
        recycling programs for hotels, casinos and local businesses.</p>
    <div class="spacer">
    </div>
    <h3>
        Why Recycle?</h3>
    <p>
        Annually, approximately three million tons of waste is produced by Clark County,
        with nearly 60% coming from Hotels/Casinos. Almost all of it is sent to landfills
        ­ it is estimated that only 17% is recycled (much lower than the national average).
        In addition, restaurants in Clark County produce at least twice the national average
        of three gallons of cooking grease per resident annually. RENUoil of America, Inc.
        encompasses a complete array of comprehensive services which have extensive ecological
        benefits by maximizing sustainability initiatives and minimizing waste handling
        costs. Our goal as a business is to assist our partners in their efforts to reduce
        their carbon footprint and pollution as well as to increase awareness among the
        local community in the “Green” movement.
    </p>--%>
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
    <%--   <div class="sidebar nospace">
        <div class="sidebartop">
        </div>
        <div class="sidebarmain">
            <div class="sidebarcontent">
                <h4 class="sidebarheading">
                    Latest News</h4>
                <div class="itemlist">
                    <ul>
                        <li><a href="http://www.abc.net.au/environment/articles/2011/12/22/3396578.htm" target="_blank">
                            Top environment stories of 2011</a>
                        </li>
                        <li><a href="http://www.keprtv.com/news/local/Washington-recycling-more-than-ever-135583303.html"
                            target="_blank">Washington recycling more than ever</a>
                           </li>
                        <li><a href="http://www.reddit.com/tb/njw0v" target="_blank">Single-Stream Recycling</a>
                        </li>
                        <li><a href="http://www.nytimes.com/2011/12/03/us/politics/obama-announces-backing-for-energy-efficiency-initiative.html?_r=1&ref=energy-environment"
                            target="_blank">Obama Announces Backing for Energy-Efficiency Initiative</a>
                        </li>
                        <li><a href="http://www.greenpacks.org/2011/11/21/hybrid-car-lovers-you-are-now-safer-from-injury-in-crash"
                            target="_blank">Hybrid Car Lovers, You Are Now Safer From Injury in Crash</a>
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
    </div>--%>
</asp:Content>
<asp:Content ID="bottomContent" ContentPlaceHolderID="bottomContent" runat="server">
   <center>
        <div class="error" style="float:none">
            <h3 style="float:none">
                You are not authorized for this page.</h3>
        </div>
        <div class="spacer"></div>
    </center>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>

﻿<%@ Page Title="Portal" Language="C#" MasterPageFile="~/MasterPages/Portal.Master" AutoEventWireup="true"
    CodeBehind="Validation.aspx.cs"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<%--<asp:Content ID="Content2" ContentPlaceHolderID="slideshowContent" runat="server">
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
</asp:Content>--%>
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
    <h3>
        Community Involvement</h3>
    <p>
        RENUoil of America, Inc. has worked together with organizations involved in community
        assistance. Our programs have benefited the following organizations:
    </p>
    <div class="itemlist">
        <ul>
            <li>Aguilas Christian Family Center</li>
            <li>Blind Center of Nevada</li>
            <li>Candlelighters Childhood Cancer Foundation</li>
            <li>Casa Grande Transitional Center </li>
            <li>Cystic Fibrosis Foundation</li>
            <li>Catholic Charities</li>
            <li>Mountaintop Faith Ministries</li>
            <li>Opportunity Village</li>
            <li>St. Jude Ranch for Children</li>
            <li>The Salvation Army</li>
        </ul>
    </div>
    <div class="spacer">
    </div>
    <h3>
        Recognition</h3>
    <p>
        Over the years, the hard work and dedication from every team member at RENUoil
        has not only brought business growth but public recognition from various institutions.
        This year we were recognized as the 2011 Professional Service Company of the Year
        via NVMSDC in the July 2011 Edition of the Las Vegas Business Press. Check out the
        article at: <a href="http://www.lvbusinesspress.com/articles/2011/07/18/business_life/iq_45511030.txt">
            http://www.lvbusinesspress.com/articles/2011/07/18/business_life/iq_45511030.txt</a>
    </p>
    <div class="spacer">
        <br />
    </div>
    <h3>
        Other company highlights and attributes</h3>
    <div class="itemlist">
        <ul>
            <li>Our management staff are certified as LEED Green Associates via NVMSDC</li>
            <li>Minority Certified via the NVMSDC</li>
            <li>Latin Chamber of Commerce Members</li>
            <li>Las Vegas Green Chamber of Commerce Members</li>
            <li>Nevada Development Authority Members</li>
        </ul>
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
                    Recycling for military personnel or their families is now more rewarding than ever!
                    A reward program has been created to reward all residents for their “Green” efforts
                    in waste management. Although it is only available for military personnel in the
                    Las Vegas Valley, anyone can join in through a program called <a href="http://greenopolis.com/myopolis/rewards">
                        “Greenopolis”</a>. They have partnered with establishment and institutions in
                    order to reward recycling efforts. For every time a customer scans their card, they
                    gain points. They have on-street kiosks and a website where people can scan their
                    cards after they recycle material which allows participants to do actual “trackable”
                    good for the planet. This program was created to make your everyday life better
                    by offering rewards for helping the world and changing the way we handle our natural
                    resources.
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
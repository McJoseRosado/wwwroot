<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Blueprint.Master" AutoEventWireup="true"
    CodeBehind="FAQ.aspx.cs" Inherits="RenuOil.FAQ" %>

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
    <h3>
        Why should I recycle?</h3>
    <p>
        Recycling benefits the community and environment we live in. If we come together
        as a community and put forth our recycling efforts, we can reduce the amount of
        waste sent to landfills as well as reduce the cost of natural resources used to
        manufacture everyday goods. See our “About Us” page for more information.</p>
    <h3>
        What kind of recycling services does your company offer?</h3>
    <p>
        We offer a wide variety of recycling services such as hotel/casino dock management,
        recycling sorting services, asset recovery, fryer oil filtration services, yellow
        grease recovery services and grease trap pumping. See our “Services” page for more
        information.</p>
    <h3>
        How does your company differ from other recycling companies or facilities?</h3>
    <p>
        Our company is unique as we were one of the initial driving forces in the beginning
        of the “Green” movement in the Las Vegas Valley; we serviced casinos with one of
        the first filtration (kitchen oil recycling) machines nearly 14 years ago. More
        importantly, our company aims to benefit and educate the local community either
        by partnering with other companies to or by directly donating to charitable and
        non-profit organizations.
    </p>
    <h3>
        What kind of materials does your company establish recycling programs for?</h3>
    <p>
        We establish programs for several types of plastic, cardboard, aluminum, metal,
        tin, glass, and yellow grease. We also provide recycling programs for other recyclable
        items such as electronics, batteries, food waste, paper, and intact fluorescent
        light bulbs.
    </p>
    <h3>
        Does your company recycle motor oil?</h3>
    <p>
        No, we do not recover or collect any type of motor oil.</p>
    <h3>
        What is included in your oil recycling program?</h3>
    <p>
        We currently filter and recover used fryer oil (known as the commodity yellow grease).
        Our filtration program extends the life of cooking oil up to twofold. Once the oil
        is no longer usable, it is discarded into special custom-built containers. It is
        then collected and transported to a plant that filters and processes the oil to
        create biodiesel which is simple to use, biodegradable, nontoxic, and essentially
        free of sulfur and aromatics.
    </p>
    <h3>
        How is your company environmentally friendly?</h3>
    <p>
        Our company strives to be the primary example in the “Green” movement in various
        ways. First of all, our sorting process is done manually, rather than using conveyor
        systems that use up enormous amounts of energy. We primarily use chemicals that
        are bio-degradable and have been marked to be environmentally friendly. When feasible,
        we purchase energy efficient equipment and supplies. We strive to motivate our partners
        to do the same in order to maximize energy efficiency, minimize greenhouse gas emissions,
        reduce the amount of waste sent to landfills, and increase the utilization of products
        made from recycled material.
    </p>
    <h3>
        What happens to the materials that get recycled?</h3>
    <p>
        The recycling process for paper products, including cardboard, involves being transported
        first to the Material Recovery Facility (MRF) where it is shredded and mixed with
        water to make a pulp. This pulp is washed, refined and cleaned, then turned to a
        paste that is then used to create more paper products. The glass is converted into
        a valuable range of products used everyday such as fiberglass insulation, food and
        beverage containers, reflective materials, among many others. The plastic is transported
        to a plant where it follows chemical processes of polymerization and reused to create
        a variety of plastic products.</p>
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
                    Heating and cooling costs are always an issue in the Las Vegas Valley as our temperatures
                    differ so much throughout the year. Usually, energy wasting results from poor insulation,
                    lack of energy management or oversized A/C units. By enlisting the help of eco-friendly
                    methods, you can lower your heating and cooling costs. Rather than blasting A/C
                    units, include energy-efficient ceiling fans in the rooms used most frequently.
                    During the winter season, you can use a fireplace or wood-burning stove to alternate
                    with the reverse setting in your ceiling fans.
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

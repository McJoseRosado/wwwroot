<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Blueprint.Master" AutoEventWireup="true"
    CodeBehind="OurServices.aspx.cs" Inherits="RenuOil.OurServices" %>

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
        Our Services</h3>
    <p>
        RENUoil of America, Inc. provides several recycling programs for all of our Recycling
        Partners. We offer Dock & Environmental Management, Asset Reclamation, Oil Filtration,
        Yellow Grease Recovery, Grease Trap Cleaning / Brown Grease Recovery and Waste Consulting
        services.</p>
    <div class="spacer">
    </div>
    <h3>
        Dock & Environmental Management</h3>
    <p>
        Our company designs the best layout for optimal environmental management specific
        for any hotel/casino. We modify the dock into a recycling center to source separate
        recyclables from the waste stream. We provide dock personnel to manage the Green
        infrastructure of each dock. We develop an all-encompassing sustainability program
        and we assure that every recycling dock exceeds all standards regarding sanitation
        and safety. We endeavor to raise the recycling rate at each client’s property by
        refining upstream and downstream procedures. Recyclable materials are separated
        by category, baled, and then transported to a permitted recycling facility.
    </p>
    <h3>
        Asset Reclamation</h3>
    <p>
        Another program specific for hotels and casinos involves the reclamation of salvageable
        items (dishes, towels, silverware, etc.) during the source separation process at
        the casino dock’s recycling center; items are retrieved which belong to the property,
        that are inadvertently discarded. These items are recorded on a customized spreadsheet
        for internal inventory control tracking; these items are then returned to the property
        daily.
    </p>
    <h3>
        Oil Filtration</h3>
    <p>
        Our company supplies a custom built filtration machine and all tools necessary to
        extend the usable life of frying oil. We filter the oil daily or as often as needed.
        Our filtration program extends the use of cooking oil by nearly twofold. This substantially
        reduces overall costs of purchasing cooking oil. The filtration process revitalizes
        cooking oil; therefore, the quality of the food served is never compromised.
    </p>
    <h3>
        Yellow Grease Recovery</h3>
    <p>
        For all of our restaurant partnerships, we provide a secure yellow grease storage
        container with a splash guard and an extra-fine filter for safe storage and removal
        of yellow-grease. Yellow grease is recovered and transported to be processed and
        converted into biodiesel which is used for fueling our school district busses. The
        yellow grease recovery is done according to a specific, custom schedule with each
        one of our partners.</p>
    <h3>
        Grease Trap Cleaning and Brown Grease Recovery / Waste to Energy</h3>
    <p>
        RENUoil of America, Inc. has a full ecosystem program for grease trap services
        and brown grease recovery that is unique. We recycle brown grease into compost that
        can be reused in horticulture and landscaping. This compost requires only a fraction
        of the normal amount of water. More importantly, our program prevents this waste
        from resulting at a landfill. We inspect every system with our clients, check for
        warning signs, assure satisfaction with follow up inspections and suggest appropriate
        service frequencies and maintenance plans to help keep every grease trap system
        running smoothly. Waste Consulting We offer a free consultation and comprehensive
        evaluation of the current waste stream of each client or property to identify where
        waste sent to landfills can be minimized. By finding innovative methods of improving
        every type of recycling and waste management program, we thrive to increase our
        community’s overall recycling rate.
    </p>
    <h3>
        Waste Consulting</h3>
    <p>
        We offer a free consultation and comprehensive evaluation of the current waste stream
        of each client or property to identify where waste sent to landfills can be minimized.
        By finding innovative methods of improving every type of recycling and waste management
        program, we thrive to increase our community’s overall recycling rate.</p>
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
                    We motivate every resident of the Las Vegas Valley to join our “Green” movement
                    and raise the residential recycling rate in our city. If you are unsure about any
                    recycling in Southern Nevada, feel free to email us with any questions you might
                    have. You can also use <a href="http://earth911.com">Earth 911</a>'s website, which
                    will allow you to find a recycling center near you according to the material you
                    are recycling. You can also locate local recycling facilities via the <a href="http://www.cchd.org/">
                        Southern Nevada Health District</a> website.</p>
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
<asp:Content ID="Content6" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>

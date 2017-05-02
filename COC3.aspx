<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="True" CodeBehind="NewOrExistingOilFiltration.aspx.cs" Inherits="RenuOil.NewOrExistingOilFiltration" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content3" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server"></asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="bottomContent" runat="server">
    <div id="newOrExistingOilFiltrationView" runat="server">
        <h2>COC</h2><hr/>
        <div class="mainbox2">
            <h4 class="title"><a href="Bales.aspx">Bales</a></h4>
            <div id="existingWorkOrdersBox" runat="server" class="boximg2">
                <a href="Bales.aspx">
                    <img src="images/service-img5.jpg" class="boximg-pad" alt="" /></a>
            </div>
            <div id="existingWorkOrdersNoAccessBox" runat="server" visible="false" class="boximg2">
                <img src="images/noaccess.jpg" class="boximg-pad" alt="" />
            </div>
        </div>
        <div class="mainbox2">
            <h4 class="title"><a href="Loads.aspx">Loads</a></h4>
            <div id="newWorkOrderBox" runat="server" class="boximg2">
                <a href="Loads.aspx">
                    <img src="images/service-img8.jpg" class="boximg-pad" alt="" /></a>
            </div>
            <div id="newWorkOrderNoAccessBox" runat="server" visible="false" class="boximg2">
                <img src="images/noaccess.jpg" class="boximg-pad" alt="" />
            </div>
        </div>
    </div>
     <div class="mainbox2">
            <h4 class="title"><a href="Receiver.aspx">Receiver</a></h4>
            <div id="Div1" runat="server" class="boximg2">
                <a href="Receiver.aspx">
                    <img src="images/service-img8.jpg" class="boximg-pad" alt="" /></a>
            </div>
            <div id="Div2" runat="server" visible="false" class="boximg2">
                <img src="images/noaccess.jpg" class="boximg-pad" alt="" />
            </div>
        </div>
</asp:Content>

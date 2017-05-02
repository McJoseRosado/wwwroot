<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="True" CodeBehind="NewOrExistingOilFiltration.aspx.cs" Inherits="RenuOil.NewOrExistingOilFiltration" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content3" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server"></asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="bottomContent" runat="server">
    <div id="newOrExistingOilFiltrationView" runat="server">
        <h2>Oil Filtration</h2><hr/>
        <div class="mainbox2">
            <h4 class="title"><a href="WorkOrders.aspx">Existing Work Order</a></h4>
            <div id="existingWorkOrdersBox" runat="server" class="boximg2">
                <a href="WorkOrders.aspx">
                    <img src="images/service-img5.jpg" class="boximg-pad" alt="" /></a>
            </div>
            <div id="existingWorkOrdersNoAccessBox" runat="server" visible="false" class="boximg2">
                <img src="images/noaccess.jpg" class="boximg-pad" alt="" />
            </div>
        </div>
        <div class="mainbox2">
            <h4 class="title"><a href="BeginWorkOrder.aspx">New Work Order</a></h4>
            <div id="newWorkOrderBox" runat="server" class="boximg2">
                <a href="EditWorkOrder.aspx?id=0">
                    <img src="images/service-img8.jpg" class="boximg-pad" alt="" /></a>
            </div>
            <div id="newWorkOrderNoAccessBox" runat="server" visible="false" class="boximg2">
                <img src="images/noaccess.jpg" class="boximg-pad" alt="" />
            </div>
        </div>
    </div>
</asp:Content>

﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/Main.Master" CodeFile="NewBale.aspx.cs" Inherits="RenuOil.NewBale" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:ConnectionString %>' SelectCommand="SELECT * FROM [Bales]"></asp:SqlDataSource>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="mainContent2" runat="server">
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="sideBarContent2" runat="server">
</asp:Content>
<asp:Content ID="Content8" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true" CodeBehind="Production.aspx.cs" Inherits="RenuOil.Production" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Name"></asp:DropDownList>
    <asp:Label ID="LblEmployee" Text="Employee Name" CssClass="label" runat="server"></asp:Label>
    <asp:TextBox runat="server"></asp:TextBox>
    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [First Name] AS First_Name, [Middle Name] AS Middle_Name, [Last Name] AS Last_Name, [Property Name] AS Property_Name FROM [DockWorkers]"></asp:SqlDataSource>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="sideBarContent" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="bottomContent" runat="server">
    <asp:Button ID="btnAddNewEmployee" runat="server" CssClass="button" Text="Add New Employee" UseSubmitBehavior="true" OnClick="btnAddNewEmployee_Click" />
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="mainContent2" runat="server">
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="sideBarContent2" runat="server">
</asp:Content>
<asp:Content ID="Content8" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>

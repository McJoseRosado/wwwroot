<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true"
    CodeBehind="Reports.aspx.cs" Inherits="RenuOil.Reports" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="sideBarContent" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="bottomContent" runat="server">
    <asp:ScriptManager ID="scriptMgr" runat="server">
    </asp:ScriptManager>
    <h4 class="title">
        Reports</h4>
    <h3>
        Recycling and Diverted Tonnage Report</h3>
    <asp:Label ID="lblYear" CssClass="label" Text="Year:" runat="server"></asp:Label>
    <asp:DropDownList ID="ddlYears" runat="server">
    </asp:DropDownList>
    <asp:Label ID="lblAccount" CssClass="label" Text="Account:" runat="server"></asp:Label>
    <asp:DropDownList ID="ddlAccount" runat="server">
    </asp:DropDownList>
    <div style="float: right; padding-bottom: 10px;">
        <asp:Button ID="btnGenerateReport" runat="server" CssClass="button" Text="Generate"
            OnClick="btnGenerateReport_Click" />
    </div>
    
    <div class="clear">
    </div>

    <hr />
    <h3>
        Filtration Savings Report</h3>
    <asp:Button ID="btnAll" runat="server" CssClass="button" Text="Select All" OnClick="btnAll_Click" />
    <div id="FsrMessages" runat="server">
        <div class="clear">
        </div>
    </div>
    <asp:Label ID="lblAccounts" runat="server" CssClass="label" Text="Accounts:"></asp:Label>
    <asp:CheckBoxList ID="cblAccounts" runat="server" CssClass="checklist" DataTextField="Name"
        DataValueField="AccountId">
    </asp:CheckBoxList>
    <asp:Label ID="lblFSRStartDate" CssClass="label" Text="Start Date:" runat="server"></asp:Label>
    <telerik:RadDatePicker CssClass="radDatePicker" ID="rdpFSRStartDate" runat="server">
    </telerik:RadDatePicker>
    <asp:Label ID="lblFSREndDate" CssClass="label" Text="End Date:" runat="server"></asp:Label>
    <telerik:RadDatePicker CssClass="radDatePicker" ID="rdpFSREndDate" runat="server">
    </telerik:RadDatePicker>
    <asp:Label ID="lblShowDetails" CssClass="label" Text="Show Details" runat="server"></asp:Label>
    <asp:CheckBox ID="chkShowDetails" runat="server" CssClass="checkbox" />
    <div style="float: right; padding-bottom: 10px;">
        <asp:Button ID="btnGenerateFsrReport" runat="server" CssClass="button" Text="Generate"
            OnClick="btnGenerateFsrReport_Click" />
    </div>
    
    <div class="clear">
    </div>

    <hr />
    <asp:Button ID="btnCancel" runat="server" CssClass="button" Text="Cancel" OnClick="btnCancel_Click" />
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="mainContent2" runat="server">
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="sideBarContent2" runat="server">
</asp:Content>
<asp:Content ID="Content8" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>

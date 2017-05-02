<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/Main.Master" CodeFile="NewBale.aspx.cs" Inherits="RenuOil.NewBale" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageHeadingContent" runat="server">
     <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <head runat="server">
    <title></title>
    <telerik:radstylesheetmanager id="RadStyleSheetManager1" runat="server" />
</head>
<body>
    <form id="form1" runat="server">
        <telerik:radajaxmanager id="RadScriptManager1" runat="server">
        <Scripts>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js" />
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js" />
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js" />
        </Scripts>
    </telerik:radajaxmanager>
        <script type="text/javascript">
        //Put your JavaScript code here.
        </script>
        <telerik:radajaxmanager id="RadAjaxManager1" runat="server">
        <ClientEvents OnRequestStart="RadAjaxManager1_RequestStart" />
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadGrid1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:radajaxmanager>
        <div>
            <telerik:radscriptblock id="RadScriptBlock1" runat="server">
        <script type="text/javascript">
                function gridExport() 
                {
                    $find("<%= RadGrid1.ClientID %>").get_masterTableView().exportToExcel();
                    return false;
                }
                function RadAjaxManager1_RequestStart(sender, args) 
                {
                    if (args.get_eventTarget() == "<%= RadGrid1.ClientID %>")
                        args.set_enableAjax(false);
                }
        </script>
        </telerik:radscriptblock>
            <asp:Button OnClientClick="return gridExport()" ID="Button1" runat="server" Text="Excel" />

            <asp:SqlDataSource SelectCommand="SELECT Account.Name, Dock.DockName, RecycleType.Name AS Commonity, Bales.[Initial Weight], Bales.[Bale Number] FROM Account INNER JOIN Dock ON Account.AccountId = Dock.AccountId CROSS JOIN RecycleType CROSS JOIN [Load] CROSS JOIN Bales" ConnectionString="Data Source=s06.winhost.com;Persist Security Info=True;User ID=DB_100791_renuoil_user;Password=Temp123#" ProviderName="System.Data.SqlClient" ID="DataSource1" runat="server"></asp:SqlDataSource>

            <telerik:radgrid datasourceid="DataSource1" id="RadGrid1" runat="server">
            <ExportSettings ExportOnlyData="False" FileName="ExportedRadGrid"  OpenInNewWindow="False" IgnorePaging="False" />
        </telerik:radgrid>
        </div>
    </form>
</body>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="sideBarContent" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="bottomContent" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="mainContent2" runat="server">
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="sideBarContent2" runat="server">
</asp:Content>
<asp:Content ID="Content8" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>

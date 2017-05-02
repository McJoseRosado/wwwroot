<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RadGridExportWebForm.aspx.cs" Inherits="RadGridExportWebForm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <telerik:radstylesheetmanager id="RadStyleSheetManager1" runat="server" />
</head>
<body>
    <form id="form1" runat="server">
        <telerik:radscriptmanager id="RadScriptManager1" runat="server">
        <Scripts>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js" />
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js" />
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js" />
        </Scripts>
    </telerik:radscriptmanager>
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
</html>



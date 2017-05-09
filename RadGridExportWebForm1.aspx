<%@ Page Language="C#" AutoEventWireup="true" Codefile="RadGridExportWebForm.aspx.cs" Inherits="RadGridExportWebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <telerik:RadStyleSheetManager ID="RadStyleSheetManager1" runat="server" />
</head>
<body>
    <form id="form1" runat="server">
        <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
            <Scripts>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js" />
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js" />
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js" />
            </Scripts>
        </telerik:RadScriptManager>
        <script type="text/javascript">
        //Put your JavaScript code here.
        </script>
        <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
            <AjaxSettings>
                <telerik:AjaxSetting AjaxControlID="RadGrid1">
                    <UpdatedControls>
                        <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
                    </UpdatedControls>
                </telerik:AjaxSetting>
            </AjaxSettings>
        </telerik:RadAjaxManager>
        <div>
            <asp:Button ID="Button1" runat="server" Text="ExportToCSV" OnClick="Button1_Click" />

            <asp:SqlDataSource InsertCommand="INSERT INTO Bales (Date, Name, [Dock Name], Commodity, [Initial Weight], [Bale Number]) VALUES (,,,,,)" ConnectionString="Data Source=s06.winhost.com;Persist Security Info=True;User ID=DB_100791_renuoil_user;Password=Temp123#" ProviderName="System.Data.SqlClient" ID="DataSource1" runat="server"></asp:SqlDataSource>

            <telerik:RadGrid DataSourceID="DataSource1" ID="RadGrid1" runat="server">
                <ExportSettings ExportOnlyData="False" FileName="ExportedRadGrid" OpenInNewWindow="False" IgnorePaging="False" />
            </telerik:RadGrid>
        </div>
    </form>
</body>
</html>



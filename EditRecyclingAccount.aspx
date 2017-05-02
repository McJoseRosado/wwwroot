<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true" CodeBehind="EditRecyclingAccount.aspx.cs" Inherits="RenuOil.EditRecyclingAccount" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content7" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content8" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content9" ContentPlaceHolderID="mainContent" runat="server">
    <telerik:RadAjaxManager ID="RadAjaxManager2" runat="server">
    </telerik:RadAjaxManager>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Always">
        <Triggers>
            <%--<asp:AsyncPostBackTrigger ControlID="btnSaveAccount" />--%>
        </Triggers>
        <ContentTemplate>
            <h4>
                <a id="accountNameTitle" runat="server"></a>
            </h4>
            <div id="messages" runat="server">
                <div class="clear">
                </div>
            </div>
            <asp:Label ID="Label1" Text="Account Name:" CssClass="label" runat="server"></asp:Label>
            <asp:TextBox ID="txtAcctName" CssClass="textbox" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" Text="Account No:" CssClass="label" runat="server"></asp:Label>
            <asp:TextBox ID="txtAcctNo" CssClass="textbox" runat="server"></asp:TextBox>
            <asp:Label ID="Label3" Text="Address 1:" CssClass="label" runat="server"></asp:Label>
            <asp:TextBox ID="txtAddress1" CssClass="textbox" runat="server"></asp:TextBox>
            <asp:Label ID="Label4" Text="Address 2:" CssClass="label" runat="server"></asp:Label>
            <asp:TextBox ID="txtAddress2" CssClass="textbox" runat="server"></asp:TextBox>
            <asp:Label ID="Label5" Text="City:" CssClass="label" runat="server"></asp:Label>
            <asp:TextBox ID="txtCity" CssClass="textbox" runat="server"></asp:TextBox>
            <asp:Label ID="Label6" Text="State:" CssClass="label" runat="server"></asp:Label>
            <asp:DropDownList ID="ddlState" runat="server" onkeypress="setFocus(this, event)">
                <asp:ListItem Value="" Selected="True"></asp:ListItem>
                <asp:ListItem Value="AL">AL</asp:ListItem>
                <asp:ListItem Value="AK">AK</asp:ListItem>
                <asp:ListItem Value="AZ">AZ</asp:ListItem>
                <asp:ListItem Value="AR">AR</asp:ListItem>
                <asp:ListItem Value="CA">CA</asp:ListItem>
                <asp:ListItem Value="CO">CO</asp:ListItem>
                <asp:ListItem Value="CT">CT</asp:ListItem>
                <asp:ListItem Value="DC">DC</asp:ListItem>
                <asp:ListItem Value="DE">DE</asp:ListItem>
                <asp:ListItem Value="FL">FL</asp:ListItem>
                <asp:ListItem Value="GA">GA</asp:ListItem>
                <asp:ListItem Value="HI">HI</asp:ListItem>
                <asp:ListItem Value="ID">ID</asp:ListItem>
                <asp:ListItem Value="IL">IL</asp:ListItem>
                <asp:ListItem Value="IN">IN</asp:ListItem>
                <asp:ListItem Value="IA">IA</asp:ListItem>
                <asp:ListItem Value="KS">KS</asp:ListItem>
                <asp:ListItem Value="KY">KY</asp:ListItem>
                <asp:ListItem Value="LA">LA</asp:ListItem>
                <asp:ListItem Value="ME">ME</asp:ListItem>
                <asp:ListItem Value="MD">MD</asp:ListItem>
                <asp:ListItem Value="MA">MA</asp:ListItem>
                <asp:ListItem Value="MI">MI</asp:ListItem>
                <asp:ListItem Value="MN">MN</asp:ListItem>
                <asp:ListItem Value="MS">MS</asp:ListItem>
                <asp:ListItem Value="MO">MO</asp:ListItem>
                <asp:ListItem Value="MT">MT</asp:ListItem>
                <asp:ListItem Value="NE">NE</asp:ListItem>
                <asp:ListItem Value="NV">NV</asp:ListItem>
                <asp:ListItem Value="NH">NH</asp:ListItem>
                <asp:ListItem Value="NJ">NJ</asp:ListItem>
                <asp:ListItem Value="NM">NM</asp:ListItem>
                <asp:ListItem Value="NY">NY</asp:ListItem>
                <asp:ListItem Value="NC">NC</asp:ListItem>
                <asp:ListItem Value="ND">ND</asp:ListItem>
                <asp:ListItem Value="OH">OH</asp:ListItem>
                <asp:ListItem Value="OK">OK</asp:ListItem>
                <asp:ListItem Value="OR">OR</asp:ListItem>
                <asp:ListItem Value="PA">PA</asp:ListItem>
                <asp:ListItem Value="RI">RI</asp:ListItem>
                <asp:ListItem Value="SC">SC</asp:ListItem>
                <asp:ListItem Value="SD">SD</asp:ListItem>
                <asp:ListItem Value="TN">TN</asp:ListItem>
                <asp:ListItem Value="TX">TX</asp:ListItem>
                <asp:ListItem Value="UT">UT</asp:ListItem>
                <asp:ListItem Value="VT">VT</asp:ListItem>
                <asp:ListItem Value="VA">VA</asp:ListItem>
                <asp:ListItem Value="WA">WA</asp:ListItem>
                <asp:ListItem Value="WV">WV</asp:ListItem>
                <asp:ListItem Value="WI">WI</asp:ListItem>
                <asp:ListItem Value="WY">WY</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="Label7" Text="Zip/Postal:" CssClass="label" runat="server"></asp:Label>
            <asp:TextBox ID="txtZip" CssClass="textbox" runat="server"></asp:TextBox>
            <asp:Label ID="Label8" Text="Phone:" CssClass="label" runat="server"></asp:Label>
            <asp:TextBox ID="txtPhone" CssClass="textbox" runat="server"></asp:TextBox>
            <asp:Label ID="Label9" Text="Main Contact:" CssClass="label" runat="server"></asp:Label>
            <asp:TextBox ID="txtMainContact" CssClass="textbox" runat="server"></asp:TextBox>
        </ContentTemplate>
    </asp:UpdatePanel>
    <div class="clear">
    </div>
    <br />
</asp:Content>
<asp:Content ID="Content10" ContentPlaceHolderID="bottomContent" runat="server">
</asp:Content>
<asp:Content ID="Content11" ContentPlaceHolderID="sideBarContent" runat="server">
    <div class="sidebar nospace">
        <div class="sidebartop">
        </div>
        <div class="sidebarmain">
            <div class="sidebarcontent">
                <h4 class="sidebarheading">
                    Notes</h4>
                <div class="clear">
                </div>
                <asp:TextBox ID="txtNotes" CssClass="sidebarTextbox" runat="server" TextMode="MultiLine"
                    Height="90px"></asp:TextBox>
                <div class="clear">
                </div>
            </div>
        </div>
        <div class="sidebarbottom">
        </div>
        <div class="clear">
        </div>
        <div id="instructions" class="info" runat="server">
            <p>
                Enter information for the new account and then click Save.</p>
        </div>
        <div style="float: right; padding-bottom: 10px;">
            <asp:Button ID="btnSaveAccount" runat="server" CssClass="button" Text="Save Account"
                OnClick="btnSaveAccount_Click" />
            <asp:Button ID="btnCancel" runat="server" CssClass="button" Text="Cancel" OnClick="btnCancel_Click" />
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content12" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>

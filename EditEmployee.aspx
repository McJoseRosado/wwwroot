<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true" CodeBehind="EditEmployee.aspx.cs" Inherits="RenuOil.EditEmployee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <asp:ScriptManager ID="scriptMgr" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnSaveEmployee" />
            <asp:AsyncPostBackTrigger ControlID="btnCancel" />
            <asp:AsyncPostBackTrigger ControlID="lnkBtnChangePassword" />
        </Triggers>
        <ContentTemplate>
            <h4><a id="employeeNameTitle" runat="server"></a></h4>
            <div id="messages" runat="server">
                <div class="clear">
                </div>
            </div>
            <asp:Label ID="lblFirstName" Text="First Name:" CssClass="label" runat="server"></asp:Label>
            <asp:TextBox ID="txtFirstName" CssClass="textbox" runat="server"></asp:TextBox>
            <asp:Label ID="lblMiddleName" Text="Middle Name:" CssClass="label" runat="server"></asp:Label>
            <asp:TextBox ID="txtMiddleName" CssClass="textbox" runat="server"></asp:TextBox>
            <asp:Label ID="lblLastName" Text="Last Name:" CssClass="label" runat="server"></asp:Label>
            <asp:TextBox ID="txtLastName" CssClass="textbox" runat="server"></asp:TextBox>
            <asp:Label ID="lblSSN" Text="SSN:" CssClass="label" runat="server"></asp:Label>
            <asp:TextBox ID="txtSSN" CssClass="textbox" runat="server"></asp:TextBox>
            <asp:Label ID="lblEmployeeNo" Text="Employee No:" CssClass="label" runat="server"></asp:Label>
            <asp:TextBox ID="txtEmployeeNo" CssClass="textbox" runat="server"></asp:TextBox>
            <asp:Label ID="lblAddress1" Text="Address 1:" CssClass="label" runat="server"></asp:Label>
            <asp:TextBox ID="txtAddress1" CssClass="textbox" runat="server"></asp:TextBox>
            <asp:Label ID="lblAddress2" Text="Address 2:" CssClass="label" runat="server"></asp:Label>
            <asp:TextBox ID="txtAddress2" CssClass="textbox" runat="server"></asp:TextBox>
            <asp:Label ID="lblCity" Text="City:" CssClass="label" runat="server"></asp:Label>
            <asp:TextBox ID="txtCity" CssClass="textbox" runat="server"></asp:TextBox>
            <asp:Label ID="lblState" Text="State:" CssClass="label" runat="server"></asp:Label>
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
            <asp:Label ID="lblZip" Text="Zip/Postal:" CssClass="label" runat="server"></asp:Label>
            <asp:TextBox ID="txtZip" CssClass="textbox" runat="server"></asp:TextBox>
            <asp:Label ID="lblPhone" Text="Phone:" CssClass="label" runat="server"></asp:Label>
            <asp:TextBox ID="txtPhone" CssClass="textbox" runat="server"></asp:TextBox>
            <div class="clear">
            </div>
            <hr />
            <h4>Mobile App Login Information</h4>            
            <asp:Label ID="lblUsername" Text="Username:" CssClass="label" runat="server"></asp:Label>
            <asp:TextBox ID="txtUsername" CssClass="textbox" runat="server"></asp:TextBox>
            <asp:Label ID="lblPassword" Text="Password:" CssClass="label" runat="server"></asp:Label>
            <asp:LinkButton ID="lnkBtnChangePassword" runat="server" CssClass="linkButton" Text="Change Password" OnClick="lnkBtnChangePassword_Click"></asp:LinkButton>
            <asp:TextBox ID="txtPassword" CssClass="textbox" TextMode="Password" runat="server"></asp:TextBox>
            <div id="divChangePassword" runat="server" visible="false">
                <asp:Label ID="lblChangePassword" Text="New Password:" CssClass="label" runat="server"></asp:Label>
                <asp:TextBox ID="txtNewPassword" CssClass="textbox" TextMode="Password" runat="server"></asp:TextBox>
                <asp:Label ID="lblConfirmPassword" Text="Confirm Password:" CssClass="label" runat="server"></asp:Label>
                <asp:TextBox ID="txtConfirmPassword" CssClass="textbox" TextMode="Password" runat="server"></asp:TextBox>
            </div>
            <div style="float: right; padding-bottom: 10px;">
                <asp:Button ID="btnSaveEmployee" runat="server" CssClass="button" Text="Save Employee" UseSubmitBehavior="true" OnClick="btnSaveEmployee_Click" />
                <asp:Button ID="btnCancel" runat="server" CssClass="button" Text="Cancel" OnClick="btnCancel_Click" />
            </div>
            <div class="clear">
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="sideBarContent" runat="server">
    <div class="sidebar nospace">
        <div id="divServiceLocations" runat="server">
            <div class="sidebartop">
            </div>
            <div class="sidebarmain">
                <div class="sidebarcontent">
                    <h4 class="sidebarheading">Employee Notes</h4>
                </div>
            </div>
            <div class="sidebarbottom">
            </div>
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="footerContent" runat="server"></asp:Content>

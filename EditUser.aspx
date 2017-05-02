<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true" CodeBehind="EditUser.aspx.cs" Inherits="RenuOil.EditUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <asp:ScriptManager ID="scriptMgr" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
        <Triggers>
            <asp:PostBackTrigger ControlID="btnSaveUser" />
            <asp:PostBackTrigger ControlID="btnCancel" />
            <asp:AsyncPostBackTrigger ControlID="lnkBtnChangePassword" />
            <asp:AsyncPostBackTrigger ControlID="ddlUserType" />
            <asp:AsyncPostBackTrigger ControlID="lnkBtnChangePassword" />
        </Triggers>
        <ContentTemplate>
            <h4><a id="userNameTitle" runat="server"></a></h4>
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
            <asp:Label ID="lblEmailAddress" Text="Email Address:" CssClass="label" runat="server"></asp:Label>
            <asp:TextBox ID="txtEmailAddress" CssClass="textbox" runat="server"></asp:TextBox>
            <asp:Label ID="lblUserType" Text="User Type:" CssClass="label" runat="server"></asp:Label>
            <asp:DropDownList ID="ddlUserType" CssClass="dropdown" runat="server" OnSelectedIndexChanged="ddlUserType_OnSelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
            <div class="clear">
            </div>
            <div id="accountLists" runat="server">
                <asp:Label ID="lblRecyclingAccounts" Text="Assign Accounts:" CssClass="label" runat="server"></asp:Label>
                <div id="divAccounts" class="accountList">
                    <center><strong>Asset Accounts:</strong></center>
                    <br />
                    <br />
                    <asp:DataList ID="dtListAsset" runat="server" RepeatColumns="2" RepeatDirection="Horizontal" OnItemDataBound="dtListAccount_OnItemDataBound">
                        <ItemTemplate>
                            <asp:CheckBox ID="chkAccount" runat="server" />
                            <asp:HiddenField ID="hdnAccountId" runat="server"/>
                        </ItemTemplate>
                    </asp:DataList>
                    <hr />
                    <div class="clear">
                        <hr />
                    </div>
                    <center><strong>Oil Filtration Accounts:</strong></center>
                    <br />
                    <br />
                    <asp:DataList ID="dtListOilFiltration" runat="server" RepeatColumns="2" RepeatDirection="Horizontal" OnItemDataBound="dtListAccount_OnItemDataBound">
                        <ItemTemplate>
                            <asp:CheckBox ID="chkAccount" runat="server" />
                            <asp:HiddenField ID="hdnAccountId" runat="server"/>
                        </ItemTemplate>
                    </asp:DataList>
                                        <div class="clear">
                        <hr />
                    </div>
                    <center><strong>Recycling Accounts:</strong></center>
                    <br />
                    <br />
                    <asp:DataList ID="dtListRecycle" runat="server" RepeatColumns="2" RepeatDirection="Horizontal" OnItemDataBound="dtListAccount_OnItemDataBound">
                        <ItemTemplate>
                            <asp:CheckBox ID="chkAccount" runat="server" />
                            <asp:HiddenField ID="hdnAccountId" runat="server"/>
                        </ItemTemplate>
                    </asp:DataList>
                </div>
            </div>
            <div class="clear">
            </div>
            <hr />
            <h4>Login Information</h4>
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
                <asp:Button ID="btnSaveUser" runat="server" CssClass="button" Text="Save User" UseSubmitBehavior="true" OnClick="btnSaveUser_Click" />
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
                    <h4 class="sidebarheading">User Notes</h4>
                </div>
            </div>
            <div class="sidebarbottom">
            </div>
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="bottomContent" runat="server"></asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="footerContent" runat="server"></asp:Content>

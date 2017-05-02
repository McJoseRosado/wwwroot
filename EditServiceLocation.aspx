<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true" CodeBehind="EditServiceLocation.aspx.cs" Inherits="RenuOil.EditServiceLocation" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 107px;
        }
        .style2
        {
            width: 176px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" runat="server">
    <asp:ScriptManager ID="scriptMgr" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
        <Triggers>
        </Triggers>
        <ContentTemplate>
            <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                <ProgressTemplate>
                    <div class="t-a-c status-floater">
                        <img id="Img2" runat="server" src="~/images/ajax-loader-circle.gif" />
                        <br />
                        Processing, please wait...
                    </div>
                </ProgressTemplate>
            </asp:UpdateProgress>
            <h4>
                <a id="serviceLocationTitle" runat="server"></a>
            </h4>
            <div id="messages" runat="server">
                <div class="clear">
                </div>
            </div>
            <asp:Label ID="lblServiceLocationName" Text="Name:" CssClass="label" runat="server"></asp:Label>
            <asp:TextBox ID="txtServiceLocationName" CssClass="textbox" runat="server"></asp:TextBox>
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
            <asp:Label ID="lblMainContact" Text="Main Contact:" CssClass="label" runat="server"></asp:Label>
            <asp:TextBox ID="txtMainContact" CssClass="textbox" runat="server"></asp:TextBox>
            <div class="clear">
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="bottomContent" runat="server">
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
    </telerik:RadAjaxManager>
    <div style="float: right; padding-bottom: 10px;">
        <asp:Button ID="btnSaveServiceLocation" runat="server" CssClass="button" Text="Save" OnClick="btnSaveServiceLocation_Click" />
        <asp:Button ID="btnCancel" runat="server" CssClass="button" Text="Cancel" OnClick="btnCancel_Click" />
    </div>
    <div id="fryersDiv" runat="server" visible="false">
        <div class="clear">
        </div>
        <hr />
        <h4>
            Fryers</h4>
        <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Always">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnAddNewFryer" />
                <asp:AsyncPostBackTrigger ControlID="rdFryersGrid" />
                <asp:AsyncPostBackTrigger ControlID="btnSaveFryers" />
                <asp:AsyncPostBackTrigger ControlID="btnCancelFryers" />
            </Triggers>
            <ContentTemplate>
                <div style="float: left; padding-bottom: 10px;">
                    <asp:Button ID="btnAddNewFryer" runat="server" CssClass="button" Text="Add New Fryer" OnClick="btnAddNewFryer_Click" />
                </div>
                <asp:HiddenField ID="hdnDeepFryerId" Value="0" runat="server" />
                <div id="divAddNewFryer" runat="server" visible="false">
                    <div id="Div1" runat="server">
                        <div class="clear">
                        </div>
                    </div>
                    <asp:Label ID="Label1" Text="Name:" CssClass="label" runat="server"></asp:Label>
                    <asp:TextBox ID="txtDeepFryerName" CssClass="textbox" runat="server"></asp:TextBox>
                    <asp:Label ID="Label2" Text="Description:" CssClass="label" runat="server"></asp:Label>
                    <asp:TextBox ID="txtDeepFryerDescription" CssClass="textbox" runat="server"></asp:TextBox>
                    <asp:Label ID="Label3" Text="Size (in gallons):" CssClass="label" runat="server"></asp:Label>
                    <asp:TextBox ID="txtSizeInGallons" CssClass="textbox" runat="server"></asp:TextBox>
                    <div style="margin-right: 310px; float: right; padding-bottom: 10px;">
                        <asp:Button ID="btnSaveDeepFryer" runat="server" CssClass="button" Text="Save New Fryer" UseSubmitBehavior="true" OnClick="btnSaveDeepFryer_Click" />
                    </div>
                </div>
                <div class="clear">
                </div>
                <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
                <telerik:RadGrid ID="rdFryersGrid" Skin="" AllowPaging="false" ShowFooter="true" GridLines="Both" runat="server" AutoGenerateColumns="False" AllowSorting="False" PageSize="3" OnItemCommand="rdFryersGrid_OnItemCommand" OnItemDataBound="rdFryersGrid_OnItemDataBound" AllowAutomaticUpdates="true" OnNeedDataSource="rdFryersGrid_NeedDataSource">
                    <MasterTableView DataKeyNames="DeepFryerId" AutoGenerateColumns="false" HierarchyDefaultExpanded="true" EditMode="InPlace" OnDataBinding="rdFryersGrid_OnDataBinding" ShowHeader="true" ShowFooter="false">
                        <Columns>
                            <telerik:GridBoundColumn SortExpression="DeepFryerId" HeaderText="DeepFryerId" Visible="false" HeaderButtonType="TextButton" DataField="DeepFryerId" Display="false" ReadOnly="true" HeaderStyle-HorizontalAlign="Center">
                            </telerik:GridBoundColumn>
                            <telerik:GridTemplateColumn UniqueName="DeepFryerName" HeaderText="Name" HeaderStyle-HorizontalAlign="Center">
                                <ItemTemplate>
                                    <div style="text-align: center">
                                        <asp:HiddenField ID="hdnDeepFryerId" Value='<%# Eval("DeepFryerId") %>' runat="server" />
                                        <asp:TextBox ID="txtDeepFryerName" runat="server" CssClass="gridtextbox" Text='<%# Eval("Name") %>'></asp:TextBox></div>
                                </ItemTemplate>
                                <ItemStyle CssClass="gridTextItalic gray" Width="450px" BorderColor="ActiveBorder" />
                            </telerik:GridTemplateColumn>
                            <telerik:GridTemplateColumn UniqueName="DeepFryerDescription" HeaderText="Description" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center">
                                <ItemTemplate>
                                    <div style="text-align: center">
                                        <asp:TextBox ID="txtDeepFryerDescription" runat="server" CssClass="gridtextbox" Text='<%# Eval("Description") %>'></asp:TextBox></div>
                                </ItemTemplate>
                                <ItemStyle CssClass="gridTextItalic gray" Width="450px" BorderColor="ActiveBorder" />
                            </telerik:GridTemplateColumn>
                            <telerik:GridTemplateColumn UniqueName="Size" HeaderText="Size (in gallons)" DataField="SizeInGallons" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="100px">
                                <ItemTemplate>
                                    <div style="text-align: right">
                                        <asp:HiddenField ID="hdnOrigSize" runat="server" Value='<%# Eval("SizeInGallons") %>' />
                                        <asp:TextBox ID="txtDeepFryerSizeInGallons" runat="server" CssClass="gridtextbox" Text='<%# Eval("SizeInGallons") %>'></asp:TextBox>
                                    </div>
                                </ItemTemplate>
                                <ItemStyle CssClass="gridText gray" BorderColor="ActiveBorder" />
                            </telerik:GridTemplateColumn>
                            <telerik:GridTemplateColumn UniqueName="Delete" HeaderText="" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50px">
                                <ItemTemplate>
                                    <div style="text-align: center">
                                        <asp:Button ID="btnDeleteFryer" runat="server" CssClass="delete" CommandName="delete" CommandArgument='<%# Eval("DeepFryerId") %>' UseSubmitBehavior="true" />
                                </ItemTemplate>
                                <ItemStyle BorderColor="ActiveBorder" CssClass="gridTextItalic gray" HorizontalAlign="Center" />
                            </telerik:GridTemplateColumn>
                        </Columns>
                        <HeaderStyle Font-Bold="true" CssClass="gridTextItalic" BorderWidth="0" />
                    </MasterTableView>
                </telerik:RadGrid>
                <div class="clear">
                </div>
                <div style="float: right; padding-bottom: 10px;">
                    <asp:Button ID="btnSaveFryers" runat="server" CssClass="button" Text="Save Fryers" UseSubmitBehavior="true" OnClick="btnSaveFryers_Click" />
                    <asp:Button ID="btnCancelFryers" runat="server" CssClass="button" Text="Cancel" OnClick="btnCancelFryers_Click" />
                </div>
                <div class="spacer">
                </div>
                <div id="revisionDiv" runat="server" visible="false">
                        <hr />
                        <h4>
                            Latest Fryer Changes:</h4>
                        <asp:Repeater ID="rptChanges" runat="server" OnItemDataBound="rptChanges_ItemDataBound">
                            <HeaderTemplate>
                                <table id="accountTable" cellspacing="0" class="repeater" width="850px">
                                    <tr>
                                        <th>
                                            Date
                                        </th>
                                        <th>
                                            User
                                        </th>
                                        <th>
                                            Fryer
                                        </th>
                                        <th>
                                            Change
                                        </th>
                                    </tr>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <%--<tr class="<%# ((bool)Eval("IsActive") ? "" : "error") %>">--%>
                                <tr>
                                    <td style="text-align: right; width: 150px">
                                        <asp:Label ID="lblDate" runat="server"></asp:Label>
                                    </td>
                                    <td style="text-align: center">
                                        <asp:Label ID="lblUsername" runat="server"></asp:Label>
                                    </td>
                                    <td style="text-align: center">
                                        <asp:Label ID="lblFryerName" runat="server"></asp:Label>
                                    </td>
                                    <td style="text-align: left">
                                        <asp:Label ID="lblRevisionInfo" runat="server"></asp:Label>
                                    </td>
                                </tr>
                            </ItemTemplate>
                            <FooterTemplate>
                                </table>
                            </FooterTemplate>
                        </asp:Repeater>
                    </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="sideBarContent" runat="server">
    <div style="float: right; padding-bottom: 10px;">
        <asp:Button ID="btnDeleteServiceLocation" runat="server" CssClass="button" Text="Delete this Restaurant Outlet" OnClick="btnDeleteServiceLocation_Click" Visible="false" OnClientClick="javascript:return confirm('Are you sure you want to delete?');" />
    </div>
    <div class="sidebar nospace">
        <div class="sidebartop">
        </div>
        <div class="sidebarmain">
            <div class="sidebarcontent">
                <h4 class="sidebarheading">
                    Notes</h4>
                <div class="clear">
                </div>
                <asp:TextBox ID="txtNotes" CssClass="sidebarTextbox" runat="server" TextMode="MultiLine" Height="90px"></asp:TextBox>
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
                Enter information for the new location and then click Save.</p>
            <p id="instructionmessage" runat="server">
            </p>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>

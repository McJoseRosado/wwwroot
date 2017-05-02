<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/Coc.Master"
    CodeBehind="NewDock.aspx.cs" Inherits="RenuOil.NewDock" %>

<asp:Content ContentPlaceHolderID="Coc_ContentPlaceHolder" runat="server">
    <div id="coc_new_dock_page">
        <div class="main_row row">

            <div class="col-sm-12">
                <h3>New Dock</h3>
                    <hr />
                <div class="row">
                    <form class="form-horizontal" runat="server">
                        <div class="form-group">
                            <div class="col-sm-12">
                                <div class="alert alert-danger" id="new_dock_alert" runat="server" role="alert">
                                    <span class="glyphicon glyphicon-exclamation-sign" aria-hidden="true"></span>
                                    <span class="sr-only">Error:</span>
                                    <span id="new_dock_alert_text" runat="server" ></span>
                                </div>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">Property</label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="propertiesList" runat="server" CssClass="form-control">
                                </asp:DropDownList>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">Dock Name</label>
                            <div class="col-sm-10">
                                <input class="form-control" id="dockName" runat="server" placeholder="Dock Name"/>
                            </div>
                        </div>

                        <div class="form-group">
                            <div class="col-sm-12">
                                <hr />
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label"></label>
                            <div class="col-sm-10">
                                <asp:Button runat="server" OnClick="btnSaveDock_Click" Text="Save" CssClass="btn btn-default btn-success"/>
                                <asp:Button runat="server" OnClick="btnCancel_Click" Text="Cancel" CssClass="btn btn-default btn-danger"/>
                            </div>

                        </div>
                    </form>
                </div>
            </div>

        </div>
    </div>
</asp:Content>

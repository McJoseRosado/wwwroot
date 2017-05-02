<%@ Page Language="C#" MasterPageFile="~/MasterPages/Coc.Master" AutoEventWireup="true"
    CodeBehind="COC.aspx.cs" Inherits="RenuOil.COC" %>

<asp:Content ContentPlaceHolderID="Coc_ContentPlaceHolder" runat="server">
    <div id="coc_landing_page">
        <div class="main_row row">
            <div class="col-sm-12">
                <div class="alert alert-info" id="coc_alert" runat="server" role="alert">
                    <span class="glyphicon glyphicon-exclamation-sign" aria-hidden="true"></span>
                    <span class="sr-only">Error:</span>
                    <span id="coc_alert_text" runat="server"></span>
                </div>
            </div>
            <div class="col-sm-12">
                <div class="row">
                    <div class="col-sm-6 col-md-3">
                        <a href="NewBale.aspx" class="btn btn-info btn-lg btn-block linkButton">Create Bale</a>
                    </div>

                    <div class="col-sm-6 col-md-3">
                        <a href="EditBale.aspx" class="btn btn-info btn-lg btn-block linkButton">Edit Bale</a>
                    </div>

                    <div class="col-sm-6 col-md-3">
                        <a href="NewLoad.aspx" class="btn btn-success btn-lg btn-block linkButton">Create Load</a>
                    </div>

                    <div class="col-sm-6 col-md-3">
                        <a href="ExistingLoads.aspx" class="btn btn-success btn-lg btn-block linkButton">Existing Load</a>
                    </div>

                    <div class="col-sm-6 col-md-3">
                        <a href="NewDock.aspx" class="btn btn-warning btn-lg btn-block linkButton">New Dock</a>
                    </div>

                    <div class="col-sm-6 col-md-3">
                        <a href="EditDock.aspx" class="btn btn-warning btn-lg btn-block linkButton">Edit Dock</a>
                    </div>

                    <div class="col-sm-6 col-md-3">
                        <a href="ReceiverView.aspx" class="btn btn-primary btn-lg btn-block linkButton">Receiver View</a>
                    </div>

                    <div class="col-sm-6 col-md-3">
                        <a href="Home.aspx" class="btn btn-info btn-lg btn-block linkButton">Back to Home</a>
                    </div>
                </div>
            </div>

        </div>
    </div>
</asp:Content>

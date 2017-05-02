<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="MasterPages/Coc.master"
    CodeBehind="NewLoad.aspx.cs" Inherits="RenuOil.NewLoad" %>


<asp:Content ID="Content1" ContentPlaceHolderID="Coc_HeaderPlaceHolder" runat="server">
    <link href="include/datepicker/css/bootstrap-datepicker3.standalone.min.css" rel="stylesheet" type="text/css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Coc_ContentPlaceHolder" runat="server">
    <div id="coc_new_load_page">
        <div class="main_row row">
            <div class="col-sm-12">
                <h3>New Load</h3>
                <hr />
                <div class="row">
                    <form id="Form1" class="form-horizontal" runat="server">
                        <div class="form-group">
                            <div class="col-sm-12">
                                <div class="alert alert-danger" id="new_load_alert" runat="server" role="alert">
                                    <span class="glyphicon glyphicon-exclamation-sign" aria-hidden="true"></span>
                                    <span class="sr-only">Error:</span>
                                    <span id="new_load_alert_text" runat="server"></span>
                                </div>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">Load Id</label>
                            <div class="col-sm-10">
                                <h5><b runat="server" ID="loadIdText"></b></h5>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">Date</label>
                            <div class="col-sm-10">
                                <input runat="server" ID="date" class="form-control datepicker" placeholder=""/>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">Driver</label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="driversList" runat="server" CssClass="form-control">
                                </asp:DropDownList>
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
                                <asp:Button ID="Button1" runat="server" OnClick="btnSaveLoad_Click" Text="Save" CssClass="btn btn-default btn-success" />
                                <asp:Button ID="Button2" runat="server" OnClick="btnCancel_Click" Text="Cancel" CssClass="btn btn-default btn-danger" />
                            </div>

                        </div>
                    </form>
                </div>
            </div>

        </div>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Coc_footer_script_holder" runat="server">
    <script type="text/javascript" src="include/datepicker/js/bootstrap-datepicker.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $('.datepicker').datepicker({
                todayHighlight: true,
                todayBtn: "linked",
                autoclose: true,
                defaultDate: new Date()
            });

            $('.datepicker').datepicker('update', new Date());
        });
    </script>
</asp:Content>  

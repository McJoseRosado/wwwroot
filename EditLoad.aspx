<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditLoad.aspx.cs" Inherits="RenuOil.EditLoad"
    MasterPageFile="MasterPages/Coc.master" %>

<%@ Import Namespace="System.Linq" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Coc_HeaderPlaceHolder" runat="server">
    <link href="include/datepicker/css/bootstrap-datepicker3.standalone.min.css" rel="stylesheet"
        type="text/css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Coc_ContentPlaceHolder" runat="server">
    <div id="coc_edit_load_page">
        <div class="main_row row">
            <form id="Form1" runat="server">
                <div class="col-sm-12">
                    <h3>
                        <asp:Button ID="Button1" runat="server" OnClick="btnCancel_Click" Text="Back" CssClass="btn btn-default btn-info backToHome_button" />Edit
                        load - #<%= Load.LoadId %>
                        <asp:Button ID="Button2" runat="server" Text="COC MAIN SCREEN" OnClick="BackToCoc"
                            CssClass="btn btn-warning pull-right" /></h3>
                    <hr />
                    <div class="alert alert-success" role="alert"></div>
                    <div class="alert alert-danger" role="alert"></div>
                    <div class="col-sm-12">
                        <asp:DropDownList runat="server" ID="PropertiesList" CssClass="form-control main_propertiesList" />
                    </div>
                </div>
                <div class="col-sm-12">
                    <hr />
                </div>
                <div class="col-sm-12">
                    <h5><b>Selected Bales</b></h5>
                    <table class="table table-bordered table-striped selectedBalesTable">
                        <thead>
                            <tr>
                                <td>Bale Number</td>
                                <td>Property</td>
                                <td>Dock</td>
                                <td>Recycle Type</td>
                                <td>WT</td>
                                <td>Notes</td>
                                <td></td>
                            </tr>
                        </thead>
                        <tbody>
                        </tbody>
                    </table>
                </div>
                <div class="col-sm-12">
                    <hr />
                </div>
                <div class="col-sm-12">
                    <h5><b>Available Bales</b></h5>
                    <table class="table table-bordered table-striped availableBalesTable">
                        <thead>
                            <tr>
                                <td>Bale Number</td>
                                <td>Property</td>
                                <td>Dock</td>
                                <td>Recycle Type</td>
                                <td>WT</td>
                                <td>Notes</td>
                                <td></td>
                            </tr>
                        </thead>
                        <tbody>
                        </tbody>
                    </table>
                </div>
            </form>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Coc_footer_script_holder" runat="server">
    <script type="text/javascript" src="js/coc_script.js"></script>
    <script type="text/javascript" src="include/datepicker/js/bootstrap-datepicker.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $('.datepicker').datepicker({
                todayHighlight: true,
                todayBtn: "linked",
                autoclose: true
            });

            function updateTables(propertyId) {
                $(".availableBalesTable tbody").html("");
                $(".selectedBalesTable tbody").html("");

                //grab bales from this property
                var jsonData = JSON.stringify(
               {
                   propertyId: propertyId,
                   loadId: <%= Load.LoadId %>
                   });

               $.ajax({
                   url: "EditLoad.aspx/GetBalesInProperty",
                   data: jsonData,
                   contentType: "application/json",
                   success: function(data) {
                       var result = jQuery.parseJSON(data.d);

                       if (result.availableBales.length > 0) {
                           $(result.availableBales).each(function(index, bale) {
                               $(".availableBalesTable tbody")
                                   .append("<tr>" +
                                       "<td>" + bale.BaleNumber + "</td>" +
                                       "<td>" + bale.Property + "</td>" +
                                       "<td>" + bale.Dock + "</td>" +
                                       "<td>" + bale.RecycleType + "</td>" +
                                       "<td>" + bale.InitWeight + "</td>" +
                                       "<td>" + bale.Notes + "</td>" +
                                       "<td><input type='checkbox' class='editLoad_checkbox' baleId='"+ bale.BaleId +"'/></td>" +
                                       "</tr>");
                           });
                       }
                       if (result.selectedBales.length > 0) {
                           $(result.selectedBales).each(function(index, bale) {
                               $(".selectedBalesTable tbody")
                                   .append("<tr>" +
                                       "<td>" + bale.BaleNumber + "</td>" +
                                       "<td>" + bale.Property + "</td>" +
                                       "<td>" + bale.Dock + "</td>" +
                                       "<td>" + bale.RecycleType + "</td>" +
                                       "<td>" + bale.InitWeight + "</td>" +
                                       "<td>" + bale.Notes + "</td>" +
                                       "<td><input type='checkbox' class='editLoad_checkbox' baleId='"+ bale.BaleId +"' checked/></td>" +
                                       "</tr>");
                           });
                       }
                   },
                   type: "post",
                   dataType: "json"
               });
           }

            //main_propertiesList -> pull bales
            $(".main_propertiesList").change(function (e) {
                var self = $(this);
                if (self.val() != "-1") {
                    updateTables(self.val());
                }
            });

            //check update
            $("body").on("change",".editLoad_checkbox", function(e) {
                var self = $(this);

                var jsonData = JSON.stringify(
                   {
                       baleId: self.attr("baleId"),
                       isChecked: self.is(":checked"),
                       loadId: <%= Load.LoadId %>
                       });

                $.ajax({
                    url: "EditLoad.aspx/UpdateBale",
                    data: jsonData,
                    contentType: "application/json",
                    success: function(data) {
                        var result = jQuery.parseJSON(data.d);
                        updateTables($(".main_propertiesList").val());

                        if (result.Success) {
                            $(".alert-success").stop();
                            $(".alert").hide();
                            $(".alert-success").html("Updated load.").slideDown();
                            setTimeout(
                              function () {
                                  $(".alert-success").slideUp();
                              }, 2000);
                        }

                    },
                    type: "post",
                    dataType: "json"
                });

            });


        });
    </script>
</asp:Content>

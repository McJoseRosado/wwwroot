<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="MasterPages/Coc.master"
    CodeBehind="ReceiverView.aspx.cs" Inherits="RenuOil.ReceiverView" %>

<%@ Import Namespace="System.Linq" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Coc_HeaderPlaceHolder" runat="server">
    <link rel="stylesheet" type="text/css" href="include/DataTables/css/jquery.dataTables.min.css" />
    <link href="include/datepicker/css/bootstrap-datepicker3.standalone.min.css" rel="stylesheet"
        type="text/css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Coc_ContentPlaceHolder" runat="server">
    <div id="coc_receiverView_page">
        <div class="main_row row">
            <form runat="server">
                <div class="col-sm-12">
                    <h3>
                        <asp:Button ID="Button1" runat="server" OnClick="btnCancel_Click" Text="Back" CssClass="btn btn-default btn-info backToHome_button" />Receiver
                        View</h3>
                    <hr />
                    <div class="alert alert-success" role="alert"></div>
                    <div class="alert alert-danger" role="alert"></div>
                    <div class="col-sm-5">
                        <input class="form-control datepicker" placeholder="" runat="server" id="startDate" />
                    </div>
                    <div class="col-sm-5">
                        <input class="form-control datepicker" placeholder="" runat="server" id="endDate" />
                    </div>
                    <div class="col-sm-2">
                        <button id="Button2" runat="server" class="btn btn-primary btn-block" onserverclick="OnSearchClick">
                            Search</button>
                    </div>
                </div>
                <div class="col-sm-12">
                    <hr />
                </div>

                <div class="col-sm-12">
                    <table class="table table-bordered dataTable" width="100%">
                        <thead>
                            <tr>
                                <td>Load Id</td>
                                <td style="width: 30%">Date</td>
                                <td style="width: 30%">Driver</td>
                                <td></td>
                            </tr>
                        </thead>
                        <tbody>
                            <%
                                foreach (var load in Loads)
                                {
                            %>
                            <tr>
                                <td>
                                    <p class="edit_p"><b><%= load.LoadId %></b></p>
                                </td>
                                <td>
                                    <p class="edit_p"><%= load.Date.ToString("MM/dd/yyyy") %></p>
                                </td>
                                <td>
                                    <p class="edit_p"><%= load.Employee.FullName %></p>
                                </td>
                                <td class="crud_td">
                                    <% if (!Bales.Any(b => b.LoadId == load.LoadId))
                                       { %>
                                    <a class="btn btn-info" disabled loadid="<%= load.LoadId %>">Edit Bales</a>
                                    <% }
                                       else
                                       { %>
                                    <a href="ReceiverViewEditBales.aspx?loadId=<%= load.LoadId %>" loadid="<%= load.LoadId %>"
                                        class="btn btn-primary editBalesModal_button"
                                        loadid="<%= load.LoadId %>">Edit Bales</a>
                                    <% } %>
                                </td>
                            </tr>
                            <%
                                }
                            %>
                        </tbody>
                    </table>
                </div>
            </form>
        </div>
    </div>

    <div class="modal modal-fullscreen fade receiverModal">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="main_row row">
                    <!--edit bales-->
                    <div class="col-sm-12 editBalesContent">
                        <h3>Receiver View - <i>Edit Bales</i></h3>
                        <div style="display: none;" class="modal-alert alert alert-success modal-alert-success"
                            role="alert">
                        </div>
                        <div style="display: none;" class="modal-alert alert alert-danger modal-alert-danger"
                            role="alert">
                        </div>
                        <hr />
                        <table class="table table-bordered table-striped modalDataTable" style="width: 100%">
                            <thead>
                                <tr>
                                    <td>Property</td>
                                    <td>Dock</td>
                                    <td style="width: 80px;">Bale Number</td>
                                    <td>Recycle Type</td>
                                    <td style="width: 85px;">Initial Weight</td>
                                    <td style="width: 125px;">Warehouse Weight</td>
                                    <td style="width: 85px;">Final Weight</td>
                                    <td>Notes</td>
                                    <td></td>
                                    <td></td>
                                </tr>
                            </thead>
                            <tbody>
                            </tbody>
                        </table>
                        <hr />

                        <div class="pull-right">
                            <button class="btn btn-success confirmSave_button">Save</button>
                            <button class="btn btn-danger" data-dismiss="modal" aria-label="Close">Cancel</button>
                        </div>
                    </div>

                    <!--swap bale-->
                    <div class="col-sm-12 swapBaleContent" style="display: none;">

                        <div class="col-sm-12">
                            <h3>
                                <button class="btn btn-warning swapContentBack_Button">Back</button>
                                Receiver View - <i>Swap Bale# <span class="baleNumberSpan"></span></i></h3>
                            <hr />
                            <div style="display: none;" class="modal-alert alert alert-success modal-alert-success"
                                role="alert">
                            </div>
                            <div style="display: none;" class="modal-alert alert alert-danger modal-alert-danger"
                                role="alert">
                            </div>
                            <div class="col-sm-5">
                                <input class="form-control datepicker swapBaleStartDate" placeholder="" />
                            </div>
                            <div class="col-sm-5">
                                <input class="form-control datepicker swapBaleEndDate" placeholder="" />
                            </div>
                            <div class="col-sm-2">
                                <button class="btn btn-primary btn-block swapBaleDateSearch_button">Search</button>
                            </div>
                        </div>


                        <div class="col-sm-12">
                            <hr />
                        </div>

                        <table class="table table-bordered table-striped modalSwapBaleDataTable" style="width: 100%">
                            <thead>
                                <tr>
                                    <td>Load Number</td>
                                    <td>Date</td>
                                    <td>Driver</td>
                                    <td></td>
                                </tr>
                            </thead>
                            <tbody>
                            </tbody>
                        </table>
                        <hr />
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Coc_footer_script_holder" runat="server">
    <script type="text/javascript" charset="utf8" src="include/script/jquery-ui.min.js"></script>
    <script type="text/javascript" charset="utf8" src="include/datatables/js/jquery.dataTables.min.js"></script>
    <script type="text/javascript" charset="utf8" src="include/datatables/js/dataTables.bootstrap.min.js"></script>
    <script type="text/javascript" src="include/datepicker/js/bootstrap-datepicker.min.js"></script>
    <script type="text/javascript" src="js/coc_script.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {

            //datepicker

            //first set swapBaleStartDate and swapBaleEndDate
            function setSwapBaleDates() {
                $(".swapBaleStartDate").val($.datepicker.formatDate('mm/dd/yy', new Date(new Date().setDate(new Date().getDate() - 1))));
                $(".swapBaleEndDate").val($.datepicker.formatDate('mm/dd/yy', new Date()));
            }

            setSwapBaleDates();

            $('.datepicker, .swapBaleStartDate, .swapBaleEndDate').datepicker({
                todayHighlight: true,
                todayBtn: "linked",
                autoclose: true
            });

            //data tables
            var table = $(".dataTable").DataTable({
                responsive: {
                    details: {
                        type: 'column'
                    }
                }
            });

            ////////////////////////////////////////////ajax pulling/////////////////////////////////////
            //pull recycle types list
            var recycleTypesList = jQuery.parseHTML("<select class='form-control recycleTypesList'></select>");
            function getRecycleTypesList() {
                $.ajax({
                    url: "ReceiverView.aspx/GetRecycleTypesList",
                    contentType: "application/json",
                    type: "post",
                    dataType: "json",
                    success: function (data) {
                        var result = jQuery.parseJSON(data.d);

                        $(result.RecycleTypes).each(function (index, type) {
                            $(recycleTypesList).append("<option value=" + type.RecycleTypeId + ">" + type.Name + "</option>");
                        });

                    },
                    fail: (function () {
                        $(".alert").hide();
                        $(".alert-danger").html("An Error Has Occurred, Please Try Again Later.").slideDown();
                    })
                });
            }
            getRecycleTypesList();

            //pull loads for swap bales content
            function getLoadsForSwapBaleTable() {
                var jsonData = JSON.stringify(
                {
                    startDate: $(".swapBaleStartDate").val(),
                    endDate: $(".swapBaleEndDate").val()
                });

                var table = $(".modalSwapBaleDataTable tbody");
                table.html("");

                $.ajax({
                    url: "ReceiverView.aspx/GetLoads",
                    contentType: "application/json",
                    data: jsonData,
                    type: "post",
                    dataType: "json",
                    success: function (data) {
                        var result = jQuery.parseJSON(data.d);

                        $(result.Loads).each(function (index, load) {

                            table.append("<tr>" +
                                "<td>" + load.LoadNumber + "</td>" +
                                "<td>" + load.Date + "</td>" +
                                "<td>" + load.EmployeeName + "</td>" +
                                "<td><button class='btn btn-info swapLoad_button' loadId='" + load.LoadId + "'>Swap</button></td>" +
                                "</tr>");
                        });

                    },
                    fail: (function () {
                        $(".alert").hide();
                        $(".alert-danger").html("An Error Has Occurred, Please Try Again Later.").slideDown();
                    })
                });
            }


            ///////////////////////////////////////////////////////////////////////////////////////////////

            //modal
            $('.modal').on('hidden.bs.modal', function (e) {
                $(".modalDataTable tbody").html("");
                $(".modal-alert").hide();
                //reset confirmSave_button loadId
                $(".confirmSave_button").prop("loadId", "");

                //reset contents
                $(".editBalesContent").show();
                $(".swapBaleContent").hide();

                setSwapBaleDates();
            });

            //editBales
            $(".editBalesModal_button").click(function (e) {
                e.preventDefault();

                //get bales for this load
                var loadId = $(this).attr("loadId");

                var jsonData = JSON.stringify(
                {
                    loadId: loadId
                });

                $.ajax({
                    url: "ReceiverView.aspx/GetBales",
                    data: jsonData,
                    contentType: "application/json",
                    success: function (data) {
                        var result = jQuery.parseJSON(data.d);

                        //if editBalesModal_button is clicked, then it should have at least one bale
                        if (result.Success && result.Bales.length > 0) {
                            $(result.Bales).each(function (index, bale) {
                                $(".modalDataTable tbody")
                                       .append("<tr baleId='" + bale.BaleId + "'>" +
                                           "<td>" + bale.Property + "</td>" +
                                           "<td>" + bale.Dock + "</td>" +
                                           "<td><input type='number' step='1' min='0' class='form-control baleNumber' value='" + bale.BaleNumber + "' /></td>" +
                                           "<td recycleTypeId='" + bale.RecycleTypeId + "'>" + $(recycleTypesList).clone().wrap('<p>').parent().html() + "</td>" +
                                           "<td><input type='number' step='1' min='0' class='form-control initWeight' value='" + bale.InitWeight + "' /></td>" +
                                           "<td><input type='number' step='1' min='0' class='form-control warehouseWeight' value='" + bale.WarehouseWeight + "' /></td>" +
                                           "<td><input type='number' step='1' min='0' class='form-control calculatedFinalWeight' disabled value='" + bale.FinalWeight + "'</td>" +
                                           "<td><input class='form-control notes' value='" + bale.Notes + "' /></td>" +
                                           "<td><button class='btn btn-warning swapBale_button' baleId='" + bale.BaleId + "' baleNumber='" + bale.BaleNumber + "'><span class='glyphicon glyphicon-random' aria-hidden='true'></span></button></td>" +
                                           "<td><button class='btn btn-danger deleteBale_button'><span class='glyphicon glyphicon-remove-circle'></span></button></td>" +
                                           "</tr>");
                            });

                            //set selected recycle type
                            $(".recycleTypesList").each(function (index, list) {
                                $(this).find("option[value=" + $(this).parent().attr("recycleTypeId") + "]").prop("selected", true);
                            });

                            //set confirmSave_button loadId
                            $(".confirmSave_button").attr("loadId", loadId);
                        }
                    },
                    fail: (function () {
                        $(".alert").hide();
                        $(".alert-danger").html("An Error Has Occurred, Please Try Again Later.").slideDown();
                    }),
                    type: "post",
                    dataType: "json"
                });

                $(".modal").modal("show");
            });

            //delete
            $('body').on("click", ".deleteBale_button", function (e) {
                e.preventDefault();

                var tr = $(this).parents("tr");

                tr.attr("baleAction", "delete");

                tr.hide();
            });

            //swap slide action
            function slideModelContent(baleNumber, baleId) {

                var modal = $(".receiverModal");

                //slide one then show another
                if ($(".editBalesContent").is(":visible")) {
                    modal.find(".editBalesContent").toggle("slide", function () {
                        modal.find(".swapBaleContent").toggle("slide");
                    });

                    //set baleNumberSpan
                    $(".baleNumberSpan").attr("baleId", baleId);
                    $(".baleNumberSpan").text(baleNumber);

                } else {
                    modal.find(".swapBaleContent").toggle("slide", function () {
                        modal.find(".editBalesContent").toggle("slide");
                    });
                }
            }

            //swap
            $('body').on("click", ".swapBale_button", function (e) {
                e.preventDefault();
                var baleNumber = $(this).attr("baleNumber");
                var baleId = $(this).attr("baleId");

                //when you go into the swap contant screen, this will set the .baleNumberSpan bale number and id
                slideModelContent(baleNumber, baleId);

                //pull avaiable loads based on date
                getLoadsForSwapBaleTable();
            });

            //swap date search
            $('body').on("click", ".swapBaleDateSearch_button", function (e) {
                e.preventDefault();
                //pull avaiable loads based on date
                getLoadsForSwapBaleTable();
            });

            //swap back button
            $('body').on("click", ".swapContentBack_Button", function (e) {
                e.preventDefault();
                var baleNumber = $(this).attr("baleNumber");

                slideModelContent(baleNumber);
            });

            //swapLoad_button
            $('body').on("click", ".swapLoad_button", function (e) {
                e.preventDefault();

                $(".swapContentBack_Button").click();

                var loadId = $(this).attr("loadId");
                var baleId = $(".baleNumberSpan").attr("baleId");

                //find the bale and disable it
                $(".modalDataTable tbody tr").each(function (index, row) {
                    if ($(row).attr("baleId") == baleId) {
                        $(this).attr("newLoadId", loadId);
                        $(this).attr("baleAction", "swap");

                        $(row).html("<td colspan='10'>This bale will be moved to load id # " + loadId + "</td>");
                    }
                });
            });


            //save ajax
            $('.confirmSave_button').click(function (e) {
                e.preventDefault();
                var hasWeightInputError = false;

                //update all the bales in this load
                var updateBales = [];
                var deleteBales = [];
                var swapBales = [];

                $.each($(".modalDataTable tbody").find("tr"), function (index, value) {
                    var bale = {};
                    bale.baleId = $(this).attr("baleId");

                    //*don't push header tr
                    if (isNaN(bale.baleId)) {
                        return;
                    }

                    //if not swapping, then look for props
                    if ($(this).attr("baleAction") != "swap") {

                        bale.BaleNumber = $(this).find(".baleNumber").val();
                        bale.recycleTypeId = $(this).find(".recycleTypesList").val();
                        bale.initWeight = $(this).find(".initWeight").val();
                        bale.warehouseWeight = $(this).find(".warehouseWeight").val();
                        bale.finalWeight = $(this).find(".calculatedFinalWeight").val();
                        bale.notes = $(this).find(".notes").val();

                        //check weight inputs
                        var weightInputs = [bale.initWeight, bale.warehouseWeight, bale.finalWeight];
                        for (var i = 0; i < weightInputs.length; i++) {
                            var weight = weightInputs[i];
                            //*don't check if the weight is empty
                            if (parseFloat(weight) == NaN || weight != "") {
                                if (!isInt(parseFloat(weight))) {
                                    hasWeightInputError = true;
                                }
                            }
                        }

                        if (hasWeightInputError) {
                            //continus to next one
                            return;
                        }
                    }

                    //push to updateBales, deleteBales, or swapBales
                    if ($(this).attr("baleAction") == "delete") {
                        deleteBales.push(bale);
                    } else if ($(this).attr("baleAction") == "swap") {
                        //swap -> new load Id
                        bale.LoadId = $(this).attr("newLoadId");

                        swapBales.push(bale);
                    } else {
                        updateBales.push(bale);
                    }
                });

                if (hasWeightInputError) {

                    $(".modal-alert").hide();
                    $(".modal-alert-danger").html("No decimal point allowed for weight input.").slideDown();
                    return;
                }


                var jsonData = JSON.stringify(
                {
                    loadId: $(this).attr("loadId"),
                    updateBales: JSON.stringify(updateBales),
                    deleteBales: JSON.stringify(deleteBales),
                    swapBales: JSON.stringify(swapBales)
                });


                $.ajax({
                    url: "ReceiverView.aspx/Save",
                    data: jsonData,
                    contentType: "application/json",
                    success: function (data) {
                        $(".alert").stop();

                        $(".alert").hide();
                        $(".alert-success").html("Bales updated. Refreshing page...").slideDown();

                        //close modal
                        $('.modal').modal("hide");

                        setTimeout(
                          function () {
                              $(".alert").slideUp();
                              location.reload();
                          }, 2000);
                    },
                    fail: (function () {
                        $(".alert").hide();
                        $(".alert-danger").html("An Error Has Occurred, Please Try Again Later.").slideDown();
                    }),
                    type: "post",
                    dataType: "json"
                });
            });

            //warehouseWeight
            $('.modalDataTable tbody').on('change', '.warehouseWeight', function () {
                if (isNumeric($(this).val())) {

                    var typeName = $(this).closest("tr").find($(".recycleTypesList option:selected")).text();
                    var ratio = 1;

                    if (typeName.indexOf("P1") != -1) {
                        ratio = .93;
                    } else if (typeName.indexOf("Aluminum") != -1) {
                        ratio = .87;
                    }

                    $(this).closest("tr").find(".calculatedFinalWeight").val(Math.round(parseFloat($(this).val()) * ratio));
                }
            });

        });
    </script>
</asp:Content>

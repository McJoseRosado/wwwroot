<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReceiverViewEditBales.aspx.cs"
    Inherits="RenuOil.ReceiverViewEditBales" MasterPageFile="MasterPages/Coc.master" %>

<%@ Import Namespace="System.Linq" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Coc_HeaderPlaceHolder" runat="server">
    <link rel="stylesheet" type="text/css" href="include/DataTables/css/jquery.dataTables.min.css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Coc_ContentPlaceHolder" runat="server">
    <div id="coc_receiverView_page">
        <div class="main_row row">
            <div class="col-sm-12">
                <form id="Form1" runat="server">
                    <h3>
                        <asp:Button ID="Button1" runat="server" OnClick="btnCancel_Click" Text="Back" CssClass="btn btn-default btn-info backToHome_button" />Receiver
                        View - <i>Edit Bales in Load "<%= Load.LoadNumber %>"</i>
                        <asp:Button ID="Button2" runat="server" Text="COC MAIN SCREEN" OnClick="BackToCoc"
                            CssClass="btn btn-warning pull-right" /></h3>
                    <div class="alert alert-success" role="alert"></div>
                    <div class="alert alert-danger" role="alert"></div>

                    <hr />
                    <table class="table table-bordered table-striped dataTable" style="width: 100%">
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
                            </tr>
                        </thead>
                        <tbody>
                            <% foreach (var bale in Bales.OrderBy(b => b.BaleId))
                               { %>
                            <tr loadid="<%= Load.LoadId %>" baleId="<%= bale.BaleId %>">
                                <td>
                                    <p class="edit_p"><b><%= bale.Account.Name %></b></p>
                                </td>
                                <td>
                                    <p class="edit_p"><b><%= bale.Dock.DockName %></b></p>
                                </td>
                                <td>
                                    <p class="edit_p"><b class="baleId"><%= bale.BaleNumber %></b></p>
                                </td>
                                <td>
                                    <select class="form-control recycleTypesList">
                                        <%
                                   foreach (var recycleType in RecycleTypesList)
                                   {
                                       if (recycleType.RecycleTypeId == bale.RecycleTypeId)
                                       {
                                        %>
                                        <option selected="selected" value="<%= recycleType.RecycleTypeId %>"><%= recycleType.Name %></option>
                                        <%
                                       }
                                       else
                                       {
                                        %>
                                        <option value="<%= recycleType.RecycleTypeId %>"><%= recycleType.Name %></option>
                                        <%
                                       }
                                   }
                                        %>
                                    </select></td>

                                <td>
                                    <input type="number" step="1" min="0" class="form-control initWeight" value="<%= bale.InitWeight %>" />
                                </td>
                                <td>
                                    <input type="number" step="1" min="0" class="form-control warehouseWeight" value="<%= bale.WarehouseWeight %>" />
                                </td>
                                <td>
                                    <input type="number" step="1" min="0" class="form-control calculatedFinalWeight"
                                        value="<%= bale.FinalWeight %>" />
                                </td>
                                <td>
                                    <input type="text" class="form-control notes" value="<%= bale.Notes %>" />
                                </td>
                            </tr>
                            <% } %>
                        </tbody>
                    </table>
                    <hr />

                    <div class="pull-right">
                        <button class="btn btn-success confirmSave_button" loadId="<%= Load.LoadId %>">Save</button>
                        <asp:Button ID="Button3" runat="server" OnClick="btnCancel_Click" Text="Cancel" CssClass="btn btn-danger" />
                    </div>

                </form>
            </div>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Coc_footer_script_holder" runat="server">
    <script type="text/javascript" charset="utf8" src="include/datatables/js/jquery.dataTables.min.js"></script>
    <script type="text/javascript" charset="utf8" src="include/datatables/js/dataTables.bootstrap.min.js"></script>
    <script type="text/javascript" src="js/coc_script.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            var table = $(".dataTable").DataTable({
                responsive: {
                    details: {
                        type: 'column'
                    }
                }
            });

            //save ajax
            $('.confirmSave_button').click(function (e) {
                e.preventDefault();
                var hasWeightInputError = false;

                //update all the bales in this load
                var bales = [];

                $.each($(".dataTable tbody").find("tr"), function (index, value) {
                    var bale = {};
                    bale.baleId = $(this).attr("baleId");

                    //*don't push header tr
                    if (isNaN(bale.baleId)) {
                        return;
                    }


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

                    //push to bales
                    bales.push(bale);
                });

                if (hasWeightInputError) {

                    $(".alert").hide();
                    $(".alert-danger").html("No decimal point allowed for weight input.").slideDown();
                    return;
                }


                var jsonData = JSON.stringify(
                {
                    loadId: $(this).attr("loadId"),
                    bales: JSON.stringify(bales)
                });


                $.ajax({
                    url: "ReceiverViewEditBales.aspx/Save",
                    data: jsonData,
                    contentType: "application/json",
                    success: function (data) {
                        $(".alert").stop();

                        $(".alert").hide();
                        $(".alert-success").html("Bales updated.").slideDown();

                        setTimeout(
                          function () {
                              $(".alert").slideUp();
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
            $('.dataTable tbody').on('change', '.warehouseWeight', function () {
                if (isNumeric($(this).val())) {

                    var typeName = $(this).closest("tr").find($(".recycleTypesList option:selected")).text();
                    var ratio = 1;

                    if (typeName == "P1 Cups") {
                        ratio = .93;
                    } else if (typeName == "Aluminum") {
                        ratio = .87;
                    }

                    $(this).closest("tr").find(".calculatedFinalWeight").val(Math.round(parseFloat($(this).val()) * ratio));
                }
            });

        });
    </script>
</asp:Content>

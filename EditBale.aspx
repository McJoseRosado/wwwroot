<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditBale.aspx.cs" Inherits="RenuOil.EditBale"
    MasterPageFile="~/MasterPages/Coc.Master" %>

<%@ Import Namespace="System.Linq" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Coc_HeaderPlaceHolder" runat="server">
    <link rel="stylesheet" type="text/css" href="include/DataTables/css/jquery.dataTables.min.css" />
    <link href="include/datepicker/css/bootstrap-datepicker3.standalone.min.css" rel="stylesheet" type="text/css" />
</asp:Content>

<asp:Content ContentPlaceHolderID="Coc_ContentPlaceHolder" runat="server">
    <div id="coc_edit_bale_page">
        <div class="main_row row">
            <form id="Form1" runat="server">
                <div class="col-sm-12">

                    <h3>
                        <asp:Button ID="Button1" runat="server" OnClick="btnCancel_Click" Text="Back" CssClass="btn btn-default btn-info backToHome_button" />Edit
                        Bale</h3>
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
                                <td>Id</td>
                                <td>Created Date</td>
                                <td>Property</td>
                                <td>Dock</td>
                                <td>Recycle Type</td>
                                <td>Bale Number</td>
                                <td>WT</td>
                                <td>Notes</td>
                                <td></td>
                            </tr>
                        </thead>
                        <tbody>
                            <%
                                foreach (var bale in Bales)
                                {
                            %>
                            <tr>
                                <td>
                                    <p class="edit_p"><b><%= bale.BaleId %></b></p>
                                </td>
                                <td>
                                    <p class="edit_p"><b><%= bale.CreatedDate.Date.ToString("MM/dd/yyyy") %></b></p>
                                </td>
                                <td>
                                    <select class="form-control propertiesList" disabled>
                                        <%
                                    foreach (var property in Properties)
                                    {
                                        if (property.AccountId == bale.AccountId)
                                        {
                                        %>
                                        <option selected="selected" value="<%= property.AccountId %>"><%= property.Name %></option>
                                        <%
                                        }
                                        else
                                        {
                                        %>
                                        <option value="<%= property.AccountId %>"><%= property.Name %></option>
                                        <%
                                        }
                                    }
                                        %>
                                    </select>
                                </td>
                                <td>
                                    <select class="form-control docksList" disabled>
                                        <%
                                    foreach (var dock in Docks.Where(d => d.AccountId == bale.AccountId))
                                    {
                                        if (dock.DockId == bale.DockId)
                                        {
                                        %>
                                        <option selected="selected" value="<%= dock.DockId %>"><%= dock.DockName %></option>
                                        <%
                                        }
                                        else
                                        {
                                        %>
                                        <option value="<%= dock.DockId %>"><%= dock.DockName %></option>
                                        <%
                                        }
                                    }
                                        %>
                                    </select>
                                </td>
                                <td>
                                    <select class="form-control recycleTypesList" disabled>
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
                                    <input type="number" class="form-control baleNumber" value="<%= bale.BaleNumber %>" disabled />
                                </td>
                                <td>
                                    <input type="number" step="1" min="0" class="form-control initWeight" value="<%= bale.InitWeight %>"
                                        disabled /></td>
                                <td>
                                    <input type="text" class="form-control notes" value="<%= bale.Notes %>" disabled />
                                </td>

                                <td class="crud_td">
                                    <div class="row editOrDelete_row">
                                        <button type="button" class="btn btn-default edit_button">
                                            Edit</button>
                                        <button type="button" class="btn btn-danger delete_button">
                                            Delete</button>
                                    </div>
                                    <div class="row confirmDelete_row">
                                        <button type="button" class="btn btn-danger confirmDetele_button" baleid="<%= bale.BaleId %>">
                                            Delete</button>
                                        <button type="button" class="btn btn-default cancel_button">
                                            Back</button>
                                    </div>
                                    <div class="row confirmSave_row">
                                        <button type="button" class="btn btn-success confirmSave_button" baleid="<%= bale.BaleId %>">
                                            Save</button>
                                        <button type="button" class="btn btn-default cancel_button">
                                            Back</button>
                                    </div>
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
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="Coc_footer_script_holder" runat="server">
    <script type="text/javascript" charset="utf8" src="include/datatables/js/jquery.dataTables.min.js"></script>
    <script type="text/javascript" charset="utf8" src="include/datatables/js/dataTables.bootstrap.min.js"></script>
    <script type="text/javascript" src="include/datepicker/js/bootstrap-datepicker.min.js"></script>
    <script type="text/javascript" src="js/coc_script.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $('.datepicker').datepicker({
                todayHighlight: true,
                todayBtn: "linked",
                autoclose: true
            });

            var table = $(".dataTable").DataTable({
                sScrollX: "100%",
                "autoWidth": false,
                columnDefs: [
                    { orderable: false, targets: [2, 3, 4, 5, 6] }
                ]
            });

            //delete
            $("body").on("click", ".confirmDetele_button", function (e) {
                e.preventDefault();
                var button = $(this);

                var jsonData =
                    JSON.stringify({
                        baleId: button.attr("baleId")
                    });

                $.ajax({
                    url: "EditBale.aspx/Delete",
                    data: jsonData,
                    contentType: "application/json",
                    success: function (data) {
                        var result = jQuery.parseJSON(data.d);

                        if (result.Success == true) {
                            $(".alert").hide();
                            $(".alert-success").html("Deleted bale.").slideDown();

                            button.parents("tr").remove();
                        } else {
                            $(".alert").hide();
                            $(".alert-danger").html("An error has occurred.").slideDown();
                        }
                    },
                    type: "post",
                    dataType: "json"
                });
            });

            //save
            $("body").on("click", ".confirmSave_button", function (e) {
                e.preventDefault();
                var button = $(this);
                var parent = button.parents("tr");
                var hasError = false;
                var str = "";

                var newAccountId = parent.find(".propertiesList").val();
                var newDockId = parent.find(".docksList").val();
                var newRecycleTypeId = parent.find(".recycleTypesList").val();
                var newBaleNumber = parent.find(".baleNumber").val();
                var newNotes = parent.find(".notes").val();
                var newWeight = parent.find(".initWeight").val();

                if (newDockId == "-1") {
                    str += "Selected dock is invalid. ";
                    hasError = true;
                }

                if (parseInt(newWeight) !== parseInt(newWeight, 10)) {
                    str += "Initial weight is invalid. ";
                    hasError = true;
                }

                if (hasError) {
                    $(".alert").hide();
                    $(".alert-danger").html(str).slideDown();

                    return;
                }

                var jsonData =
                    JSON.stringify({
                        baleId: button.attr("baleId"),
                        accountId: newAccountId,
                        dockId: newDockId,
                        recycleTypeId: newRecycleTypeId,
                        baleNumber: newBaleNumber,
                        notes: newNotes,
                        initWeight: newWeight
                    });

                $.ajax({
                    url: "EditBale.aspx/Save",
                    data: jsonData,
                    contentType: "application/json",
                    success: function (data) {
                        $(".alert").hide();
                        $(".alert-success").html("Bale updated.").slideDown();

                        //fake click the back button
                        parent.find(".cancel_button").click();

                        setTimeout(
                              function () {
                                  $(".alert-success").slideUp();
                              }, 1000);
                    },
                    fail: (function () {
                        $(".alert").hide();
                        $(".alert-danger").html("An Error Has Occurred, Please Try Again Later.").slideDown();
                    }),
                    type: "post",
                    dataType: "json"
                });
            });
        });
    </script>
</asp:Content>

<%@ Page Language="C#" AutoEventWireup="True" MasterPageFile="MasterPages/Coc.master"
    CodeBehind="ExistingLoads.aspx.cs" Inherits="RenuOil.ExistingLoad" %>

<%@ Import Namespace="System.Linq" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Coc_HeaderPlaceHolder" runat="server">
    <link rel="stylesheet" type="text/css" href="include/DataTables/css/jquery.dataTables.min.css" /> 
    <link href="include/datepicker/css/bootstrap-datepicker3.standalone.min.css" rel="stylesheet"
        type="text/css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Coc_ContentPlaceHolder" runat="server">
    <div id="coc_existing_loads_page">
        <div class="main_row row">
            <form id="Form1" runat="server">
                <div class="col-sm-12">
                    <h3>
                        <asp:Button ID="Button1" runat="server" OnClick="btnCancel_Click" Text="Back" CssClass="btn btn-default btn-info backToHome_button" />Existing
                        Loads</h3>
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
                        <button runat="server" class="btn btn-primary btn-block" onserverclick="OnSearchClick">
                            Search</button>
                    </div>
                </div>
                <div class="col-sm-12">
                    <hr />
                </div>
                <div class="col-sm-12">
                    <table class="table table-bordered table-striped dataTable" width="100%">
                        <thead>
                            <tr>
                                <td>Load Number</td>
                                <td>Date</td>
                                <td>Driver</td>
                                <td></td>
                            </tr>
                        </thead>
                        <tbody>
                            <% foreach (var load in Loads)
                               { %>
                            <tr>
                                <td><%= load.LoadNumber %></td>
                                <td><%= load.Date.ToString("MM/dd/yyyy") %></td>
                                <td><%= load.Employee.FullName %></td>
                                <td>
                                    <div class="row editOrDelete_row">
                                        <button type="button" class="btn btn-block btn-primary select_button" loadid="<%= load.LoadId %>">
                                            Select</button>
                                        <button type="button" class="btn btn-danger delete_button">Delete</button>
                                    </div>
                                    <div class="row confirmDelete_row">
                                        <button type="button" class="btn btn-danger confirmDetele_button" loadid="<%= load.LoadId %>">
                                            Delete</button>
                                        <button type="button" class="btn btn-default cancel_button">
                                            Back</button>
                                    </div>
                                </td>
                            </tr>

                            <%  } %>
                        </tbody>
                    </table>
                </div>
            </form>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Coc_footer_script_holder" runat="server">
    <script type="text/javascript" charset="utf8" src="include/datatables/js/jquery.dataTables.min.js"></script>
    <script type="text/javascript" charset="utf8" src="include/datatables/js/dataTables.bootstrap.min.js"></script>
    <script type="text/javascript" src="js/coc_script.js"></script>
    <script type="text/javascript" src="include/datepicker/js/bootstrap-datepicker.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {

            var table = $(".dataTable").DataTable({
                responsive: {
                    details: {
                        type: 'column'
                    }
                }
            });

            $('.datepicker').datepicker({
                todayHighlight: true,
                todayBtn: "linked",
                autoclose: true
            });


            //go to edit load page
            $("body").on("click", ".select_button", function (e) {
                e.preventDefault();
                var button = $(this);
                var loadId = button.attr("loadId");

                window.location.href = window.location.href.replace("ExistingLoads.aspx", "EditLoad.aspx?loadId="+loadId);

            });

            //delete
            $("body").on("click", ".confirmDetele_button", function (e) {
                e.preventDefault();
                var button = $(this);
                var parent = button.parents("tr");

                var jsonData =
                JSON.stringify({
                    loadId: button.attr("loadId")
                });

                $.ajax({
                    url: "ExistingLoads.aspx/Delete",
                    data: jsonData,
                    contentType: "application/json",
                    success: function (data) {
                        var result = jQuery.parseJSON(data.d);

                        if (result.Success == true) {

                            $(".alert").stop();

                            $(".alert").hide();
                            $(".alert-success").html("Deleted Load.").slideDown();

                            button.parents("tr").remove();

                            setTimeout(
                              function () {
                                  $(".alert").slideUp();
                              }, 1000);
                        } else {
                            $(".alert").hide();
                            $(".alert-danger").html("An error has occurred.").slideDown();
                        }
                    },
                    type: "post",
                    dataType: "json"
                });
            });
        });
    </script>
</asp:Content>

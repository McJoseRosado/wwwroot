<%@ Page Language="C#" MasterPageFile="~/MasterPages/Coc.Master" AutoEventWireup="true"
    CodeBehind="EditDock.aspx.cs" Inherits="RenuOil.EditDock" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Coc_HeaderPlaceHolder" runat="server">
    <link rel="stylesheet" type="text/css" href="include/DataTables/css/jquery.dataTables.min.css" />
</asp:Content>

<asp:Content ContentPlaceHolderID="Coc_ContentPlaceHolder" runat="server">
    <div id="coc_edit_dock_page">
        <div class="main_row row">
            <div class="col-sm-12">
                <form id="Form1" runat="server">
                    <h3>
                        <asp:Button runat="server" OnClick="btnCancel_Click" Text="Back" CssClass="btn btn-default btn-info backToHome_button" />Edit
                        Dock</h3>
                    <div class="alert alert-success" role="alert"></div>
                    <div class="alert alert-danger" role="alert"></div>
                    <table class="table table-bordered dataTable">
                        <thead>
                            <tr>
                                <td>Dock Id</td>
                                <td style="width: 30%">Property</td>
                                <td style="width: 30%">Dock Name</td>
                                <td></td>
                            </tr>
                        </thead>
                        <tbody>
                            <%
                                foreach (var dock in Docks)
                                {
                            %>
                            <tr dockid="<%= dock.DockId %>">
                                <td>
                                    <p class="edit_p"><b><%= dock.DockId %></b></p>
                                </td>
                                <td>
                                    <select class="form-control propertiesList" disabled>
                                        <%
                                    foreach (var property in Properties)
                                    {
                                        if (property.AccountId == dock.AccountId)
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
                                    <input type="text" class="form-control dockName_input" value="<%= dock.DockName %>"
                                        disabled />
                                </td>
                                <td class="crud_td">
                                    <div class="row editOrDelete_row">
                                        <button type="button" class="btn btn-block btn-default edit_button">Edit</button>
                                        <button type="button" class="btn btn-danger delete_button">Delete</button>
                                    </div>
                                    <div class="row confirmDelete_row">
                                        <button type="button" class="btn btn-danger confirmDetele_button" dockid="<%= dock.DockId %>">
                                            Delete</button>
                                        <button type="button" class="btn btn-default cancel_button">
                                            Back</button>
                                    </div>
                                    <div class="row confirmSave_row">
                                        <button type="button" class="btn btn-success confirmSave_button" dockid="<%= dock.DockId %>">
                                            Save</button>
                                        <button type="button" class="btn btn-default cancel_button">Back</button>
                                    </div>
                                </td>
                            </tr>
                            <%
                                }
                            %>
                        </tbody>
                    </table>
                </form>
            </div>
        </div>
    </div>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="Coc_footer_script_holder" runat="server">
    <script type="text/javascript" charset="utf8" src="include/datatables/js/jquery.dataTables.min.js"></script>
    <script type="text/javascript" charset="utf8" src="include/datatables/js/dataTables.bootstrap.min.js"></script>
    <script type="text/javascript" src="js/coc_script.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            var table = $(".dataTable").DataTable({
                sScrollX: "100%",
                "autoWidth": false,
                columnDefs: [
                    { orderable: false, targets: [1,2,3] }
                ]
            });

            //delete
            $("body").on("click", ".confirmDetele_button", function (e) {
                e.preventDefault();
                var button = $(this);

                var jsonData =
                JSON.stringify({
                    dockId: button.attr("dockId")
                });

                $.ajax({
                    url: "EditDock.aspx/Delete",
                    data: jsonData,
                    contentType: "application/json",
                    success: function (data) {
                        var result = jQuery.parseJSON(data.d);

                        if (result.Success == true) {
                            $(".alert").hide();
                            $(".alert-success").html("Deleted dock.").slideDown();

                            button.parents("tr").remove();
                        } else {
                            $(".alert").hide();
                            $(".alert-danger").html("An error has occurred. Please make sure there is no bales connected to this dock.").slideDown();
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

                var newAccountId = parent.find(".propertiesList").val();
                var newName = parent.find(".dockName_input").val();

                if (/\S/.test(newName)) {
                    // string is not empty and not just whitespace

                    var jsonData =
                    JSON.stringify({
                        dockId: button.attr("dockId"),
                        accountId: newAccountId,
                        name: newName
                    });

                    $.ajax({
                        url: "EditDock.aspx/Save",
                        data: jsonData,
                        contentType: "application/json",
                        success: function (data) {
                            $(".alert").hide();
                            $(".alert-success").html("Dock updated.").slideDown();

                            //fake click the back button
                            parent.find(".cancel_button").click();
                        },
                        fail: (function () {
                            $(".alert").hide();
                            alert("An error has occurred. Please try again later.");
                        }),
                        type: "post",
                        dataType: "json"
                    });

                } else {
                    $(".alert").hide();
                    $(".alert-danger").html("Please enter a name.").slideDown();
                }
            });
        });
    </script>
</asp:Content>


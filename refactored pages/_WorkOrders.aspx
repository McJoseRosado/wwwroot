<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Main.Master" AutoEventWireup="true" CodeBehind="_WorkOrders.aspx.cs" Inherits="RenuOil._WorkOrders" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="include/bootstrap/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="include/css/coc_style.css" rel="stylesheet" type="text/css" />
    <link href="include/datepicker/css/bootstrap-datepicker3.standalone.min.css" rel="stylesheet"
        type="text/css" />

    <style>
        .selected {
            background-color: #D8D8D8;
            color: White;
        }

        .unselected {
            background-color: inherit;
        }

        .tab {
            font-size: 1em;
            padding: 5px 5px 5px 5px;
            margin: 6px 0;
            height: 70px;
            width: 120px;
            color: White;
            white-space: normal;
            border: 2px solid #D8D8D8;
            border-top-right-radius: 10px;
            border-top-left-radius: 10px;
        }

        .section {
            padding: 5px;
            border: 2px solid #D8D8D8;
            border-bottom-right-radius: 10px;
            border-bottom-left-radius: 10px;
        }

        body {
            background-color: #2888BF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="pageHeadingContent" runat="server">
    <img src="images/page-heading1.jpg" alt="" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainContent" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-sm-8">
                <h3>Work Orders</h3>
            </div>
            <div class="col-sm-4">
                <h3><a href="EditWorkOrder.aspx?id=0" runat="server" id="btnAddNewWorkOrder" class="btn btn-success right" style="color: white">ADD NEW WORK ORDER</a></h3>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <hr />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <select class="form-control" runat="server" id="accountSelect">
                </select>
            </div>
            <hr />

            <div class="col-sm-5">
                <input class="form-control datepicker" placeholder="" runat="server" id="startDate" />
            </div>
            <div class="col-sm-5">
                <input class="form-control datepicker" placeholder="" runat="server" id="endDate" />
            </div>
            <div class="col-sm-2">
                <button id="Button2" runat="server" class="btn btn-primary btn-block" onserverclick="OnSearchClick">
                    Update</button>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <hr />
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <div class="">
                    <ul id="workOrdersTab" class="nav nav-tabs" role="tablist">
                        <li class="active"><a href="#oil" role="tab" data-toggle="tab" aria-expanded="true">Oil Filtration</a></li>
                        <li class=""><a href="#recycling" role="tab" data-toggle="tab" aria-expanded="false">Recycling</a></li>
                        <li class=""><a href="#asset" role="tab" data-toggle="tab" aria-expanded="false">Asset</a></li>

                    </ul>
                    <div id="myTabContent" class="tab-content">
                        <div class="tab-pane fade active in" id="oil">
                            <table class="table table-bordered table-hover table-striped">
                                <thead>
                                    <tr>
                                        <td>Account</td>
                                        <td>Date</td>
                                        <td>Day of Week</td>
                                        <td></td>
                                    </tr>
                                </thead>
                                <%
                                
                                    foreach (var order in OilWorkOrders)
                                    {
                                %>
                                <tr>
                                    <td><%= order.Account.Name %></td>
                                    <td><%= order.AppointmentDate.ToShortDateString() %></td>
                                    <td><%= order.AppointmentDate.DayOfWeek %></td>
                                    <td>
                                        <button class="btn btn-info btn-block lnkBtnEditWorkOrderBtn" orderid="<%= order.WorkOrderId %>">Edit</button></td>
                                </tr>
                                <% }%>
                            </table>
                        </div>

                        <div class="tab-pane fade" id="recycling">
                            <table class="table table-bordered table-hover table-striped">
                                <thead>
                                    <tr>
                                        <td>Account</td>
                                        <td>Date</td>
                                        <td>Day of Week</td>
                                        <td></td>
                                        <td></td>
                                    </tr>
                                </thead>
                                <%
                                
                                    foreach (var order in RecyclingOrders)
                                    {
                                %>
                                <tr>
                                    <td><%= order.Account.Name %></td>
                                    <td><%= order.AppointmentDate.ToShortDateString() %></td>
                                    <td><%= order.AppointmentDate.DayOfWeek %></td>
                                    <td>
                                        <button class="btn btn-info btn-block lnkBtnEditWorkOrderBtn" orderid="<%= order.WorkOrderId %>">Edit</button></td>
                                    <td>
                                        <button class="btn btn-danger btn-block lnkBtnEditWorkOrderBtn" orderid="<%= order.WorkOrderId %>">Delete</button></td>
                                </tr>
                                <% }%>
                            </table>
                        </div>

                        <div class="tab-pane fade" id="asset">
                            <table class="table table-bordered table-hover table-striped">
                                <thead>
                                    <tr>
                                        <td>Account</td>
                                        <td>Date</td>
                                        <td>Day of Week</td>
                                        <td></td>
                                        <td></td>
                                    </tr>
                                </thead>
                                <%
                                
                                    foreach (var order in AssetOrders)
                                    {
                                %>
                                <tr>
                                    <td><%= order.Account.Name %></td>
                                    <td><%= order.AppointmentDate.ToShortDateString() %></td>
                                    <td><%= order.AppointmentDate.DayOfWeek %></td>
                                    <td>
                                        <button class="btn btn-info btn-block lnkBtnEditWorkOrderBtn" orderid="<%= order.WorkOrderId %>">Edit</button></td>
                                    <td>
                                        <button class="btn btn-danger btn-block lnkBtnEditWorkOrderBtn" orderid="<%= order.WorkOrderId %>">Delete</button></td>
                                </tr>
                                <% }%>
                            </table>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
    <hr />
</asp:Content>


<asp:Content ID="Content5" ContentPlaceHolderID="bottomContent" runat="server"></asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="sideBarContent" runat="server">
    <div class="sidebar nospace">
        <div class="sidebartop">
        </div>
        <div class="sidebarmain">
            <div class="sidebarcontent">
                <h4 class="sidebarheading">Work Orders</h4>
                <p>This is a list of work orders within the specified date range.</p>
                <div class="clear">
                </div>
                <%--                <a href="#" class="button-more">View All News</a>--%>
            </div>
        </div>
        <div class="sidebarbottom">
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="footerContent" runat="server">
    <script type="text/javascript" src="js/jquery.js"></script>
    <script type="text/javascript" src="include/bootstrap/js/bootstrap.min.js"></script>
    <script type="text/javascript" src="include/datepicker/js/bootstrap-datepicker.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {

            $('.datepicker').datepicker({
                todayHighlight: true,
                todayBtn: "linked",
                autoclose: true
            });

            $(".lnkBtnEditWorkOrderBtn").click(function (e) {
                e.preventDefault();

                var activeTabName = $("#workOrdersTab").find("li.active").text();

                var jsonData =
                JSON.stringify({
                    commandName: $(this).html(),
                    id: $(this).attr("orderId"),
                    activeTabName: activeTabName
                });

                $.ajax({
                    url: "WorkOrders.aspx/lnkBtnEditWorkOrderBtnCommand",
                    data: jsonData,
                    contentType: "application/json",
                    type: "post",
                    dataType: "json",
                    success: function (data) {
                        var result = jQuery.parseJSON(data.d);
                        if (result.Path != "") {
                            window.location.href = window.location.href.replace("WorkOrders.aspx", result.Path);
                        } else {
                            window.location.reload();
                        }
                    }
                })
            });


        });
    </script>

</asp:Content>

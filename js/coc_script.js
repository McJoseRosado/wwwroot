$.fn.exists = function () {
    return this.length !== 0;
}

function isNumeric(n) {
    return !isNaN(parseFloat(n)) && isFinite(n);
}

function isInt(n) {
    return Number(n) === n && n % 1 === 0;
}

function isFloat(n) {
    return Number(n) === n && n % 1 !== 0;
}

//Uncomment for fullscreen backdrop
////modal classes
//$(".modal-transparent").on('show.bs.modal', function () {
//    setTimeout(function () {
//        $(".modal-backdrop").addClass("modal-backdrop-transparent");
//    }, 0);
//});
//$(".modal-transparent").on('hidden.bs.modal', function () {
//    $(".modal-backdrop").addClass("modal-backdrop-transparent");
//});

//$(".modal-fullscreen").on('show.bs.modal', function () {
//    setTimeout(function () {
//        $(".modal-backdrop").addClass("modal-backdrop-fullscreen");
//    }, 0);
//});
//$(".modal-fullscreen").on('hidden.bs.modal', function () {
//    $(".modal-backdrop").addClass("modal-backdrop-fullscreen");
//});

$(document).ready(function () {
    //basic workflow
    $(".edit_button").click(function (e) {
        e.preventDefault();
        var tr = $(this).parents("tr");
        var editOrDelete = tr.find(".editOrDelete_row");
        editOrDelete.hide();

        var confirmDelete = tr.find(".confirmDelete_row");
        confirmDelete.hide();

        var confirmSave = tr.find(".confirmSave_row");
        confirmSave.show();

        //enable inputs
        $(this).parents("tr").find(".form-control").attr("disabled", false);
    });

    $(".delete_button").click(function (e) {
        e.preventDefault();
        var tr = $(this).parents("tr");
        var editOrDelete = tr.find(".editOrDelete_row");
        editOrDelete.hide();

        var confirmDelete = tr.find(".confirmDelete_row");
        confirmDelete.show();

        var confirmSave = tr.find(".confirmSave_row");
        confirmSave.hide();
    });

    $(".cancel_button").click(function (e) {
        e.preventDefault();
        var tr = $(this).parents("tr");
        var editOrDelete = tr.find(".editOrDelete_row");
        editOrDelete.show();

        var confirmDelete = tr.find(".confirmDelete_row");
        confirmDelete.hide();

        var confirmSave = tr.find(".confirmSave_row");
        confirmSave.hide();

        //disable inputs
        $(this).parents("tr").find(".form-control").attr("disabled", true);
    });

    ///////////property / dock


    //first check dock list
    $(".docksList").each(function (index, value) {
        if ($(this).val() == "-1") {
            $(this).attr("disabled", true);
        }
    });

    //pull dock list after the property is selcted
    $(".propertiesList").change(function (e) {
        var self = $(this);
        var docksList = self.parents("tr").find(".docksList");

        //New Bale -> it doesn't have "tr", only inputs
        if(!docksList.exists()){
            docksList = self.parents("form").find(".docksList");
        }

        if (self.val() != "-1") {

            //grab docks from this property
            var jsonData = JSON.stringify(
           {
               propertyId: self.val()
           });

            $.ajax({
                url: "NewBale.aspx/GetDocksList", //doesn't matter where, we just need a list of docks in this property
                data: jsonData,
                contentType: "application/json",
                success: function (data) {
                    var result = jQuery.parseJSON(data.d);

                    docksList.html("");

                    if (result.docks.length > 0) {

                        $.each(result.docks, function (index, dock) {
                            docksList.append("<option value=" + dock.DockId + ">" + dock.DockName + "</option>");
                        });

                        docksList.attr("disabled", false);

                    } else {
                        //no docks found
                        docksList.append("<option value='-1'>No dock found</option>");
                        docksList.attr("disabled", true);
                    }
                },
                type: "post",
                dataType: "json"
            });
        } else {
            docksList.attr("disabled", true);
            docksList.val("-1");
        }

    });
});
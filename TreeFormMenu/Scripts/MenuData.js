$(function () {
    $.ajax({
        url: '/Home/Country',
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            $("#Country").empty();
            var v = "<option>---Select---</option>";
            for (var i = 0; i < result.data.length; i++) {
                v += "<option value=" + result.data[i].Value + ">" + result.data[i].Text + "</option>";
            }
            $("#Country").html(v);
        }

    });
})

$(document).ready(function () {
    $("#Country").change(function () {
        var id = $(this).val();
        $("#state").empty();
        $.get("../Home/State",
            { country_id: id },
            function (data) {
            var v = "<option>---Select---</option>";
            $.each(data, function (i, v1) {
                v += "<option value=" + v1.Value + ">" + v1.Text + "</option>";
            });
            $("#state").html(v);
        });
    });

    $("#state").change(function () {
        var id = $(this).val();
        $("#city").empty();
        $.get("City_Bind",{ state_id: id }, function (data) {
            var v = "<option>---Select---</option>";
            $.each(data, function (i, v1) {
                v += "<option value=" + v1.Value + ">" + v1.Text + "</option>";
            });
            $("#city").html(v);
        });
    });
});;
          
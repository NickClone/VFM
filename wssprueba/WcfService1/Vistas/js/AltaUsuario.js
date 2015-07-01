$(document).ready(function () {


    var edi = new Object();
    edi.cod_edif = 1;

    $("#btn").click(function () {

        $.ajax({
            url: 'http://localhost:1066/services/service1.svc/GetHabitList',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            type: 'POST',
            dataType: 'JSON',
            data: JSON.stringify(edi),
            async: false
        }).done(function (data) {

            alert("ID de nuevo Edificio es: " +
           "\n" + data);
        });

    })


});

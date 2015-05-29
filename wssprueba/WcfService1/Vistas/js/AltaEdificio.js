$(document).ready(function () {
    $("#edif_btn").click(function () {

        insert(
        $("#edif_nombre").val(),
        $("#edif_calle").val(),
        $("#edif_num").val(),
        $("#edif_cp").val(),
        $("#edif_loc").val(),
        $("#edif_prov").val(),
        $("#edif_country").val() 
        );

    });
});

function insert(nombre, calle, num, cp, loc, prov, country) {
    var edi = new Object();
    edi.edif_nombre = nombre;
    edi.edif_calle = calle;
    edi.edif_num = num;
    edi.edif_cp = cp;
    edi.edif_loc = loc;
    edi.edif_prov = prov;
    edi.edif_country = country;
    $.ajax({
        url: 'http://localhost:1066/services/service1.svc/AltaEdificio',
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
           "\n"+data);
    });

}
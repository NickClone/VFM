$(document).ready(function () {
    $("#but").click(function () {
        login($("#name").val(), $("#pwd").val());
    });
});


function login(usr, pass) {
    if (usr != '' && pass != '') {
        var log = new Object();
        log.Account = usr;
        log.Password = pass;
        $.ajax({
            url: 'http://localhost:1066/services/service1.svc/getdata',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            type: 'POST',
            dataType: 'JSON',
            data: JSON.stringify(log),
            async: false
        }).done(function (data) {

            console.log(data);
            append(data);
            getMenuOpt();
        });

    }
    else {
        alert("hay campos en blanco");
    }

}
function append(data) {
    if (data != null) {
        $('body').css('background-image', 'none');
        $("body").empty();
        $("body").append(data.campo);
    }

}

function getMenuOpt() {
    $(".menuvar ul li a").click(function () {
        console.log($(this).attr('id'));
        if ($(this).attr('id') != 'drop') {
            getform('laldsa');
        }
    });

}

function getform(idform) {
    var log = new Object();
    $.ajax({
        url: 'http://localhost:1066/services/service1.svc/formres',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        type: 'POST',
        dataType: 'JSON',
        data: JSON.stringify(log),
        async: false
    }).done(function (data) {
        $("#forminy").empty();
        $("#forminy").append(data.campo);
        console.log(data);

        Resident();

    });

}

function Resident(e) {

    e.preventdefault();
    $("#crearUsr").click(function () {

        insert(
        $("#nomUsr").val(),
        $("#apeUsr").val(),
        $("#mailusr").val(),
        $("#PassUsr").val(),
        $("#telUsr").val(),
        $("#fnUsr").val(),
        $("#sexUsr").val()
        );

    });

}

function insert(nombre, apellido, account, password, tel, Fnac, Sexo) {
    var usr = new Object();
    //usr.id = id;

    usr.Nombre = nombre;
    usr.Apellido = apellido;
    usr.Account = account;
    usr.Password = password;
    usr.Tel = tel;
    usr.Sexo = Sexo;
    usr.Id_edif = 1;
    usr.rol = 2;
    usr.Piso = "2";
    usr.Dpto = "B";

    usr.FechaNacimiento = Fnac;
    //usr.FechaRegistracion = Freg;
    //usr.FechaActualizacion = Fact;
    //usr.Estado = estado;
    $.ajax({
        url: 'http://localhost:1066/services/service1.svc/insHab',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        type: 'POST',
        dataType: 'JSON',
        data: JSON.stringify(usr),
        async: false
    }).done(function (data) {

        alert("ID de nuevo usuario es: ");
        alert(data);


    });


}
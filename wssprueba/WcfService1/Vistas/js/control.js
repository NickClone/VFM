$(document).ready(function () {
   var optmenu;
    $("#but").click(function () {
        login($("#name").val(), $("#pwd").val());
    });


});
function insertedif(nombre, calle, num, cp, cantpisos, deptosxpiso, tienepb, deptoletra, loc, prov, country) {
    var edi = new Object();
    console.log(nombre, calle, num, cp, cantpisos, deptosxpiso, tienepb, deptoletra, loc, prov, country);

    edi.edif_nombre = nombre;
    edi.edif_calle = calle;
    edi.edif_num = num;
    edi.edif_cp = cp;
    edi.edif_cantpisos = cantpisos;
    edi.edif_deptosxpiso = deptosxpiso;
    edi.edif_tienepb = tienepb;
    edi.edif_deptoletra = deptoletra;
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
           "\n" + data);
    });

}

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
            
            if (data.campo !== null) {
                console.log(data);
                append(data);
                getMenuOpt();
                loadEvents();
            }
            else {
                alert(data.error);
            }
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
            getform($(this).attr('id'));
        }
    });

}

function getform(idform) {
    var log = new Object();
    log.IdRequestor = $("#mhdnId").val();
    log.FormTipo = getTipo(idform);
    log.data = '';

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
        loadEvents();
        console.log(data);
    });
}

function Resident(e) {
    $("#crearUsr").click(function () {
        insert( $("#nomUsr").val(), $("#apeUsr").val(), $("#mailusr").val(), $("#PassUsr").val(), $("#telUsr").val(),$("#fnUsr").val(),$("#sexUsr").val());
    });

}
function insertUsr(nombre, apellido, account, password, tel, Fnac, Sexo) {
    var usr = new Object();
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
function loadEvents() {
    $("#crearUsr").click(function () {

        insertUsr(
        $("#box_nombre").val(),
        $("#box_apellido").val(),
        $("#box_account").val(),
        $("#box_password").val(),
        $("#box_telefono").val(),
        $("#box_FecNac").val(),
        $("#box_sexo").val()
        );

    });
    $("#edif_btn").click(function () {
        insertedif(
        $("#edif_nombre").val(),
        $("#edif_calle").val(),
        $("#edif_num").val(),
        $("#edif_cp").val(),
        $("#edif_cantpisos").val(),
        $("#edif_deptosxpiso").val(),
        $("edif_TienePB").val(),
        $("edif_DeptoLetra").val(),
        $("#edif_loc").val(),
        $("#edif_prov").val(),
        $("#edif_country").val()
        );

    });

    $("#File1").fileinput();
    $("#File1").change(function () {
        console.log("entreFILE");
        readImage(this);

    });
    $("#Submit1").click(function () {
     //   readImage($("#File1"));
        console.log($('#hide').val());
  

    });
}

function insertUser(nombre, apellido, account, password, tel, Fnac, Sexo) {
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
function readImage(input) {
    if (input.files && input.files[0]) {
        var FR = new FileReader();
        FR.onload = function (e) {
            // $('#img').attr("src", e.target.result);
            $('#hide').val(e.target.result);
            console.log(e.target.result);
        };
        FR.readAsDataURL(input.files[0]);
    }
}
function getTipo(idform) {
var ret;
    switch (idform) {
        case 'cargaexp':
            ret =1;
        break;
        case 'altaUsr':
            ret =2;
        break;
    }

    return ret;

}
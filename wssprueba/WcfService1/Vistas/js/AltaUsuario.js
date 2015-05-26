$(document).ready(function () {
    $("#btn").click(function () {

        insert($("#id").val(), $("#box_nombre").val(), $("#box_apellido").val(), $("#box_account").val(), $("#box_password").val(), $("#box_telefono").val(), $("#box_FecNac").val(), $("#box_FecReg").val(), $("#box_sexo").val(), $("#box_FecAct").val(), $("#box_Status").val());

    });
});

function insert(id, nombre, apellido, account, password, tel, Fnac, Freg, Sexo, Fact, estado) {

    var usr = new Object();
    usr.id = id;
    usr.Nombre = nombre;
    usr.Apellido = apellido;
    usr.Account = account;
    usr.Password = password;
    usr.Tel = tel;
    usr.FechaNacimiento = Fnac;
    usr.Sexo = Sexo;
    usr.FechaRegistracion = Freg;
    usr.FechaActualizacion = Fact;
    usr.Estado = estado;
    $.ajax({
        url: 'http://localhost:1066/services/service1.svc/insUsr',
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
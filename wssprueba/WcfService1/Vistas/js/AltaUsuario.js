$(document).ready(function () {
    $("#btn").click(function () {

        insert(
        $("#box_nombre").val(),
        $("#box_apellido").val(),
        $("#box_account").val(),
        $("#box_password").val(), 
        $("#box_telefono").val(),
        $("#box_FecNac").val(),
        $("#box_sexo").val() 
        );

    });
});

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
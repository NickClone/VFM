$(document).ready(function () {
    alert("entro");
   $("#btn").click(function () {


       insert($("#id").val(), $("#box_nombre").val(), $("#box_apellido").val(), $("#box_account").val(), $("#box_password").val(), 
       $("#box_telefono").val(), $("#box_FecNac").val(), $("#box_FecReg").val(), $("box_sexo").val(), $("#FecAct").val(), $("#box_Status").val());
       
    });
});

function insert(id,nombre,apellido,account,password,tel,Fnac,Freg,Sexo,Fact,estado){
   
        var usr=new Object();
        usr.id = id;
        usr.Nombre = nombre;
        usr.Apellido = apellido;
        usr.account = account;
        usr.Password = Password;
        usr.Tel = tel;
        usr.FechaNacimiento = Fnac;
        usr.Sexo = Sexo;
        usr.FechaRegistracion = Freg;
        usr.FechaActualizacion = Fact;
        usr.Estado = Estado;
       // log.fac='edificio1';
            $.ajax({
                url: 'http://localhost:1066/services/service1.svc/insUsr',               //  asda 'http://localhost:1066/Service1.svc/GetData',
                headers:{
                'Accept': 'application/json',
                'Content-Type': 'application/json'
                },
                type: 'POST',
                dataType: 'JSON',
                data: JSON.stringify(usr),
                async: false
            }).done(function (data) {
              
              
               alert(data)
               // redirect(data);
               
            });
        
    }
 
    

function redirect(data){
 if(data != null){
   window.location =data.url;   
 }
    
}

//
//
//function funcion() {
//    var per = new Object();
//    per.id = 32;
//    per.name = 'Nicolito';
//    per.app = 'calvo';
//    var det = 'alala';
//    $.ajax({
//        url: 'http://localhost:1066/Expensas.svc/GetExp',               //  asda 'http://localhost:1066/Service1.svc/GetData',
//        headers:{
//        'Accept': 'application/json',
//        'Content-Type': 'application/json'
//        },
//        type: 'POST',
//        dataType: 'JSON',
//        data: JSON.stringify(per),
//        async: false
//    }).done(function (data) {
//        alert(data.name);
//    });
//    //alert(ret);
//}
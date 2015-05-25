$(document).ready(function () {

alert("entro");
   $("#btn").click(function () {


       insert($("#id").val(), $("#text1").val(), $("#text2").val(), $("#text3").val(), $("#text4").val(), $("#text5").val(), $("#text6").val(), $("#text7").val(), $("#text8").val(), $("#text9").val(), $("#text10").val());
       

    });
});

function insert(id,nombre,apellido,account,password,tel,Fnac,Sexo,Freg,Fact,estado){
   
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
$(document).ready(function () {
    $("#but").click(function () {
        login($("#name").val(), $("#pwd").val());
    });
});


function login(usr,pass){
    if(usr  != '' &&  pass  != '') {
        var log=new Object();
        log.usr = usr;
        log.pass=pass;
       // log.fac='edificio1';
        $.ajax({
            url: 'http://localhost:1066/services/service1.svc/GetData',               //  asda 'http://localhost:1066/Service1.svc/GetData',
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
            alert(data);
            // redirect(data);

        });
        
    }
    else {
     alert("hay campos en blanco");   
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
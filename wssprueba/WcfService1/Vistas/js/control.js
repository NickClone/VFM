$(document).ready(function () {
//    $('#modal').modal({
//        keyboard: false,
//        show: true
//    });
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
              //  loadEvents();
          
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
     //   $("body").append("<div id='modal' class='modal fade' tabindex='-1' role='dialog'><div class='modal-dialog'><div class='modal-content'><div class='modal-header'><button type='button' class='close' data-dismiss='modal' aria-hidden='true'>X</button><h3 id='myModalLabel'>Busqueda Reparacion</h3></div><div class='modal-body' id ='bod'><div id='detsearch'></div></div></div></div></div>");
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
    if (log.FormTipo > 0) {
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
            btnlistener();
            console.log(data);
        });
    }
    else {
        $("#forminy").empty();
        //$('#forminy').prepend('<img id="theImg" src="http://www.bpj-bd.com/images/Website-Under-Construction-template1.jpg"  height="100%" width="70%"/>')
        
    }
}

function Resident(e) {
    $("#crearUsr").click(function () {
        insert( $("#nomUsr").val(), $("#apeUsr").val(), $("#mailusr").val(), $("#PassUsr").val(), $("#telUsr").val(),$("#fnUsr").val(),$("#sexUsr").val());
    });

}
function insertUsr(nombre, apellido, account, password, tel, Fnac, Sexo, id, perfil, piso,dtpo) {
  
    
    var usr = new Object();
    usr.id = id;
    usr.Nombre = nombre;
    usr.Apellido = apellido;
    usr.Account = account;
    usr.Password = password;
    usr.Tel = tel;
    usr.Sexo = Sexo;
    usr.Id_edif = 1;
    usr.rol = null;
    usr.Piso = piso;
    usr.Dpto = dtpo;
    usr.FechaNacimiento = Fnac;
    usr.Perfil = perfil;
    //usr.FechaRegistracion = Freg;
    //usr.FechaActualizacion = Fact;
    //usr.Estado = estado;
    console.log("objeto user:"+usr);
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
    /*  usr.Id_edif = 1;
    usr.rol = 2;
    usr.Piso = "2";
    usr.Dpto = "B";
    */
    $("#crearUsr").click(function () {
        insertUsr(
        $("#nomUsr").val(),
        $("#apeUsr").val(),
        $("#mailusr").val(),
        $("#PassUsr").val(),
        $("#telUsr").val(),
        $("#fnUsr").val(),
        $('#sexo input[type=radio]:checked').val(),
        $("#idUsr").val(),
        1, 
        $("#pisUsr").val(),
        $("#depUsr").val()
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
        case 'edificio':
            ret = 3;
            break;
        default:
            ret = -1;
     
    }

    return ret;

}


function btnlistener() {
    $('#usralta').click(function () {
       $('#modal').modal({
         show: false
    });
        
    })
    $("#usrbaja").click(function () {
       setModalBaja();
    });
    $("#usrmod").click(function () {
         setModalMod();
         
    });
}


 function setModalMod() {
    $("#modalTitle").text("Modificacion Residentes");
    $("#bod").empty();
    var obj = new Object();
    obj = getListHabit();
    var tbl='';
     console.log(obj);
    $.each(obj, function(key,value){
          tbl += '<tr><td>'+value.Nombre+'</td><td>'+ value.Apellido+'</td><td>'+value.FechaNacimiento+'</td><td>'+ value.Piso + value.Dpto+'</td></tr>';
    });
     
   $("#bod").append( ' <table class="table table-striped" id= "tabla"> <thead> <tr> <th>Nombre</th> <th>Apellido</th> <th>Fec Nac</th><th>Depto</th> </tr> </thead> <tbody> '+tbl +' </tbody> </table> ');
    $('#modal').modal({
        keyboard: false,
        show: true
    });
    var tableData;
    $("#tabla  tr").click(function() {
        tableData = $(this).children("td").map(function() {
        return $(this).text();
    }).get();
        $.each(obj, function(key,value){
        //alert(value.Nombre + ' '+  $.trim(tableData[0]));
            if ( value.Apellido == $.trim(tableData[1]) && (value.Piso + value.Dpto) ==  $.trim(tableData[3]) ){
               // funcion llenar dom formulario
            }
        });
    }); 
          //alert("Your data is: " + $.trim(tableData[0]) + " , " + $.trim(tableData[1]) + " , " + $.trim(tableData[2]));
         
 
   // $('#tabla  tr ').click(function() {
       // alert($(this).find(".Email").html());   
        //alert($(this).text());
//        $.each(obj, function(key,value){
//            if (value.Nombre = $(this).nombre;
//        }); 
        
    //});
     
     

}

function setModalBaja() {
    
    alert('dar de baja?');
    /*
    $("#modalTitle").text("Baja Residentes");
    $('.modal-dialog').css('width', 700);
    $("#bod").empty();
    $("#bod").append('<form class="form-horizontal"><fieldset><div class="form-group"><label class="col-md-4 control-label" for="usrmail">Email</label><div class="col-md-4"><input id="usrDNI" name="usrDNI" placeholder="sin puntos" class="form-control input-md" required="" type="text"></div></div><div class="form-group"><label class="col-md-4 control-label" for="usrDepto">Depto</label><div class="col-md-2"><input id="usrDepto" name="usrDepto" placeholder="" class="form-control input-md" required="" type="text"><span class="help-block">Piso-Depto</span></div></div><div class="form-group"><label class="col-md-4 control-label" for="BajaUsr"></label><div class="col-md-4"><button id="BajaUsr" name="BajaUsr" class="btn btn-primary">Eliminiar</button></div></div></fieldset></form>');
    $('#modal').modal({
        keyboard: false,
        show: true
    });

*/
}


function getListHabit() {
    var ret = new Object();
    var edi = new Object();
    edi.cod_edif = 1;
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
       ret = data;
    });
return ret;
}
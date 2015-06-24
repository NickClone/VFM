$(document).ready(function () {

    $("#File1").fileinput();
    $("#File1").change(function () {
        readImage(this);

    });
    $("#Submit1").click(function () {
     //   readImage($("#File1"));
        console.log($('#hide').val());
  

    });
});





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

/*
function upload() {
    
    var FR= new FileReader();
    FR.onload = function(e) {
             $('#img').attr( "src", e.target.result );
             $('#base').text( e.target.result );
        };       
        FR.readAsDataURL( input.files[0] );
    }

    fileName = document.getElementById("File1").files[0].name;
    fileSize = document.getElementById("File1").files[0].size;
    fileType = document.getElementById("File1").files[0].type;
    stream = document.getElementById("File1").files[0];
    var data = new FormData();

    
    data.append('stream', document.getElementById("File1").files[0])


    console.log(stream);

//    edi.edif_calle = calle;
//    edi.edif_num = num;
//    edi.edif_cp = cp;
//    edi.edif_loc = loc;
//    edi.edif_prov = prov;
//    edi.edif_country = country;

    $.ajax({
        url: 'http://localhost:1066/services/FileManagerService.svc/UploadFile',
        data: data,
        cache: false,
        contentType: false,
        processData: false,
        type: 'POST',
    }).done(function (data) {

        alert("ID de nuevo Edificio es: " +
           "\n"+data);
    });

}

*/
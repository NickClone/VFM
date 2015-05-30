$(document).ready(function () {


    $("#Submit1").click(function () {
        alert("funciona")
    upload();

    });
});

function upload() {
    
    
    fileName = document.getElementById("File1").files[0].name;
    fileSize = document.getElementById("File1").files[0].size;
    fileType = document.getElementById("File1").files[0].type;
    stream = document.getElementById("File1").files[0];

//    edi.edif_calle = calle;
//    edi.edif_num = num;
//    edi.edif_cp = cp;
//    edi.edif_loc = loc;
//    edi.edif_prov = prov;
//    edi.edif_country = country;

    $.ajax({
        url: 'http://localhost:1066/services/FileManagerService.svc/UploadFile',
        headers: {
            'Accept': 'application/json',
            'Content-Type': "application/octet-stream" 
        },
        type: 'POST',
        data: JSON.stringify(stream),
        async: false
    }).done(function (data) {

        alert("ID de nuevo Edificio es: " +
           "\n"+data);
    });

}
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
    var data = new FormData();

    alert(data)
    data.append('stream', document.getElementById("File1").files[0])


    console.info(data);

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
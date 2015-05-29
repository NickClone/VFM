$(document).ready(function () {
    $("#but").click(function () {
        login($("#name").val(), $("#pwd").val());
    });
});


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

            console.log(data);
            append(data);
            getMenuOpt();
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

function getForm(idform) {
    var log = new Object();
    log.Account = usr;
    log.Password = pass;
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
        $("#forminy").append(data);
        console.log(data);

    });
    
}
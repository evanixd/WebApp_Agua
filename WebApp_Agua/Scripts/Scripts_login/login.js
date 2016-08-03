$(document).ready(function () {
    $(".user").focusin(function () {
        $(".inputUserIcon").css("color", "#e74c3c");
    }).focusout(function () {
        $(".inputUserIcon").css("color", "white");
    });

    $(".pass").focusin(function () {
        $(".inputPassIcon").css("color", "#e74c3c");
    }).focusout(function () {
        $(".inputPassIcon").css("color", "white");
    });
})

function ValidarFormulario() {
    var user = $("#user").val();
    var pass = $("#pass").val();
    if (user === '' || pass === '') {
        alert("Usuario y Contraseña son Obligatorios");
    }
}
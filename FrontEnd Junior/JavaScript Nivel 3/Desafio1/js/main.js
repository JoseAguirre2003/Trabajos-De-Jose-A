"use strcit"

let puntos = 0;

$(document).ready(()=>{
    $("#punts").text(`${puntos}`);
});

$(".imagen").click(function(){

    puntos++
    $("#punts").text(`${puntos}`);
    $(".imagen").removeClass("imgSelecc");
    $(this).addClass("imgSelecc");
    $("#muestra").attr('style', "display: block;");
    $("#muestra").attr('src', $(this).attr('src'));
    $("#titulo").text($(this).attr('title'));
    $("#historial").append(`<li>${$(this).attr('title')}</li>`);
    
});

$("#btn").click(()=>{

    puntos = 0;
    $("#punts").text(`${puntos}`);
    $("#historial").empty();
    $("#titulo").text("");
    $("#muestra").attr('src', "");
    $("#muestra").attr('style', "display: none;");
    $(".imagen").removeClass("imgSelecc");

})
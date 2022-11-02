"use strcit"

let puntos = 0;
let cartas = [];

$(document).ready(()=>{
    $("#punts").text(`${puntos}`);
    $("tr").slideDown(700);
    $(".imagen").slideDown(700);
});

$(".imagen").click(function(){

    $("#historial").empty()

    puntos++
    $("#punts").text(`${puntos}`);
    $(".imagen").removeClass("imgSelecc");
    $(this).addClass("imgSelecc");
    $("#muestra").attr('src', $(this).attr('src'));
    $("#muestra").fadeIn("slow");
    $("#titulo").text($(this).attr('title'));
    $(this).fadeOut("fast").fadeIn("fast");

    for (let i = 0; i < 8; i++){

        if(cartas[i].titulo == $(this).attr('title'))
            cartas[i].contador++;

    }

    for (let i = 0; i < 8; i++) {
        
        $("#historial").append(`<li>${cartas[i].titulo} - <span>${cartas[i].contador}</span></li>`);

    }
    
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

//Funcion contructora

function imagen(title){ 

    this.titulo = title;
    this.contador = 0;

}

let img = $(".imagen");

let cart;

for (let i = 0; i < img.length; i++) {

    cart = new imagen(img[i].title)

    if(!existe(cart.titulo))
        cartas.push(cart);
    
}

function existe(propiedad){

    for (let i = 0; i < cartas.length; i++)

        if (cartas[i].titulo == propiedad)
            return true;

    return false;
    
}
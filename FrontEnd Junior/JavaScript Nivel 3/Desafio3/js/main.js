"use strcit"

let puntos = 0;
let cartas = [];

$(document).ready(()=>{
    $("#punts").text(`${puntos}`);
    $("tr").slideDown(700);
    $(".imagen").slideDown(700);
    $(".imagen").removeAttr("src");
    $(".imagen").attr("src", "./img/back.png");

    try{
        console.log(JSON.parse(Cookies.get("cartas")));
    }catch(e){
        console.error("NO SE PUDO LEER LA COOKIE");
    }
});

//Funcion contructora

function imagen(title){ 

    this.titulo = title;
    this.contador = 0;

}

let img = $(".imagen");

let cart;

//Arreglado lo de que se creaban objetos de mas

for (let i = 0; i < img.length; i++) {

    if(!existe(img[i].title)){
        cart = new imagen(img[i].title);
        cartas.push(cart);
    }

}

function existe(propiedad){

    for (let i = 0; i < cartas.length; i++)

        if (cartas[i].titulo == propiedad)
            return true;

    return false;
    
}

$(".imagen").click(function(){

    $("#historial").empty();
    $(".imagen").removeClass("imgSelecc");
    $(this).addClass("imgSelecc");

    if($(this).attr("src") == "./img/back.png"){

        $(this).attr("src", `./img/${$(this).attr("title")}.jpg`);

        puntos++
        $("#punts").text(`${puntos}`);

        for (let i = 0; i < 8; i++){

            if(cartas[i].titulo == $(this).attr('title'))
                cartas[i].contador++;
    
        }

        Cookies.set("cartas",JSON.stringify(cartas), {expires:2, path: ''});

    }else
        $(this).attr("src", "./img/back.png");

    $(this).fadeOut("fast").fadeIn("fast");

    for (let i = 0; i < 8; i++)
        $("#historial").append(`<li>${cartas[i].titulo} - <span>${cartas[i].contador}</span></li>`);

});

$("#btn").click(()=>{

    puntos = 0;
    $("#punts").text(`${puntos}`);
    $("#historial").empty();
    $("#titulo").text("");
    $(".imagen").removeClass("imgSelecc");
    $(".imagen").attr("src", "./img/back.png");

    for (let i = 0; i < 8; i++)
            cartas[i].contador = 0;

    Cookies.set("cartas",JSON.stringify(cartas), {expires:2, path: ''});
    
})
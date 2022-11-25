"use strcit"

let puntos = 0;
let cartas = [];
let contCartasPar = 0
let tiempo = 0;
let empieza = false;

class imagen {
    constructor(title) {

        this.titulo = title;
        this.contador = 0;

    }
}

let img = $(".imagen");

let cart;

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

function ordenamientoAleatorio(){

    let cartasAOrdenar = cartas.concat(cartas);
    cartasAOrdenar = cartasAOrdenar.sort(()=> Math.random() - 0.5);

    for (let i = 0; i < img.length; i++)
        img[i].title = cartasAOrdenar[i].titulo;

}


$(document).ready(()=>{

    $("#punts").text(`${puntos}`);
    $("tr").slideDown(700);
    $(".imagen").slideDown(700);
    $(".imagen").removeAttr("src");
    $(".imagen").attr("src", "./img/back.png");
    
    if(localStorage.getItem("mejorTiempo") != null){ 
        $("#recordActual").text(`El record es de ${Math.floor(localStorage.getItem("mejorTiempo"))} segundos`);
        $("#recordActual").fadeIn("fast");
    }

    ordenamientoAleatorio();

});

let carteaLevantada;

$(".imagen").click(function(){  

    if(empieza){

        $("#historial").empty();

        if($(this).attr("src") == "./img/back.png"){
    
            $(this).fadeOut("fast").fadeIn("fast");
    
            $(this).attr("src", `./img/${$(this).attr("title")}.jpg`);
    
            for (let i = 0; i < 8; i++){
    
                if(cartas[i].titulo == $(this).attr('title'))
                    cartas[i].contador++;
        
            }
    
            if(carteaLevantada == undefined){
    
                carteaLevantada = $(this).attr('title'); 
                $(this).addClass("imgSelecc"); 
    
            }else if(carteaLevantada == $(this).attr('title')){ 
    
                $("#coincide").text("Las cartas son iguales!!");
                $("#coincideDIV").removeClass("bg-danger");
                $("#coincideDIV").addClass("bg-success");
                puntos++;
                contCartasPar++;
                $("#punts").text(`${puntos}`);
                $(".imgSelecc").removeClass("imagen");
                $(".imgSelecc").removeClass("imgSelecc");
                $(this).removeClass("imagen");
                carteaLevantada = undefined;
    
                verficarSiGano();
    
            } else if(carteaLevantada != $(this).attr('title')){
    
                $(".imgSelecc").fadeOut("fast",()=> {
                    $(".imgSelecc").attr("src", "./img/back.png");
                    $(".imgSelecc").fadeIn("fast");
                    $(".imagen").removeClass("imgSelecc");
                });
                
                $(this).fadeOut("fast",()=> {
                    $(this).attr("src", "./img/back.png");
                    $(this).fadeIn("fast");
                });
    
                $("#coincide").text("Las cartas no son iguales");
                $("#coincideDIV").removeClass("bg-danger");
                $("#coincideDIV").addClass("bg-danger");
                carteaLevantada = undefined;
    
            }
    
        }

        for (let i = 0; i < 8; i++)
            $("#historial").append(`<li>${cartas[i].titulo} - <span>${cartas[i].contador}</span></li>`);

    }else
        $("#coincide").text("Debe hacer click en Iniciar partida");

});

let time;

function activarTemporizador(){

    let fecha = new Date;

    time = setInterval(()=>{
        
        let actual = new Date;
        tiempo = (actual - fecha)/1000;

        $("#tiempo").text(`${(Math.floor(tiempo))} seg`);        

    },1000)
}

$("#btn").click(()=>{

    if(time == undefined){
        
        empieza = true;
        activarTemporizador();
        $("#btn").text("Reiniciar Partida");
        $("#tiempo").text("0 seg");
        ordenamientoAleatorio();
        $("img").addClass("imagen");
        $("img").attr("src", "./img/back.png")
        $("#nuevoRecord").fadeOut("fast")

        $("#coincide").fadeIn("slow");
        $("#coincideDIV").fadeIn("slow");
        
    }else{

        $("#nuevoRecord").fadeOut("fast")
        $("#tiempo").text("0 seg");
        clearInterval(time);
        activarTemporizador();
        ordenamientoAleatorio();
        $("#coincide").text("Las cartas son...");
        $("img").addClass("imagen");
        $("img").attr("src", "./img/back.png")
        puntos = 0;
        $("#punts").text(`${puntos}`);
        $("#historial").empty();
        $(".imagen").removeClass("imgSelecc");

        for (let i = 0; i < 8; i++)
            cartas[i].contador = 0;

    }
    
})

function verficarSiGano(){

    if(contCartasPar == 8){

        clearInterval(time);
        time = undefined;
        empieza = false

        $("#coincide").text("Encontraste todas las cartas!! Ganaste!! :D");
        $("#coincideDIV").removeClass("bg-danger");
        $("#coincideDIV").addClass("bg-success");

        contCartasPar = 0

        $("#btn").text("Iniciar Partida");

        if(localStorage.getItem("mejorTiempo") == null){
            localStorage.setItem("mejorTiempo", tiempo);
            $("#recordActual").text(`El record es de ${Math.floor(localStorage.getItem("mejorTiempo"))} segundos`);
            $("#recordActual").fadeIn("fast");
            $("#nuevoRecord").fadeIn("fast");
        }else if(tiempo < localStorage.getItem("mejorTiempo")){
            localStorage.setItem("mejorTiempo", tiempo);
            $("#recordActual").text(`El record es de ${Math.floor(localStorage.getItem("mejorTiempo"))} segundos`);
            $("#recordActual").fadeIn("fast");
            $("#nuevoRecord").fadeIn("fast");
        }

    }

}
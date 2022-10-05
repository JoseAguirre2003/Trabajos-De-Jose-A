"use strict"

let colores = ["yellow", "blue", "red", "green", "purple", 
    "orange", "brown", "pink", "grey", "black"];

let url = ["https://www.youtube.com/", "https://github.com/", "https://cadif1.com/", 
"https://twitter.com/home?lang=es", "https://fonts.google.com/knowledge"];


function infoUser() {

    if (navigator.language == "es-ES") 
        alert(`El idoma del navegador es es Español(${navigator.language}) y el sistema operativo es ${navigator.platform}`);
        else if (navigator.language == "en-EN")
            alert(`The language of the browser is English(${navigator.language}) and the operating system is ${navigator.platform}`);
        else if (navigator.language == "fr-FR")
            alert(`La langue du navigateur est l'anglais(${navigator.language}) et le système d'exploitation est ${navigator.platform}`);

}

var ventana;

function abrirPagina(posicion) {

    switch (posicion) {
        case 0:
        case 1:
        case 2:
            window.location = url[posicion];
        break;
        case 3:
            ventana = window.open(url[posicion],'ventana','width=10px,height=10px');
            ventana.resizeTo(window.screen.availWidth * 2/3, window.screen.availHeight * 3/4);
            ventana.moveTo((window.screen.availWidth * 2/3) /4, (window.screen.availHeight * 3/4) / 4);
        break;
    }

}

function cambiarColor() {

    let numColor = Math.random() * 9;
    numColor = Math.round(numColor);

    document.body.style.backgroundColor = colores[numColor];

    document.title = colores[numColor].toUpperCase();

}
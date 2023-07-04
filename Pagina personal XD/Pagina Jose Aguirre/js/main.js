"use strict"

document.getElementById("uno").addEventListener("click", () => {cargarContent("./html/e.html")});
document.getElementById("dos").addEventListener("click", () => {cargarContent("./html/p.html")});

document.readyState = cargarContent("./html/e.html");

function cargarContent(url){
    var peticion = new XMLHttpRequest();
    peticion.open('GET', url);
    peticion.onload = ()=>{
        let resp = peticion.responseText;
        document.getElementById("info").innerHTML = resp
    };
    peticion.send();
}

// var peticion = new XMLHttpRequest();
// peticion.open('GET', "./html/e.html");
// peticion.onload = ()=>{
//     let resp = peticion.responseText;
//     document.getElementById("info").innerHTML = resp
// };
// peticion.send();
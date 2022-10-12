"use strict"

//Declaraciones de variables globales

let promedio;
let notaTeorica;
let ArrEstudiantes = [];
let nota;
let botonTomarNotas;
let botonRegistraNotas;
let botonGenerarNotas;
let spanAprobacion;
let estudiante;


window.onload = () => {

    botonTomarNotas = document.getElementById("BotonTomaNotas");
    botonRegistraNotas = document.getElementById("BotonRigistrar");
    botonGenerarNotas = document.getElementById("GenerarNotas");

    botonRegistraNotas.addEventListener("click", registrarAlumno);
    botonTomarNotas.addEventListener("click", tomaNotas);

    spanAprobacion = document.getElementById("aprobacion");

    botonGenerarNotas.onclick = () => {

        for (let i = 1; i <= 5; i++) {

            nota = document.getElementsByClassName("nota");
            nota[i].value = parseInt(Math.random() * 100);

        }

    }

}

function tomaNotas() {

    //Declaraciones de variables locales de tomaNota()

    let errorCont = 0;
    let acum = 0;
    let cant = 0;
    let errorMs = document.getElementById("Error");

    notaTeorica = document.tomaNotas.elements[5].value;

    estudiante = document.tomaNotas.elements[0].value;

    //Toma y validacion de de notas

    for (let i = 1; i <= 5; i++) {

        nota = document.tomaNotas.elements[i].value;

        if (validacionNumeros(nota, 0, 100) == false)
            errorCont++;

    }

    ComprobarErrorComprob(estudiante, errorCont, 0, errorMs);

    if (errorCont < 1 && estudiante.trim() != "") {

        errorMs.style.display = "none";

        for (let i = 1; i <= 4; i++) {

            nota = parseInt(document.tomaNotas.elements[i].value);

            acum += nota;
            cant++;

        }

        promedio = acum / cant;
        document.tomaNotas.promedioID.value = promedio;
        console.log("promedio es: " + promedio.toFixed(2));

        comprobarSiAprobo();

    } else {
        console.warn("no se pudo calcular");
        document.tomaNotas.promedioID.value = 0;
        spanAprobacion.style.display = "none";
    }

}

function registrarAlumno() {

    //Declaraciones de variables locales de registrarAlumno()

    let errorMs = document.getElementById("Error");
    let contadorAprob = document.getElementById("CantidadAlumnosApr");
    let contadorRepro = document.getElementById("CantidadAlumnosRep");
    let aprobacion;

    estudiante = document.tomaNotas.elements[0].value;
    estudiante = estudiante.toUpperCase();

    if (comprobarErrorRegist(estudiante, errorMs) == true) {

        ArrEstudiantes.push(estudiante);
        errorMs.innerText = "El estudiante fue agregado con exito";
        errorMs.style.display = "block";
        errorMs.style.backgroundColor = "#24cc8b";

        if (promedio >= 80 && notaTeorica >= 80) {
            contadorAprob.innerText++;
            aprobacion = true;
        } else {
            contadorRepro.innerText++;
            aprobacion = false;
        }

        agregarAlumALaTabla(aprobacion);
        document.tomaNotas.reset();
        window.scroll(0,window.screen.availHeight);

        promedio = ""
        notaTeorica = ""

    }
    

    console.log(ArrEstudiantes);

}

//Funciones exclusivas para el desafio

//Funciones de Comprobar Notas

function comprobarSiAprobo() {

    if (promedio >= 80 && notaTeorica >= 80) {

        console.log("Aprobo");
        spanAprobacion.innerText = "El Alumno ha aprobado!! :D";
        spanAprobacion.style.display = "block";
        spanAprobacion.style.backgroundColor = "#24cc8b";

    } else if (promedio <= 80 || notaTeorica <= 80) {

        console.log("No aprobo");
        spanAprobacion.innerText = "El Alumno no ha aprobado :(";
        spanAprobacion.style.display = "block";
        spanAprobacion.style.backgroundColor = "#b13e3e";

    }
}

function ComprobarErrorComprob(string, errorCont, min, errorMs) {

    if (validarString(string) == false) {

        console.error("datos nombre invalido");
        errorMs.innerText = `No puede comprobar si no pone el nombre del alumno`;
        errorMs.style.display = "block";
        errorMs.style.backgroundColor = "#b13e3e";
        window.scroll(0,0);

    } else if (errorCont > min) {

        console.error("datos notas invalidas");
        errorMs.innerText = `${errorCont} de las notas ingresadas no es(son) valida(s), procure escribir numeros entre 0 y 100`;
        errorMs.style.display = "block";
        errorMs.style.backgroundColor = "#b13e3e"
        window.scroll(0,0);

    }
}

//Funciones de Resgistrar Notas

function comprobarErrorRegist(string, errorMs) {

    if (validarString(string) == false) {

        console.error("datos nombre invalido");
        errorMs.innerText = "Tiene que poner un nombre, vuelva a intentar";
        errorMs.style.display = "block";
        errorMs.style.backgroundColor = "#b13e3e";
        window.scroll(0,0);

        return false

    } else if (ArrEstudiantes.includes(estudiante)) {

        console.warn("datos ya inluido");
        errorMs.innerText = "El estudiante ya esta registrado, intente de nuevo con otro nombre";
        errorMs.style.display = "block";
        errorMs.style.backgroundColor = "#b13e3e";
        window.scroll(0,0);

        return false

    } else if (promedio == "" || notaTeorica == "") {

        console.error("datos notas invalidas");
        errorMs.innerText = "Debe comprobar notas para poder registrar a el estudiante";
        errorMs.style.display = "block";
        errorMs.style.backgroundColor = "#b13e3e";
        window.scroll(0,0);

        return false;
    } else
        return true;
  
}

//Funcion Agregar a la table

function agregarAlumALaTabla(aprobacion) {

    let tabla = document.getElementById("tabla");

    let fila = tabla.insertRow(-1);

    let celda = fila.insertCell(-1);
    celda.innerText = document.tomaNotas.elements[0].value;

    celda = fila.insertCell(-1);
    celda.innerText = document.tomaNotas.elements[1].value;

    celda = fila.insertCell(-1);
    celda.innerText = document.tomaNotas.elements[2].value;

    celda = fila.insertCell(-1);
    celda.innerText = document.tomaNotas.elements[3].value;

    celda = fila.insertCell(-1);
    celda.innerText = document.tomaNotas.elements[4].value;

    celda = fila.insertCell(-1);
    celda.innerText = document.tomaNotas.elements[9].value;

    celda = fila.insertCell(-1);
    celda.innerText = document.tomaNotas.elements[5].value;

    celda = fila.insertCell(-1);
    if (aprobacion == true) {
        celda.innerText = "Aprobado"
    } else
        celda.innerText = "Reprobado"

}

//Ya es como la quinta version de este algoritmo XD es 
//que siempre se me ocurre algo nuevo que creo que necesita
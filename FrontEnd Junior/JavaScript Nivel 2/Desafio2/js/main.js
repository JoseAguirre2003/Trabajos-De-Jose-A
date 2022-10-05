"use strict"

//Declaraciones de variables globales

let promedio;
let notaTeorica;
let ArrEstudiantes = [];

function tomarNota() {

    //Declaraciones de variables locales de tomaNota()

    let errorCont = 0;
    let acum = 0;
    let cant = 0;
    let nota;
    let spanAprobacion = document.getElementById("aprobacion");
    let errorMs = document.getElementById("Error");

    notaTeorica = document.tomaNotas.elements[5].value;
    
    //Toma y validacion de de notas

    for (let i = 1; i <= 4; i++) {

        nota = document.tomaNotas.elements[i].value;

        if (nota == null || isNaN(nota) || nota.trim() == "" || nota < 0 || nota > 100)
            errorCont++;

    }

    if (notaTeorica == null || isNaN(notaTeorica) || nota.trim() == "" || notaTeorica < 0 || notaTeorica > 100)
        errorCont++;
  

    //Contador de Errores

    if (errorCont > 0) {
        console.error("datos notas invalidas");
        errorMs.innerText = `${errorCont} de las notas ingresadas no es(son) valida(s), procure escribir numeros entre 0 y 100`;
        errorMs.style.display = "block";
        errorMs.style.backgroundColor = "#b13e3e"
    }

    //Calcular y mostrar promedio

    if (errorCont < 1) {
        
        errorMs.style.display = "none";

        for (let i = 1; i <= 4; i++) {

            nota = parseInt(document.tomaNotas.elements[i].value);

            acum += nota;
            cant++;

        }

        promedio = acum / cant;
        document.tomaNotas.promedioID.value = promedio;
        console.log("promedio es: " + promedio.toFixed(2));

        if (promedio >= 80 && notaTeorica >= 80) {

            console.log("Aprobo");
            spanAprobacion.innerText = "El Alumno ha aprobado!! :D";
            spanAprobacion.style.display = "block";
            spanAprobacion.style.backgroundColor = "#24cc8b";

        } else if (promedio <= 80 || notaTeorica <= 80 ) {

            console.log("No aprobo");
            spanAprobacion.innerText = "El Alumno no ha aprobado :(";
            spanAprobacion.style.display = "block";
            spanAprobacion.style.backgroundColor = "#b13e3e";

        }

    } else {
        console.warn("no se pudo calcular");
        document.tomaNotas.promedioID.value = 0;
        spanAprobacion.style.display = "none";
    }
    
    errorCont = 0;

}

function registrarAlumno() {

    //Declaraciones de variables locales de registrarAlumno()

    let errorMs = document.getElementById("Error");
    let estudiante = document.tomaNotas.elements[0].value;
    let contadorAprob = document.getElementById("CantidadAlumnosApr");
    let contadorRepro = document.getElementById("CantidadAlumnosRep");
    
    estudiante = estudiante.toUpperCase();

    //Validaciones de registro

    if (estudiante == undefined || estudiante.trim() == ""){

        console.error("datos nombre invalido");
        errorMs.innerText = "Tiene que poner un nombre, vuelva a intentar";
        errorMs.style.display = "block";
        errorMs.style.backgroundColor = "#b13e3e";

    } else if (ArrEstudiantes.includes(estudiante)) {
        
        console.warn("datos ya inluido");
        errorMs.innerText = "El estudiante ya esta registrado, intente de nuevo con otro nombre";
        errorMs.style.display = "block";
        errorMs.style.backgroundColor = "#b13e3e";
    
    } else if (promedio == undefined || notaTeorica == undefined || isNaN(promedio) || isNaN(notaTeorica))  {

        console.error("datos notas invalidas");
        errorMs.innerText = "Debe comprobar notas para poder registrar a el estudiante";
        errorMs.style.display = "block";
        errorMs.style.backgroundColor = "#b13e3e";

        //Envio y conteo de datos al arreglo

    } else {

        ArrEstudiantes.push(estudiante);
        errorMs.innerText = "El estudiante fue agregado con exito";
        errorMs.style.display = "block";
        errorMs.style.backgroundColor = "#24cc8b";
        
        if (promedio >= 80 && notaTeorica >=80){
            contadorAprob.innerText++;
        } else {
            contadorRepro.innerText++;
        }

    }
    
    //Reset

    promedio = undefined
    notaTeorica = undefined

    document.tomaNotas.reset()
     
    console.log(ArrEstudiantes);

}

//Quiero un 100 :v las validaciones me estan volviendo loco XD espero no se me haya escapado nunguna posibilidad
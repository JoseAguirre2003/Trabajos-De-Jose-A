"use strcit"

//Funcion de Validacion de String

function validarString(mensaje, mensajeError) {

    do {

        dato = prompt(mensaje);

        if (dato == null || dato.trim() == "") {
            console.log(mensajeError)
            alert(mensajeError)
        } else 
            return dato;

    } while ((dato == null || dato.trim() == ""))

}

//Funcion de Validacion de Numero

function validarNumero(mensaje, mensajeError) {

    do {

        numero = prompt(mensaje);
    
        if (numero == null || isNaN(numero) || numero.trim() == "") {
            console.warn(mensajeError);
            alert(mensajeError);
        } else
            return parseInt(numero); 
            
    } while (numero == null || isNaN(numero) || numero.trim() == "");

}


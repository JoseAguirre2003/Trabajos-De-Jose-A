"use strict"

/* Validar numero */

function validacionNumeros(num, min, max) {

    if (isNaN(num) || num.trim() == "" || num < min || num > max)
        return false;
    else
        return true;
}

function validarString(string) {
    if (string.trim() == "")
        return false
    else
        return true
}
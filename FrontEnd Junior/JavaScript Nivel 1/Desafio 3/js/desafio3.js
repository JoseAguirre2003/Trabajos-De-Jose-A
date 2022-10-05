"use strict"

//Declaraciones de Variables

const ciudadesDestino = ["Aruba", "Mexico", "Miami", "Londres", "Suiza"];
const preciosVuelos = [250, 4570, 500, 1400, 2200];
var descuento = 0;
var IVA;
var Total = 0;
var cedulaValida;
var ciudadValida;
var cantidadClientes = 0
var ganancias = 0

alert("Bienvenido al Aeropuerto CADI F1");

do {

    //Entradas

    //Cedula

    do {

        var cedula = prompt("Por favro ingrese su numero de C.I.");

        if (cedula == null || isNaN(cedula) || cedula.trim() == "") {
            console.warn("Debe introducir una cedula, por favor vuelva a intentar");
            alert("Debe introducir una cedula, por favor vuelva a intentar");
            cedulaValida = false
        } else
            cedulaValida = true

        cedula = parseInt(cedula);

    } while (cedulaValida == false);

    //Ciudad de destino

    do {

        var elecDestino = prompt(`Ingrese su ciudad de destino con un valor del 1 al 5:
        1 para ir a ${ciudadesDestino[0]} con un precio de ${preciosVuelos[0]}$
        2 para ir a ${ciudadesDestino[1]} con un precio de ${preciosVuelos[1]}$
        3 para ir a ${ciudadesDestino[2]} con un precio de ${preciosVuelos[2]}$
        4 para ir a ${ciudadesDestino[3]} con un precio de ${preciosVuelos[3]}$
        5 para ir a ${ciudadesDestino[4]} con un precio de ${preciosVuelos[4]}$`);

        if (elecDestino < 1 || elecDestino > 5 || elecDestino == null || isNaN(elecDestino) || elecDestino.trim() == "") {
            alert("Eligio una opcion invalida, por favor vuelva a intentar escribiendo valores entre 1 y el 5");
            console.log("Eligio una opcion invalida, por favor vuelva a intentar escribiendo con valores entre 1 y el 5");
            ciudadValida = false
        } else
            ciudadValida = true

        elecDestino = parseInt(elecDestino);

    } while (ciudadValida == false);

    //Proceso

    /* if (ciudadValida == true || cedulaValida == true) { */

        //Determinar si descuento va o no

        switch (elecDestino) {
            case 1:
            case 2:
            case 3:

                alert(`Ha seleccionado a ${ciudadesDestino[elecDestino - 1]}(${preciosVuelos[elecDestino - 1]}$) como su ciudad de destino`);
                console.log(`Se ha seleccionado la ciudad ${ciudadesDestino[elecDestino - 1]}`);
                break;

            case 4:
            case 5:

                alert(`Ha seleccionado a ${ciudadesDestino[elecDestino - 1]}(${preciosVuelos[elecDestino - 1]}$) como su ciudad de destino por lo que obtendra un descuento del 10%`);
                console.log(`Se ha seleccionado la ciudad ${ciudadesDestino[elecDestino - 1]}(${preciosVuelos[elecDestino - 1]})`);

                descuento = preciosVuelos[elecDestino - 1] * 0.10;

                break;
        }

        //Determinar impuesto

        if (cedula % 2 == 0) {
            alert("Dado a que su numero de C.I. es un numero par, tendra un impuesto de 15$");
            console.log("Dado a que su numero de C.I. es un numero par, tendra un impuesto de 15$");
            IVA = 15
        } else {
            alert("Dado a que su numero de C.I. es un numero impar, tendra un impuesto de 30$");
            console.log("Dado a que su numero de C.I. es un numero impar, tendra un impuesto de 30$");
            IVA = 30
        }

        Total = preciosVuelos[elecDestino - 1] - descuento + IVA

        //Salidas de clientes

        //Salidas de cliente por alerta

        alert(`Cedula: ${cedula}
    Ciudad de destino: ${ciudadesDestino[elecDestino - 1]}
    Precio del vuelo: ${preciosVuelos[elecDestino - 1]}$
    Descuento: ${descuento}$
    Impuesto: ${IVA}$
    a pagar: ${Total}$`)

        //Salidas de cliente por consola

        console.log("Cedula: " + cedula);
        console.log("Ciudad de destino: " + ciudadesDestino[elecDestino - 1]);
        console.log(" Precio del vuelo: " + preciosVuelos[elecDestino - 1] + "$");
        console.log("Descuento: " + descuento + "$");
        console.log("Impuesto: " + IVA + "$");
        console.log("Total a pagar: " + Total + "$");

    // }

    cantidadClientes++
    ganancias += Total

    var otroCliente = confirm("Desea procesar otro cliente?");

} while (otroCliente == true);

//Salidas para la agencia

var promedio = ganancias / cantidadClientes;

alert(`Cantidad de clientes: ${cantidadClientes}
Ganancias totales: ${ganancias}
Promedio de ingreso: ${promedio.toFixed(2)}$`);

console.log("Cantidad de clientes: " + cantidadClientes);
console.log("Ganancias Totales: " + ganancias + "$");
console.log("Promedio de ingreso: " + promedio.toFixed(2) + "$");
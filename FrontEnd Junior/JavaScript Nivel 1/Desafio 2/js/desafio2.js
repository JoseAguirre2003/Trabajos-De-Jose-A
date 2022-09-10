"use strcit"

//Declaraciones de variables

//Variables definidas

const precioPlayera = 25;
const precioDeportiva = 50;
const precioCasual = 68;
const precioSudadera = 98;

//Variables por definir

var ropaDeseada;
var precioUnitarioRopa;
var subTotal;
var porcDesc
var descuento;
var subTotalDesc;
var IVA;
var total; 

//Entradas

alert("Bienvenido a la tienda, por favor seleccione el tipo de ropa que desea comprar: ");
ropaDeseada = prompt(`Playera ${precioPlayera}$, Deportiva ${precioDeportiva}$ , Casual ${precioCasual}$, Sudadera ${precioSudadera}$`);

if (ropaDeseada != null) {

    ropaDeseada = ropaDeseada.toUpperCase();

}

//Proceso

//Estableciendo valor unitario de la prenda

if (ropaDeseada == null || ropaDeseada == "") { 

    alert("Debe colocar un el tipo de ropa que va comprar");
    console.log("Debe colocar un el tipo de ropa que va comprar");

} else if (ropaDeseada == "PLAYERA") {

    precioUnitarioRopa = precioPlayera;
    alert(`Ha seleccionado la camiseta Playera con un costo de ${precioUnitarioRopa}$`);
    console.log(`Ha seleccionado la camiseta Playera con un costo de ${precioUnitarioRopa}$`);

} else if (ropaDeseada == "DEPORTIVA") {

    precioUnitarioRopa = precioDeportiva;
    alert(`Ha seleccionado la camiseta Deportiva con un costo de ${precioUnitarioRopa}$`);
    console.log(`Ha seleccionado la camiseta Deportiva con un costo de ${precioUnitarioRopa}$`);

} else if (ropaDeseada == "CASUAL") {

    precioUnitarioRopa = precioCasual;
    alert(`Ha seleccionado la camiseta Casual con un costo de ${precioUnitarioRopa}$`);
    console.log(`Ha seleccionado la camiseta Casual con un costo de ${precioUnitarioRopa}$`);

} else if (ropaDeseada == "SUDADERA") { 
    
    precioUnitarioRopa = precioSudadera;
    alert(`Ha seleccionado la Sudadera con un costo de ${precioUnitarioRopa}$`);
    console.log(`Ha seleccionado la Sudadera con un costo de ${precioUnitarioRopa}$`);

} else {

    alert("El tipo de ropa que ha seleccionado no esta en nuestro catalogo");
    console.log("El tipo de ropa que ha seleccionado no esta en nuestro catalogo");

}

//Calculando descuentos

if ((ropaDeseada != null && ropaDeseada != "") && (ropaDeseada == "PLAYERA" || ropaDeseada == "DEPORTIVA" || ropaDeseada == "CASUAL" || ropaDeseada == "SUDADERA")) {

    cantidad =  Math.random()*50;

    alert(`La cantidad de unidades a comprar es ${Math.ceil(cantidad)}`);
    console.log(`La cantidad de unidades a comprar es ${Math.ceil(cantidad)}`);

    subTotal = precioUnitarioRopa * Math.ceil(cantidad);

    if (cantidad > 24) { 

        alert("Dado a que la cantidad de unidades a comprar es mayor a 2 docenas(24) obtiene un descuento del 15%");
        console.log("Dado a que la cantidad de unidades a comprar es mayor a 2 docenas(24) obtiene un descuento del 15%");
        porcDesc = 15;

    } else if (cantidad > 6 && cantidad < 11) {

        alert("Dado a que la cantidad de unidades a comprar esta entre el rango de 6 a 11 unidades, obtiene un descuento del 5%");
        console.log("Dado a que la cantidad de unidades a comprar esta entre el rango de 6 a 11 unidades, obtiene un descuento del 5%");
        porcDesc = 5;

    } else {

        alert("No obtiene ningun descuento");
        console.log("No obtiene ningun descuento");
        porcDesc = 0;

    }

    descuento = subTotal * porcDesc / 100;

    subTotalDesc = subTotal - descuento;

    IVA = subTotalDesc * 0.12;

    total = subTotalDesc + IVA;

    //Salidas

    //Salidas por la consola

    console.log("")
    console.log("Info de la compra")
    console.log(`Tipo de ropa: ${ropaDeseada}`);
    console.log(`Precio unitario: ${precioUnitarioRopa}$`);
    console.log(`Cantidad de unidades: ${Math.ceil(cantidad)}`);
    console.log(`Precio sub-total: ${subTotal.toFixed(2)}$`);
    console.log(`Porcentaje de Descuento: ${porcDesc}%`);
    console.log(`Monto descontado: ${descuento.toFixed(2)}$`);
    console.log(`Precio sub-total con descuento: ${subTotalDesc.toFixed(2)}$`);
    console.log(`Monto de IVA: ${IVA.toFixed(2)}$`);
    console.log(`Monto de Total a pagar: ${total.toFixed(2)}$`)

    //Salidas por alerta

    alert(`Info de la compra:
    Tipo de ropa: ${ropaDeseada}
    Precio unitario: ${precioUnitarioRopa}$
    Cantidad de unidades: ${Math.ceil(cantidad)}
    Precio sub-total: ${subTotal.toFixed(2)}$
    Porcentaje de Descuento: ${porcDesc}%
    Monto descontado: ${descuento.toFixed(2)}$
    Precio sub-total con descuento: ${subTotalDesc.toFixed(2)}$
    Monto de IVA: ${IVA.toFixed(2)}$
    Monto de Total a pagar: ${total.toFixed(2)}$`)
}

//I did it! of corse I did it :)

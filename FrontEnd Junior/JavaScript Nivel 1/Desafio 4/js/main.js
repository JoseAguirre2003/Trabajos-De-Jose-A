"use srcit"

//Declaraciones de Variables

let modelosAutos = [];
let precioAuto = [];
let estadoAuto = [];

let repet = false;
let acum = 0;
let cantAutos = 0;
let cantAutosNew = 0;
let cantAutosOld = 0;
let promedio = 0;

let modelo;
let precio;
let estado;

//Entradas y Proceso

do {

    do {

        //Peticion del Nombre del Modelo:

        modelo = validarString("Ingrese el Modelo del auto", "Debe colocar un nombre para el modelo, no lo puede dejar vacio");
        modelo = modelo.toUpperCase();

        if (modelosAutos.indexOf(modelo) >= 0) {
            console.warn("Ese modelo ya existe, vuelva  intentar!");
            alert("Ese modelo ya existe, vuelva a intentar!");
            repet = true;
        } else
            repet = false;

    } while (repet == true);

    //Peticion del Precio del Modelo: 

    precio = validarNumero("Ingrese el precio del modelo del auto", "Debe introducir un numero entero, por favor vuelva a intentar");
    console.log(precio)

    //Peticion del Estado del Modelo: 

    estado = confirm("Es el auto nuevo?");

    if (estado == true) {
        modelosAutos.unshift(modelo);
        precioAuto.unshift(precio);
        estadoAuto.unshift(estado);
    } else {
        modelosAutos.push(modelo);
        precioAuto.push(precio);
        estadoAuto.push(estado);
    }

    acum += precio;
    cantAutos++

    //Repeticion

} while (confirm("Desea incluir otro auto?"))

for (i = 0; i < estadoAuto.length; i++) {

    if (estadoAuto[i] == true)
        cantAutosNew++;
    else
        cantAutosOld++;
}

promedio = acum / cantAutos;

//Salidas

//Salidas por alerta y consola

alert(`Informacion del Concesionario:
Cantidad de Autos: ${cantAutos}
Cantidad de Autos Nuevos: ${cantAutosNew}
Cantidad de Autos Usados: ${cantAutosOld}
Promedio de precio de autos: ${promedio.toFixed(2)}$`);

console.log(`Informacion del Concesionario:
Cantidad de Autos: ${cantAutos}
Cantidad de Autos Nuevos: ${cantAutosNew}
Cantidad de Autos Usados: ${cantAutosOld}
Promedio de precio de autos: ${promedio.toFixed(2)}$`);

alert(`Lista de autos: \n${modelosAutos.join("\n")}`);

console.log(`Lista de autos: \n${modelosAutos.join("\n")}`);
"use strict"

alert("Tenemos 4 tipos de Franelas: ")
alert("Playera, Deportiva, Casual, Sudadera!")


var tipoFranela = prompt("Que tipo de Franela Quieres:?")


if (tipoFranela == null || tipoFranela == "" )
    alert("Debes ingresar un tipo de franela o presionaste cancelar, Por favor intente nuevamente!!")

    if (tipoFranela == "playera"){
        alert("Has seleccionado la playera y su costo es de 25$")
        var playeraCantidad = Math.random()*(50-1)+1
        console.log(playeraCantidad)
        }
        else
            if (tipoFranela == "deportiva"){
                alert("Has seleccionado la deportiva y su costo es de 50$")
                var deportivaCantidad = Math.random()*(50-1)+1
                console.log(deportivaCantidad)
            }
            else
                if (tipoFranela == "casual"){
                    alert("Has seleccionado casual y su costo es de 68$")
                    var casualCantidad = Math.random()*(50-1)+1
                    console.log(casualCantidad)
                }
                else
                    if (tipoFranela == "sudadera"){
                        alert("Has seleccionado sudadera y su costo es de 90$")
                        var sudaderaCantidad = Math.random()*(50-1)+1
                        console.log(sudaderaCantidad)
                    }

// PRECIO DE LAS FRANELAS
 var playera = 25
 var deportiva = 50
 var casual = 68
 var sudadera = 90                   


// SUBTOTAL DE TODAS LOS TIPOS DE FRANELAS
 var subTotalP = playera * playeraCantidad
 var subTotalD = deportiva * deportivaCantidad
 var subTotalC = casual * casualCantidad
 var subTotalS = sudadera * sudaderaCantidad
 
 var porcentaje = 0
 var descuento = 0
 var total= 0
 var impuesto = 0.12
    
    debugger;

    if (playeraCantidad >= 24){
         porcentaje = 0.15 * subTotalP
         descuento = subTotalP - porcentaje
         total = descuento + descuento * impuesto
         console.log(`La cantidad de franelas son: ${playeraCantidad.toFixed(0)}`)
         console.log(`El subtotal a pagar es de: ${subTotalP.toFixed(2)}`)
         console.log(`Tuvo un descuento de ${porcentaje.toFixed(0)} bls`)
         console.log(`El monto luego del descuento por su compra es de: ${descuento.toFixed(2)}`)
         console.log(`El impuesto del IVA es de: ${impuesto * 100}%`)
         console.log(`El total a pagar es de ${total.toFixed(0)}`)
        }                    
        else
            if(playeraCantidad >= 6 && playeraCantidad <= 11){
                porcentaje = 0.05 * subTotalP
                descuento = subTotalP - porcentaje
                total = descuento + descuento * impuesto
                console.log(`La cantidad de franelas son: ${playeraCantidad.toFixed(0)}`)
                console.log(`El subtotal a pagar es de: ${subTotalP.toFixed(2)}`)
                console.log(`Tuvo un descuento de ${porcentaje.toFixed(0)} bls`)
                console.log(`El monto luego del descuento por su compra es de: ${descuento.toFixed(2)}`)
                console.log(`El impuesto del IVA es de: ${impuesto * 100}%`)
                console.log(`El total a pagar es de ${total.toFixed(0)}`)

                } 
                else{
                    console.log("No ha obtenido ningun beneficio de descuento por su compra")
                    descuento = subTotalP * impuesto
                    total = subTotalP - descuento
                    console.log(`La cantidad de franelas son: ${playeraCantidad.toFixed(0)}`)
                    console.log(`El subtotal a pagar es de: ${subTotalP.toFixed(2)}`)
                    console.log(`El impuesto del IVA es de: ${impuesto * 100}%`)
                    console.log(`El total a pagar es ${total}`)
                }

    console.log("------------------------------------------------------------------------------------")            

    if (deportivaCantidad >= 24){
        porcentaje = 0.15 * subTotalD
        descuento = subTotalD - porcentaje
        total = descuento + descuento * impuesto
        console.log(`La cantidad de franelas son: ${deportivaCantidad}`)
        console.log(`El subtotal a pagar es de: ${subTotalD}`)
        console.log(`Tuvo un descuento de ${porcentaje} bls`)
        console.log(`El monto luego del descuento por su compra es de: ${descuento}`)
        console.log(`El impuesto del IVA es de: ${impuesto * 100}%`)
        console.log(`El total a pagar es de ${total}`)
    }                    
    else
        if(deportivaCantidad >= 6 && deportivaCantidad <= 11){
            porcentaje = 0.05 * subTotalD
            descuento = subTotalD - porcentaje
            total = descuento + descuento * impuesto
            console.log(`La cantidad de franelas son: ${deportivaCantidad}`)
            console.log(`El subtotal a pagar es de: ${subTotalD}`)
            console.log(`Tuvo un descuento de ${porcentaje} bls`)
            console.log(`El monto luego del descuento por su compra es de: ${descuento}`)
            console.log(`El impuesto del IVA es de: ${impuesto * 100}%`)
            console.log(`El total a pagar es de ${total}`)
            } 
            else{
                console.log("No ha obtenido ningun beneficio de descuento por su compra")
                descuento = subTotalD * impuesto
                total = subTotalD - descuento
                console.log(`La cantidad de franelas son: ${deportivaCantidad}`)
                console.log(`El subtotal a pagar es de: ${subTotalD}`)
                console.log(`El impuesto del IVA es de: ${impuesto * 100}%`)
                console.log(`El total a pagar es ${total}`)
            }
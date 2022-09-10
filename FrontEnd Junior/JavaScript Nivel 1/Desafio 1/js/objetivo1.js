"use strict"
    
//Variables Definidas

var salarioBase = 500;
var comision = 20;
var cantAutosVendidos = 13;
var vendedorNomb = "José Aguirre";

//Variables sin definir todavia - Proceso

var totalVentas = comision * cantAutosVendidos;
var bono = totalVentas * 0.10;
var salarioNeto = salarioBase + totalVentas + bono;

//Salidas

console.log(`Empleado: ${vendedorNomb}`);
console.log(`Salario base: ${salarioBase}$`);
console.log(`Cantidad de autos vendidos: ${cantAutosVendidos}`);
console.log(`Total de Ventas: ${totalVentas}$`);
console.log(`Bono: ${bono}$`);
console.log(`Salario Neto ${salarioNeto}$`);

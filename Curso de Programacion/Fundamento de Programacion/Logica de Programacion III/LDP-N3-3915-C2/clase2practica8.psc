SubAlgoritmo solicitarInformacion(mensaje, var Por Referencia)
	Mostrar mensaje Sin Saltar
	Leer var
FinSubAlgoritmo
//SubAlgoritmo calcularPorcentaje(start, percentage, value Por Referencia)
//	value = start * percentage / 100
//FinSubAlgoritmo
Funcion value <- funcCalcularPorcentaje(start, percentage)
	Definir value Como Real
	value = start * percentage / 100
FinFuncion
SubAlgoritmo mostrarInformacion(mensaje, var)
	Mostrar mensaje var
FinSubAlgoritmo

Algoritmo clase2practica8
	//Declaraciones de variables
	Definir precioFabrica, ganancia, comVendedor, precioBase, iva, precioVenta como Real
	//Inicializaciones de variables
	//Entradas
	solicitarInformacion("Indique el precio de fabrica del producto: ", precioFabrica)
	//Procesos
	ganancia = funcCalcularPorcentaje(precioFabrica, 25)
	comVendedor = funcCalcularPorcentaje(precioFabrica, 20)
	precioBase = precioFabrica+ ganancia + comVendedor
	iva = funcCalcularPorcentaje(precioBase, 15)
	precioVenta = precioBase + iva
	//Salidas
	mostrarInformacion("La ganancia para la empresa es de: ", ganancia)
	mostrarInformacion("La comision del vendedor es de: ", comVendedor)
	mostrarInformacion("El precio base del producto es: ", precioBase)
	mostrarInformacion("El Impuesto al Valor Agregado es: " , iva)
	mostrarInformacion("El precio de venta al publico es:", precioVenta)
	
	
FinAlgoritmo

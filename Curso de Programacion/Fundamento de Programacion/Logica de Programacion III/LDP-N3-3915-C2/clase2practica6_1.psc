SubAlgoritmo solicitarInformacion(mensaje, var Por Referencia)
	Mostrar mensaje Sin Saltar
	Leer var
FinSubAlgoritmo

SubAlgoritmo calcularSueldo(base, cant, bono, mont, porc, sueldo Por Referencia)
	sueldo = base + cant*bono + mont*porc/100
FinSubAlgoritmo

SubAlgoritmo mostrarInformacion(mensaje, var)
	Mostrar mensaje var
FinSubAlgoritmo

Algoritmo clase2practica3_2
	//Declaracion de variables
	Definir nombre Como Caracter
	Definir cantidad Como Entero
	Definir montoVentas, sueldoBase, sueldoTotal, porcentaje, multiploComisionCant Como Real
	//Procesos
	solicitarInformacion("Ingrese el sueldo base: ", sueldoBase)
	solicitarInformacion("Ingrese el nombre del vendedor: ", nombre)
	solicitarInformacion("Ingrese la cantidad de autos vendidos: ", cantidad)
	solicitarInformacion("Ingrese el monto de ventas del vendedor: ", montoVentas)
	solicitarInformacion("Ingrese el porcentaje de ganancia en razon al monto de ventas: ", porcentaje)
	solicitarInformacion("Ingrese el multiplo referente a la comision por cantidad de autos vendidos: ", multiploComisionCant)
	calcularSueldo(sueldoBase, cantidad, multiploComisionCant, montoVentas, porcentaje, sueldoTotal)
	mostrarInformacion("El sueldo final del empleado es:", sueldoTotal)
	
FinAlgoritmo

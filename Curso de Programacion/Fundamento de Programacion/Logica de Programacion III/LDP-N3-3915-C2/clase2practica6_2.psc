SubAlgoritmo solicitarInformacion(mensaje, var Por Referencia)
	Mostrar mensaje Sin Saltar
	Leer var
FinSubAlgoritmo
SubAlgoritmo mensajePersonalizado(mensaje, name)
		Mostrar mensaje " " name
FinSubAlgoritmo
//NUEVO MODULO PAR INICIALIZAR EL ARREGLO
SubAlgoritmo inicializarArreglo(size, array Por Referencia)
	Definir i Como Entero
	Para i=1 hasta size
		array[i] = 0
	FinPara
FinSubAlgoritmo
//MODULO REUSABLE PORQUE RECIBE EL TAMANO DEL ARREGLO
SubProceso calcularPromedio(size, array, promedio Por Referencia)
	Definir i Como Entero 
	Definir acum como Real
	Para i=1 hasta size
		Mostrar "Ingrese la " i " nota: " Sin Saltar
		Leer array[i]
	FinPara
	acum = 0
	Para i=1 hasta size
		acum = acum + array[i]
	FinPara
	promedio = acum / size
FinSubProceso
SubAlgoritmo despedirNoPersonalizado()
	Mostrar "Gracias por usar nuestro programa."
	Mostrar "Hasta Luego!!!"
FinSubAlgoritmo

//Cuerpo Principal O MAIN
Algoritmo clase2practica6
	//Declaraciones de variables
	Definir nombre, bienvenida como Caracter
	Definir notas, promedio como Real
	Definir tamanoArreglo como Entero
	//Inicializacion de variables
	bienvenida = "Bienvenido al sistema"
	//Procesos
	solicitarInformacion("Ingresa tu nombre: ", nombre)
	solicitarInformacion("Indique el tamaño del arreglo de notas", tamanoArreglo)
	Dimension notas[tamanoArreglo]
	inicializarArreglo(tamanoArreglo, notas)
	mensajePersonalizado(bienvenida,nombre)
	calcularPromedio(tamanoArreglo, notas, promedio)
	mensajePersonalizado("El promedio del alumno es:", promedio)
	despedirNoPersonalizado()
FinAlgoritmo

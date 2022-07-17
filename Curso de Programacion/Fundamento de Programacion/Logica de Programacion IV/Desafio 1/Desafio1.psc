//Parte 1 del desafio

Funcion datoEncontrado <- FuncUbicarDato(mensaje, array, datoBuscado)
	
	Definir aux, i Como Entero
	Definir datoEncontrado Como Logico
	datoEncontrado = Falso
	
	Mostrar mensaje Sin Saltar
	Leer datoBuscado
	
	i = 1
	
	Para Cada aux de array
		Si datoBuscado = array[i]
			datoEncontrado = Verdadero
		FinSi
		i = i + 1
	FinPara
	
FinFuncion

//Parte 2 del desafio

SubAlgoritmo calcularPromedio(array, acum, Prom, mensaje1, mensaje2)
	
	Definir aux, i, j, Divisor Como Entero
	Definir PermitirCalc Como Logico
	
	PermitirCalc = Verdadero
	i = 1
	j = 1
	Divisor = 0
	
	Para cada aux de array Hacer
		Si array[i] = 0
			PermitirCalc = Falso
		FinSi
		i = i + 1
	FinPara
	
	acum = 0
	
	Si PermitirCalc = Verdadero
		Para cada aux de array Hacer
			
			acum = acum + array[j]
			
			j = j + 1
			Divisor = Divisor + 1
			
		FinPara
		
		prom = acum / Divisor
		
		Mostrar mensaje1 prom
	SiNo
		Mostrar mensaje2
	FinSi
	
FinSubAlgoritmo

//Parte 3 del Desafio

SubAlgoritmo solicitarDatoEnRango(mensaje1, mensaje2, dato, max, min)
	
	Definir datoValido Como Logico
	
	datoValido = Verdadero
	
	Repetir
		Mostrar mensaje1 min " - " max Sin Saltar
		Leer dato
		
		Si (dato >= min) y (dato <= max) 
			datoValido = Verdadero
		Sino 
			datoValido = Falso
			Mostrar mensaje2 min " - " max
		FinSi
	Mientras Que datoValido = Falso
	
FinSubAlgoritmo

//Parte 4 del desafio

SubAlgoritmo saberPorcentaje(mensaje, array, dato, porc Por Referencia)
	
	Definir aux, i, contadorEsp, contadorGen Como Entero
	
	i = 1
	contadorEsp = 0
	contadorGen = 0
	
	Para Cada aux de array
		Si array[i] > dato Entonces
			contadorEsp = contadorEsp + 1
		FinSi
		contadorGen = contadorGen + 1
		i = i + 1 
	FinPara
	
	porc = contadorEsp / contadorGen * 100
	
	Mostrar mensaje dato " es del " porc "%"
	
FinSubAlgoritmo

//Parte 5 del desafio

SubAlgoritmo InicializarArreglo(array1, array2, N)
	Definir i Como Entero
	
	Para i=1 Hasta N
		array1[i] = ""
		array2[i] = ""
	FinPara
	
FinSubAlgoritmo

SubAlgoritmo registrarUsuario(arrayUsername, arrayPassword, username, password, N)
	
	Definir i, j Como Entero
	Definir NombYaExiste, NombValido, ContrasenaValida, NombreVacio Como Logico
	
	Para i = 1 hasta N
		
		Repetir
			NombYaExiste = Falso
			NombreVacio = Falso
			NombValido = Verdadero
			Mostrar "Ingrese el nombre de usuario: " Sin Saltar
			Leer username
			Para j = 1 hasta N 
				Si arrayUsername[j] = username
					NombYaExiste = Verdadero
				FinSi
			FinPara
			Si username = ""
				NombreVacio = Verdadero
			FinSi
			Si NombreVacio = Verdadero Entonces
				NombValido=Falso
				NombYaExiste=Falso
				Mostrar "El nombre debe tener al menos un caracter"
			FinSi
			Si NombYaExiste = Verdadero
				Mostrar "El nombre de usuario ya esta tomado, vuelva a intentar"
			Sino
				arrayUsername[i] = username
			FinSi
		Hasta Que (NombYaExiste = Falso) y (NombValido = Verdadero)
		
		Repetir
			ContrasenaValida = Verdadero
			Mostrar "Ingrese su contraseña: " Sin Saltar
			Leer password
			arrayPassword[i] = password
			Si password = ""
				ContrasenaValida = Falso
				Mostrar "La contraseña debe tener al menos un caracter, vuelva a intentar"
			FinSi
		Hasta Que ContrasenaValida = Verdadero
		
	FinPara
	
	Para i = 1 Hasta N
		Mostrar ""
		Mostrar "Nombre de usuario: " arrayUsername[i]
		Mostrar "Contraseña: " arrayPassword[i]
		Mostrar ""
	FinPara
	
FinSubAlgoritmo

Algoritmo Desafio1
	
	//Declaraciones de variables
	
	Definir mensaje, arregloNombreUsario, arregloContrasenas, nombreUsuario, contrasena Como Caracter
	Definir datoBuscado, tamanoArreglo Como Entero
	Definir arrayEjem, arrayEjem2, promedio, acumulador, datoRango, datoPorc, topeInferor, topeSuperior, porcentaje Como Real
	Definir datoEncontrado Como Logico
	
	//Inicializaciones
	
	Dimension arrayEjem[5]
	Dimension arrayEjem2[5]
	Dimension arregloNombreUsario[5]
	Dimension arregloContrasenas[5]
	
	datoBuscado = 0
	acumulador = 0
	promedio = 0
	topeInferor = 10
	topeSuperior = 20
	datoRango = 0
	datoPorc = 80
	tamanoArreglo = 5
	nombreUsuario = ""
	contrasena = ""
	
	
	arrayEjem[1] = 100
	arrayEjem[2] = 90
	arrayEjem[3] = 80
	arrayEjem[4] = 70
	arrayEjem[5] = 60
	
	//Entradas-Procesos-Salidas
	
	Repetir
		Mostrar "Para esta parte se pueden buscar los valores 100, 90, 80, 70 y 60"
		datoEncontrado = FuncUbicarDato("Ingrese el dato a busacar ", arrayEjem, datoBuscado)
		
		Si datoEncontrado = Verdadero
			Mostrar "Se encontro lo que busca"
		SiNo si datoEncontrado = Falso
				Mostrar "No se encontro lo que busca"
			Fin si	
		FinSi
	Hasta Que datoEncontrado = Verdadero
	
	Mostrar ""
	Mostrar "Presione cualquier tecla para continuar"
	Esperar Tecla
	Limpiar Pantalla
	
	Mostrar "El Promedio del primer arreglo con valores"
	calcularPromedio(arrayEjem, acumulador, promedio, "El Promedio es: ", "No se pudo calcular el promedio debido a que uno o varios de los valores del arreglo no esta registrado")
	Mostrar "Presione cualquier tecla para continuar"
	Esperar Tecla
	Limpiar Pantalla
	
	Mostrar "Aqui se intenta sacar promedio con un arreglo sin valores"
	calcularPromedio(arrayEjem2, acumulador, promedio, "El Promedio es: ", "No se pudo calcular el promedio debido a que uno o varios de los valores del arreglo no esta registrado")
	Mostrar "Presione cualquier tecla para continuar"
	Esperar Tecla
	Limpiar Pantalla
	
	Mostrar "Para salir del modulo, debe ingresar un dato dentro del rango establecido"
	solicitarDatoEnRango("Ingrese un valor dentro del rango ", "El dato ingresado esta fuera de rango, vuelva a intentar con un valor entre ", datoRango, topeSuperior, topeInferor)
	Mostrar "Presione cualquier tecla para continuar"
	Esperar Tecla
	Limpiar Pantalla
	
	saberPorcentaje("En el primer arreglo, el porcentaje de valores superiores a ", arrayEjem, datoPorc, porcentaje)
	Mostrar "Presione cualquier tecla para continuar"
	Esperar Tecla
	Limpiar Pantalla
	
	InicializarArreglo(arregloNombreUsario, arregloContrasenas, tamanoArreglo)
	registrarUsuario(arregloNombreUsario, arregloContrasenas, nombreUsuario, contrasena, tamanoArreglo)
	
FinAlgoritmo
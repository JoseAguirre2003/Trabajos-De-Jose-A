SubAlgoritmo solicitarInformacion(mensaje, var Por Referencia)
	Mostrar mensaje Sin Saltar
	Leer var
FinSubAlgoritmo

SubAlgoritmo MostrarInfo(mensaje, var)
	Mostrar mensaje var
FinSubAlgoritmo

SubAlgoritmo Promedio(acum, cant, prom Por Referencia)
	prom = acum / cant
FinSubAlgoritmo

SubAlgoritmo Porcentaje(acumEsp, acumGen, porc Por Referencia)
	porc = acumEsp / acumGen * 100
FinSubAlgoritmo

SubAlgoritmo AcumladoresCantidadMayoresyMenores(dato, cant1 Por Referencia, cant2 Por Referencia, acum1 Por Referencia acum2 Por Referencia, aux1 Por Referencia, aux2 Por Referencia, name Por Referencia, name1 Por Referencia, name2 Por Referencia)
	Si dato >= 80 Entonces
		cant1 = cant1 + 1
		acum1 = acum1 + dato
	FinSi
	Si dato < 80 Entonces
		cant2 = cant2 +1
		acum2 = acum2 + dato
	FinSi
	Si dato > aux1 Entonces
		aux1 = dato
		name1 = name
	Sino si dato < aux2
			aux2 = dato
			name2 = name
		FinSi
	FinSi
FinSubAlgoritmo

SubAlgoritmo Menu(eleccion Por Referencia)
	//Declaraciones de variables del Menu
	Definir nombre, confirmacion, nombreNotaMayor, nombreNotaMenor Como Caracter
	Definir cantidadAprob, cantidadReprob, contGen Como Entero
	Definir nota, acumAprob, acumReprob, notaMayor, notaMenor, promedioAprob, promedioReprob, porcentajeAprob Como Real
	Definir repet Como Logico
	
	//Inicializacion del Menu
	
	repet = Falso
	cantidadAprob = 0
	cantidadReprob = 0
	acumAprob = 0
	acumReprob = 0
	promedioAprob = 0
	promedioReprob = 0
	notaMayor = -1
	notaMenor = 101
	contGen = 0
	porcentajeAprob = 0
	nombreNotaMayor = ""
	nombreNotaMenor = ""
	
	//Entradas y Salidas del Menu
	
	Repetir
		Mostrar "Bienvenido al sistema"
		Mostrar "Elija una de la 4 opciones"
		Mostrar "1. Para Ingresar las notas"
		Mostrar "2. Para Ver la cantidad de aprobados y reprobados, promedios de aprobados y reprobados, y mayor y menor nota"
		Mostrar "3. Para el el porcentaje de la seccion que aprobo"
		Mostrar "4. Para Salir del menu"
		Mostrar "Ingrese una opcion entre el 1 y 4" Sin Saltar
		Leer eleccion
		Segun eleccion Hacer
			1:Repetir
				solicitarInformacion("Ingrese el nombre del alumno: ", nombre)
				solicitarInformacion("Ingrese la nota del alumno: ", nota)
				contGen = contGen + 1
				AcumladoresCantidadMayoresyMenores(nota, cantidadAprob, cantidadReprob, acumAprob, acumReprob, notaMayor, notaMenor, nombre, nombreNotaMayor, nombreNotaMenor)
				Mostrar "¿Desea agregar a otro alumno? escriba S para Si o N para No"
				Leer confirmacion
				Si (confirmacion = "S") o (confirmacion = "s") Entonces
					repet = Verdadero
				SiNo
					repet = Falso
				FinSi
			Hasta Que repet = Falso
			Mostrar "Presione cualquier tecla para continuar"
			Esperar Tecla
			Limpiar Pantalla
			2:Promedio(acumAprob, cantidadAprob, promedioAprob)
				Promedio(acumReprob, cantidadReprob, promedioReprob)
				MostrarInfo("Cantidad de aprobados es: ", cantidadAprob)
				MostrarInfo("Promedio de aprobados es: ", promedioAprob)
				MostrarInfo("Mayor nota de la seccion es: ", notaMayor)
				MostrarInfo("La mayor nota pertenece a: ", nombreNotaMayor) 
				MostrarInfo("Cantidad de reprobados es: ", cantidadReprob)
				MostrarInfo("Promedio de Reprobados es: ", promedioReprob)
				MostrarInfo("Menor nota de la secciob es ", notaMenor)
				MostrarInfo("La menor nota pertenece a: ", nombreNotaMenor)
				Mostrar "Presione cualquier tecla para continuar"
				Esperar Tecla
				Limpiar Pantalla
			3:Porcentaje(cantidadAprob, contGen, porcentajeAprob )
				Mostrar "El " porcentajeAprob "% de la seccion aprobo"
				Mostrar "El " 100 - porcentajeAprob "% de la seccion reprobo"
				Mostrar "Presione cualquier tecla para continuar"
				Esperar Tecla
				Limpiar Pantalla
			4: Mostrar "Que tenga un buen dia"
			De Otro Modo:
				Mostrar "Tiene que elegir una opcion entre 1 y 4"
				Mostrar "Presione cualquier tecla para continuar"
				Esperar Tecla
				Limpiar Pantalla
		Fin Segun
	Hasta Que eleccion = 4
FinSubAlgoritmo
Algoritmo Desafio3
//Declaraciones de variables
	Definir eleccion Como Entero
//Entradas-Procesos-Salidas
	Menu(eleccion)
FinAlgoritmo

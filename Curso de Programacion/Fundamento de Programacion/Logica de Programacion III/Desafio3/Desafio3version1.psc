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

SubAlgoritmo Menu(eleccion Por Referencia)
	//Declaraciones de variables del Menu
	Definir nombre, confirmacion, nombreNotaMayor, nombreNotaMenor Como Caracter
	Definir cantidadAprob, cantidadReprob Como Entero
	Definir nota, acumAprob, acumReprob, notaMayor, notaMenor, promedioAprob, promedioReprob, acumGen, porcentajeAprob Como Real
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
	acumGen = 0
	porcentajeAprob = 0
	
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
				acumGen = acumGen + nota
				Si nota >= 80 Entonces
					cantidadAprob = cantidadAprob + 1
					acumAprob = acumAprob + nota
				FinSi
				Si nota < 80 Entonces
					cantidadReprob = cantidadReprob +1
					acumReprob = acumReprob + nota
				FinSi
				Si nota > notaMayor Entonces
					notaMayor = nota
					nombreNotaMayor = nombre
				Sino si nota < notaMenor
						notaMenor = nota
						nombreNotaMenor = nombre
					FinSi
				FinSi
				Mostrar "¿Desea agregar a otro alumno? escriba S para Si o N para No"
				Leer confirmacion
				Si (confirmacion = "S") o (confirmacion = "s") Entonces
					repet = Verdadero
				SiNo
					repet = Falso
				FinSi
			Hasta Que repet = Falso
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
			3:Porcentaje(acumAprob, acumGen, porcentajeAprob )
				Mostrar "El " porcentajeAprob "% de la seccion aprobo"
				Mostrar "El " 100 - porcentajeAprob "% de la seccion reprobo"
			4: Mostrar "Que tenga un buen dia"
			De Otro Modo:
				Mostrar "Tiene que elegir una opcion entre 1 y 4"
		Fin Segun
	Hasta Que eleccion = 4
FinSubAlgoritmo
Algoritmo Desafio3version1
//Declaraciones de variables
	Definir eleccion Como Entero
//Entradas-Procesos-Salidas
	Menu(eleccion)
FinAlgoritmo

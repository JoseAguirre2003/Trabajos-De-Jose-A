//Inicializacion de los arreglos

SubAlgoritmo InicializarArreglo(array1 Por Referencia, array2 Por Referencia, size)
	
	Definir i Como Entero
	
	Para i=1 Hasta size
		array1[i] = ""
		array2[i] = 0
	FinPara
	
FinSubAlgoritmo

//Cargando los Arreglos

SubAlgoritmo CargarArreglos(mensaje1, array1 Por Referencia, mensaje2, array2 Por Referencia, size, min, max)
	
	Definir i Como Entero
	Definir valorValido Como Logico
	
	valorValido = Verdadero
	
	Para i=1 Hasta size
		Mostrar mensaje1 Sin Saltar
		Leer array1[i]
		Repetir
			Mostrar mensaje2 Sin Saltar
			Leer array2[i]
			Si (array2[i] >= min) y (array2[i] <= max)
				valorValido = Verdadero
			SiNo
				valorValido = Falso
				Mostrar "Debe ingresar un valor entre " min " y " max ", vuelva a intentar"
			FinSi
		Hasta Que valorValido = Verdadero
	FinPara

FinSubAlgoritmo

//Oredenando los Arreglos

SubAlgoritmo OrdenarArreglosDescendente(mensaje1, mensaje2, mensaje3, array1, array2, size)
	
	Definir i, j Como Entero
	Definir aux2 Como Real
	Definir aux1 Como Caracter
	
	Para i=1  hasta size-1
		Para j=1 Hasta size-1
			Si array2[j] < array2[j+1]
				
				aux2=array2[j]
				aux1=array1[j]
				array2[j]=array2[j+1]
				array1[j]=array1[j+1]
				array2[j+1]=aux2
				array1[j+1]=aux1
				
			FinSi
		FinPara
	FinPara
	
	Mostrar mensaje3
	
	Para i=1 Hasta size
		
		Mostrar mensaje1 array1[i]
		Mostrar mensaje2 array2[i]
		
	FinPara
	
FinSubAlgoritmo

//Determinar la nota mayor

SubAlgoritmo DetermMayor(mensaje1, mensaje2, array1, array2, nombreMayor Por Referencia, varMayor Por Referencia, N)
	Definir p Como Entero
	
	nombreMayor=array1[1]
	varMayor=array2[1]
	
	Para p=2 hasta N
		Si array2[p] > varMayor Entonces
			varMayor = array2[p]
			nombreMayor = array1[p]
		FinSi
	FinPara
	
	Mostrar mensaje1 nombreMayor 
	Mostrar mensaje2 varMayor 
	
FinSubAlgoritmo

//Determinar la menor nota

SubAlgoritmo DetermMenor(mensaje1, mensaje2, array1, array2, nombreMenor Por Referencia, varMenor Por Referencia, N)
	Definir p Como Entero
	
	nombreMenor=array1[1]
	varMenor=array2[1]
	
	Para p=2 hasta N
		Si array2[p] < varMenor Entonces
			varMenor = array2[p]
			nombreMenor = array1[p]
		FinSi
	FinPara
	
	Mostrar mensaje1 nombreMenor 
	Mostrar mensaje2 varMenor
	
FinSubAlgoritmo

//Promedio y quienes superaron el Promedio

SubAlgoritmo Promedio(array, acum, Prom Por Referencia, size)
	
	Definir i Como Entero
	
	acum = 0
	
	Para i=1 Hasta size
		
		acum = acum + array[i]
		
	FinPara
	
	prom = acum / size
	
FinSubAlgoritmo

SubAlgoritmo SuperaPromedio(mensaje1, mensaje2, mensaje3, array1, array2, prom, size)
	
	Definir i Como Entero
	
	Mostrar mensaje3 prom
	
	Para i=1 Hasta size
		
		Si array2[i] >= prom
			Mostrar mensaje1 array1[i] mensaje2 array2[i]
		FinSi
		
	FinPara
	
FinSubAlgoritmo

//Algoritmo Principal

Algoritmo Desafio2
	
	//Declaraciones de variables
	
	Definir nombres, nombreMayor, nombreMenor Como Caracter
	Definir tamano, i Como Entero
	Definir notas, min, max, notaMayor, notaMenor, promedioN, acumNotas Como Real
	
	//Inicializaciones de variables
	
	min = 0
	max = 150
	tamano = 12
	acumNotas = 0
	PromedioN = 0
	
	//Dimensionando los arreglos
	
	Dimension nombres[tamano]
	Dimension notas[tamano]
	
	InicializarArreglo(nombres, notas , tamano)
	CargarArreglos("Ingrese el nombre del estudiante", nombres, "Ingrese la nota del estudiante", notas, tamano, min, max)
	
	Mostrar ""
	Mostrar "Presione una tecla para continuar"
	Esperar Tecla
	Limpiar Pantalla
	
	OrdenarArreglosDescendente("Nombre: ", "Nota: ", "Lista de estudiantes: ", nombres, notas, tamano)
	
	Mostrar ""
	Mostrar "Presione una tecla para continuar"
	Esperar Tecla
	Limpiar Pantalla
	
	DetermMayor("Quien obtuvo la mayor nota fue ", "Su nota fue de ", nombres, notas, nombreMayor, notaMayor, tamano)
	
	Mostrar ""
	
	DetermMenor("Quien obtuvo la menor nota fue ", "Su nota fue de ", nombres, notas, nombreMenor, notaMenor, tamano)
	
	Mostrar ""
	Mostrar "Presione una tecla para continuar"
	Esperar Tecla
	Limpiar Pantalla
	
	Promedio(notas, acumNotas, promedioN, tamano)

	SuperaPromedio("El Estudiante ", " Supero la nota promedio con ", "La nota promedio ", nombres, notas, promedioN, tamano)
	
FinAlgoritmo
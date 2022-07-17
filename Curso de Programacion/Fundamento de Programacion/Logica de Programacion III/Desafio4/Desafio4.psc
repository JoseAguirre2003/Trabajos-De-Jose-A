SubAlgoritmo InicializarArreglo(array1 Por Referencia, array2 Por Referencia, N Por Referencia)
	Definir i Como Entero
	
	Para i=1 Hasta N
		array1[i] = ""
		array2[i] = 0
	FinPara
	
FinSubAlgoritmo

SubAlgoritmo CargarArreglo(mensaje1, array1 Por Referencia, mensaje2, array2 Por Referencia, N Por Referencia)
	Definir i Como Entero
	
	Para i=1 Hasta N
		Mostrar mensaje1 i Sin Saltar
		Leer array1[i]
		Mostrar mensaje2 i Sin Saltar
		Leer array2[i]
	FinPara
	
FinSubAlgoritmo

SubAlgoritmo DetermMayorVendedor(mensaje1, mensaje2, array1, array2, nombreMayor Por Referencia, varMayor Por Referencia, N)
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

SubAlgoritmo DetermMenorVendedor(mensaje1, mensaje2, array1, array2, nombreMenor Por Referencia, varMenor Por Referencia, N)
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

SubAlgoritmo Promedio(array, acum, Prom Por Referencia, N)
	
	Definir i Como Entero
	
	acum = 0
	
	Para i=1 Hasta N
		
		acum = acum + array[i]
		
	FinPara
	
	prom = acum / N
	
FinSubAlgoritmo

SubAlgoritmo SuperaPromedio(mensaje1, mensaje2, array1, array2, prom, N)
	
	Definir i Como Entero
	
	Para i=1 Hasta N
		
		Si array2[i] >= prom
			Mostrar mensaje1 array1[i] mensaje2 array2[i]
		FinSi
		
	FinPara
FinSubAlgoritmo

SubAlgoritmo BuscarSucursal(array1, array2, N)
	
	Definir i Como Entero
	Definir encontrado Como Logico
	Definir datoBuscado Como Caracter
	encontrado = Falso
	
	Mientras encontrado = Falso Hacer
		mostrar "Ingrese el nombre de la sucursal que busca"
		Leer datoBuscado
		Para i=1 hasta N
			Si datoBuscado = array1[i] Entonces
				Mostrar "La sucursal de nombre " datoBuscado " fue encontrada, su posicion es " i
				Mostrar "Su monto total de ventas es " array2[i]
				encontrado = Verdadero
			FinSi
		FinPara
		Si encontrado = Falso
			Mostrar "No se ha encontrado la sucursal bajo el nombre " datoBuscado " Vuelva a intentar"
		FinSi
	Fin Mientras
	
FinSubAlgoritmo

SubAlgoritmo menu(eleccion Por Referencia)
	
	Definir nombres, nombreMayor, nombreMenor, nombBuscado Como Caracter
	Definir aux, N Como Entero
	Definir totalVenta, montoMayor, montoMenor, PromedioTotales, acumTotal Como Real
	Definir encontrado Como Logico
	
	N = 10
	Dimension nombres[N]
	Dimension totalVenta[N]
	nombreMayor = ""
	montoMayor = 0
	acumTotal = 0
	PromedioTotales = 0
	
	InicializarArreglo(nombres, totalVenta, N)
	
	Repetir
		Mostrar "Bienvenido al sistema"
		Mostrar "Elija una opcion entre el 1 y el 5"
		Mostrar "1. Para Ingresar datos"
		Mostrar "2. Para ver mayores y menores ventas"
		Mostrar "3. Para ver que sucursales superaron las espectativas de ventas"
		Mostrar "4. Para Buscar una sucursal en especifico"
		Mostrar "5. Para Salir del sistema"
		Mostrar "Ingrese su eleccion: " Sin Saltar
		Leer eleccion
		Segun eleccion Hacer
			1: CargarArreglo("Ingrese el nombre de la sucursal #", nombres, "Ingrese el total de venta de la sucursal #", totalVenta, N)
				Mostrar "Presiones cualquier tecla para continuar"
				Esperar Tecla
				Limpiar Pantalla
			2: DetermMayorVendedor("La Sucursal que mas ventas totales tuvo fue ", " con un total de ventas de ", nombres, totalVenta, nombreMayor, montoMayor, N)
				DetermMenorVendedor("La Sucursal que menos ventas totales tuvo fue ", " con un total de ventas de ", nombres, totalVenta, nombreMenor, montoMenor, N)
				Mostrar "Presiones cualquier tecla para continuar"
				Esperar Tecla
				Limpiar Pantalla
			3: Promedio(totalVenta, acumTotal, PromedioTotales, N)
				SuperaPromedio("La sucursal ", " supero las espectativas de ventas con una venta tota de ", nombres, totalVenta, PromedioTotales, N)
				Mostrar "Presiones cualquier tecla para continuar"
				Esperar Tecla
				Limpiar Pantalla
			4: BuscarSucursal(nombres, totalVenta, N)
				Mostrar "Presiones cualquier tecla para continuar"
				Esperar Tecla
				Limpiar Pantalla
			5: Mostrar "Que tenga un buen dia :)"
			De Otro Modo:
				Mostrar "Por favor introduzca una opcion valida del 1 al 5, vuelva a intentar"
		Fin Segun
	Hasta Que eleccion = 5
	
FinSubAlgoritmo

Algoritmo Desafio4
	
	Definir eleccion Como Entero
	
	menu(eleccion)

FinAlgoritmo


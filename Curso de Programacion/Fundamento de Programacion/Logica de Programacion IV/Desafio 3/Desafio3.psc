//Inicializar Matriz

SubAlgoritmo InicializarMatriz(row, column, matrix Por Referencia)
	
	Definir i, j Como Entero
	
	Para i = 1 Hasta row
		Para j = 1 hasta column
			matrix[i, j] = 0
		FinPara
	FinPara
	
FinSubAlgoritmo

//Cargar de Matriz

SubAlgoritmo CargaDeMatriz(row, column, restaAux1, restaAux2, matrix Por Referencia)
	
	Definir i, j, k Como Entero
	
	Para i = 1 Hasta row - restaAux1
		Para j = 1 hasta column
			matrix[i, j] = Aleatorio(19, 34)
		FinPara
	FinPara
	Para k = 1 Hasta column - restaAux2
		matrix[row, k] = Aleatorio(19, 34)
	FinPara
	
FinSubAlgoritmo

//Mostrar Contenido de la Matriz

SubAlgoritmo MostrarMatriz(row, column, matrix, mensaje1, mensaje2, restaAux1, restaAux2)
	
	Definir i, j, k Como Entero
	
	Mostrar "         D  L  Ma Mi  J  V  S" 
	Para i = 1 hasta row - restaAux1
		Mostrar mensaje2 i ": " Sin Saltar
		Para j = 1 hasta column
			Mostrar matrix[i, j] " " Sin Saltar
		FinPara
		Mostrar ""
	FinPara
	Mostrar mensaje2 5 ": " Sin Saltar
	Para k = 1 hasta column - restaAux2
		Mostrar matrix[row, k] " " Sin Saltar
	FinPara
	Mostrar ""
	
FinSubAlgoritmo

//Calcular Promedio de los datos de la Matriz

Funcion promedio <- CalcPromedioDeMatriz(row, column, matrix)
	
	Definir i, j, contador Como Entero
	Definir acum Como Real
	Definir promedio Como Real
	
	acum = 0
	contador = 0
	Para i = 1 Hasta row
		Para j = 1 hasta column
			acum = acum + matrix[i, j]
			contador = contador + 1
		FinPara
	FinPara
	promedio = acum / contador
	
FinFuncion

//Mostrar quienes y cuantos superaron el Promedio

SubAlgoritmo QuienYCuantosSupProm(row, column, matrix, prom, mensaje1, mensaje2, mensaje3, mensaje4, mensaje5, mensaje6)
	
	Definir i, j, contDia, diasSuperaProm Como Entero
	
	prom = CalcPromedioDeMatriz(row, column, matrix)
	
	Mostrar ""
	Mostrar mensaje1 prom mensaje2
	Mostrar ""
	
	contDia = 1
	diasSuperaProm = 0
	
	Para i = 1 hasta row
		Para j = 1 hasta column
			Si matrix[i, j] > prom
				Mostrar mensaje3 contDia mensaje4 matrix[i, j] mensaje5
				diasSuperaProm = diasSuperaProm + 1
			FinSi
			contDia = contDia + 1
		FinPara
	FinPara
	
	Mostrar ""
	Mostrar mensaje6 diasSuperaProm
	Mostrar ""
	
FinSubAlgoritmo

//Porcentaje de la Matriz

Funcion Porc <- PorcMenoresADato(row, column, matrix, dato)
	
	Definir i, j, contadorGen, contadorEsp Como Entero
	Definir Porc Como Real
	
	contadorGen = 0
	contadorEsp = 0
	
	Para i = 1 Hasta row
		Para j = 1 hasta column
			Si matrix[i, j] < dato
				contadorEsp = contadorEsp + 1
			FinSi
			contadorGen = contadorGen + 1
		FinPara
	FinPara
	
	Porc = contadorEsp / contadorGen * 100
	
FinFuncion

//Mostrar Quienes son menores al dato a comparar y que Porcentaje representan

SubAlgoritmo MostrarMenoresADato(row, column, matrix, dato, Porc, mensaje1, mensaje2, mensaje3, mensaje4, mensaje5)
	
	Definir i, j, contDia Como Entero
	
	Porc <- PorcMenoresADato(row, column, matrix, dato)
	
	contDia = 1
	
	Mostrar ""
	Mostrar mensaje1 Porc "%"
	Mostrar ""
	Mostrar mensaje2
	Mostrar ""
	
	Para i = 1 hasta row
		Para j = 1 hasta column
			Si (matrix[i, j] < dato) y (matrix[i, j] > 19)
				Mostrar mensaje3 contDia mensaje4 matrix[i, j] mensaje5
			FinSi
			contDia = contDia + 1
		FinPara
	FinPara
	Mostrar ""
	
FinSubAlgoritmo

//Cierre Hermoso

SubAlgoritmo CierreHermoso()
	
	Mostrar "Presione cualquier tecla para continuar"
	Esperar Tecla
	Limpiar Pantalla
	
FinSubAlgoritmo

Algoritmo Desafio3
	
	//Declaraciones de Variables
	
	Definir mes, dias, semanas, restaAux1, restaAux2 Como Entero 
	Definir i, j, k, opcMenu Como Entero
	Definir promedio, porcentaje Como Real
	
	//Inicializaciones
	
	semanas = 5
	dias = 7
	restaAux1 = 1
	restaAux2 = 4
	promedio = 0
	porcentaje = 0
	
	Dimension mes[semanas, dias]
	
	//Bienvenida al usuario
	
	Mostrar "-----------------------------------------------"
	Mostrar "Bienvenido al sistema de control del clima v1.0"
	Mostrar "-----------------------------------------------"
	Mostrar ""
	Mostrar "Presione cualquier tecla para ver la informacion sobre el Mes de Diciembre 2022"
	Esperar Tecla
	Limpiar Pantalla
	
	//Carga de informacion en la Matriz
	
	InicializarMatriz(semanas, dias, mes)
	CargaDeMatriz(semanas, dias, restaAux1, restaAux2, mes)
	
	Repetir
		Mostrar "Mes de Diciembre 2022"
		Mostrar ""
		MostrarMatriz(semanas, dias, mes, "            D  L  Ma Mi  J  V  S", "semana ", restaAux1, restaAux2)
		Mostrar ""
		Mostrar "Elija una opcion entre 1 y 3"
		Mostrar "1 - Para Determinar y ver el promedio de temperatura en el mes y cuales y cuantos dias superaron ese promedio"
		Mostrar "2 - Para Determinar y ver el porcentaje de dias que tuvieron temperaturas menores a 25°C y cuales dias estuvieron por debaje de eso"
		Mostrar "3 - Salir"
		Mostrar "Ingrese una opcion: "
		Leer opcMenu
		Segun opcMenu Hacer
			1:
				Limpiar Pantalla
				Mostrar "Mes de Diciembre 2022"
				Mostrar ""
				MostrarMatriz(semanas, dias, mes, "            D  L  Ma Mi  J  V  S", "semana ", restaAux1, restaAux2)
				QuienYCuantosSupProm(semanas, dias, mes, promedio, "El promedio de temperatura en el mes de Diciembre fue de: ", "°C", "El dia ", " de Diciembre de 2022 tuvo una temperatura de ", "°C la cual supero al promedio", "La cantidad de dias que superan el promedio es de ")
				CierreHermoso()
			2:
				Limpiar Pantalla
				Mostrar "Mes de Diciembre 2022"
				Mostrar ""
				MostrarMatriz(semanas, dias, mes, "            D  L  Ma Mi  J  V  S", "semana ", restaAux1, restaAux2)
				MostrarMenoresADato(semanas, dias, mes, 25, porcentaje, "El porcentaje de dias con temperaturas menores a 25°C es de ", "Los dias con temperaturas menores a 25°C fueron:", "El dia ", " de Diciembre de 2022 tuvo una temperatura de ", "°C la cues es menor a 25°")
				CierreHermoso()
			3:
				Limpiar Pantalla
				Mostrar "Adios, gracias por usar nuestros servicios"
			De Otro Modo:
				Limpiar Pantalla
				Mostrar "Debe colocar una opcion entre 1 y 3, por favor vuelva a intentar"
				CierreHermoso()
		Fin Segun
	Hasta Que opcMenu = 3
	
FinAlgoritmo
Algoritmo Desafio1_LogicaNiv2
	
	//Declaraciones de variables
	
	Definir nombre, genero, M, F Como Caracter
	Definir iterar, iniBisiestos, iniNumImpar, IPersonas, NPersonas Como Real
	
	//1era parte
	
	Mostrar "Los valores dobles de la variable Incial son: "
	Mostrar ""
	Para iterar<-1 Hasta 10 Hacer
		Mostrar iterar*2
	Fin Para
	Mostrar ""
	Mostrar "Presione cualquier tecla para continuar"
	Esperar Tecla
	Limpiar Pantalla
	
	//2da parte
	
	Mostrar "Los años bisiestos desde 2016 hasta 2040 son: "
	Mostrar ""
	Para iniBisiestos<-2016 Hasta 2040 Con Paso 4 Hacer
		Mostrar iniBisiestos
	Fin Para
	Mostrar ""
	Mostrar "Presione cualquier tecla para continuar"
	Esperar Tecla
	Limpiar Pantalla
	
	//3era parte
	
	Mostrar "Los numero impares del 1 al 51 son: "
	Mostrar ""
	Para iniNumImpar<-51 hasta 1 Con Paso -2 Hacer
		Mostrar iniNumImpar
	FinPara
	Mostrar ""
	Mostrar "Presione cualqueir tecla para continuar"
	Esperar Tecla
	Limpiar Pantalla
	
	//4ta y 5ta parte Entrada-Proceso-Salida
	
	NPersonas<-5
	
	Para IPersonas<-1 Hasta NPersonas Hacer
		Mostrar "Indique su nombre" Sin Saltar
		Leer nombre
		Mostrar "Indique su genero con M si es Masculino y F si es femenino: " Sin Saltar
		Leer genero
		
		genero=Mayusculas(genero)
		
		Si genero="M"
			Mostrar ""
			Mostrar "Estimado señor " nombre " de genero masculino, sea bienvenido"
		FinSi
		Si genero="F"
			Mostrar ""
			Mostrar "Estimada señora " nombre " de genero femenino, sea bienvenida"
		FinSi
		Mostrar ""
	FinPara
	
FinAlgoritmo

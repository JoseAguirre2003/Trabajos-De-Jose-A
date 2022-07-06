Algoritmo Desafio3LogicaN2Algoritmo2
	
	//Declaraciones de variables
	
	Definir sexo Como Caracter
	Definir Edad, Cotizaciones  Como Entero
	
	//Entradas
	
	Mostrar ""
	Mostrar "Indique la edad: " Sin Saltar
	Leer Edad
	Mostrar "Indique el genero, M si es masculino y F si es femenino: " Sin Saltar
	Leer sexo
	Mostrar "Indique el numero de cotizaciones emitidas: " Sin Saltar
	Leer Cotizaciones
	Mostrar "Presione cualquier tecla para continuar"
	Esperar Tecla
	Limpiar Pantalla
	
	//Proceso-Salidas
	
	Mostrar ""
	Si (Edad >= 60) y (sexo = "M" o sexo = "m") y (Cotizaciones >= 750)
		Mostrar "La edad es: " Edad
		Mostrar "El genero es: Masculino"
		Mostrar "Es apto para disfrutar del benefico de pension"
	Sino si (Edad >= 55) y (sexo = "F" o sexo = "f") y (Cotizaciones >= 750)
			Mostrar "La edad es: " Edad
			Mostrar "El genero es: Femenino"
			Mostrar "Es apta para disfrutar del beneficio de pension"
		Sino si (Edad < 60 y (sexo = "M" o sexo = "m")) o (Edad < 55 y (sexo = "F" o sexo = "f"))
				Mostrar "No tiene suficiente edad para disfrutar del beneficio de pension"
			SiNo si (sexo = "M" o sexo = "m" o sexo = "F" o sexo = "f" ) y (Cotizaciones < 750)
					Mostrar "No tiene suficientes cotizaciones"
				SiNo
					Mostrar "Tiene que colocar un genero valido (M para masculino o F para femenino)"
				FinSi
			Fin si 
		FinSi	
	FinSi
	Mostrar ""
	
FinAlgoritmo

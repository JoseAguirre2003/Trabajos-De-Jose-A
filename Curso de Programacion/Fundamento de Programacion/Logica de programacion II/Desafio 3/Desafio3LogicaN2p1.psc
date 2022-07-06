Algoritmo Desafio3LogicaN2Algoritmo1
	
	//Declaraciones de variables
	
	Definir sexo Como Caracter
	Definir Edad Como Entero
	
	//Entradas
	
	Mostrar ""
	Mostrar "Indique la edad: " Sin Saltar
	Leer Edad
	Mostrar "Indique el genero, M si es masculino y F si es femenino: " Sin Saltar
	Leer sexo
	Mostrar ""
	Mostrar "Presione cualquier tecla para continuar"
	Esperar Tecla
	Limpiar Pantalla
	
	//Proceso-Salidas 
	
	Mostrar ""
	Si (Edad >= 60) y (sexo = "M" o sexo = "m")
		Mostrar "La edad es: " Edad
		Mostrar "El genero es: Masculino"
		Mostrar "Es apto para disfrutar del benefico de pension"
	Sino si (Edad >= 55) y (sexo = "F" o sexo = "f")
			Mostrar "La edad es: " Edad
			Mostrar "El genero es: Femenino"
			Mostrar "Es apta para disfrutar del beneficio de pension"
		Sino si (Edad < 60 y (sexo = "M" o sexo = "m")) o (Edad < 55 y (sexo = "F" o sexo = "f"))
				Mostrar "No tiene suficiente edad para disfrutar del beneficio de pension"
			SiNo
				Mostrar "Tiene que colocar un genero valido (M para masculino o F para femenino)"
			Fin si 
		FinSi	
	FinSi
	Mostrar ""
	
FinAlgoritmo

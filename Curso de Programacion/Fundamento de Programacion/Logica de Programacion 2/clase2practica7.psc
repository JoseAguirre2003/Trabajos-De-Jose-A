Algoritmo clase2practica7
	
	//Declaraciones de variables
	Definir aux Como Caracter
	Definir Edad Como Entero
	Definir PorcDesc, GeneralEntrada, MontoDescuento, MontoPagar Como Real
	Definir estudiante Como Logico
	//Inicializacion
	GeneralEntrada = 10000
	//Entradas
	Mostrar "Ingrese la edad: " Sin Saltar
	Leer Edad
	Mostrar "Indique si es estudiante (S/N): " Sin Saltar
	Leer aux
	Limpiar Pantalla
	//Proceso 
	
	aux = Mayusculas(aux)
	
	Si aux = "S" Entonces
		estudiante = Verdadero
	SiNo
		estudiante = Falso
	FinSi
	
	Si Edad>0 Entonces
		Si Edad < 2
			PorcDesc = 100
		SiNo
			Si Edad <= 5
				PorcDesc = 50
			SiNo
				Si Edad <= 10
					Si estudiante
						PorcDesc = 25
					SiNo
						PorcDesc = 20
						
					FinSi
				SiNo
					Si Edad < 55
						Si estudiante
							PorcDesc = 25
						SiNo
							PorcDesc = 0
						FinSi
	                SiNo
						Si edad >= 55
							PorcDesc = 30
						FinSi
					FinSi
					
				FinSi
			FinSi
		FinSi
		
	FinSi
	
	MontoDescuento = GeneralEntrada * PorcDesc / 100
	
	MontoPagar = GeneralEntrada - MontoDescuento

	//Salida
	
	Mostrar "Su entrada tendra un descuento del: " PorcDesc "%"
	Mostrar "Es decir, se le descontara: " MontoDescuento
	Mostrar "Por lo que el monto a pagar por su entrada es: " MontoPagar
	Mostrar ""
	
FinAlgoritmo

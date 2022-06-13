Algoritmo clase3practica1
	
	//Declaraciones de variables
	
	Definir Genero Como Caracter
	Definir Edad Como Entero
	Definir MontoVendido, PorcAdic, BonoVentas, SueldoBase, Bono3eraEdad, sueldoFinal Como Real
	
	//Entradas
	
	Mostrar "Ingrese Edad del vendedor"
	Leer Edad
	Mostrar "Defina el genero del vendedor (M o F): "
	Leer Genero
	Mostrar "Ingrese sueldo base del vendedor: "
	Leer SueldoBase
	Mostrar "Ingrese el monto mensual de las ventas del vendedor: "
	Leer MontoVendido
	
	//Proceso
	
	si MontoVendido > 0 y MontoVendido <75000
			PorcAdic = 5
		Sino si MontoVendido >= 75000 y MontoVendido < 90000
				PorcAdic = 6
			SiNo si MontoVendido >= 90000 y MontoVendido < 200000
					PorcAdic = 7
				Sino si MontoVendido >= 200000 y MontoVendido < 300000
						PorcAdic = 6
					Sino si MontoVendido >= 300000 y MontoVendido < 1000000
							PorcAdic = 8
						Sino si MontoVendido >= 1000000 y MontoVendido < 1500000
								PorcAdic = 6
							SiNo si MontoVendido >= 1500000
									PorcAdic = 10
								FinSi
							FinSi
						Finsi	
					Fin si	
				Fin si	
			Fin si	
		FinSi	
	
	Genero=Mayusculas(Genero)
	
	Si Genero = "M" y Edad >= 60
		Bono3eraEdad = 40000
	Sino Si Genero = "F" y Edad >= 55
			Bono3eraEdad = 40000
		Finsi 	
	FinSi
	
	BonoVentas = MontoVendido*PorcAdic/100
	sueldoFinal = SueldoBase+BonoVentas+Bono3eraEdad
	
	//Salidas
	
	Mostrar "El sueldo base es: " SueldoBase
	Mostrar "El porcentaje de bono de ventas es: " PorcAdic "%"
	Mostrar "El monto de Bono de ventas es: " BonoVentas
	Mostrar "El Bono por 3era Edad es: " Bono3eraEdad
	Mostrar "El dueldo final del vendedor es: " sueldoFinal
	
	
FinAlgoritmo

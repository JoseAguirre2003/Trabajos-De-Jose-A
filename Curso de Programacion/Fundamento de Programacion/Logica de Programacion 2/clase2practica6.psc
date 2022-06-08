Algoritmo clase2practica6
	
	//Declaraciones de variables
	
	Definir precioPantalonA, precioPantalonB, precioPantalonc, PrecioUnitario Como Real
	Definir nombre, TipoPantalon Como Caracter
	Definir cantidad Como Entero
	Definir Valido Como Logico
	
	precioPantalonA = 80000
	precioPantalonB = 105000
	precioPantalonA = 250000
	
	Valido = Falso
	
	//Entradas
	
	Mostrar "Ingrese su nombre: " Sin Saltar
	Leer nombre
	Mostrar "Ingrese el tipo de pantalon a comprar, si es A, B o C: " Sin Saltar
	Leer TipoPantalon
	Mostrar "Ingrese la cantidad de pantalones a comprar: " Sin Saltar
	Leer cantidad
	
	//Proceso 
	
	Si TipoPantalon = "A"
		PrecioUnitario = precioPantalonA * cantidad
		Valido = Verdadero
	SiNo si TipoPantalon = "B"
			PrecioUnitario = precioPantalonB * cantidad
			Valido = Verdadero
		Sino si TipoPantalon = "C"
				PrecioUnitario = precioPantalonc * cantidad
				Valido = Verdadero
			SiNo
					Mostrar "Tiene que ingresar un tipo de pantalon valido"
					PrecioUnitario = 0
					Finsi
			FinSi
		FinSi
		
	
	TipoPantalon = Mayusculas(TipoPantalon)
	
	//Salidas
	
	Si Valido = Verdadero
		Mostrar "Estimado(a) " nombre
		Mostrar "Usted va comrar del tipo: " TipoPantalon
		Mostrar "La cantidad que va llevar: " cantidad
		Mostrar "El monto a pagar: " PrecioUnitario
	FinSi
	
FinAlgoritmo

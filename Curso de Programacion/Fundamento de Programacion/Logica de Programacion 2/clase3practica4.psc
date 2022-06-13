Algoritmo clase3practica4
	
	//Declaraciones de variables
	
	Definir Talla Como Caracter
	Definir Cantidad Como Entero
	Definir PrecioUnitaro, subTotal, descuento, PorcDesc, total Como Real
	Definir valido Como Logico
	
	Mostrar "Ingrese la talla a comprar (S, M, L, XL): " Sin Saltar
	Leer Talla
	Mostrar "Cantidad de prendas a comprar: " Sin Saltar
	Leer Cantidad
	
	//Proceso
	
	Segun Talla Hacer
		"s":
			PrecioUnitaro = 50000
			valido = Verdadero
		"m":
			PrecioUnitaro = 55000
			valido = Verdadero
		"l":
			PrecioUnitaro = 60000
			valido = Verdadero
		"xl":
			PrecioUnitaro = 65000
			valido = Verdadero
		De Otro Modo:
			Mostrar "Ha ingresado una talla de franela invalida"
			valido=Falso
	Fin Segun
	
	Talla=Minusculas(Talla)
	
	Si (Cantidad >= 6 y Cantidad <= 11)
		PorcDesc = 5
	SiNo
		Si (Cantidad >= 12 y Cantidad <= 24)
			PorcDesc = 10
		SiNo
			PorcDesc = 15
		FinSi
		
	FinSi
	
	subTotal=PrecioUnitaro*Cantidad
	descuento=subTotal*PorcDesc/100
	total=subTotal-descuento
	
	//Salidas
	
	Si valido = Verdadero
		Mostrar "La talla escigida fue: " Talla
		Mostrar "Precio unitario de cada franela es: " PrecioUnitaro
		Mostrar "Cantidad de franelas: " Cantidad
		Mostrar "Precio  Pre desceunto es: " subTotal
		Mostrar "Porcentaje de descuento es: " PorcDesc
		Mostrar "Monto de descuento es: " descuento
		Mostrar "Total a pagar: " total
	FinSi
	
FinAlgoritmo

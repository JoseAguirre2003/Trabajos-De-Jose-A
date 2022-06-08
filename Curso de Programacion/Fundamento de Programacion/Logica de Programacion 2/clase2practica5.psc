Algoritmo clase2practica5
	
	//Declaraciones de variables
	
	Definir IVA, Precio, SubTotal, PorcDescuento, descuento, SubTotalDescontado, MontoPagar Como Real
	Definir cantidad Como Entero
	
	//Entradas
	
	Mostrar "Ingrese el precio del producto: " Sin Saltar
	Leer Precio
	Mostrar "Ingrese la cantidad a llevar: " Sin Saltar
	Leer cantidad
	
	//Proceso
	
	SubTotal <- Precio * cantidad
	
	Si SubTotal > 50000
		PorcDescuento = 5
	SiNo
		PorcDescuento = 2
	FinSi
	
	Descuento = SubTotal * PorcDescuento / 100
	SubTotalDescontado = SubTotal - Descuento
	IVA = SubTotalDescontado * 0.16
	MontoPagar = SubTotalDescontado + IVA
	
	//Salidas
	
	Mostrar "El SubTotal a pagar es: " SubTotal
	Mostrar "Aplica un descuento  del: " PorcDescuento "%"
	Mostrar  "que corresponde a: " Descuento
	Mostrar "El SubTotal con el descuento es: " SubTotalDescontado
	Mostrar "El IVA es: " IVA
	Mostrar "Total a pagar es: " MontoPagar
	
FinAlgoritmo

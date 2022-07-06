Algoritmo Desafio3LogicaN2p4
	
	//Declaraciones de Variables
	
	Definir PrecioFranela, PrecioSubTotalSinIva, PrecioNeto, IVA, PorcDesc, PrecioTotal, MontoDescuento Como Real
	Definir Cantidad Como Entero
	Definir Descuento Como Logico
	
	//Inicializacion de variables
	
	PrecioFranela=100000
	
	//Entradas
	
	Mostrar ""
	Mostrar "El precio de las franelas es 100000Bs, indique la cantidad de franelas que desea comprar: " Sin Saltar
	Leer Cantidad
	Mostrar ""
	
	//Proceso 
	
	PrecioSubTotalSinIva=PrecioFranela*Cantidad
	IVA=PrecioSubTotalSinIva*0.16
	PrecioNeto=PrecioSubTotalSinIva+IVA
	
	Descuento=(PrecioNeto > 500000)
	
	Si NO Descuento
		PorcDesc=2
	SiNo
		PorcDesc=5
	FinSi
	
	MontoDescuento=PrecioNeto*PorcDesc/100
	PrecioTotal=PrecioNeto-MontoDescuento
	
	//Salidas
	
	Mostrar "El precio unitario de la franela es: " PrecioFranela
	Mostrar "La cantida a comprar es: " Cantidad
	Mostrar "El Monto (Sin descuento y sin IVA es: " PrecioSubTotalSinIva
	Mostrar "El Monto del IVA es: " IVA
	Mostrar "El Monto Neto (IVA incluido) es: " PrecioNeto
	Mostrar "El porcentaje de descueto es: " PorcDesc
	Mostrar "El monto del descuento es: " MontoDescuento
	Mostrar "El Monto Total a pagar es: " PrecioTotal
	Mostrar ""
	
FinAlgoritmo
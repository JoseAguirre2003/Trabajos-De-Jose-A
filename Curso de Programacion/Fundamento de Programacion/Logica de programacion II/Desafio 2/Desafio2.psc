Algoritmo sin_titulo
	
	//Declaraciones de variables
	
	Definir TipoBoleto Como Caracter
	Definir CantBoleto Como Entero
	Definir PrecioUnitario, PorcDesc, MontoDesc, PrecioTotal, BoletoV, BoletoP, BoletoG, PrecioSubTotal Como Real
	Definir Valido Como Logico
	
	BoletoV<-500000
	BoletoP<-300000
	BoletoG<-150000
	Valido=Verdadero
	
	//Entradas
	
	Mostrar ""
	Mostrar "Sea Bienvenido o Bienvenida al Club Milo´s Dance"
	Mostrar ""
	Mostrar "He aqui los costos de nuestros boletos: "
	Mostrar "Boleto VIP " BoletoV
	Mostrar "Boleto Preferencial " BoletoP
	Mostrar "Boleto General " BoletoG
	Mostrar ""
	Mostrar "Dependiendo del monto que vaya a cancelar, podra obtener un descuento de: "
	Mostrar "5% para montos menores o iguales a 400.000"
	Mostrar "13% para montos entre 400.000 y 1.400.000 o para montos entre 1.800.000 y 2.400.000"
	Mostrar "10% para montos iguales o mayores a 2.400.000"
	Mostrar ""
	Mostrar "Ingrese el tipo de boleto que va a adquirir, V para el Boleto VIP, P para el Boleto Preferencial y G para Boleto General" Sin Saltar
	Leer TipoBoleto
	Mostrar "Ingrese la cantidad de boletos" Sin Saltar
	Leer CantBoleto
	Mostrar ""
	Mostrar "Presiones cualquier tecla para continuar"
	Esperar Tecla
	Limpiar Pantalla
	
	//Proceso
	
	TipoBoleto<-Mayusculas(TipoBoleto)
	
	Si TipoBoleto="V"
		PrecioUnitario=BoletoV
		PrecioSubTotal=PrecioUnitario*CantBoleto
		Valido=Verdadero
	Sino si TipoBoleto="P"
			PrecioUnitario=BoletoP
			PrecioSubTotal=PrecioUnitario*CantBoleto
			Valido=Verdadero
		SiNo si TipoBoleto="G"
				PrecioUnitario=BoletoG
				PrecioSubTotal=PrecioUnitario*CantBoleto
				Valido=Verdadero
			SiNo 
				Mostrar "Debe ingresar algun tipo de Boleto Valido (V, P o G)"
				PrecioSubTotal=0
				Valido=Falso
			Fin Si
		Fin Si
	Fin Si
	
	Si PrecioSubTotal >= 0 Entonces
		Si PrecioSubTotal <= 400000
			PorcDesc = 5
		SiNo si PrecioSubTotal < 1400000  
				PorcDesc = 13
			Sino si PrecioSubTotal <= 1800000
					PorcDesc = 7
				SiNo si PrecioSubTotal < 2400000
						PorcDesc = 13
					SiNo si PrecioSubTotal >= 2400000
							PorcDesc = 10
						Fin Si
					Fin Si
				Fin Si	
			Fin Si
			
		Fin Si
	Fin Si
	
	MontoDesc = PrecioSubTotal*PorcDesc/100
	PrecioTotal = PrecioSubTotal-MontoDesc
	
	//Mostrar 
	
	Si Valido=Verdadero Entonces
		Mostrar ""
		Mostrar "Precio Unitario de su tipo de Boleto es: " PrecioUnitario
		Mostrar "Cantidad de boletos adquirida es: " CantBoleto
		Mostrar "Precio Pre Descuento: " PrecioSubTotal
		Mostrar "Porcentaje de descuento: " PorcDesc "%"
		Mostrar "Monto de Descuento: " MontoDesc
		Mostrar "Precio total a pagar: " PrecioTotal
		Mostrar ""
	Fin Si
		
FinAlgoritmo

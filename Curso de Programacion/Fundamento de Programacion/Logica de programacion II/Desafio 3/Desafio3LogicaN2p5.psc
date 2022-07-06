Algoritmo Desafio3LogicaN2p4
	
	//Como Caracter
	
	Definir Reclamo Como Caracter
	Definir saldo Como Real
	Definir  Eleccion Como Entero
	
	//Inicializacion
	
	saldo = 14.75
	
	// Entrada
	
	Mostrar ""
	Mostrar "Bienvenido"
	Mostrar ""
	Mostrar "Seleccione un numero del 1 al 5 para"
	Mostrar "1 para ver su saldo"
	Mostrar "2 para conocer su plan de servicio"
	Mostrar "3 para la activacion de planes"
	Mostrar "4 para eclamos y atencion al usuario"
	Mostrar "5 para salir"
	Mostrar ""
	Mostrar "Ingrese el numero de la opcion que desea "Sin Saltar
	Leer Eleccion
	Mostrar ""
	Mostrar "Presione cualquier tecla para continuar"
	Esperar Tecla
	Limpiar Pantalla
	
	//Salida
	
	Mostrar ""
	Segun Eleccion Hacer
		1:
			Mostrar "Su saldo es " saldo
			Mostrar ""
		2:
			Mostrar "Usted tiene el Plan Plus de 4Gb"
			Mostrar ""
		3:
			Mostrar "Los planes que disponemos son los siguienes:"
			Mostrar ""
			Mostrar "Plan plus de 4Gb que incluye 120 minutos, 200 sms y 4Gb por 3$"
			Mostrar "Plan plus de 10Gb que inluye 150 minutos, 250 sms y 10Gb por 8$"
			Mostrar "Plan Full Plus que te permite hacer llamadas, enviar mensajes y navegar hasta 5 gigabytes al mes, cancelando los megas, minutos y mensajes que hayas consumido"
			Mostrar ""
			Mostrar "Si esta interesado, llame al 811 para solicitar y activar alguno de nuestros planes"
			Mostrar ""
		4:
			Mostrar "Si presenta algun problema con nuestros servicios, por favor indiquenos el motivo de su reclamo"
			Mostrar "Motivos del reclamo" Sin Saltar
			Leer Reclamo
			Mostrar "Gracias por notificar, ya se le hara llegar el reclamo a atencion al cliente y le llamaremos en el transcurso de la tarde"
		5:	
			Limpiar Pantalla
		De Otro Modo:
			Mostrar "Por favor ingrese un numero que sea valido, solo se aceptan numeros del 1 al 5"
	Fin Segun
	
FinAlgoritmo

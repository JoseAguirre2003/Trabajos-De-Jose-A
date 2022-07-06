Algoritmo Desafio3LogicaN2p3
	
	//Declaraciones de variables
	
	Definir A, B Como Entero
	Definir A_Diferente_B, A_Mayor_B, A_Igual_B Como Logico
	
	//Inicializacion de variables
	
	A = Azar(21)
	B = Azar(21)
	A_Diferente_B = A <> B
	A_Mayor_B = A > B
	A_Igual_B = (A = B)
	
	//Proceso-Salida
	
	Si A_Diferente_B = Verdadero
		Mostrar "A que equivale a " A " es diferente de B que equivale a " B
	SiNo
		Mostrar "A que equivale a " A " es igual a B que equivale tambien a " B
	FinSi
	
	Mostrar ""
	
	Si A_Mayor_B = Verdadero
		Mostrar "A que equivale a " A " es Mayor a B que equivale a " B
	SiNo Si A_Igual_B = Verdadero
			Mostrar "A que equivale a " A " no es mayor es a B, si no que es igual a B que equivale tambien a " B
		SiNo
			Mostrar "A que equivale a " A " no es Mayor a B que equivale a " B
		FinSi
	FinSi
	
FinAlgoritmo
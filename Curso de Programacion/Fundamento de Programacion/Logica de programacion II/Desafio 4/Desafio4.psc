[1]Algoritmo Desafio4
	
	//Declaraciones de Variables
	
	Definir Materia Como Caracter
	Definir DesafioNota1, DesafioNota2, DesafioNota3, DesafioNota4, Notas, aux,i,Nota Como Entero
	
	Dimension Notas[4]
		
	//Entradas
	
	Mostrar ""
	Mostrar "Ingrese la Materia: " Sin Saltar
	Leer Materia
	Mostrar "Ingrese la nota del desafio 1: " Sin Saltar
	Leer DesafioNota1
	Mientras (DesafioNota1 < 0) o (DesafioNota1 > 100) Hacer
		Mostrar "Debe ingresar una nota con valor entre 0 y 100, vuelva a intentar"
		Mostrar "Ingrese la nota del desafio 1: " Sin Saltar
		Leer DesafioNota1
	Fin Mientras
	Mostrar "Ingrese la nota del desafio 2: " Sin Saltar
	Leer DesafioNota2
	Mientras (DesafioNota2 < 0) o (DesafioNota2 > 100) Hacer
		Mostrar "Debe ingresar una nota con valor entre 0 y 100, vuelva a intentar"
		Mostrar "Ingrese la nota del desafio 2: " Sin Saltar
		Leer DesafioNota2
	Fin Mientras
	Mostrar "Ingrese la nota del desafio 3: " Sin Saltar
	Leer DesafioNota3
	Mientras (DesafioNota3 < 0) o (DesafioNota3 > 100) Hacer
		Mostrar "Debe ingresar una nota con valor entre 0 y 100, vuelva a intentar"
		Mostrar "Ingrese la nota del desafio 3: " Sin Saltar
		Leer DesafioNota3
	Fin Mientras
	Mostrar "Ingrese la nota del desafio 4: " Sin Saltar
	Leer DesafioNota4
	Mientras (DesafioNota4 < 0) o (DesafioNota4 > 100) Hacer
		Mostrar "Debe ingresar una nota con valor entre 0 y 100, vuelva a intentar"
		Mostrar "Ingrese la nota del desafio 4: " Sin Saltar
		Leer DesafioNota4
	Fin Mientras
	Mostrar ""

	//Proceso-Salida
	
	Notas[1]=DesafioNota1
	Notas[2]=DesafioNota2
	Notas[3]=DesafioNota3
	Notas[4]=DesafioNota4
	
	Para i<-1 Hasta 4 Hacer
		Si Notas[i] >= 80
			Mostrar "La Nota esta aprobada, la posicion es " i
		FinSi
	Fin Para
	
	aux=1
	
	Para Cada Nota de Notas
		Si Nota < 80
			Mostrar "La nota esta repobada, la posicion es " aux
		FinSi
		aux=aux+1
	FinPara
	
FinAlgoritmo

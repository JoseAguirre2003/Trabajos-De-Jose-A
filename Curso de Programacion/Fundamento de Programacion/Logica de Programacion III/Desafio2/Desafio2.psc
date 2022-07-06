SubAlgoritmo CargarDatos(nombre Por Referencia, cedula Por Referencia, sexo Por Referencia)
	Definir repet Como Logico
	Repetir
		Mostrar "Ingrese el nombre del estidiante: " Sin Saltar
		Leer nombre
		Mostrar "Ingrese Cedula de Identidad el estudiante" Sin Saltar
		Leer cedula
		Mostrar "Indique el genero del estudiante (M para masculino, F para Femenino): " Sin Saltar
		Leer sexo
		Si (sexo = "M") o (sexo = "m") o (sexo = "F") o (sexo = "f")
			repet = Falso
		SiNo
			Mostrar "Debe ingresar un genero que sea valido, M para masculino o F para femenino"
			repet = Verdadero
		FinSi
	Hasta Que repet = Falso
FinSubAlgoritmo

SubAlgoritmo MostrarInfo(mensaje1, nombre, mensaje2, cedula, sexo)
	Mostrar mensaje1 nombre
	Mostrar mensaje2 cedula
	Si (sexo = "M") o (sexo = "m")
		Mostrar "El genero del estudiante es masculino"
	Sino si (sexo = "F") o (sexo = "f")
			Mostrar "El genero del estudiante es femenino"
		FinSi	
	FinSi
FinSubAlgoritmo


SubAlgoritmo CargarNotas(mensaje,nota Por Referencia)
	Definir noRepet Como Logico
	Repetir
		Mostrar mensaje Sin Saltar
		Leer nota
		Si (nota >= 0) y (nota <= 100)
			noRepet = Falso
		SiNo
			Mostrar "Tiene que poner un valor valido entre 0 y 100"
			noRepet = Verdadero
		FinSi
	Hasta Que noRepet = falso
FinSubAlgoritmo

SubAlgoritmo MostrarInfo2(mensaje, vari)
	Mostrar mensaje, vari
FinSubAlgoritmo

SubAlgoritmo Promedio(vari1, vari2, vari3, vari4, promedioN Por Referencia)
	promedioN = (vari1+vari2+vari3+vari4)/4
FinSubAlgoritmo

Algoritmo Desafio2
	Definir eleccion Como Entero
	Definir nombre1, nombre2, nombre3, nombre4, cedula1, cedula2, cedula3, cedula4, sexo1, sexo2, sexo3, sexo4 Como Caracter
	Definir nota1, nota2, nota3, nota4, promedioN Como Real
	
	Repetir
	Mostrar "Bienvenido, por favor seleccione una opcion del 1 al 5"	
	Mostrar "1. Para ingresar datos"
	Mostrar "2. Para Mostrar datos de alumnos"
	Mostrar "3. Para Registrar notas"
	Mostrar "4. Mostrar listado con las notas"
	Mostrar "5. Salir"
	Mostrar "Ingrese aqui su eleccion: "Sin Saltar
	Leer eleccion
	Mostrar ""
		Segun eleccion Hacer
			1:CargarDatos(nombre1, cedula1, sexo1)
				CargarDatos(nombre2, cedula2, sexo2)
				CargarDatos(nombre3, cedula3, sexo3)
				CargarDatos(nombre4, cedula4, sexo4)
				
			2:Mostrar ""
				MostrarInfo("El nombre del estudiante es ", nombre1,"La Cedula de identidad del estudiante es: ", cedula1, sexo1)
				Mostrar ""
				MostrarInfo("El nombre del estudiante es ", nombre2, "La Cedula de identidad del estudiante es: ", cedula2, sexo2)
				Mostrar ""
				MostrarInfo("El nombre del estudiante es ", nombre3, "La Cedula de identidad del estudiante es: ", cedula3, sexo3)
				Mostrar ""
				MostrarInfo("El nombre del estudiante es ", nombre4, "La Cedula de identidad del estudiante es: ",cedula4, sexo4)
				Mostrar ""
				
			3:CargarNotas("Ingrese la del primer estudiante nota: ", nota1)
				CargarNotas("Ingrese la del segundo estudiante nota: ", nota2) 
				CargarNotas("Ingrese la del tercer estudiante nota: ", nota3) 
				CargarNotas("Ingrese la del cuarto estudiante nota: ", nota4)
				Mostrar ""
			4:MostrarInfo("El nombre del estudiante es: ", nombre1,"La Cedula de identidad del estudiante es: ", cedula1, sexo1)
				MostrarInfo2("Y su nota promedio es: ", nota1)
				Mostrar ""
				MostrarInfo("El nombre del estudiante es: ", nombre2,"La Cedula de identidad del estudiante es: ", cedula2, sexo2)
				MostrarInfo2("Y su nota promedio es: ", nota2)
				Mostrar ""
				MostrarInfo("El nombre del estudiante es: ", nombre3,"La Cedula de identidad del estudiante es: ", cedula3, sexo3)
				MostrarInfo2("Y su nota promedio es: ", nota3)
				Mostrar ""
				MostrarInfo("El nombre del estudiante es: ", nombre4,"La Cedula de identidad del estudiante es: ", cedula4, sexo4)
				MostrarInfo2("Y su nota promedio es: ", nota4)
				Mostrar ""
				Promedio(nota1, nota2, nota3, nota4, promedioN)
				MostrarInfo2("El promedio de la seccion es: ", promedioN)
			5: Mostrar "Gracias por usar nuestro servicio"	
			De Otro Modo:
				Mostrar "nada"
		Fin Segun
	Hasta Que eleccion = 5 
	

FinAlgoritmo

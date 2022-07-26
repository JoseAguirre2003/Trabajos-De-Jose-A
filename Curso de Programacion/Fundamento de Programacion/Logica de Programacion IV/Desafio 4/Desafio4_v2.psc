//InicializarMatriz de Caracter

SubAlgoritmo InicializarMatrizCaracter(row, column, matrix Por Referencia)
	
	Definir i, j Como Entero
	
	Para i = 1 Hasta row
		Para j = 1 hasta column
			matrix[i, j] = ""
		FinPara
	FinPara
	
FinSubAlgoritmo

//Inicializar Matriz Numerica

SubAlgoritmo InicializarMatrizNumerica(row, column, matrix Por Referencia)
	
	Definir i, j Como Entero
	
	Para i = 1 Hasta row
		Para j = 1 hasta column
			matrix[i, j] = 0
		FinPara
	FinPara
	
FinSubAlgoritmo

//Solicitar Informacion

SubAlgoritmo SolicitarInfo(mensaje, dato Por Referencia)
	Mostrar mensaje
	Leer dato
FinSubAlgoritmo

//Cargar Matriz de Alumnos

SubAlgoritmo CargaDeMatrizAlumnos(row, matrix Por Referencia)
	
	Definir i, j Como Entero
	Definir cedula Como Caracter
	Definir CIYaExiste, CIVacio, CIValida, NombreValido Como Logico
	
	Para i = 1 Hasta row
		
		Repetir
			NombreValido = Verdadero
			Mostrar "Ingrese el nombre del " i "° alumno: " Sin Saltar
			Leer matrix[i,1]
			Si matrix[i,1] = ""
				NombreValido = Falso
				Mostrar "El Nombre debe tener al menos un caracter, vuelva a intentar"
			FinSi
		Hasta Que NombreValido = Verdadero
		
		//Comprobando si la CI es Valida
		
		Repetir
			CIYaExiste = Falso
			CIVacio = Falso
			CIValida = Verdadero
			Mostrar "Ingrese el numero de Cedula del " i "° alumno: " Sin Saltar
			Leer cedula
			Para j = 1 hasta row 
				Si matrix[j,2] = cedula
					CIYaExiste = Verdadero
				FinSi
			FinPara
			Si cedula = ""
				CIVacio = Verdadero
			FinSi
			Si CiVacio = Verdadero
				CIValida=Falso
				CIYaExiste=Falso
				Mostrar "La Cedula debe tener al menos un caracter"
			FinSi
			Si CIYaExiste = Verdadero
				Mostrar "La Cedula ya existe, porfavor vuelva a intentar"
			Sino
				matrix[i,2] = cedula
			FinSi
		Hasta Que (CIYaExiste = Falso) y (CIValida = Verdadero)
		
	FinPara
	
FinSubAlgoritmo

//Cargar Matriz de Notas

SubAlgoritmo CargaDeMatrizNotas(row, column, matrix Por Referencia)
	
	Definir i, j Como Entero
	
	Para i = 1 Hasta row
		Para j = 1 hasta column
			matrix[i, j] = Aleatorio(0, 100)
		FinPara
	FinPara
	
FinSubAlgoritmo

//Mostrar  Informacion

SubAlgoritmo MostrarInfo(matrix1, matrix2, row, column)
	
	Definir i, j Como Entero
	
	Para i = 1 hasta row
		Mostrar "Alumno " i "° : " matrix1[i, 1]
		Mostrar "C.I : " matrix1[i, 2]
		Para j = 1 hasta column
			Mostrar "Nota " j "° : " matrix2[i, j]
		FinPara
		Mostrar ""
	FinPara
	
FinSubAlgoritmo

//Funcion para sacar Promedio

Funcion promedio <- CalcPromedioDeMatriz(row, column, matrix)
	
	Definir i, j, contador Como Entero
	Definir acum Como Real
	Definir promedio Como Real
	
	acum = 0
	contador = 0
	Para i = 1 Hasta row
		Para j = 1 hasta column
			acum = acum + matrix[i, j]
			contador = contador + 1
		FinPara
	FinPara
	promedio = acum / contador
	
FinFuncion

//Funcion para sacar mayor o menor

Funcion datoDeseado <- saberMayOMen(eleccion, row, column, matrix, matrix2)
	
	Definir nombreMayor, nombreMenor, cedulaMayor, cedulaMenor Como Caracter
	Definir i, j Como Entero
	Definir datoDeseado, varMayor, varMenor Como Real
	
	varMayor = matrix[1,1]
	nombreMayor = matrix2[1,1]
	cedulaMayor = matrix2[1,2]
	
	varMenor = matrix[1,1]
	nombreMenor = matrix2[1,1]
	cedulaMenor = matrix2[1,2]
	
	datoDeseado = 0
	
	Si (eleccion = 5) 
		Para i = 1 hasta row
			Para j = 1 Hasta column
				Si matrix[i,j] > varMayor Entonces
					varMayor = matrix[i,j]
					nombreMayor = matrix2[i,1]
					cedulaMayor = matrix2[i,2]
					datoDeseado = varMayor
				FinSi
			FinPara
		FinPara
		Mostrar "La nota pertenece a " nombreMayor
		Mostrar "La de cedula " cedulaMayor
	Sino Si (eleccion = 6)
			Para i = 1 hasta row
				Para j = 1 Hasta column
					Si matrix[i,j] < varMenor Entonces
						varMenor = matrix[i,j]
						nombreMenor = matrix2[i,1]
						cedulaMenor = matrix2[i,2]
						datoDeseado = varMenor
					FinSi
				FinPara
			FinPara
			Mostrar "La nota pertenece a " nombreMenor
			Mostrar "La de cedula " cedulaMenor
		FinSi
	FinSi
	
FinFuncion

//Funcion para buscar

Funcion posicionBuscada <- BuscarDato(row, matrix)
	
	Definir i, j, posicionBuscada Como Entero
	Definir encontrado, repet, repet2 Como Logico
	Definir datoBuscado, eleccion Como Caracter
	
	encontrado = Falso
	repet = Verdadero
	repet2 = Falso
	
	Mientras repet = Verdadero Hacer
		mostrar "Ingrese la Cedula que buscada"
		Leer datoBuscado
		Para i = 1 hasta row
			Si datoBuscado = matrix[i,2]
				Mostrar "La cedula " matrix[i,2] " fue encontrada"
				Mostrar "La Cedula pertenece a " matrix[i,1]
				encontrado = Verdadero
				repet = Falso
				posicionBuscada = i
			FinSi	
		FinPara
		Si encontrado = Falso
			Mostrar "No se ha encontrado la cedula " datoBuscado
			Repetir
				Mostrar "¿Desea volver a intentar? S para si, N para No"
				Leer eleccion
				eleccion = Mayusculas(eleccion)
				Si eleccion = "S"
					repet = Verdadero
					repet2 = Falso
				Sino Si eleccion = "N"
						repet = Falso
						repet2 = Falso
					SiNo
						Mostrar "Debe ingresar una eleccion valida, S o N"
						repet2 = Verdadero
					FinSi	
				FinSi
			Hasta Que repet2 = Falso
			
		FinSi
	Fin Mientras
	
FinFuncion

//Promedio de una Fila

Funcion promedio <- CalcPromedioDeFila(dato, row, matrix)
	
	Definir i, j, contador Como Entero
	Definir acum, promedio Como Real
	
	acum = 0
	contador = 0
	Para i = 1 Hasta row
		acum = acum + matrix[dato, i]
		contador = contador + 1
	FinPara
	promedio = acum / contador
	
FinFuncion

//Modulo Promedio de un Estudiante

SubAlgoritmo PromedioEstudiante(row, matrix1, matrix2)
	
	Definir posicion Como Entero
	Definir promedio Como Real
	
	promedio = 0
	
	posicion <- BuscarDato(row, matrix1)
	
	Si posicion <> 0
		promedio <- CalcPromedioDeFila(posicion, row, matrix2)
		Si promedio >= 80
			Mostrar "El alumno " matrix1[posicion, 1] " de cedula " matrix1[posicion, 2] " a aprobado con un promedio de " promedio
			Mostrar "El alumno puede optar por certificado de conocimiento"
		SiNo
			Mostrar "El alumno " matrix1[posicion, 1] " de cedula " matrix1[posicion, 2] " a reprobado, pues solo consiguio un promedio de " promedio
		FinSi
	SiNo
		Mostrar "Busqueda cancelada"
	FinSi
	
	
	
FinSubAlgoritmo

//Cierre Elegante

SubAlgoritmo CierreElegante()
	
	Mostrar ""
	Mostrar "Presione cualquier tecla para continuar"
	Esperar Tecla
	Limpiar Pantalla
	
FinSubAlgoritmo

Algoritmo Desafio4_v2
	
	//Declaraciones de Variables
	
	Definir materiaNomb, alumnos, materiaCode Como Caracter
	Definir MenuOpc, cantAlum, posicionBuscada Como Entero
	Definir notas, promedio, datoDeseado Como Real
	Definir MatrizAlumCargada, MatrizNotasCargada, cantidadValida, nombreMateriaValido, codigoMateriaValido Como Logico
	
	//Inicialización de variables
	
	MatrizAlumCargada = Falso
	MatrizNotasCargada = Falso
	cantidadValida = Falso
	nombreMateriaValido = Falso
	codigoMateriaValido = Falso
	
	//Entradas-Procesos-Salidas
	
	Mostrar "BIENVENIDO AL SISTEMA :)"
	Mostrar ""
	Mostrar "Por favor"
	
	Repetir
		SolicitarInfo("Ingrese el nombre de la materia", materiaNomb)
		Si materiaNomb = ""
			nombreMateriaValido = Falso
			Mostrar "El nombre de la materia debe tener al menos un caracter, vuelva a intentar"
		Sino
			nombreMateriaValido = Verdadero
		FinSi
	Hasta Que nombreMateriaValido = Verdadero
	
	Repetir
		SolicitarInfo("Ingrese el codigo de la materia", materiaCode)
		Si materiaCode = ""
			codigoMateriaValido = Falso
			Mostrar "El codigo debe tener al menos un caracter, vuelva a intentar"
		SiNo
			codigoMateriaValido = Verdadero
		FinSi
	Hasta Que codigoMateriaValido = Verdadero
	
	Repetir
		SolicitarInfo("Ingrese cantidad de alumnos de la seccion", cantAlum)
		Si cantAlum > 0
			cantidadValida = Verdadero
		SiNo
			cantidadValida = Falso
			Mostrar "La cantidad de alumnos debe ser superior a 0, vuelva a intentar"
		FinSi
	Hasta Que cantidadValida = Verdadero
	
	CierreElegante()
	
	//Dimensionando e inicializando el Arreglo
	
	Dimension alumnos[cantAlum, 2]
	Dimension notas[cantAlum, 5]
	
	InicializarMatrizCaracter(cantAlum, 2, alumnos)
	InicializarMatrizNumerica(cantAlum, 5, notas)
	
	Repetir
		Mostrar "Elija una opcion entre 1 y 8"
		Mostrar "1 - Parar Cargar los Datos de los Alumnos de la Seccion"
		Mostrar "2 - Para Cargar las notas de los Alumnos de la Seccion"
		Mostrar "3 - Ver las Notas y Nombres de los alumnos de la Seccion"
		Mostrar "4 - Para saber el promedio de la Seccion"
		Mostrar "5 - Ver la mayor nota de todas las actividades"
		Mostrar "6 - Ver la menor nota de todas las actividades"
		Mostrar "7 - Comprobar si un alumno es candidato a certificado de conocimiento"
		Mostrar "8 - Salir"
		Leer MenuOpc
		Limpiar Pantalla
		Segun MenuOpc Hacer
			1:
				CargaDeMatrizAlumnos(cantAlum, alumnos)
				MatrizAlumCargada = Verdadero
				CierreElegante()
			2:
				CargaDeMatrizNotas(cantAlum, 5, notas)
				MatrizNotasCargada = Verdadero
				Mostrar "Cargando Matriz..."
				Esperar 2 Segundos
				Mostrar ""
				Mostrar "Matriz Cargada correctamente!!"
				CierreElegante()
			3:
				Si (MatrizAlumCargada = Verdadero) y (MatrizNotasCargada = Verdadero)
					
					Mostrar materiaNomb " - " materiaCode ": "
					Mostrar ""
					MostrarInfo(alumnos, notas, cantAlum, 5)
					
				SiNo Si (MatrizAlumCargada = Falso) y (MatrizNotasCargada = Verdadero)
						Mostrar "La Informacion de los alumnos no esta cargada, por favor carguelos con la opcion 1 primero y vuelva a intentar"
					Sino Si (MatrizAlumCargada = Verdadero) y (MatrizNotasCargada = Falso)
							Mostrar "Las nota de los alumnos no estan cargadas, Por favor carguelas con la opcion 2 primero y vuelva a intentar"
						Sino Si (MatrizAlumCargada = Falso) y (MatrizNotasCargada = Falso)
								Mostrar "Ni la informacion de los alumnos, ni las notas estan cargadas, Por favor cargue la informacion con la opcion 1 y 2 y vuelva a intentar"
							FinSi	
						FinSi	
					FinSi
				FinSi
				CierreElegante()
			4:
				Si (MatrizNotasCargada = Verdadero)
					
					promedio <- CalcPromedioDeMatriz(cantAlum, 5, notas)
					Mostrar "El promedio de la seccion en la materia de " materiaNomb " - " materiaCode " es de: " promedio 
					
				SiNo
					Mostrar "Las nota de los alumnos no estan cargadas, Por favor carguelas con la opcion 2 primero y vuelva a intentar"
				FinSi
				CierreElegante()
			5:
				Si (MatrizAlumCargada = Verdadero) y (MatrizNotasCargada = Verdadero)
					
					datoDeseado <- saberMayOMen(MenuOpc, cantAlum, 5, notas, alumnos)
					Mostrar "La Mayor nota es: " datoDeseado
					
				SiNo Si (MatrizAlumCargada = Falso) y (MatrizNotasCargada = Verdadero)
						Mostrar "La Informacion de los alumnos no esta cargada, por favor carguelos con la opcion 1 primero y vuelva a intentar"
					Sino Si (MatrizAlumCargada = Verdadero) y (MatrizNotasCargada = Falso)
							Mostrar "Las nota de los alumnos no estan cargadas, Por favor carguelas con la opcion 2 primero y vuelva a intentar"
						Sino Si (MatrizAlumCargada = Falso) y (MatrizNotasCargada = Falso)
								Mostrar "Ni la informacion de los alumnos, ni las notas estan cargadas, Por favor cargue la informacion con la opcion 1 y 2 y vuelva a intentar"
							FinSi	
						FinSi	
					FinSi
				FinSi
				CierreElegante()
			6:
				Si (MatrizAlumCargada = Verdadero) y (MatrizNotasCargada = Verdadero)
					
					datoDeseado <- saberMayOMen(MenuOpc, cantAlum, 5, notas, alumnos)
					Mostrar "La Menor nota es: " datoDeseado
					
				SiNo Si (MatrizAlumCargada = Falso) y (MatrizNotasCargada = Verdadero)
						Mostrar "La Informacion de los alumnos no esta cargada, por favor carguelos con la opcion 1 primero y vuelva a intentar"
					Sino Si (MatrizAlumCargada = Verdadero) y (MatrizNotasCargada = Falso)
							Mostrar "Las nota de los alumnos no estan cargadas, Por favor carguelas con la opcion 2 primero y vuelva a intentar"
						Sino Si (MatrizAlumCargada = Falso) y (MatrizNotasCargada = Falso)
								Mostrar "Ni la informacion de los alumnos, ni las notas estan cargadas, Por favor cargue la informacion con la opcion 1 y 2 y vuelva a intentar"
							FinSi	
						FinSi	
					FinSi
				FinSi
				CierreElegante()
			7:
				Si (MatrizAlumCargada = Verdadero) y (MatrizNotasCargada = Verdadero)
					
					PromedioEstudiante(cantAlum, alumnos, notas)
					
				SiNo Si (MatrizAlumCargada = Falso) y (MatrizNotasCargada = Verdadero)
						Mostrar "La Informacion de los alumnos no esta cargada, por favor carguelos con la opcion 1 primero y vuelva a intentar"
					Sino Si (MatrizAlumCargada = Verdadero) y (MatrizNotasCargada = Falso)
							Mostrar "Las nota de los alumnos no estan cargadas, Por favor carguelas con la opcion 2 primero y vuelva a intentar"
						Sino Si (MatrizAlumCargada = Falso) y (MatrizNotasCargada = Falso)
								Mostrar "Ni la informacion de los alumnos, ni las notas estan cargadas, Por favor cargue la informacion con la opcion 1 y 2 y vuelva a intentar"
							FinSi	
						FinSi	
					FinSi
				FinSi
				CierreElegante()
			8: 
				Limpiar Pantalla
				Mostrar "Gracias por usar nuestro sistema, que tenga un buen dia"
				Mostrar "Adios"
			De Otro Modo:
				Mostrar "Debe elegir una opcion entre 1 y 8, por favor vuelva a intentar"
		Fin Segun
	Hasta Que MenuOpc = 8
	
FinAlgoritmo
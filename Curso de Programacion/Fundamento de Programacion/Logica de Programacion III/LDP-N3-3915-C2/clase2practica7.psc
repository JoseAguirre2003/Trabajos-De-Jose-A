SubAlgoritmo solicitarInformacion(mensaje, var Por Referencia)
	Mostrar mensaje Sin Saltar
	Leer var
FinSubAlgoritmo

SubAlgoritmo menu()
	Mostrar "Bienvenido al sistema"
	Mostrar "Seleccione la opcion que requiera: "
	Mostrar "1. Registrar informacion"
	Mostrar "2. Mostrar monto inicial"
	Mostrar "3. Mostrar cuotas mensuales"
	Mostrar "4. Salir"
FinSubAlgoritmo

SubAlgoritmo ingresarDatos(name Por Referencia, course Por Referencia, price Por Referencia)
	solicitarInformacion("Ingrese su nombre: ", name)
	solicitarInformacion("Ingrese el nombre del curso: ", course)
	solicitarInformacion("Ingrese el costo total del curso: ", price)
FinSubAlgoritmo

SubAlgoritmo calcularPorcentaje(start, percentage, value Por Referencia)
	value = start * percentage / 100
FinSubAlgoritmo

SubProceso calcularCuotasMenosInicial(total, start, months, value Por Referencia)
	Repetir
		Si months > 0
			value = (total - start)/months
		SiNo
			Mostrar "El divisor no puede ser ni cero ni negativo"
		FinSi
	Hasta Que months > 0
FinSubProceso


SubAlgoritmo mostrarInformacion(mensaje, var)
	Mostrar mensaje var
FinSubAlgoritmo

SubAlgoritmo cierreModulo()
	Mostrar ""
	Mostrar "Presione una tecla para continuar..."
	Esperar Tecla
	Limpiar Pantalla
FinSubAlgoritmo

Algoritmo clase2practica7
	//Declaraciones de variables
	Definir nombre, curso Como Caracter
	Definir opcMenu como Entero
	Definir costoCurso, inicial, cuotas como Real
	//Inicializaciones de variables
	//Entradas
	//Procesos
	//CONSTRUICCION DEL MENU
	Repetir
		menu()
		Leer opcMenu
		Segun opcMenu Hacer
			1:
				ingresarDatos(nombre, curso, costoCurso)
				cierreModulo()
			2:
				calcularPorcentaje(costoCurso, 20, inicial)
				mostrarInformacion("El costo inicial del curso es: ", inicial)
				cierreModulo()
			3:
				calcularCuotasMenosInicial(costoCurso, inicial, 24, cuotas)
				mostrarInformacion("Las cuotas mensuales son: ", cuotas)
				cierreModulo()
			4:
				Mostrar "Hasta Luego!!!"
			De Otro Modo:
				Mostrar "Ha ingresado una opcion invalida"
				Mostrar "Debe ser una opcion entre 1-4"
				cierreModulo()
		Fin Segun
	Hasta Que (opcMenu = 4) 
	
	
	//Salidas
FinAlgoritmo

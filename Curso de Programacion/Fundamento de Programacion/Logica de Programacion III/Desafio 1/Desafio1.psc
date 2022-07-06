SubAlgoritmo SolicitarInformacion(mensaje, vari Por Referencia)
	Mostrar mensaje Sin Saltar
	Leer vari
FinSubAlgoritmo

SubAlgoritmo Promedio(var1, var2, var3, var4, promedioT Por Referencia, N Por Referencia)
	promedioT=(var1 + var2 + var3 + var4) / N
FinSubAlgoritmo

SubAlgoritmo Ganancia(promedioT, porc, MontoGanancia Por Referencia)
	MontoGanancia=promedioT*porc/100 
FinSubAlgoritmo

SubAlgoritmo MostrarInformacion(mensaje, vari, Moneda)
	Mostrar mensaje vari Moneda
FinSubAlgoritmo

Algoritmo Desafio1
	Definir mensaje, Moneda Como Caracter
	Definir total1, total2, total3, total4, promedioT, porc, MontoGanancia Como Real
	Definir N Como Entero
	N = 4
	porc = 30
	SolicitarInformacion("Indique el total de ventas del mes de la Sucursal 1: ", total1)
	SolicitarInformacion("Indique el total de ventas del mes de la Sucursal 2: ", total2)
	SolicitarInformacion("Indique el total de ventas del mes de la Sucursal 3: ", total3)
	SolicitarInformacion("Indique el total de ventas del mes de la Sucursal 4: ", total4)
	Promedio(total1, total2, total3, total4, promedioT, N)
	Ganancia( promedioT, porc, MontoGanancia)
	MostrarInformacion("El Promedio de ventas del mes en todas las sucursales es: ", promedioT, "Bs")
	MostrarInformacion("La ganancia es: ", MontoGanancia, "Bs")
FinAlgoritmo
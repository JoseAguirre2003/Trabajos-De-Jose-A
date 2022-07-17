//Modulo para cargar entradas 

Subproceso leerDat(nombVend Por Referencia, cantVend Por Referencia,totalVtas Por Referencia)
	Mostrar "¿Nombre del Empleado?" Sin Saltar
Leer nombVend
	Mostrar "¿Cantidad de autos vendidos?" Sin Saltar
Leer cantVend
	Mostrar "¿Monto total de ventas?" Sin Saltar
Leer totalVtas 
FinSubProceso

//Modulo para multiplicar 2 factores

Funcion resMultip<-funcMultip2Fact(factor1,factor2)
	
	Definir resMultip Como Real
	
resMultip=factor1*factor2
FinFuncion

//Modulo para determinar la comision del vendedor 

Subproceso detCom(cantAV,mtoTVtas,comTotal Por Referencia)
	
	Definir comAV, comTVtas Como Real
	
	comAV=funcMultip2Fact(CantAV,100000)
	comTVtas=funcMultip2Fact(mtoTVtas,0.18)
	comTotal=comAV+comTVtas
	
FinSubProceso

//Modulo para determinar el salario final

SubProceso calcSalario(Com_total,SalNeto Por Referencia)
	
	SalNeto=700000+Com_total
	
FinSubProceso

//Modulo para mostrar la informacion del vendedor

SubProceso mostrarSalidas(Nomb_Vend,SalNeto)
	
	Mostrar Nomb_Vend " debe percibir como salario neto " SalNeto " Bs."
	
FinSubProceso

//Algoritmo Principal

Algoritmo Buenas_practicas_desafio2_Arreglado
	
	//Declaraciones de Variables
	
	Definir nombVend Como Caracter
	Definir cantAV Como Entero
	Definir mtoTVtas, comTotal, salNeto Como Real
	
	//Entradas
	
	leerDat(nombVend,cantAV,mtoTVtas)
	
	//Procesos
	
	detCom(cantAV,mtoTVtas,comTotal)
	calcSalario(comTotal,SalNeto)
	
	//Salidas
	
	mostrarSalidas(nombVend,salNeto)
	
FinAlgoritmo
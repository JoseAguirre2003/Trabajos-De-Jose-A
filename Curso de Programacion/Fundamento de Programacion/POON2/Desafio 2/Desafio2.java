clase Alquiler
    Publico Definir NombreCliente Como Caracter
    Publico Definir DiasAlquiler Como Entero
    Privado Definir PagoInicial Como Real 
    Privado Definir MontoTotal Como Real
    Publico Definir CuotasAPagar Como Entero
    Privado Definir PagoDiarioNuev Como Real

    Metodo Leer_Dato(mensaje, vari)
        Mostrar mensaje Sin Saltar
        Leer vari
    FinMetodo

    Metodo Determ_MontoTotal(vari)
        MontoTotal = vari * DiasAlquiler
    FinMetodo
    
    Metodo Determ_PagoInicial()
        Definir PorcPagoIni Como Real
        PorcPagoIni = 35
        PagoInicial = MontoTotal * PorcPagoIni / 100
    FinMetodo

    Metodo Determ_CuotasAPagar()
        CuotasAPagar = DiasAlquiler - 1
    FinMetodo
    
    Metodo Determ_PagoDiarioNuev()
        PagoDiarioNuev = (MontoTotal - PagoInicial) / CuotasAPagar
    FinMetodo
    
    Metodo Mostrar_Dato (mensaje, vari)
        Mostrar mensaje vari
    FinMetodo    

FinClase

clase Carro
    Publico Definir modelo Como Caracter
    Privado Definir precio Como Real

    Metodo Leer_Dato(mensaje, vari)
        Mostrar mensaje Sin Saltar
        Leer vari
    FinMetodo

    Metodo Mostrar_Dato(mensaje, vari)
        Mostrar mensaje vari
    FinMetodo

FinClase

Algoritmo

    Definir auto Como Carro
    Definir alquila Como Alquiler

    auto = nuevo Carro()
    alquila = nuevo Alquiler()
    
    //Entradas

    alquila.Leer_Dato("Ingrese el nombre del cliente: ", NombreCliente)
    auto.Leer_Dato("Ingrese el modelo que desea alquilar: ", modelo)
    auto.Leer_Dato("Ingrese el precio del alquiler de un dia del auto: ", precio)
    alquila.Leer_Dato("Ingrese la cantidad de dias de alquiler: ", DiasAlquiler)
   
    //Procesos

    alquila.Determ_MontoTotal(auto.precio)
    alquila.Determ_PagoInicial()
    alquila.Determ_CuotasAPagar()
    alquila.Determ_PagoDiarioNuev()

    //Salidas

    alquila.Mostrar_Dato("El Nombre del cliente es: ", NombreCliente)
    auto.Mostrar_Dato("El Modelo escogido es: ", modelo)
    auto.Mostrar_Dato("El Costo diario del vehico es: ", precio)
    alquila.Mostrar_Dato("La cantidad de dias de alquiler es: ", DiasAlquiler)
    alquila.Mostrar_Dato("El Monto total por el alquiler es: ", MontoTotal)
    alquila.Mostrar_Dato("El monto inicial el cual es un 35% del monto total es: ", PagoInicial)
    alquila.Mostrar_Dato("La cuotas diarias a pagar son: ", CuotasAPagar)
    alquila.Mostrar_Dato("Cada cuota tiene un costo de: ", PagoDiarioNuev)

Fin Algoritmo
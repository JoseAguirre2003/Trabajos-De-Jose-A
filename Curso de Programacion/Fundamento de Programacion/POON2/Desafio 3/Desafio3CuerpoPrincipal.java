Algoritmo

    Definir codigo1, codigo2, pilotNomb1, pilotNomb2, pilotSex1, pilotSex2, destinoV1, destinoV2 Como Caracter 
    Definir edad1, edad2, capPasajeros1, capPasajeros2, horaDeSalida1, horaDeSalida2, cantPasajeros1, cantPasajeros2 Como Entero
    Definir capCombustible1, capCombustible2, precio1, precio2, montoTotalVendido Como Real
    Definir vuelo1, vuelo2 Como Vuelo
    Defnir sexoValido, horaValida, capacidadValida, avionLleno Como Logico

    sexoValido = Verdadero
    horaValida = Verdadero
    capacidadValida = Verdadero

    //Instanciacion y Entradas de Vuelo 1

    vuelo1 = nuevo Vuelo()

    Mostrar "Ingrese nombre del piloto: " Sin Saltar
    Leer pilotNomb1
    Mostrar "Ingrese la edad del piloto: " Sin Saltar
    Leer edad1
    
    Repetir

        Mostrar "Ingrese el genero del piloto, M para Masculino, F para Femenino: " Sin Saltar
        Leer pilotSex1

        Si (pilotSex1 = "M") o (pilotSex1 = "m") o (pilotSex1 = "F") o (pilotSex1 = "f") Entonces
            sexoValido = Verdadero
        Sino
            sexoValido = Falso
            Mostrar "Tiene que poner un sexo valido M o F, por favor vuelva a intentar"
        FinSi

    Hasta Que sexoValido = Verdadero

    Mostrar "Ingrese el codigo del avion: " Sin Saltar
    Leer codigo1
    Mostrar "Ingrese la capacidad de pasajeros del avion: " Sin Saltar
    Leer capPasajeros1
    Mostrar "Ingrese la capacidad de combustible del avion: " Sin Saltar
    Leer capCombustible1
    Mostrar "Ingrese la ciudad de destino del vuelo: " Sin Saltar
    Leer destinoV1

    Repetir

        Mostrar "Ingrese la hora de salida con un valor entre el 0 y 24 "
        Leer horaDeSalida1

        Si (horaDeSalida1 > 0) y (horaDeSalida1 < 24) Entonces
            horaValida = Verdadero
        Sino
            horaValida = Falso
            Mostrar "Tiene que ingresar un valor entre el 0 y 24, por favor vuelva a intentar" 
        FinSi

    Hasta Que horaValida = Verdadero

    Repetir

        Mostrar "Ingrese la cantidad de pasajeros que viajaron, la capacidad maxima del avion es " capPasajeros1
        Leer cantPasajeros1
        Si (cantPasajeros1 <= capPasajeros1)
            capacidadValida = Verdadero
        Sino 
            capacidadValida = Falso
            Mostrar "El avion puede albergas mas pasajeros que si capacidad, por favor ingrese una cantidad de pasajeros menor, la capacidad maxima es " capPasajeros1
        FinSi

    Hasta Que capacidadValida = Verdadero
    

    vuelo2 = nuevo Vuelo()

    //Instanciacione y Entradas de Vuelo 2

    Mostrar "Ingrese nombre del piloto: " Sin Saltar
    Leer pilotNomb2
    Mostrar "Ingrese la edad del piloto: " Sin Saltar
    Leer edad2
    
    Repetir

        Mostrar "Ingrese el genero del piloto, M para Masculino, F para Femenino: " Sin Saltar
        Leer pilotSex2

        Si (pilotSex2 = "M") o (pilotSex2 = "m") o (pilotSex2 = "F") o (pilotSex2 = "f") Entonces
            sexoValido = Verdadero
        Sino
            sexoValido = Falso
            Mostrar "Tiene que poner un sexo valido M o F, por favor vuelva a intentar"
        FinSi

    Hasta Que sexoValido = Verdadero

    Mostrar "Ingrese el codigo del avion: " Sin Saltar
    Leer codigo2
    Mostrar "Ingrese la capacidad de pasajeros del avion: " Sin Saltar
    Leer capPasajeros2
    Mostrar "Ingrese la capacidad de combustible del avion: " Sin Saltar
    Leer capCombustible2
    Mostrar "Ingrese la ciudad de destino del vuelo: " Sin Saltar
    Leer destinoV2

    Repetir

        Mostrar "Ingrese la hora de salida con un valor entre el 0 y 24 "
        Leer horaDeSalida2

        Si (horaDeSalida2 > 0) y (horaDeSalida2 < 24) Entonces
            horaValida = Verdadero
        Sino
            horaValida = Falso
            Mostrar "Tiene que ingresar un valor entre el 0 y 24, por favor vuelva a intentar" 
        FinSi

    Hasta Que horaValida = Verdadero

    Repetir

        Mostrar "Ingrese la cantidad de pasajeros que viajaron, la capacidad maxima del avion es " capPasajeros2
        Leer cantPasajeros2
        Si (cantPasajeros2 <= capPasajeros2)
            capacidadValida = Verdadero
        Sino 
            capacidadValida = Falso
            Mostrar "El avion puede albergas mas pasajeros que si capacidad, por favor ingrese una cantidad de pasajeros menor, la capacidad maxima es " capPasajeros2
        FinSi

    Hasta Que capacidadValida = Verdadero

    //Procesos Vuelo 1

    Vuelo1.avion.pilot.setNombre(pilotNomb1)
    Vuelo1.avion.pilot.setEdad(edad1)
    Vuelo1.avion.pilot.setSexo(pilotSex1)
    Vuelo.avion(codigo1, capPasajeros1, capCombustible1)
    Vuelo1.setCantPasajeros(cantPasajeros1)
    Vuelo1.setDestino(destinoV1)
    Vuelo1.setHoraDeSalida(horaDeSalida1)
    Vuelo1.DerminarPrecio(destinoV1)
    montoTotalVendido = Vuelo1.getCantPasajeros() * Vuelo1.getPrecio()

    Si  Vuelo1.getCantPasajeros() = Vuelo1.avion.getCapPasajeros() Entonces
        avionLleno = Verdadero
    SiNo 
        avionLleno = Falso
    FinSi

    //Procesoso Vuelo 2

    Vuelo2.avion.pilot.setNombre(pilotNomb2)
    Vuelo2.avion.pilot.setEdad(edad2)
    Vuelo2.avion.pilot.setSexo(pilotSex2)
    Vuelo2.avion(codigo2, capPasajeros2, capCombustible2)
    Vuelo2.setCantPasajeros(cantPasajeros2)
    Vuelo2.setDestino(destinoV2)
    Vuelo2.setHoraDeSalida(horaDeSalida2)
    Vuelo2.DerminarPrecio(destinoV2)
    montoTotalVendido = Vuelo2.getCantPasajeros() * Vuelo2.getPrecio()

    Si  Vuelo2.getCantPasajeros() = Vuelo2.avion.getCapPasajeros() Entonces
        avionLleno = Verdadero
    SiNo 
        avionLleno = Falso
    FinSi

    //Salidas Vuelo 1

    Mostrar "Nombre del piloto: " Vuelo1.avion.pilot.getNombre()
    Mostrar "Edad del piloto: " Vuelo1.avion.pilot.getEdad()
    Mostrar "El genero del piloto: " Vuelo1.avion.pilot.getSexo()
    Mostrar "Codigo del avion: " Vuelo1.avion.getCodigo()
    Mostrar "Capacidad de combustible del avion: " Vuelo1.avion.getCapCombustible()
    Mostrar "Capacidad de pasajeros del avion: " Vuelo1.avion.getCapPasajeros()
    Mostrar "Ciudad de destino: " Vuelo1.getDestino()
    Mostrar "Hora de Salida: A las " Vuelo1.getHoraDeSalida() " horas"
    Mostrar "Cantidad de pasajeros: " Vuelo1.getCantPasajeros()

    Si avionLleno = Verdadero
        Mostrar "El Avion iba lleno"
    Sino Si avionLleno = Falso
            Mostrar "El Avion no estaba lleno"
        FinSi
    FinSi

    //Salidas Vuelo 2

    Mostrar "Nombre del piloto: " Vuelo2.avion.pilot.getNombre()
    Mostrar "Edad del piloto: " Vuelo2.avion.pilot.getEdad()
    Mostrar "El genero del piloto: " Vuelo2.avion.pilot.getSexo()
    Mostrar "Codigo del avion: " Vuelo2.avion.getCodigo()
    Mostrar "Capacidad de combustible del avion: " Vuelo2.avion.getCapCombustible()
    Mostrar "Capacidad de pasajeros del avion: " Vuelo2.avion.getCapPasajeros()
    Mostrar "Ciudad de destino: " Vuelo2.getDestino()
    Mostrar "Hora de Salida: A las " Vuelo2.getHoraDeSalida() " horas"
    Mostrar "Cantidad de pasajeros: " Vuelo2.getCantPasajeros()

    Si avionLleno = Verdadero
        Mostrar "El Avion iba lleno"
    Sino Si avionLleno = Falso
            Mostrar "El Avion no estaba lleno"
        FinSi
    FinSi 

FinAlgoritmo
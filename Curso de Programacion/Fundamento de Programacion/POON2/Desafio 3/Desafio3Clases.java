Clase Piloto

    Privado Definir nombre, sexo Como Caracter
    Privado Definir edad Como Entero

    Metodo Piloto()

        nombre = ""
        sexo = ""
        edad = 0

    FinMetodo

    Publico Metodo getNombre() Como Caracter
        Retornar nombre
    FinMetodo

    Publico Metodo setNombre(name)
        nombre = name
    FinMetodo

    Publico Metodo getSexo() Como Caracter
        Retornar sexo
    FinMetodo

    Publico Metodo setSexo(sex)
        Sexo = sex
    FinMetodo

    Publico Metodo getEdad() Como Caracter
        Retornar nombre
    FinMetodo

    Publico Metodo setEdad(age)
        edad = age
    FinMetodo

    Publico Metodo(name, sex, age)

FinClase

Clase Avion

    Privado Definir codigo Como Caracter
    Privado Definir capPasajeros Como Entero
    Privado Definir capCombustible Como Real
    Definir pilot Como Piloto

    Metodo Avion(cod, passCap, fCap)

        codigo = cod
        capPasajeros = passCap
        capCombustible = fCap

    FinMetodo

    Publico Metodo getCodigo() Como Caracter
        Retornar codigo
    FinMetodo

    Publico Metodo setCodigo(code)
        codigo = code
    FinMetodo

    Publico Metodo getCapPasajeros() Como Caracter
        Retornar capPasajeros
    FinMetodo

    Publico Metodo setCapPasajeros(passengerCap)
        capPasajeros = passengerCap
    FinMetodo

    Publico Metodo getCapCombustible() Como Real
        Retornar capCombustible
    FinMetodo

    Publico Metodo setCapPasajeros(fuelCap)
        getCapCombustible = fuelCap
    FinMetodo

FinClase

Clase Vuelo

    Privado Definir destino Como Caracter
    Privado Definir horaDeSalida, cantPasajeros Como Entero
    Privado Definir precio Como Real
    Definir plane Como Avion

    Metodo Vuelo()

        destino = ""
        cantPasajeros = 0
        horaDeSalida = 0

    FinMetodo

    Publico Metodo getDestino() Como Caracter
        Retornar destino
    FinMetodo

    Publico Metodo setDestino(destiny)
        destino = destiny
    FinMetodo

    Publico Metodo getHoraDeSalida() Como Entero
        Retornar horaDeSalida
    FinMetodo

    Publico Metodo setHoraDeSalida(planeDeparture)
        horaDeSalida = planeDeparture
    FinMetodo

    Publico Metodo getCantPasajeros() Como Entero
        Retornar cantPasajeros
    FinMetodo

    Publico Metodo setCantPasajeros(numbPassengers)
        cantPasajeros = numbPassengers
    FinMetodo

    Publico Metodo getPrecio() Como Real
        Retornar precio
    FinMetodo

    Publico Metodo DerminarPrecio(destino)

        Si (destino = "Carcas") Entonces
            precio = 20
        Sino Si (destino = "Porlamar") Entonces
                precio = 30
            Sino Si (destino = "Puerto Ordaz") Entonces
                    precio = 35
                FinSi
            FinSi
        FinSi     

    FinMetodo

FinClase
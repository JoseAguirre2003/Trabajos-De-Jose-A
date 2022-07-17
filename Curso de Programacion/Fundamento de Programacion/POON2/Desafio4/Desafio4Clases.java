//Clase Fecha

Clase Fecha

    Privado Definir dia Como Entero
    Privado Definir mes Como Entero
    Privado Definir año Como Entero

    Publico Metodo Fecha()
        dia = 0
        mes = 0
        año = 0
    FinMetodo

    Publico Metodo getDia() Como Entero
        Retornar dia
    FinMetodo

    Publico Metodo setDia(day)
        dia = day
    FinMetodo
    
    Publico Metodo getMes() Como Entero
        Retornar mes
    FinMetodo

    Publico Metodo setMes(month)
        mes = month
    FinMetodo

    Publico Metodo getAño() Como Entero
        Retornar año
    FinMetodo

    Publico Metodo setAño(year)
        año = year
    FinMetodo

FinClase

//Clase cuenta banco

Clase CuentaBanco

    Protegido Definir nroCuenta Como Entero
    Protegido Definir tipoCuenta Como Caracter
    Protegido Definir saldo Como Real

    Publico Metodo CuentaBanco()
        nroCuenta = 0
        tipoCuenta = ""
        saldo = 0
    FinMetodo

    Publico Metodo getNroCuenta() Como Entero
        Retornar nroCuenta
    FinMetodo

    Publico Metodo setNroCuenta(numAccount)
        nroCuenta = numAccount
    FinMetodo

    Publico Metodo getTipoCuenta() Como Caracter
        Retornar tipoCuenta
    FinMetodo

    Publico Metodo setTipoCuenta(accountType)
        tipoCuenta = accountType
    FinMetodo

    Publico Metodo getSaldo() Como Real
        Retornar saldo
    FinMetodo

    Publico Metodo setSaldo(balance)
        saldo = balance
    FinMetodo

FinClase

//Clase cliente

Clase Cliente

    Protegido Definir nombre, rif Como Caracter
    Protegido Definir cuentaBanco Como CuentaBanco
    Protegido Definir fecha Como Fecha

    Publico Metodo Cliente()
        nombre = ""
        rif = ""
    FinMetodo

    Pubilco Metodo getNombre() Como Caracter
        retornar nombre
    FinMetodo

    Publico Metodo setCapitalSocial(name)
        nombre = name
    FinMetodo

    Pubilco Metodo getRIF() Como Caracter
        retornar rif
    FinMetodo

    Publico Metodo setRIF(rifN)
        rif = rifN
    FinMetodo

FinClase

//Clase persona natural

Clase PersonaNaural Extiende Cliente

    Privado Definir sexo Como Caracter
    Privado Definir edoCivil Como Logico

    Publico Metodo PersonaNaural()
        sexo = ""
        edoCivil = Falso
    FinMetodo

    Publico Metodo getSexo() Como Caracter
        Retornar sexo
    FinMetodo

    Publico Metodo setSexo(sex)
        sexo = sex
    FinMetodo

FinClase

//Clase socio

Clase Socio

    Privado Definir nombreSocio Como Caracter

    Publico Metodo Socio()
        nombreSocio = ""
    FinMetodo

    Pubilco Metodo getNombreSocio() Como Caracter
        retornar nombreSocio
    FinMetodo

    Publico Metodo setNombreSocio(businessSocial)
        nombreSocio = businessSocial
    FinMetodo

FinClase

//Clase persona juridica

Clase PersonaJuridica Extiende Cliente

    Privado Definir capitalSocial Como Real
    Privado Definir socios Como Coleccion

    Publico Metodo PersonaJuridica()
        capitalSocial = 0
    FinMetodo
    
    Pubilco Metodo getCapitalSocial() Como Entero
        retornar capitalSocial
    FinMetodo

    Publico Metodo setCapitalSocial(socialCapital)
        capitalSocial = socialCapital
    FinMetodo

    Publico Metodo agregarSocio()
        socios.agregar(nuevo Socio())
    FinMetodo

    Publico Metodo getTamañoSocio() Como Entero
        retornar socios.tamano
    FinMetodo

FinClase

//Clase banco

Clase Banco 

    Privado Definir nombre Como Caracter
    Privado Definir clientesNaturales Como Coleccion
    Privado Defnir clientesJuridicos Como Coleccion

    Publico Metodo Banco(n)
        nombre = n
    FinMetodo

    Publico Metodo agregarClienteNatural()
        clientesNaturales.agregar(nuevo PersonaNaural())
    FinMetodo

    Publico Metodo agregarClienteJuridica()
        clientesJuridicos.agregar(nuevo PersonaJuridica())
    FinMetodo

    Publico Metodo getTamañoClienteNatu() Como Entero
        retornar clientesNaturales.tamano
    FinMetodo

    Publico Metodo getTamañoClientejuri() Como Entero
        retornar clientesJuridicos.tamano
    FinMetodo

    Publico Metodo modificarClienteNatura(index, name, rifN, sex, maritalStatus, numAccount, accountType, balance, day, month, year)

        clientesNaturales[index].nombre = name
        clientesNaturales[index].rif = rifN
        clientesNaturales[index].sexo = sex
        clientesNaturales[index].edoCivil = maritalStatus
        clientesNaturales[index].cuentaBanco.nroCuenta = numAccount
        clientesNaturales[index].cuentaBanco.tipoCuenta = accountType
        clientesNaturales[index].cuentaBanco.saldo = balance
        clientesNaturales[index].fecha.dia = day
        clientesNaturales[index].fecha.mes = month
        clientesNaturales[index].fecha.año = year

    FinMetodo

    Publico Metodo modificarClienteJuridica(index1, name, rifN, socialCap, numAccount, accountType, balance, day, month, year)

        clientesJuridicos[index1].nombre = name
        clientesJuridicos[index1].rif = rifN
        clientesJuridicos[index1].capitalSocial = socialCap
        clientesJuridicos[index1].cuentaBanco.nroCuenta = numAccount
        clientesJuridicos[index1].cuentaBanco.tipoCuenta = accountType
        clientesJuridicos[index1].cuentaBanco.saldo = balance
        clientesJuridicos[index1].fecha.dia = day
        clientesJuridicos[index1].fecha.mes = month
        clientesJuridicos[index1].fecha.año = year

    Publico Metodo 

    Publico Metodo modificarCJSocios(index2, index1, businessSocial)

        clientesJuridicos[index1].socios[index2].nombreSocio = businessSocial
    
    FinMetodo

FinClase
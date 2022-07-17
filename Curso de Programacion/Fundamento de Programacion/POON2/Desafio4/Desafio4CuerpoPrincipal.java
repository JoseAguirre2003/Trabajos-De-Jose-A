Algoritmo desafio4

    //Declaraciones de variables

    Definir tipoPersona, nombre, rif, sexo, eleccCasado, tipoCuenta, socio, addSocio, addCuenta Como Caracter
    Definir indexN, indexJ, indexS, nroCuenta, dia, mes, año, contador, i, j Como Entero
    Definir saldo, capSoc Como Real
    Definir repet0, repet1, EsCasado, repet1, repet2, repet3, repet4, repet5, repet6 Como Logico
    Defnir banco Como Banco

    //Inicializaciones e instanciado

    banco = nuevo Banco("Banco de CADI")
    EsCasado = Falso
    repet0 = Falso
    repet1 = Falso
    repet2 = Falso
    repet3 = Falso
    repet4 = Falso
    repet5 = Falso
    repet6 = Falso
    indexN = 0
    indexJ = 0
    indexS = 0
    contador = 1 

    //Entradas-Procesos

    Mostrar "Bienvenido al sistema"
    Mostrar ""

    Repetir 

        Repetir

            Mostrar "Ingrese si la persona es natural o juridica, N si es natura, J si es Juridica" Sin Saltar
            Leer tipoPersona

            Si (tipoPersona = "N") o (tipoPersona = "n") Entonces
                banco.agregarClienteNatural()
                Mostrar "Ingrese el nombre :" Sin Saltar
                Leer nombre
                Mostrar "Ingrese el RIF: " Sin Saltar
                Leer rif

                Repetir
                    Mostrar "Ingrese el genero, F para femenino, M para masculino: " Sin Saltar
                    Leer sexo
                    Si (sexo = "F") o (sexo = "f") o (sexo = "M") o (sexo = "m")
                        repet2 = Falso
                    Sino
                        Mostrar "Debe ingresar un genero que sea valido, F o M por favor vuelva a intentar"
                        repet = Verdadero
                    FinSi
                Hasta Que repet2 = Falso
        

                Repetir
                    Mostrar "Esta casado, S para si, N para no: " Sin Saltar
                    Leer eleccCasado
                    Si (eleccCasado = "S") o (eleccCasado = "s")
                        EsCasado = Verdadero
                        repet3 = Falso
                    Sino Si (eleccCasado = "N") o (eleccCasado = "n")
                            EsCasado = Falso
                            repet3 = Falso
                        Sino
                            repet3 = Verdadero
                            Mostrar "Tiene que colocar S para si o N para no, por favor vuelva a intentar" 
                        FinSi
                Hasta Que repet3 = Falso

                Mostrar "Numero de cuenta: " Sin Saltar
                Leer nroCuenta
                Mostrar "Tipo de cuenta: " Sin Saltar
                Leer tipoCuenta
                Mostrar "Saldo de cuenta: " Sin Saltar
                Leer saldo
                Mostrar "Dia de nacimiento: " Sin Saltar
                Leer dia
                Mostrar "Mes de nacimiento: " Sin Saltar
                Leer mes
                Mostrar "Año de nacimiento: " Sin Saltar
                Leer año

                banco.modificarClienteNatura(indexN, nombre, rif, sexo, EsCasado, nroCuenta, tipoCuenta, saldo, dia, mes, año)

                indexN = indexN + 1

                repet1 = Falso
        
            Sino Si (tipoPersona = "J") o (tipoPersona = "j") Entonces
                    banco.agregarClienteJuridica()
                    Mostrar "Ingrese el nombre :" Sin Saltar
                    Leer nombre
                    Mostrar "Ingrese el RIF: " Sin Saltar
                    Leer rif
                    Mostrar "Ingrese el Capital Social: " Sin Saltar
                    Leer capSoc

                    Repetir

                        banco.clientesJuridicos[indexJ].agregarSocio()
                        Mostrar "Ingrese el nombre del socio: " Sin Saltar
                        Leer socio
                        banco.modificarCJSocios(indexS, indexJ, socio)

                        Repetir

                            Mostrar "¿Desea agregar a otro socio? responda S o N " Sin Saltar
                            Leer addSocio

                            Si (addSocio = "S") o (addSocio = "s")
                                repet4 = Verdadero
                                repet5 = Falso
                                indexS = indexS + 1
                            Sino Si (addSocio = "N") o (addSocio = "n")
                                    repet4 = Falso
                                    repet5 = Falso
                                    indexJ = 0
                                Sino
                                    Mostrar "Debe ingresar S para si o N para No, intente otra vez"
                                    repet5 = Verdadero     
                                FinSi 
                            FinSi

                        HastaQue repet5 = Verdadero

                    Hasta Que repet4 = Falso
            
                    Mostrar "Ingrese el dia de fundacion: " Sin Saltar
                    Leer dia
                    Mostrar "Ingrese el mes de fundacion: " Sin Saltar
                    Leer mes
                    Mostrar "Ingrese el año de fundacion: " Sin Saltar
                    Leer año

                    banco.modificarClienteJuridica(indexJ, nombre, rif, capSoc, nroCuenta, tipoCuenta, saldo, dia, mes, año)

                    indexJ = indexJ + 1

                    repet1 = Falso
        
                Sino
                    Mostrar "Debe ingresar un tipo de cliente valido, N para natural o J para juridico, vuelva a intentar"
                    repet1 = Verdadero
                FinSi
            FinSi

        Hasta Que repet1 = Falso

        Repetir
            Mostrar "¿Desea agregar otra cuenta? S para si, N para no"
            Leer addCuenta
            Si (addCuenta = "S") o (addCuenta = "s") Entonces
                repet0 = Verdadero
                repet6 = Falso
                indexS = 0
                contador = conrador + 1
            Sino Si (addCuenta = "N") o (addCuenta = "n") Entonces
                    repet0 = Falso
                    repet6 = Falso
                Sino
                    Mostrar "Debe ingresar S para si o N para no, vuelva a intentar"
                    repet6 = Verdadero
                FinSi     
            FinSi 
        Hasta Que repet6 = Verdadero
        

    Hasta Que repet0 = Falso

    //Salidas
    
    Mostrar "Clientes Naturales: "
    Para i=0 hasta banco.getTamañoClienteNatu()-1
        Si banco.clientesNaturales[i].getSaldo >= 500 Entonces
            Mostrar ""
            Mostrar "Nombre: "banco.clientesNaturales[i].getNombre()
            Mostrar "RIF: "banco.clientesNaturales[i].getRIF()
            Mostrar "Genero: "banco.clientesNaturales[i].getSexo()
            Si banco.clientesNaturales[i].edoCivil = Verdadero Entonces
                Mostrar "El cliente es casado"
            Sino
                Mostrar "El cliente no esta casado"
            FinSi
            Mostrar "Fecha de nacimiento: " banco.clientesNaturales[i].fecha.getDia() "/" banco.clientesNaturales[i].fecha.getMes() "/" banco.clientesNaturales[i].fecha.getAño()
            Mostrar "Numero de cuenta: " banco.clientesNaturales[i].getNroCuenta()
            Mostrar "Tipo de cuenta: " banco.clientesNaturales[i].getTipoCuenta()
            Mostrar "Saldo: " banco.clientesNaturales[i].getSaldo()
            Mostrar ""
        FinSi
    FinPara

    Mostrar "Clientes Juridicos: "
    Para i=0 hasta banco.getTamañoClientejuri()-1
        Mostrar ""
        Mostrar "Nombre: "banco.clientesJuridicos[i].getNombre()
        Mostrar "RIF: "banco.clientesJuridicos[i].getRIF()
        Mostrar "Capital Social: " banco.clientesJuridicos[i].getCapitalSocial()
        Mostrar "Socios: "
        Para j=0 hasta banco.clientesJuridicos[i].getTamañoSocio()-1
            Mostrar banco.clientesJuridicos[i].socios[j].getNombreSocio()
        FinPara
        Mostrar "Fecha de fundacion: " banco.clientesJuridicos[i].fecha.getDia() "/" banco.clientesJuridicos[i].fecha.getMes() "/" banco.clientesJuridicos[i].fecha.getAño()
        Mostrar "Numero de cuenta: " banco.clientesJuridicos[i].getNroCuenta()
        Mostrar "Tipo de cuenta: " banco.clientesJuridicos[i].getTipoCuenta()
        Mostrar "Saldo: " banco.clientesJuridicos[i].getSaldo()
    FinPara

    Mostrar "La Cantidad de cuentas registradas en el banco es: " contador

    //No me raspe D:

FinAlgoritmo
clase Factura
    Definir numFactura como Caracter
    Definir rifCliente como Caracter
    Definir nombreCliente como Caracter
    Definir nombreProducto como Caracter
    Definir precioProducto como Real
    Definir cantidadProducto como Entero
    Definir subTotalPagar como Real
    Definir montoIVA como Real
    Definir totalPagar como Real
FinClase

Algoritmo facturaTienda
    Definir factura como Factura
    Definir montoIVA, totalPagar, iva, subTotalPagar como Real

    factura = nuevo Factura()

    factura.numFactura = "101101011"
    Mostrar "Ingrese el numero de Rif del cliente:" Sin Saltar
    Leer factura.rifCliente
    Mostrar "Ingrese el nombre del cliente:" Sin Saltar
    Leer factura.nombreCliente
    Mostrar "ingrese el producto comprado:" Sin Saltar
    Leer factura.nombreProducto
    Mostrar "Ingrese el precio del producto:" Sin Saltar
    Leer factura.precioProducto
    Mostrar "Ingrese la cantidad de prodcuto comprado:" Sin Saltar
    Leer factura.cantidadProducto

    subTotalPagar = factura.precioProducto * factura.cantidadProducto

    factura.subTotalPagar = subTotalPagar

    iva = 16

    montoIVA = factura.subTotalPagar * iva / 100

    factura.montoIVA = montoIVA

    totalPagar = factura.subTotalPagar + factura.montoIVA

    factura.totalPagar = totalPagar

    Mostrar ""
    Mostrar "Numero de factura: " factura.numFactura
    Mostrar "Rif del cliente: " factura.rifCliente
    Mostrar "Nombre del cliente: " factura.nombreCliente
    Mostrar "Producto: " factura.nombreProducto
    Mostrar "Precio Unitario del producto: " factura.precioProducto "Bs"
    Mostrar "Cantidad de producto: " factura.cantidadProducto
    Mostrar "Monto a pagar sin IVA: " factura.subTotalPagar "Bs"
    Mostrar "Monto del IVA (16%): " factura.montoIVA "Bs"
    Mostrar "Monto Total a pagar: " factura.totalPagar "Bs"
    Mostrar ""
Fin Algoritmo
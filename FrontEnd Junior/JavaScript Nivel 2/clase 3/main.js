let prueba = function (x, y) {
    return x * y
}

console.log(prueba(5, 5));

function calcular(a, f) {
    console.log( f(a) )
}

calcular(49, Math.sqrt);

var tabla = document.getElementById("tabla")

console.log(tabla.rows.item(0))
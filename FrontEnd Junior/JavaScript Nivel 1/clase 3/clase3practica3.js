// se define arreglo vacio
var arrNombres = []
var arrNotas = []

do {
    var nombre = prompt(`Introduzca el nombre del alumno ${arrNombres.length + 1} `);
    // se convierte a mayusculas para que pueda ser encontrado aunque el usuario 
    // escriba nombres en mayusculas o minusculas
    nombre = nombre.toUpperCase();

    if (arrNombres.includes(nombre))
        alert(`El alumno ${nombre} ya esta incluido en la seccion. Intente de nuevo`)
    else {
        var nota = prompt(`Introduzca la nota del alumno ${arrNombres.length + 1} `);

        // se agrega el nombre leido al arreglo
        arrNombres.push(nombre)
        arrNotas.push(parseInt(nota))
    }
} while (confirm("¿Desea registrar a otro alumno?"))

console.log("Los alumnos registrados fueron ")
for (i = 0; i < arrNombres.length; i++)
    console.log(`${i + 1}.- ${arrNombres[i]}. Nota:  ${arrNotas[i]}`) 
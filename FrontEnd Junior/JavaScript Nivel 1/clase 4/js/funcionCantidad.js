function funcionCantidad() {
    let n = parseInt(prompt("Introduzca la cantidad de invitados "))

        let invitados = []
        for (let i = 0; i < n; i++) {
            var invitado = prompt(`Nombre del invitado ${i + 1}/${n}`)
            invitados.push(invitado)
        }
}
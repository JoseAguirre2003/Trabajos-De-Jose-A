function posicionIvitados() {
    if (n > 0) {
        let posicion = prompt(`Introduzca la posicion donde quiere incluir a los invitados `)
        for (let i = 0; i < n; i++)
            // insertando cada elemento del arreglo invitados en el arreglo
            // nombres en la posicion indicada por el usuario
            nombres.splice(posicion, 0, invitados[i])

        console.log(`La lista completa de nombres es \n${nombres.join("\n")}`)
    }
}
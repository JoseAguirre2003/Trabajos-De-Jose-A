#include <stdio.h>
#include <stdlib.h>

int numero;

void main(){

    printf("Ingrese un numero para verificar en que rengo se encuentra:");
    scanf("%d", &numero);

    if (numero <= 0)
        printf("El numero %d esta dentro del rango menor o igual a 0\n", numero);
    else if (numero > 0 && numero <= 15 )
        printf("El numero %d esta dentro del rango entre 0 y 15\n", numero);
    else
        printf("El numero %d esta dentro del rango mayor o igual a 16\n", numero);
    
    system("pause");

}

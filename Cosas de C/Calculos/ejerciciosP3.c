#include <stdio.h>
#include <stdlib.h>

int numero;

void main(){

    do {
        printf("Introduzca un numero del 1 al 100:");
        scanf("%i", &numero);

        if (numero < 0 || numero > 100){
            printf("El numero ingresado esta fuera del rango entre 0 y 100, vuelva a intentar\n");
        }
        
    } while (numero < 0 || numero > 100);

    system("cls");

    if (numero == 2|| numero == 3 || numero == 5){
        printf("El numero %i es primo\n", numero);
    } else {
        if (numero % 2 == 0){
            printf("El numero %i es par\n", numero);
        }else if (numero % 3 == 0){
            printf("El numero %i es impar y divisible por 3\n", numero);
        }else if (numero % 5 == 0){
            printf("El numero %i es impar y divisible por 5\n", numero);
        }else{ 
            printf("El numero %i el primo\n", numero);
        }
    }   

    system("pause");

}
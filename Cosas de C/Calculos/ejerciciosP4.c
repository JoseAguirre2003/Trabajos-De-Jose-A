#include <stdio.h>
#include <stdlib.h>

int numero1, numero2, numero3, aux;
char eleccion;

void main(){

    printf("Introduzca 3 numeros:\n");
    scanf("%i %i %i", &numero1, &numero2, &numero3);

    printf("Desa ordenar los numero de mayor a menor o de menor a mayor?\n");
    printf("Escriba \"M\" para ordenar de mayor a menor o \"N\" para ordenar de menor a mayor\n");
    scanf(" %c", &eleccion);

    if (eleccion == 'm' || eleccion == 'M'){

        if(numero1 < numero2){

            aux = numero1;
            numero1 = numero2;
            numero2 = aux;

        } else if (numero1 < numero3){
            
            aux = numero1;
            numero1 = numero3;
            numero3 = aux;

        }
        
        if(numero2 < numero3){

            aux = numero2;
            numero2 = numero3;
            numero3 = aux;

        }

        if(numero1 < numero2){

            aux = numero1;
            numero1 = numero2;
            numero2 = aux;

        }

        printf("Mayor: %i %i %i :Menor\n", numero1, numero2, numero3);
        
    } else if (eleccion == 'n' || eleccion == 'N'){

        if(numero1 > numero2){

            aux = numero1;
            numero1 = numero2;
            numero2 = aux;

        } else if (numero1 > numero3){
            
            aux = numero1;
            numero1 = numero3;
            numero3 = aux;

        }
        
        if(numero2 > numero3){

            aux = numero2;
            numero2 = numero3;
            numero3 = aux;

        }

        if(numero1 > numero2){

            aux = numero1;
            numero1 = numero2;
            numero2 = aux;

        }

        printf("Menor: %i %i %i :Mayor\n", numero1, numero2, numero3);

    }

    system("pause");

}
#include <stdio.h>
#include <stdlib.h>

int numeros[5];
int mayorNumero, menorNumero;
int acum = 0;
float promedio;

void main(){

    int j = 1;
    
    for (int i = 0; i < 5; i++){

        printf("Ingrese el numero %d:\n", j);
        scanf("%d", &numeros[i]);
        j++;

    }
    
    mayorNumero = numeros[0];

    for (int i = 1; i < 5; i++){

        if (numeros[i] > mayorNumero)
            mayorNumero = numeros[i];
        
    }

    menorNumero = numeros[0];

    for (int i = 1; i < 5; i++){

        if (numeros[i] < menorNumero)
            menorNumero = numeros[i];
        
    }

    for (int i = 0; i < 5; i++){

        acum += numeros[i];
        
    }

    promedio = acum / 5;

    printf("El mayor numero es %d\n", mayorNumero);
    printf("El menor numero es %d\n", menorNumero);
    printf("Y el promedio es %.2f\n", promedio);

    system("pause");
}

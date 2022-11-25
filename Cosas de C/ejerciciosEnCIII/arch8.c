#include <stdio.h>
#include <stdlib.h>

int arreglo1[5], arreglo2[5], arreglo3[10];

int main(){

    printf("Ingrese los 10 numeros que va a utilizar\n");

    for(int i = 0; i < 5; i++){
        printf("%i numero:", i+1);
        scanf("%i", &arreglo1[i]);
    }

    for(int i = 0; i < 5; i++){
        printf("%i numero:", i+6);
        scanf("%i", &arreglo2[i]);
    }

    for(int i =0; i < 5; i++){
        arreglo3[i] = arreglo1[i];
        arreglo3[i+5] = arreglo2[i];
    }

    for(int i = 0; i < 10; i++){
        printf("%i\n", arreglo3[i]);
    }    

    system("pause");
    
    return 0;
}
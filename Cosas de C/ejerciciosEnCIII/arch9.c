//Que lea 5 números por teclado, los copie a otro array multiplicados por 2 y muestre el segundo array.

#include <stdio.h>
#include <stdlib.h>

int arregloNum[5], arregloNumX2[5];

int main(){

    printf("Ingrese los 5 numeros que va a utilizar\n");

    for(int i = 0; i < 5; i++){
        printf("%i numero:", i+1);
        scanf("%i", &arregloNum[i]);
    }

    for(int i = 0; i < 5; i++)
        arregloNumX2[i] = arregloNum[i] * 2;

    printf("\n Los numeros multiplicados X2 son: \n");

    for(int i = 0; i < 5; i++){
        printf("%i\n", arregloNumX2[i]);
    }    

    system("pause");

    return 0;
}
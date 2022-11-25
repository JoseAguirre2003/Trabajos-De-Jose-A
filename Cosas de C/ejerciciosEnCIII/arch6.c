/*Que lea 10 números por teclado, los almacene en un array y muestre la suma, resta, multiplicación y división de todos.*/

#include<stdio.h>
#include<stdlib.h>

float arreglo[10];

void suma(float array[]);
void resta(float array[]);
void multiplicacion(float array[]);
void division(float array[]);

int main(){
    
    printf("Ingrese los 10 numeros que va a utilizar\n");

    for(int i = 0; i < 10; i++){

        printf("%i numero:", i+1);
        scanf("%f", &arreglo[i]);

    }

    suma(arreglo);
    resta(arreglo);
    multiplicacion(arreglo);
    division(arreglo);

    printf("\n");
    system("pause");

    return 0;
}

void suma(float array[]){

    float sum = 0;

    for(int i = 0; i < 10; i++){

        sum += array[i];

    }

    printf("La suma de los elementos del arreglo es: %.4f\n", sum);

}

void resta(float array[]){

    float res = 0;

    for(int i = 0; i < 10; i++){

        res -= array[i];

    }

    printf("La resta de los elementos del arreglo es: %.4f\n", res);

}

void multiplicacion(float array[]){

    float multi = array[0];

    for (int i = 1; i < 10; i++){
        multi*= array[i];
    }
    
    printf("La multiplicacion de los elementos del arreglo es: %.4f\n", multi);
}
void division(float array[]){

    double div = array[0];

    for (int i = 1; i < 10; i++){
        div/= array[i];
    }

    printf("La division de los elementos del arreglo es: %E\n", div);

}
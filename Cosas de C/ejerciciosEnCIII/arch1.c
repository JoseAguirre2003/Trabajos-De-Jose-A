#include <stdio.h>
#include <stdlib.h>

int arreglo[100];
void llenarArr(int array[]);
void mostrarArr(int array[]);

int main(){    
    llenarArr(arreglo);
    mostrarArr(arreglo);
    system("pause");
    return 0;
}

void llenarArr(int array[]){
    for (int i = 0; i < 100; i++){   
        array[i] = i+1;
    }
}

void mostrarArr(int array[]){
    for (int i = 0; i < 100; i++){       
        printf("Numero: %i\n", array[i]);
    }
    printf("\n");
}
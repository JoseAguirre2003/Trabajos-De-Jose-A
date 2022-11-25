#include <stdio.h>
#include <stdlib.h>
int arreglo[10], aux;
int main(){  
    printf("Ingrese los 10 numeros que va a utilizar\n");
    for(int i = 0; i < 10; i++){
        printf("%i numero:", i+1);
        scanf("%i", &arreglo[i]);
    }
    for (int i = 0; i < 10; i++){
        for (int j = 0; j < 10; j++){
            if(arreglo[i] < arreglo[j]){
                aux = arreglo[i];
                arreglo[i] = arreglo[j];
                arreglo[j] = aux;
            } 
        }
    }
    for(int i = 0; i < 10; i++){
        printf("%i\n", arreglo[i]);
    }    
    system("pause");
    return 0;
}
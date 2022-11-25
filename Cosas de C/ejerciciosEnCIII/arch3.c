#include <stdio.h>
#include <stdlib.h>
int arreglo[100];
int verificarPrimos(int n);
void llenarArreglo(int arr[]);
void mostrarArr(int arr[]);
int main(){
    llenarArreglo(arreglo);
    mostrarArr(arreglo);
    system("pause");
    return 0;
}
int verificarPrimo(int n){
    if(n == 1)
        return 0;
    else if (n == 2 || n == 3 || n == 5 || n == 7)
        return 1;
    else if (n % 2 != 0 && n % 3 != 0 && n % 5 != 0 && n % 7 != 0)
        return 1;
    else
        return 0;
}
void llenarArreglo(int arr[]){
    for(int i = 0; i < 100; i++){
        if(verificarPrimo(i) == 1)
            arr[i] = i;
    }
}
void mostrarArr(int arr[]){
    for (int i = 0; i <= 100; i++){      
        if(arr[i] != 0)
            printf("Numero: %i\n", arr[i]); 
    }
    printf("\n");
}
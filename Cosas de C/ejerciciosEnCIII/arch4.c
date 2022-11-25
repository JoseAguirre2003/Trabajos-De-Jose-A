#include <stdio.h>
#include <stdlib.h>
int arreglo[100], i, cont = 0;
int main(){
    for(i = 0; i <= 100; i++){
        if(i % 2 == 0 ){
            arreglo[i] = i;
            cont++;
        }
    }
    for(i = 0; i <= 100; i++){
        if(arreglo[i] != 0)
            printf("%i\n", arreglo[i]);
    }
    system("pause");
    return 0;
}
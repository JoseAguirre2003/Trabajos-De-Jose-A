#include <stdio.h>
#include <stdlib.h>

int numero1, numero2, numero3;

void main(){
   
    printf("ingrese 3 numeros:\n");
    scanf("%d %d %d", &numero1, &numero2, &numero3);

    if (numero1 % numero2 == numero1)
        printf("El numero 1 %d es residuo de %d entre %d\n", numero1, numero1, numero2);             
    else if (numero1 % numero2 == numero2)
        printf("El numero 2 %d es residuo de %d entre %d\n", numero2, numero1, numero2);
    else if (numero1 % numero2 == numero3)
        printf("El numero 3 %d es residuo de %d entre %d\n", numero3, numero1, numero2);
    else
        printf("Ninguno de los numeros es residuo de %d entre %d\n", numero1, numero2);

    system("pause");
}

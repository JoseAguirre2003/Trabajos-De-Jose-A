#include <stdio.h>
#include <stdlib.h>

float numeUnidad;
float unidadResult;
char eleccion;

void main(){

    printf("Desea transformar de Kilos a Libras o de Libras a Kilos\n");
    printf("Escriba \"K\" para transformar de Kilos a Libra\n");
    printf("Escriba \"L\" para transformar de Libras a kilo\n");
    scanf("%c", &eleccion);

    if(eleccion == 'k' || eleccion == 'K'){

        printf("Ingrese la unidad en Kilo para transformar a Libras:");
        scanf("%f", &numeUnidad);

        unidadResult = numeUnidad * 2.2046;

        printf("%.2fKg en Libras es %.2flb\n", numeUnidad, unidadResult);

    } else if (eleccion == 'l' || eleccion == 'L'){

        printf("Ingrese la unidad en Libras para transformar a Kilos:");
        scanf("%f", &numeUnidad);

        unidadResult = numeUnidad / 2.2046;

        printf("%.2flb en Kilos es %.2fkg\n", numeUnidad, unidadResult);

    }

    system("pause");
    
}

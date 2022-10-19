#include <stdio.h>
#include <stdlib.h>

void main(){
    
    int horas, minutos, segundos;

    printf("Ingrese una hora, minutos, y segundos\n");
    scanf("%i %i %i", &horas, &minutos, &segundos);

    segundos++;

    if (segundos >= 60){
        segundos = 0;
        minutos++;
    }

    if (minutos >= 60){
        minutos = 0;
        horas++;
    }

    if ((horas == 24) && (minutos > 0 || segundos > 0))
        horas = 0;
    else if (horas > 24)
        horas = 0;

    printf("%i Horas %i Minutos %i Segundos\n", horas, minutos, segundos);

    system("pause");

}
#include <stdio.h>
#include <stdlib.h>

int horas, minutos, segundos, eleccion;
char meridian;
int i = 0;

void main(){

    printf("Ingrese la hora:");
    scanf("%i", &horas);
    printf("Ingrese el minuto:");
    scanf("%i", &minutos);
    printf("Ingrese el segundo:");
    scanf("%i", &segundos);

    printf("Seleccione el meridiano de la hora\n");
    printf("1 para hora am\n");
    printf("2 para hora mm [ADVERTENCIA, NO ACEPTARA HORA MM EN HORA DIFERENTES A 12]\n");
    printf("3 para hora pm\n");
    scanf("%i", &eleccion);

    switch (eleccion)
    {
    case 1:
        meridian = 'a';
        break;
    case 2:
        meridian = 'm';
        break;
    case 3:
        meridian = 'p';
        break;
    }

    do{

        segundos++;

    if(segundos == 60){  

        segundos = 0;
        minutos++;

    }

    if(minutos == 60){
        
        minutos = 0;
        horas++;

    }

    if(horas == 12 && minutos == 0 && segundos == 0 && meridian == 'a')
        meridian = 'm';

    if(horas == 12 && minutos == 0 && segundos == 0 && meridian == 'p')
        meridian = 'a';

    if((horas == 12) && (minutos > 0 || segundos >0) && meridian == 'm')
        meridian = 'p';

    if(horas > 12){
        
        horas = 1;   

    }

    if(horas < 10 && minutos < 10 && segundos < 10){

        printf("0%i:0%i:0%i %cm\n", horas, minutos, segundos, meridian);

    } else if (horas < 10 && minutos < 10){

        printf("0%i:0%i:%i %cm\n", horas, minutos, segundos, meridian);

    } else if(horas < 10 && segundos < 10){

        printf("0%i:%i:0%i %cm\n", horas, minutos, segundos, meridian);

    } else if(horas < 10){

        printf("0%i:%i:%i %cm\n", horas, minutos, segundos, meridian);

    } else if(minutos < 10 && segundos < 10){

        printf("%i:0%i:0%i %cm\n", horas, minutos, segundos, meridian);
 
    } else if(minutos < 10){

        printf("%i:0%i:%i %cm\n", horas, minutos, segundos, meridian);

    } else if(segundos < 10){

        printf("%i:%i:0%i %cm\n", horas, minutos, segundos, meridian);

    } else {

        printf("%i:%i:%i %cm\n", horas, minutos, segundos, meridian);

    }

    sleep(1);
    system("cls");

    } while (i < 100);
    
}
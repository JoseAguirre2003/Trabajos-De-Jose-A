/* Librerias */

#include <stdio.h>
#include <stdlib.h>
#include <math.h>

/* Declaraciones de variables */

const float pi = 3.1416;
float circunferencia, radio;
double catetoOp, catetoAb, hipotenusa;

/* Funcion principal */

void main(){
    
    /* Calculos para sacar circunferencia */

    printf("Bienvenido al sistema :D\n");
    printf("\nPara calcular la circunferencia de un circulo, introduzca el valor del radio: ");
    scanf("%f", &radio);

    circunferencia = 2 * pi * radio;
    
    printf("\nLa circunferencia es: %f", circunferencia);

    if (circunferencia < 100) {   

        printf("\nLa circunferencia es menor a 100, por lo tanto se duplica el valor del radio\n");
        radio *= 2;
        circunferencia = 2 * pi * radio;
        printf("El nuevo valor del radio es %f\n", radio);
        printf("Y el nuevo valor de la circunferencia es %f\n", circunferencia);

    } else {
        
        printf("\nLa circunferencia no es menor a 100, por lo tanto se decrementa en 1 el valor del radio\n");
        radio--;
        circunferencia = 2 * pi * radio;
        printf("El nuevo valor del radio es %f\n", radio);
        printf("Y el nuevo valor de la circunferencia es %f\n", circunferencia);

    }

    system("pause");
    system("cls");

    /* Calculos para sacar hipotenusa */

    printf("Para calcular la hipotenusa debe ingresar los valores de los catetos\n");
    printf("Ingrese el valor del cateto opuesto: ");
    scanf("%lf", &catetoOp);
    printf("Ingrese el valor del cateto abyacente: ");
    scanf("%lf", &catetoAb);

    catetoOp = pow(catetoOp, 2);
    catetoAb = pow(catetoAb, 2);

    hipotenusa = catetoOp + catetoAb;

    hipotenusa = sqrt(hipotenusa);

    if (hipotenusa < 10){
        printf("La hipotenusa es menor a diez, por lo tanto es un triangulo pequenio\n");
    }
    else if (hipotenusa >= 10 && hipotenusa <= 20 ){
        printf("La hipotenusa esta entre 10 y 20, por lo tanto es un triangulo mediano\n");
    }
    else{
        printf("La hipotenusa es mayor a 20, por lo tanto es un triangulo grande\n");
    }
    
    printf("La hipotenusa es:");
    printf("%lf\n", hipotenusa);

    system("pause");

}
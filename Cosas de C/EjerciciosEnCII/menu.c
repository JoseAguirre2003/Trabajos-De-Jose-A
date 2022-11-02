#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <windows.h>

/* Constante PI */

const float pi = 3.1416;

/*1 - Funcion para sacar circunferencia */

void sacarCircunferencia(){

    float circunferencia, radio;

    printf("\nPara calcular la circunferencia de un circulo, introduzca el valor del radio: ");
    scanf("%f", &radio);

    circunferencia = 2 * pi * radio;

    printf("\nLa circunferencia es: %f", circunferencia);

    if (circunferencia < 100){

        printf("\nLa circunferencia es menor a 100, por lo tanto se duplica el valor del radio\n");
        radio *= 2;
        circunferencia = 2 * pi * radio;
        printf("El nuevo valor del radio es %f\n", radio);
        printf("Y el nuevo valor de la circunferencia es %f\n", circunferencia);

    }else{

        printf("\nLa circunferencia no es menor a 100, por lo tanto se decrementa en 1 el valor del radio\n");
        radio--;
        circunferencia = 2 * pi * radio;
        printf("El nuevo valor del radio es %f\n", radio);
        printf("Y el nuevo valor de la circunferencia es %f\n", circunferencia);

    }

    system("pause");
    system("cls");
}

/* 2 - Funcion para sacar Hipotenusa*/

void sacarHipotenusa(){

    double catetoOp, catetoAb, hipotenusa;

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

    }else if (hipotenusa >= 10 && hipotenusa <= 20){

        printf("La hipotenusa esta entre 10 y 20, por lo tanto es un triangulo mediano\n");

    }else{

        printf("La hipotenusa es mayor a 20, por lo tanto es un triangulo grande\n");
    }

    printf("La hipotenusa es:");
    printf("%lf\n", hipotenusa);

    system("pause");
    system("cls");
}

/* 3 - Funcion para determinar el un numero primo */

void verSiEsPrimo(){

    int numero;

    printf("Introduzca un numero del 1 al 100:");
    scanf("%i", &numero);

    if (numero < 0 || numero > 100){

        printf("El numero ingresado esta fuera del rango entre 0 y 100\n");

    }else{

        if (numero == 2 || numero == 3 || numero == 5){

            printf("El numero %i es primo\n", numero);

        }else{

            if (numero % 2 == 0)
                printf("El numero %i es par\n", numero);
            else if (numero % 3 == 0)
                printf("El numero %i es impar y divisible por 3\n", numero);
            else if (numero % 5 == 0)
                printf("El numero %i es impar y divisible por 5\n", numero);
            else
                printf("El numero %i es primo\n", numero);

        }
    }

    system("pause");
    system("cls");
}

/* 4 - Funcion Ordenar 3 numeros */

void ordenarTresNumeros(){

    int numero1, numero2, numero3, aux;
    char eleccion;

    printf("Introduzca 3 numeros:\n");
    scanf("%i %i %i", &numero1, &numero2, &numero3);

    printf("Desa ordenar los numero de mayor a menor o de menor a mayor?\n");
    printf("Escriba \"M\" para ordenar de mayor a menor o \"N\" para ordenar de menor a mayor\n");
    scanf(" %c", &eleccion);

    if (eleccion == 'm' || eleccion == 'M'){

        if(numero1 < numero2){

            aux = numero1;
            numero1 = numero2;
            numero2 = aux;

        } else if (numero1 < numero3){
            
            aux = numero1;
            numero1 = numero3;
            numero3 = aux;

        }
        
        if(numero2 < numero3){

            aux = numero2;
            numero2 = numero3;
            numero3 = aux;

        }

        if(numero1 < numero2){

            aux = numero1;
            numero1 = numero2;
            numero2 = aux;

        }

        printf("Mayor: %i %i %i :Menor\n", numero1, numero2, numero3);
        
    } else if (eleccion == 'n' || eleccion == 'N'){

        if(numero1 > numero2){

            aux = numero1;
            numero1 = numero2;
            numero2 = aux;

        } else if (numero1 > numero3){
            
            aux = numero1;
            numero1 = numero3;
            numero3 = aux;

        }
        
        if(numero2 > numero3){

            aux = numero2;
            numero2 = numero3;
            numero3 = aux;

        }

        if(numero1 > numero2){

            aux = numero1;
            numero1 = numero2;
            numero2 = aux;

        }

        printf("Menor: %i %i %i :Mayor\n", numero1, numero2, numero3);

    }

    system("pause");
    system("cls");

}

/* 5 - Funcion Verficar el rango de un numero */

void verificarRango(){

    int numero;

    printf("Ingrese un numero para verificar en que rengo se encuentra:");
    scanf("%d", &numero);

    if (numero <= 0)
        printf("El numero %d esta dentro del rango menor o igual a 0\n", numero);
    else if (numero > 0 && numero <= 15 )
        printf("El numero %d esta dentro del rango entre 0 y 15\n", numero);
    else
        printf("El numero %d esta dentro del rango mayor o igual a 16\n", numero);
    
    system("pause");
    system("cls");

}

/* 6 - Funcion Verficar Vocal */

void verificarVolcal(){

    char letra;

    printf("ingrese una letra:\n");
    scanf(" %c", &letra);

    if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u' ||
        letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U')
        printf("la letra es una vocal\n");
    else
        printf("la letra no es una vocal\n");

    system("pause");
    system("cls");

}

/* 7 - Funcion Detrminar mayor, menor y promedio de 5 numeros */

void determMenMayProm(){

    int numero1, numero2, numero3, numero4, numero5, numMayor, numMenor;
    float promedio, acum;

    printf("Introduzca 5 numeros:\n");
    printf("Introduzca el numero 1:");
    scanf("%i", &numero1);
    printf("Introduzca el numero 2:");
    scanf("%i", &numero2);
    printf("Introduzca el numero 3:");
    scanf("%i", &numero3);
    printf("Introduzca el numero 4:");
    scanf("%i", &numero4);
    printf("Introduzca el numero 5:");
    scanf("%i", &numero5);


    numMenor = numero1;
    numMayor = numero1;

    /* Determinando numero menor */

    if(numero2 < numMenor){
        numMenor = numero2;
    }
    
    if(numero3 < numMenor){
        numMenor = numero3;
    }

    if(numero4 < numMenor){
        numMenor = numero4;
    }
    
    if(numero5 < numMenor){
        numMenor = numero5;
    }

    /* Determinando numero mayor */

    if(numero2 > numMayor){
        numMayor = numero2;
    }
    
    if(numero3 > numMayor){
        numMayor = numero3;
    }

    if(numero4 > numMayor){
        numMayor = numero4;
    }
    
    if(numero5 > numMayor){
        numMayor = numero5;
    }

    acum = numero1 + numero2 + numero3 + numero4 + numero5;
    promedio = acum / 5;

    printf("El numero menor es %i\n", numMenor);
    printf("El numero mayor es %i\n", numMayor);
    printf("Ël pormedio entre los 5 numeros es %f", promedio);
    printf("\n");

    system("pause");
    system("cls");

}

/* 8 - Funcion detminar si un numero es residuo de division */

void determNumResidio(){

    int numero1, numero2, numero3;

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
    system("cls");

}

/* 9 - Funcion Transformar de Kilos a Libras/Libras a Kilos */

void transformarKgALb(){

    float numeUnidad;
    float unidadResult;
    char eleccion;

    printf("Desea transformar de Kilos a Libras o de Libras a Kilos\n");
    printf("Escriba \"K\" para transformar de Kilos a Libra\n");
    printf("Escriba \"L\" para transformar de Libras a kilo\n");
    scanf(" %c", &eleccion);

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
    system("cls");

}

/* 10 - Funcion Sumar un segundo a una hora */

void sumarSegAHora(){
    
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

    if (horas >= 24)
        horas = 0;
    
    if(horas < 10 && minutos < 10 && segundos < 10){

        printf("0%i:0%i:0%i\n", horas, minutos, segundos);

    } else if (horas < 10 && minutos < 10){

        printf("0%i:0%i:%i\n", horas, minutos, segundos);

    } else if(horas < 10 && segundos < 10){

        printf("0%i:%i:0%i\n", horas, minutos, segundos);

    } else if(horas < 10){

        printf("0%i:%i:%i\n", horas, minutos, segundos);

    } else if(minutos < 10 && segundos < 10){

        printf("%i:0%i:0%i\n", horas, minutos, segundos);
 
    } else if(minutos < 10){

        printf("%i:0%i:%i\n", horas, minutos, segundos);

    } else if(segundos < 10){

        printf("%i:%i:0%i\n", horas, minutos, segundos);

    } else {

        printf("%i:%i:%i\n", horas, minutos, segundos);

    }

    system("pause");
    system("cls");

}

/* Funcion Principal */

void main(){

    int eleccion;

    do{

        printf("Bienvenido al sistema :D\n");
        printf("Elija un numero para...\n");
        printf("1 - Para sacar la circunferencia\n");
        printf("2 - Para sacar la hipotenusa\n");
        printf("3 - Para determinar si un numero entre 0 - 100 es primo\n");
        printf("4 - Para ordenar 3 numeros\n");
        printf("5 - Para verificar el rango de un numero\n");
        printf("6 - Para verificar si una letra es vocal\n");
        printf("7 - Determinar numero mayor, numero menor y promedio de 5 numeros\n");
        printf("8 - Determinar el si un numero es residuo de una division\n");
        printf("9 - Transformar de Kilos a Libras o viceversa\n");
        printf("10 - Sumar un segundo a 1 hora determinada\n");
        printf("11 - Para cerrar el programa\n");
        printf("Su eleccion es:");
        scanf("%i", &eleccion);

        switch (eleccion){
        case 1:
            system("cls");
            sacarCircunferencia();
            break;
        case 2:
            system("cls");
            sacarHipotenusa();
            break;
        case 3:
            system("cls");
            verSiEsPrimo();
            break;
        case 4:
            system("cls");
            ordenarTresNumeros();
            break;
        case 5:
            system("cls");
            verificarRango();
            break;
        case 6:
            system("cls");
            verificarVolcal();
            break;
        case 7:
            system("cls");
            determMenMayProm();
            break;
        case 8:
            system("cls");
            determNumResidio();
            break;
        case 9:
            system("cls");
            transformarKgALb();
            break;
        case 10:
            system("cls");
            sumarSegAHora();
            break;
        case 11:
            printf("Adios :)\n");
            sleep(1);
            break;
        default:
            printf("Debe elegir una opcion entre 1 y 11\n");
            system("pause");
            system("cls");
            break;
        }

    } while (eleccion != 11);
}
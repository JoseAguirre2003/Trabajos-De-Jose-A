#include <stdio.h>

float promedio(int valores[], int cantidad) {
    int i;
    float suma = 0.0;

    for (i = 0; i < cantidad; ++i)
        suma += valores[i];

    return suma / (float) cantidad;
}


int main() {

    int notas[10];
    char nombre[20];
    char opcion[3];
    int n, i;
    /* Aqui vou a poner las variables de mayor nota y menor nota*/
    int mayorNota;
    int menorNota;

    do {
        printf("Ingrese nombre del alumno: ");
        scanf("%s", nombre);

        printf("Cuantas notas tiene %s? ", nombre);
        scanf("%d", &n);

        for (i = 0; i < n; ++i) {
            printf("  Nota %d: ", i + 1);
            scanf("%d", &notas[i]);
        }

        printf("El promedio de %s es %.1f\n", nombre, promedio(notas, n));
        
        /* UN CICLO PARA RECORRER EL ARREGLO Y VER LAS NOTAS*/
        
        mayorNota = notas[0];
        
        for(i = 1; i < n; ++i){
            
           if(notas[i] > mayorNota){
               
                mayorNota = notas[i];
               
           } 
            
        }
        
        menorNota = notas[0];
        
        for(i = 1; i < n; ++i){
            
           if(notas[i] < menorNota){
               
                menorNota = notas[i];
               
           } 
            
        }
        
        printf("La Mayor Nota es %d\n", mayorNota);
        printf("La Menor Nota es %d\n", menorNota);
        
        printf("Desea calcular mas promedios (si/no)? ");
        scanf("%s", opcion);

    } while (opcion[0] == 's' || opcion[0] == 'S');

    return 0;

}
#include <stdio.h>
#include <stdlib.h>

char letra;

void main()
{

    printf("ingrese una letra:\n");
    scanf("%c", &letra);

    if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u' ||
        letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U')
        printf("la letra es una vocal\n");
    else
        printf("la letra no es una vocal\n");

    system("pause");
}

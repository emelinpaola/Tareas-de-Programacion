#include <stdio.h>
#include <stdlib.h>

int main()
{
    printf("Hello world!\n");
    return 0;
}
#include <stdio.h>
/* Superficie del triángulo.
El programa, al recibir como datos la base y la altura de un triángulo,
➥calcula su superficie.
BAS, ALT y SUP: variables de tipo real. */
void main (void)
{
 float BAS, ALT, SUP;
printf(“Ingrese la base y la altura del triángulo: “);
scanf(“%f %f”, &BAS, &ALT);
SUP = BAS * ALT / 2;
printf(“\nLa superficie del triángulo es: %5.2f”, SUP);
}

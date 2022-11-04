#include <stdio.h>
#include <stdio.h>

/* Igualdad de expresiones.
El programa, al recibir como  datos T, P y N, comprueba la igualdad de
una expresion determinada.

T, P y N: Variables de tipo entero. */

void main(void)
{
    int  T, P, N;
    printf("Ingrese los valores de T, P y N: ");
    scanf("%d %d %d", &T, &P, &N);
    if (P != 0)
    {
        if (POW(T / P, N) == (POW(T, N) / POW(P, N))
            printf("\nSe comprueba la igualdad");
            else
                printf("\nNo se comprueba la igualdad");
    }
    else
        printf("\nP tiene que ser diferente de cero");

}

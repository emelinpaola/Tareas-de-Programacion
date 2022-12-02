#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int num1, num2, num3;
int al1, al2, al3;
int pegadas = 0, premio = 0;
int monto;
double menu = 1;

int main(void)
{
    while (menu != 0)
    {
        printf ("PROGRAMA DE LOTERIA\n\n");
        printf("Ingrese el monto a jugar: \n");
        scanf("%d", &monto);
        if (monto >= 1 && monto <= 10000)
        {
            printf("ingrese el numero 1: \n");
            scanf("%d", &num1);
            printf("ingrese el numero 2: \n");
            scanf("%d", &num2);
            printf("ingrese el numero 3: \n");
            scanf("%d", &num3);

            srand(time(NULL));
            al1 = rand() % 10;
            al2 = rand() % 10;
            al3 = rand() % 10;

            printf("El primer numero ganador es: %d\n", al1);
            printf("El segundo numero ganador es: %d\n", al2);
            printf("El tercer numero ganador es: %d\n", al3);


            if (num1 == al1 || num1 == al2 || num1 == al3)
            {
                pegadas = pegadas + 1;
            }
            if (num2 == al1 || num2 == al2 || num2 == al3)
            {
                pegadas = pegadas + 1;
            }
            if (num3 == al1 || num3 == al2 || num3 == al3)
            {
                pegadas = pegadas + 1;
            }
            if (pegadas == 1)
            {
            printf ("Acertaste %d numero\n\n", pegadas);
            }else
            printf ("Acertaste %d numeros\n\n", pegadas);
            pegadas = pegadas + 1;
            if  (pegadas == 2)
            {
                premio = monto * pegadas * 10;
            }
            if  (pegadas == 3)
            {
                premio = monto * pegadas * 20;
            }
            if  (pegadas == 4)
            {
                premio = monto * pegadas * 30;
            }
            pegadas = pegadas - 1;
            if (pegadas >= 1)
            {
                printf ("Ganaste %d pesos\n\n\n\n", premio);
            }else
            {
            printf ("Mejor suerte la proxima jugada\n\n\n\n");
            }
            pegadas = 0;
        }else
        printf ("NO  se puede jugar esta cantidad\n\n");
    }
    return 0;
}

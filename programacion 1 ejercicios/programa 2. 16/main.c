#include <stdio.h>
#include <stdlib.h>

void main(void)
{
int CLA, CAT, ANT, RES;
printf("\nIngrese la clave, categor�a y antig�edad del trabajador:");
scanf("%d %d %d", &CLA, &CAT, &ANT);
switch(CAT)
{
case 3:
case 4: if (ANT >= 5)
RES = 1;
else
RES = 0;
break;
case 2: if (ANT >= 7)
RES = 1;
else
RES = 0;
break;
default: RES = 0;
break;
}
if (RES)
printf("\nEl trabajador con clave %d re�ne las condiciones para el puesto", CLA);
else
printf("\nEl trabajador con clave %d no re�ne las condiciones para el puesto", CLA);
}

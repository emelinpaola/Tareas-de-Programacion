#include <stdio.h>
#include <stdlib.h>



#define SALIR       0
#define CIUDAD      1
#define CARRETERA   2
#define ERROR_MENU  100
#define PASO        0.1
#define CONVERSION_GALON_LITRO 3.78



int main()
{
    //variables de soporte
    float CostMant = 0.8;       //costo mantenimineto por km
    float CostNeumaticos = 0.7; //Costos de neumaticos por KM
    float CostoGasolina = 297.6;//Costo gasolina x galon
    float CostoGasolinaLitros = CostoGasolina / CONVERSION_GALON_LITRO;
    float CostoFijo = CostMant + CostNeumaticos;
    float CostoGasolinaLx100 = 0.0; //Costo Gasolina en Litro x 100 Km
    float CostoGasolinaxKm = 0.0;
    const float ProMedConsumoCiudadMax = 14.2;
    const float ProMedConsumoCiudadMin = 11.6;
    const float ProMedConsumoCarreteraMax = 11.6;
    const float ProMedConsumoCarreteraMin = 9.0;
    int menu = ERROR_MENU;
    int Distancia = 0;



    printf("\n--------------------------------\n");
    printf("-   Sistema de Gastos Viajes   -\n");
    printf("--------------------------------\n");



    do
    {
        while(menu == ERROR_MENU)
        {
            printf("\n");
            printf("0 - para Salir\n");
            printf("1 - para Ciudad\n");
            printf("2 - para Carretera\n");
            scanf("%d",&menu);
            if(menu > 2 || menu < 0)
            {
                printf("Error entrada menu, debe ser entre 0 y 2");
                menu = ERROR_MENU;
            }
        }



        //calcular para ciudad
        if(menu == CIUDAD)
        {



            menu = ERROR_MENU;



            printf("Ingese la distancia del cliente en Km:");
            scanf("%d",&Distancia);
            for(float cont = ProMedConsumoCiudadMin; cont <= ProMedConsumoCiudadMax;cont += PASO )
            {
                //calcular litros
                float LitrosKm = cont / 100.0;
                float Litros = Distancia * LitrosKm;
                CostoGasolinaxKm = 0.0;
                printf("\n");
                printf("KM \t- LITROS \t- COSTO \t- COSTCOMB \t- TOTAL \t- L/100Km\n");
                printf("%d \t- %.2f    \t- %.2f    \t- %.2f    \t- %.2f    \t- %.2f\n", Distancia, Litros,
                         CostoFijo,CostoGasolinaxKm,CostoFijo+CostoGasolinaxKm,cont);
            }



        }



         //calcular para carretera
        if(menu == CARRETERA)
        {




        }




    }
    while(menu);










    return 0;
}

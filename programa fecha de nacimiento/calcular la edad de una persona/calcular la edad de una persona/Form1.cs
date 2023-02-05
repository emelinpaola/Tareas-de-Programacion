using System;

namespace Ejercicio
{
     class program
    {
        static void main(string[] args)
        {
            //Calcular la edad de una persona en C#
            Console.Write("ingrese el año actual:");
            int año_actual = int.Parse(Console.ReadLine());
            Console.Write("ingrese su año de nacimiento:");
            int año_nacimiento = int.Parse(Console.ReadLine());
            int edad = año_actual - año_nacimiento;
            Console.Write("usted tiene" + edad + "años.");
            Console.ReadKey();*/ 

                int edad, año_nacimiento;
            Console.Write("ingrese su año de nacimiento: ");
            año_nacimiento = int.Parse(Console.ReadLine());
            edad = DateTime time.today.year - año_nacimiento;
            Console.Write("usted tiene " + edad + "años.");
            Console.ReadKey();




        }

        
    }
}
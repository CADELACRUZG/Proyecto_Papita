#pragma warning disable
using System;
class proyectoPrecalculo
{
    int Eleccion;
    static void Main()
    {
        Console.WrtiteLine("Selecciones el problema que quiere resolver"); //aqui solo mostramos alguna descripción de los problemas
        Console.WrtiteLine("Problema 1: ");

        Console.WrtiteLine("Problema 2: ");

        Console.WrtiteLine("Problema 3: ");

        Console.WrtiteLine("Seleccione uno\n(1) problema 1\n(2) problema 2\n(3) problema 3");
        do{
            if (int.TryParse(Console.ReadLine(), out Eleccion)) //elección de problema
            {
                if (Eleccion<1||Eleccion>3)
                {
                   Console.WrtiteLine("Opción no válida, vuelva a intentar"); 
                }
                else{
                    break;
                }
            }
            else{
                Console.WrtiteLine("Opción no válida, vuelva a intentar");
            }
        }while(true);
        switch(Eleccion) //evaluación e instancia de métodos de cada problema
        {
            case 1:

                break;
            case 2:

                break;
            case 3:
                problemaTres();
                break;
        }
    }
    void problemaTres() //Trabajo de Luigi y Cruz
    {
        Console.WrtiteLine("Usted ha elegio el problema No. 3");
    }
}
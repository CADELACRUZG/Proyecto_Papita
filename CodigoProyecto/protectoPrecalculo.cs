#pragma warning disable
using System;
class proyectoPrecalculo
{
    int Eleccion;
    public static void Main()
    {
        Console.WriteLine("Bienvenido, seleccione la opción que desea resolver");
        Console.WriteLine("Problema No. 1: "); //Aqui pensaba poner una descripción o algo de cada figura
        
        Console.WriteLine("Problema No. 2: ");

        Console.WriteLine("Problema No. 3: ");

        Console.WriteLine("Seleccióne un problema\n(1) problema 1\n(2) problema 2\n(3) problema 3"); //para que pueda elegir cual de los tres problemas quiere que el programa resuelva
        do
        {
            if (int.TryParse(Console.ReadLine(),out Eleccion))
            {
                if (Eleccion<1||Eleccion>3){
                    Console.WriteLine("Opción no válida, vuelva a intentar");
                }
                else{
                    break;
                }
            }
            else{
                Console.WriteLine("Opción no válida, vuelva a intentar");
            }
        }while(true);
        Console.Clear();
        //Aquí ya instanciar el método de cada uno para que resuelva el problema que se seleccione
        switch (Eleccion)
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
    public void problemaTres() //Trabajo de Luigi y Cruz
    {
        double AC3, AD3;
        Console.WriteLine("Seleccionó el problema 3\nA continuación se le solicitarán datos necesarios para resolver el problema");
        
    }
}
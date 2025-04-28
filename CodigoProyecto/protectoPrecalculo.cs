#pragma warning disable
using System;
class proyectoPrecalculo
{
    // int Eleccion;
    public static void Main()
    {
        // Console.WriteLine("Bienvenido, seleccione la opción que desea resolver");
        // Console.WriteLine("Problema No. 1: "); //Aqui pensaba poner una descripción o algo de cada figura
        
        // Console.WriteLine("Problema No. 2: ");

        // Console.WriteLine("Problema No. 3: ");

        // Console.WriteLine("Seleccióne un problema\n(1) problema 1\n(2) problema 2\n(3) problema 3"); //para que pueda elegir cual de los tres problemas quiere que el programa resuelva
        // do
        // {
        //     if (int.TryParse(Console.ReadLine(),out Eleccion))
        //     {
        //         if (Eleccion<1||Eleccion>3){
        //             Console.WriteLine("Opción no válida, vuelva a intentar");
        //         }
        //         else{
        //             break;
        //         }
        //     }
        //     else{
        //         Console.WriteLine("Opción no válida, vuelva a intentar");
        //     }
        // }while(true);
        // Console.Clear();
        // //Aquí ya instanciar el método de cada uno para que resuelva el problema que se seleccione
        // switch (Eleccion)
        // {
        //     case 1:

        //         break;
        //     case 2:

        //         break;
        //     case 3:
        //        problemaTres();
        //         break;
        // }
    }
    public static void problemaTres() //Trabajo de Luigi y Cruz
    {
        Console.WriteLine("Seleccionó el problema 3\nA continuación se le solicitarán datos necesarios para resolver el problema");
        // Primer Triangulo 
        Console.Write("Ingresa el valor del primer cateto: ");
        double catetoA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa el valor del segundo cateto: ");
        double catetoB = Convert.ToDouble(Console.ReadLine());

        // Calculamos la hipotenusa usando el teorema de Pitágoras
        double hipotenusa = Math.Sqrt((Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2)));
        Console.WriteLine(hipotenusa);
        Console.WriteLine("Segundo Triangulo");
        // Mostramos el resultado
        // Segundo Triangulo
        Console.Write("Ingresa el cateto: ");
        double catetoOtro = Convert.ToDouble(Console.ReadLine());
        // Calculamos la hipotenusa usando el teorema de Pitágoras

        double hipotenusa2 = Math.Sqrt(Math.Pow(hipotenusa, 2) + Math.Pow(catetoOtro, 2)); 
        Console.WriteLine(hipotenusa2);
        Console.Write("Ingresa el cateto: ");

        // Tercer triangulo 
        double catetoAltura = catetoB * 2;
        // El angulo C del triangulo
        double cosC = (Math.Pow(hipotenusa2, 2) + Math.Pow(hipotenusa2, 2) - Math.Pow(catetoAltura, 2)) / (2 * hipotenusa2 * hipotenusa2);

        // Aseguramos que el valor esté en el rango [-1, 1] para evitar errores numéricos
        cosC = Math.Max(-1.0, Math.Min(1.0, cosC));

        // Calculamos el ángulo en radianes y lo convertimos a grados
        double anguloC = Math.Acos(cosC) * (180 / Math.PI);
        anguloC = Math.Round(anguloC, 2);
        // Mostramos el resultado
        Console.WriteLine($"El ángulo C es: {anguloC} grados");


    }
}
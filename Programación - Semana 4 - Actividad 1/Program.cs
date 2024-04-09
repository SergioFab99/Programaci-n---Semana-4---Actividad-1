using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        bool continuar = true;
        while (continuar)
        {
            MostrarMenu();
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Opción 1 seleccionada.");
                    break;
                case 2:
                    Console.WriteLine("Opción 2 seleccionada.");
                    break;
                case 3:
                    Console.WriteLine("Opción 3 seleccionada.");
                    break;
                case 4:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Opción 1");
        Console.WriteLine("2. Opción 2");
        Console.WriteLine("3. Opción 3");
        Console.WriteLine("4. Salir");
    }
}
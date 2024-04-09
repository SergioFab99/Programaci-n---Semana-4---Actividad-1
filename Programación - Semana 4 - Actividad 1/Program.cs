using System;

class Program
{
    static void Main()
    {
        CalculadoraNumerica calculadora = new CalculadoraNumerica();

        bool continuar = true;
        while (continuar)
        {
            MostrarMenu();
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese un número n para calcular el término de Fibonacci: ");
                    int nFibonacci = int.Parse(Console.ReadLine());
                    int resultadoFibonacci = calculadora.CalcularFibonacci(nFibonacci);
                    Console.WriteLine($"El término {nFibonacci} de Fibonacci es: {resultadoFibonacci}");
                    break;
                case 2:
                    Console.Write("Ingrese un número n para calcular el primo número n: ");
                    int nPrimo = int.Parse(Console.ReadLine());
                    int resultadoPrimo = calculadora.CalcularPrimo(nPrimo);
                    Console.WriteLine($"El primo número {nPrimo} es: {resultadoPrimo}");
                    break;
                case 3:
                    Console.Write("Ingrese un número n para calcular el número perfecto número n: ");
                    int nPerfecto = int.Parse(Console.ReadLine());
                    int resultadoPerfecto = calculadora.CalcularNumeroPerfecto(nPerfecto);
                    Console.WriteLine($"El número perfecto número {nPerfecto} es: {resultadoPerfecto}");
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
        Console.WriteLine("1. Calcular término n de Fibonacci");
        Console.WriteLine("2. Calcular primo número n");
        Console.WriteLine("3. Calcular número perfecto n");
        Console.WriteLine("4. Salir");
    }
}

class CalculadoraNumerica
{
    public int CalcularFibonacci(int n)
    {
        if (n <= 0)
            return 0;
        if (n == 1)
            return 1;

        int a = 0, b = 1, resultado = 0;
        for (int i = 2; i <= n; i++)
        {
            resultado = a + b;
            a = b;
            b = resultado;
        }
        return resultado;
    }

   
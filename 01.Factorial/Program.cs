using System;

namespace Factorial
{
    class Program
    {
        static long CalcularFactorial(int numero)
        {
            long resultado = 1;

            for (int i = 1; i <= numero; i++)
            {
                resultado = resultado * i;
            }

            return resultado;
        }

        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("No se puede calcular el factorial de un numero negativo");
            }
            else
            {
                long resultado = CalcularFactorial(numero);
                Console.WriteLine("El factorial del número es: " + resultado);
            }

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}

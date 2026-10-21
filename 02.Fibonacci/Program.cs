using System;

namespace fibonacci
{
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos terminos desea ver? ");
            int terminos = Convert.ToInt32(Console.ReadLine());
            if (terminos <= 1)
            {
                Console.WriteLine("El numero de terminos debe ser mayor de 0");
            }
            else
            {
                long anterior = 1;
                long actual = 2;
                Console.WriteLine("Serie: " + anterior);

                if (terminos > 2)
                {
                    Console.WriteLine(" " + actual);
                }
                for (int i = 3; i <= terminos; i++)
                {
                    long siguiente = anterior + actual;
                    Console.WriteLine(" " + siguiente);
                    anterior = actual;
                    actual = siguiente;
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
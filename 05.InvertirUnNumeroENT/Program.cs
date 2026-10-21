using System;
class program
{
    static long invertir(long n, long resultado = 0)
    {
        if (n == 0)
            return resultado;
        return invertir(n / 10, resultado * 10 + n % 10);
    }
    static void Main()
    {
        Console.WriteLine("Ingresar un número positivo");
        long n = long.Parse(Console.ReadLine());
        if (n < 0)
        {
            Console.WriteLine("El numero debe ser positivo");
            return;
        }
        Console.WriteLine("Numero invetido: " + invertir(n));
    }
    

}
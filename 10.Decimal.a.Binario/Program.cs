using System;
class program
{
    static void BinarioA(int n)
    {
        if (n < 2)
        {
            Console.WriteLine(n);
            return;
        }
        BinarioB(n/2);
        Console.WriteLine(n % 2);
    
    }
    static void BinarioB(int n)
    {
        if ( n < 2)
        {
            Console.Write(n);
            return;

        }
        BinarioA(n / 2);
        Console.Write(n % 2);
    }
    static void Main()
    {
        Console.WriteLine("Ingresa un número entero: ");
        int n = int.Parse(Console.ReadLine());
        if (n < 0)
        {
            Console.WriteLine("Ingresa un numero No negativo");
            return;
        }
        Console.Write("Binario: ");
        if (n == 0)
            Console.Write("0");
        else BinarioA(n);
        
        Console.WriteLine();
    }
}
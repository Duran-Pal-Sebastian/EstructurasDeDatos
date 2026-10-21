using System;
class program
{
    static int SumaA(int n)
    {
        if (n <= 0)
            return 0;
        return n + SumaB(n - 1);
    }
    static int SumaB(int n)
    {
        if (n <= 0)
            return 0;
        return n + SumaA(n - 1);
    }
    static void Main()
    {
        Console.WriteLine("Ingrese el numero que quiera sumar: ");
        int n = int.Parse(Console.ReadLine());
        if (n < 0 || n > 10000)
        {
            Console.WriteLine("porfavor ingrese un numero entre el 0 y el 10000.");
            return;
        }
        Console.WriteLine("La suma es: " + SumaA(n));
    }
}
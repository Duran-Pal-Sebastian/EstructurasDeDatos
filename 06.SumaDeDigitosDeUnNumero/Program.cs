using System;
class program
{
    static int SumarDigitos(int n)
    {
        if  (n == 0) 
            return 0;
        return n % 10 + SumarDigitos(n / 10);
    }
    static void Main()
    {
        Console.WriteLine("Ingresa un número: ");
        int n = int.Parse(Console.ReadLine());
    if (n < 0)
        {
            Console.WriteLine("Ingresa un número positivo");
            return;
        }
        Console.WriteLine("Suma de digitos: " + SumarDigitos(n));
    }


}
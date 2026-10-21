using System;
class program
{
    static bool EsPar(int n)
    {
        if (n == 0)
            return true;
        return EsImpar(n - 1);

    }
    static bool EsImpar(int n)
    {
        if (n == 0)
            return false;
        return EsPar(n - 1);
    }
    static void Main()
    {
        Console.WriteLine("Ingresa un número: ");
        int n = int.Parse(Console.ReadLine());
        if (n < 0 || n > 10000)
        {
            Console.WriteLine("Porfavor ingrese un numero entre el 0 y el 10,000.");
            return;
        }
    if (EsPar(n))
        
            Console.WriteLine("El numero es par.");
            else
                Console.WriteLine("El número es impar");
        
    }


}
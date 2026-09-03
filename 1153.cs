using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int fatorial = 1;
        for (int i = n; i >= 1; i--)
        {
            fatorial *= i;
        }
        Console.WriteLine(fatorial);
    }
}

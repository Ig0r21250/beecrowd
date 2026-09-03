using System;

class Program
{
    static void Main()
    {
        // Lê o valor inteiro X
        int x = int.Parse(Console.ReadLine());

        // Loop de 1 até X
        for (int i = 1; i <= x; i++)
        {
            // Verifica se o número atual é ímpar
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}

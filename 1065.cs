using System;

class Program
{
    static void Main()
    {
        int valoresPares = 0;

        // Loop para ler os 5 valores
        for (int i = 0; i < 5; i++)
        {
            int valor = int.Parse(Console.ReadLine());

            // Verifica se o número é par
            if (valor % 2 == 0)
            {
                valoresPares++;
            }
        }

        // Exibe o resultado no formato esperado
        Console.WriteLine($"{valoresPares} valores pares");
    }
}

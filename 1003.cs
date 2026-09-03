using System;

class Program
{
    static void Main()
    {
        // Lê os dois valores inteiros
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        // Calcula a soma
        int soma = a + b;

        // Imprime o resultado formatado com os espaços exigidos
        Console.WriteLine($"SOMA = {soma}");
    }
}

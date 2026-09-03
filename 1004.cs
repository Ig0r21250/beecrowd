using System;

class Program
{
    static void Main()
    {
        // Lê os dois valores inteiros da entrada
        int valor1 = int.Parse(Console.ReadLine());
        int valor2 = int.Parse(Console.ReadLine());

        // Calcula o produto entre os dois valores
        int prod = valor1 * valor2;

        // Imprime o resultado no formato exato "PROD = [valor]"
        Console.WriteLine($"PROD = {prod}");
    }
}

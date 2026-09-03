using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Define o valor de pi constante
        double pi = 3.14159;

        // Lê o valor do raio (usando InvariantCulture para aceitar pontos decimais na entrada)
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // Calcula a área: pi * raio * raio
        double area = pi * raio * raio;

        // Imprime o resultado com "A=" e exatamente 4 casas decimais
        Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");
    }
}

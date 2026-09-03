using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Lê as duas notas com dupla precisão (double)
        double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // Calcula a média ponderada com os pesos 3.5 e 7.5
        double media = ((a * 3.5) + (b * 7.5)) / 11.0;

        // Imprime o resultado com "MEDIA = " e exatamente 5 casas decimais
        Console.WriteLine($"MEDIA = {media.ToString("F5", CultureInfo.InvariantCulture)}");
    }
}

using System;
using System.Globalization;
namespace Exercicio6
{
    class Exercicio6
    {
        static void Main(string[] args)
        {
            float A, B, C;
            double areaT, areaC, areaTrapezio, areaQ, areaR;

            Console.WriteLine("Digite os valores de A, B e C: " +
                "");
            A = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            areaT = (A * C) / 2;
            areaC = 3.14159 * Math.Pow(C,2.0);
            areaTrapezio = (A + B) / 2 * C;
            areaQ = B * B;
            areaR = A * B;

            Console.WriteLine($"Triangulo: {areaT.ToString("F3",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Circulo: {areaC.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Trapézio: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Quadrado: {areaQ.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Retangulo: {areaR.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}

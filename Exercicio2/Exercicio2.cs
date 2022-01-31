using System;
using System.Globalization;
namespace Exercicio2
{
    class Exercicio2
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;

            Console.WriteLine("Digite qual o raio do circulo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double A = pi * Math.Pow(raio, 2.0);

            Console.WriteLine($"A = {A.ToString("F4",CultureInfo.InvariantCulture)}");
        }
    }
}

using System;
using System.Globalization;

namespace exercicio5
{
    class Exercicio5
    {
        static void Main(string[] args)
        {
            int numPeca1, numPeca2, codigo1, codigo2;
            double valorU1, valorU2, valorP;

            Console.WriteLine("Digite o codigo das pecas: ");
            codigo1 = int.Parse(Console.ReadLine());
            codigo2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade das pecas: ");
            numPeca1 = int.Parse(Console.ReadLine());
            numPeca2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor unitário das pecas: ");
            valorU1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valorU2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            valorP = (numPeca1 * valorU1) + (numPeca2 * valorU2);

            Console.WriteLine($"Valor a pagar: R$ {valorP.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}

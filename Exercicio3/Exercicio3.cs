using System;

namespace Exercicio3
{
    class Exercicio3
    {
        static void Main(string[] args)
        {
            int A, B, C, D;

            Console.WriteLine("Digite o valor de A: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de D: ");
            D = int.Parse(Console.ReadLine());

            int diferenca = (A * B - C * D);

            Console.WriteLine($"Diferença = {diferenca}");
        }
    }
}

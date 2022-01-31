using System;
using System.Globalization;

namespace Exercicio7
{
    class Program
    {
        static int ehPositivo(int n)
        {
            if (n >= 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
        static bool ehPar(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool ehMultiplo(int A, int B)
        {
            if (A % B == 0 || B % A == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            /*Console.WriteLine("Digite um número:");
            int num = int.Parse(Console.ReadLine());

            if(ehPositivo(num) == 1)
            {
                Console.WriteLine("Não negativo");
            }
            else
            {
                Console.WriteLine("Negativo");
            }
            Console.WriteLine("Digite um número:");
            int num2 = int.Parse(Console.ReadLine());

            if (ehPar(num2) == true)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }*/

            Console.WriteLine("Digite um número:");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            if (ehMultiplo(A, B) == true)
            {
                Console.WriteLine("São Multiplos");
            }
            else
            {
                Console.WriteLine("Não São Multiplos");
            }
        }
    }
}

using System;
using System.Globalization;
namespace Exercicio_9
{
    class Program
    {
        //Exercicio 1
        static void impares(int x)
        {
            if (x >= 1 && x <= 1000)
            {
                Console.WriteLine("Saída:");
                for (int i = 1; i <= x; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine($"{i}");
                    }
                }
            }
        }
        //Exercicio 2
        static void intervalo(int x)
        {
            {
                int coutin = 0, coutout = 0;
                for (int i = 1; i <= x; i++)
                {
                    int valor = int.Parse(Console.ReadLine());
                    if (valor >= 10 && valor <= 20)
                    {
                        coutin += 1;
                    }
                    else
                    {
                        coutout += 1;
                    }
                }
                Console.WriteLine($"{coutin} in");
                Console.WriteLine($"{coutout} out");
            }
        }
        //Exercicio 3
        static void mediaP(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                double media = 0.0;
                for (int j = 1; j <= 3; j++)
                {
                    if (j == 1)
                    {
                        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        media += (2 * valor);
                    }
                    else if (j == 2)
                    {
                        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        media += (3 * valor);
                    }
                    else if (j == 3)
                    {
                        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        media += (5 * valor);
                    }
                    else
                    {
                        break;
                    }

                }
                double result = media / 10;
                Console.WriteLine(result.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
        //Exercicio 4
        static void dividePares(int x)
        {
            int[] vet, vet2;
            vet = new int[x];
            vet2 = new int[x];
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Primeiro Numero:");
                vet[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Segundo Numero:");
                vet2[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Saída:");
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet2[i] != 0)
                {
                    Console.WriteLine(vet[i] / vet2[i]);
                }
                else
                {
                    Console.WriteLine("Divisão impossivel");
                }

            }
        }
        //Exercicio 5
        static void fatorial(int num)
        {
            int fat = 0;
            if (num == 0)
            {
                Console.WriteLine("Saída:");
                Console.WriteLine(1);
            }
            else
            {
                for (int i = 1; i <= num; i++)
                {

                    fat += (num * (num - i));
                }
                Console.WriteLine("Saída:");
                Console.WriteLine(fat);
            }

        }
        //Exercicio 6
        static void divisores(int n)
        {
            Console.WriteLine("Saída:");
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    continue;
                }
            }
        }
        //Exercicio 7
        static void quadradoCubo(int n)
        {
            Console.WriteLine("Saída:");
            for (int i = 1; i <= n; i++)
            {
                int quadrado = i * i;
                int cubo = i * i * i;
                Console.WriteLine($"\n{i}  {quadrado}  {cubo}");
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Entrada:");
            int x = int.Parse(Console.ReadLine());
            quadradoCubo(x);

        }
    }
}

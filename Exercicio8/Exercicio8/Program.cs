using System;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1
            /*Console.WriteLine("Digite sua senha: ");
            int senha = int.Parse(Console.ReadLine());
            int senhaCerta = 2002;
            bool check = false;
            while (check == false)
            {
                if(senha == senhaCerta)
                {
                    Console.WriteLine("Acesso Permitido!");
                    check = true;
                }
                else
                {
                    Console.WriteLine("Senha Invalida!");
                    Console.WriteLine("\nDigite sua senha novamente: ");
                    senha = int.Parse(Console.ReadLine());
                }

            }*/
            //Exercicio 2
            /*string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }
                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
            }*/
            int Alcool = 0;
            int Gasolina = 0;
            int Diesel = 0;


            bool check = true;
            while (check == true)
            {
                Console.WriteLine("Digite o código do produto: ");
                int codigo = int.Parse(Console.ReadLine());
                if (codigo == 1)
                {
                    Alcool += 1;
                }
                else if (codigo == 2)
                {
                    Gasolina += 1;
                }
                else if (codigo == 3)
                {
                    Diesel += 1;
                }
                else if(codigo == 4)
                {
                    Console.WriteLine("Muito Obrigado!");
                    Console.WriteLine($"Alcool: {Alcool}");
                    Console.WriteLine($"Gasolina: {Gasolina}");
                    Console.WriteLine($"Diesel: {Diesel}");
                    check = false;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}

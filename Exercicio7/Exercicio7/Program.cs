using System;
using System.Globalization;

namespace Exercicio7
{
    class Program
    {
        //Exercicio 1
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
        //Exercicio 2
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
        //Exercicio 3
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
        //Exercicio 4
        static int duracaoJogo(int hi, int hf)
        {
            if (hi >= hf)
            {
                return 24 - (hi - hf);
            }
            else
            {
                return hf - hi;
            }
        }
        //Exercicio 5
        static double valorPagar(int item)
        {
            if (item == 1)
            {
                return 4.00;
            }
            else if (item == 2)
            {
                return 4.50;
            }
            else if (item == 3)
            {
                return 5.00;
            }
            else if (item == 4)
            {
                return 2.0;
            }
            else if (item == 5)
            {
                return 1.50;
            }
            else
            {
                return 0;
            }

        }
        //Exercicio 6
        static double intervalo(double num)
        {
            if (num >= 0.25 && num <= 25.00)
            {
                return 0.25;
            }
            else if (num > 25.00 && num <= 25.50)
            {
                return 25.50;
            }
            else if (num > 25.50 && num <= 50.75)
            {
                return 50.75;
            }
            else if (num > 50.75)
            {
                return 75.100;
            }
            else
            {
                return 0;
            }
        }
        //Exercicio 7
        static string planoCartesiano(double x, double y)
        {
            if (x == 0.0 && y == 0.0)
            {
                return"Origem";
            }
            else if (x == 0.0)
            {
                return"Eixo Y";
            }
            else if (y == 0.0)
            {
                return"Eixo X";
            }
            else if (x > 0.0 && y > 0.0)
            {
                return"Q1";
            }
            else if (x < 0.0 && y > 0.0)
            {
               return"Q2";
            }
            else if (x < 0.0 && y < 0.0)
            {
               return"Q3";
            }
            else
            {
                return"Q4";
            }
        }
        //Exercicio 8
        static string cauculaImposto(double salario)
        { 
            double imposto;
            if (salario <= 2000.0)
            {
                imposto = 0.0;
            }
            else if (salario <= 3000.0)
            {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0)
            {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0)
            {
                return"Isento";
            }
            else
            {
                return"R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(cauculaImposto(salario));
            
        }
    }
}

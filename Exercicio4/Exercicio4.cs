using System;
using System.Globalization;

namespace Exercicio4
{
    class Exercicio4
    {
        static void Main(string[] args)
        {
            int numF, horas;
            double valor, salario;
              
            Console.WriteLine("Digite o numero do funcionário: ");
            numF = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de horas trabalhadas: ");
            horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite  o valor que recebe por: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horas * valor;

            Console.WriteLine($"Number = {numF}");
            Console.WriteLine($"Salary = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}

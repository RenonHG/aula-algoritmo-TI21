using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a;
            float b;
            float soma, subtracao;
            float divisao, multiplicacao, resto;

            // Console.WriteLine("Hello World poha!");

            Console.Write("Digite o 1º número: ");
            a = int.Parse (Console.ReadLine());

            Console.Write("\nDigite o 2º número: ");
            b = int.Parse(Console.ReadLine());

            soma = a + b;
            Console.WriteLine("\nA soma dos valores deu: " + soma);

            subtracao = a - b;
            Console.WriteLine("A subtração dos valores deu: " +  subtracao);

            multiplicacao = (a * b);
            Console.WriteLine("A multiplicação deu: " + multiplicacao);

            divisao = a / b;
            Console.WriteLine("A divisao deu: " + divisao);












            Console.ReadKey();
        }
    }
}

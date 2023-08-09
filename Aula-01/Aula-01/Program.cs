using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Console.Write("Hello World"); // Console.Write (Console para termos interações com o console e Write serve para escrebrt no console)
            // Console.ReadKey(); // Lê somente uma tecla

            //Variaveis:
            // string  = variaveis de caracteres (cadeia)
            // int = nº inteiros
            // float = nº reais

            int numero1;
            int numero2;
            int numero3;
            int numero4;
            int soma;

         //Para o primeiro número:

            Console.Write("Digite o 1º número: ");
           // int.Parse: converte uma cadeia de caractere para o tipo INTEIRO
            numero1 = int.Parse( Console.ReadLine()); //Lê  sequência de caractere digitado pelo usuário

            // Estamos utilizando o sinal de '+' para concatenar o texto digitado + o valor da variavel "numero1"
            Console.WriteLine("O valor digitado foi: " + numero1);

            //--------------------------------------------------------------------------------------
            //Para o 2º número:
            
            Console.Write("\nDigite o 2º número: ");
            numero2 = int.Parse( Console.ReadLine());
            Console.WriteLine("O valor digitado foi: " + numero2);

            Console.Write("\nDigite o 3º número: ");
            numero3 = int.Parse(Console.ReadLine());
            Console.WriteLine("O valor digitado foi: " + numero3);

            Console.Write("\nDigite o 4º número: ");
            numero4 = int.Parse(Console.ReadLine());
            Console.WriteLine("O valor digitado foi: " + numero4);



            soma = numero1 + numero2 + numero3 + numero4;
            Console.WriteLine("\nO valor total foi: " + soma);



            Console.ReadKey(); //Nesse momento o .readkey serve para o nosso programa não fechar
        }
    }
}

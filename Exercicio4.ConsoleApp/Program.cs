using System;
/*
 * Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.
 */

namespace Exercicio4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número digitado é par!");
            }
            else
            {
                Console.WriteLine("O número digitado é ímpar!");
            }

            Console.ReadKey();

        }
    }
}

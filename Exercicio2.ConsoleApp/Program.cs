using System;
using System.Linq;
/*
 * Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.
 */
namespace Exercicio2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] valores = new int[3];
            int[] ordemDecrescente = new int[3];

            Console.Write("Digite o primeiro valor: ");
            valores[0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            valores[1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            valores[2] = Convert.ToInt32(Console.ReadLine());

            ordemDecrescente = valores.OrderBy(x => x).ToArray();

            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write(ordemDecrescente[i] + "  ");
            }
            Console.ReadKey();

        }
    }
}

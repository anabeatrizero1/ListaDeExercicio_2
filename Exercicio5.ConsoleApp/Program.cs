﻿using System;
/*
 * Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois,
 * caso contrário multiplique A por B.
 * Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e mostrar seu conteúdo na tela.
 */
namespace Exercicio5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Digite o valor de A: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                c = a + b;
            }
            else
            {
                c = a * b;
            }

            Console.WriteLine("O valor de C é: " + c);

            Console.ReadKey();
            
        }
    }
}

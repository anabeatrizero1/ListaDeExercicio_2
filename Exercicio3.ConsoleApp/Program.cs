using System;
/*
 • O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação 
   sobre a condição de peso de uma pessoa adulta.

• A fórmula é IMC = peso / (altura) ²

• Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua condição de acordo com a tabela abaixo.

IMC em adultos Condição
Abaixo de 18,5
Abaixo do peso
Entre 18,5 e 25 Peso normal
Entre 25 e 30
Acima do peso
Acima de 30 obeso
 */

namespace Exercicio3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;

            Console.WriteLine("Digite o peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso.");
            }
            else if (imc > 18.5 && imc <= 25)
            {
                Console.WriteLine("Peso normal.");
            }
            else if (imc > 25 && imc < 30)
            {
                Console.WriteLine("Acima do peso.");
            }
            else if (imc > 30)
            {
                Console.WriteLine("Obeso.");
            }

            Console.ReadKey();

        }
    }
}

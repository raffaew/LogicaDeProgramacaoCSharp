/*
 Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste 
de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes 
conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem 
peso 5
*/

using System;
using System.Globalization;

namespace Exercício03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira uma quantidade para repetição");
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                string[] n = Console.ReadLine().Split(' ');
                double n1 = double.Parse(n[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(n[1], CultureInfo.InvariantCulture);
                double n3 = double.Parse(n[2], CultureInfo.InvariantCulture);

                double calc = ( n1 * 2.0 + n2 * 3.0 + n3 * 5.0) / (2 + 3 + 5);
                Console.WriteLine(calc.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}

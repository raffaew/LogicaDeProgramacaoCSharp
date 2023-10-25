using System;

namespace Exercício07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de repetições");
            int input = int.Parse(Console.ReadLine());

            for(int i = 1; i <= input; i++) {

                int linha = i;
                int quadrado = i * i;
                int cubo = i * i * i;

                Console.WriteLine($"{linha} {quadrado} {cubo}");
            }
        }
    }
}

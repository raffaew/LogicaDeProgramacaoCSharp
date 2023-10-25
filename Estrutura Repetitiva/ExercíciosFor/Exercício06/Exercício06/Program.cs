using System;

namespace Exercício06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de repetições");
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}

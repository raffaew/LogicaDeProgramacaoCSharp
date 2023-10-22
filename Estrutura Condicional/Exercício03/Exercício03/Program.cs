using System;

namespace Exercício03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira dois valores inteiros!");
            string[] input = (Console.ReadLine().Split(' '));

            int num1 = int.Parse(input[0]);
            int num2 = int.Parse(input[1]);

            if(num1 % num2 == 0 || num2 % num1 == 0 )
            {
                Console.WriteLine($"Você digitou {num1} e {num2}. São multiplos!");
            }else
            {
                Console.WriteLine($"Você digitou {num1} e {num2}. Não são multiplos!");
            }
            
        }
    }
}

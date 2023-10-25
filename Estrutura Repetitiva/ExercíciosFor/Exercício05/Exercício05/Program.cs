using System;

namespace Exercício05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma quantidade para repetição");
            int input = int.Parse(Console.ReadLine());

            int n = 1;

            for (int i = 1; i <= input; i++)
            {
                n *= i;
                Console.WriteLine(n);
                // input sendo 4 repete as instruções 4x
                // loop: 1*1 n = 1; 1*2 n = 2; 2*3 n = 6; 6*4 n = 24;
                // imprime: 24
            }
            
        }
    }
}

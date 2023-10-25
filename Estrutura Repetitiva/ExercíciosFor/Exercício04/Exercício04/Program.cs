using System;

namespace Exercício04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma quantidade para repetiçao:");
            int input = int.Parse(Console.ReadLine());

            for(int i = 0; i < input; i++)
            {
                string [] n = Console.ReadLine().Split(' ');
                int n1 = int.Parse(n[0]);
                int n2 = int.Parse(n[1]);

                if (n2 == 0)
                {
                    Console.WriteLine("Divisão impossivel");
                }else
                {
                    double calc = n1 / n2;
                    Console.WriteLine(calc);
                }
            }
        }
    }
}

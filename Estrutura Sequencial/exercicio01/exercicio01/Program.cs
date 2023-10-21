using System;

namespace exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inNum = Console.ReadLine();
            string[] vet = inNum.Split(' ');

            int outNum = int.Parse(vet[0]);
            int outNum2 = int.Parse(vet[1]);

            Console.WriteLine("SOMA = " + (outNum + outNum2));
        }
    }
}

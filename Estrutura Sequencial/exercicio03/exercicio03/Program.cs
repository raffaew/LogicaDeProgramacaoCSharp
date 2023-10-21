using System;

namespace exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dados = Console.ReadLine();
            string[] outDados = dados.Split (' ');
            int A = int.Parse(outDados[0]);
            int B = int.Parse(outDados[1]);
            int C = int.Parse(outDados[2]);
            int D = int.Parse(outDados[3]);

            int dif = (A * B) - (C * D);
            Console.WriteLine("DIFERENÇA = "+dif);

            
        }
    }
}

using System;

namespace Exercício04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a hora inicial e a hora final de um jogo!");

            //Pega os dados de entrada e na ocorrencia de espaços, armazena em um array.
            string[] input = (Console.ReadLine().Split(' '));

            int inicio = int.Parse(input[0]);
            int fim = int.Parse(input[1]);
            int day = 24;

            if(inicio > fim)
            {
               int calc = day - (inicio - fim);
                Console.WriteLine($"O jogo durou {calc} hora(s)");
            }else
            {
                int calc = fim - inicio;
                Console.WriteLine($"O jogo durou {calc} hora(s)");
            }


            
           

        
        }
    }
}

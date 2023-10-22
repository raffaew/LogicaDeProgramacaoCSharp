using System;
using System.Globalization;

namespace Exercício05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o codigo e a quantidade deste item!");

            //Lê os dados de entrada e na ocorrência de espaços separa os itens em um array
            string[] input = (Console.ReadLine().Split(' '));
            int codigo = int.Parse(input[0]);
            int quantidade = int.Parse(input[1]);

            
            double calc = 0;
            if(codigo == 1)
            {
                calc = quantidade * 4.0;
            }else if(codigo == 2)
            {
                calc = quantidade * 4.5;
            }
            else if (codigo == 3)
            {
                calc = quantidade * 5.0;
            }
            else if (quantidade == 4)
            {
                calc = quantidade * 2.0;
            }
            else if(quantidade == 5)
            {
                calc = quantidade * 1.5;
            }
            else
            {
                Console.WriteLine("Digite um código entre 1 e 5");
            }

            //Imprime a mensagem "Total" seguida do valor calculado com formatação "F2" --> Duas casas decimais
            //CultureInfo.InvariantCulture é uma instância da classe CultureInfo que representa uma cultura neutra. Ela é usada para garantir que formatações e análises de números, datas e outras informações culturais sejam independentes da cultura do sistema operacional do computador.
            Console.WriteLine($"Total: R$ {calc.ToString("F2", CultureInfo.InvariantCulture)}");
            
        }
    }
}

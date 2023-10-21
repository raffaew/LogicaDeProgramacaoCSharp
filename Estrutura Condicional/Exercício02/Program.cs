using System;

namespace Exercício02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:"); // Solicita ai usuário que digite um número inteiro
            string input = Console.ReadLine(); // Lê a entrada do usuário e armazena como uma string

            // Tenta converter a string 'input' em um número inteiro e armazena o resultado em 'inNum',
            // retornando true se a conversão for bem-sucedida e false se falhar.
            if (int.TryParse(input, out int inNum))
            {
                // Se a conversão for bem-sucedida
                // Determina se o número é PAR ou IMPAR pela condição ternária e armazena a mensagem apropriada em "mensagem"
                string mensagem = inNum % 2 == 0 ? "PAR" : "IMPAR";
                Console.WriteLine("Você digitou " + inNum + " " + mensagem);
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
            }
        }
    }
}

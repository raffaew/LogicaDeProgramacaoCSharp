using System; 

namespace Exercício01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:"); // Solicita ao usuário que digite um número
            string input = Console.ReadLine(); // Lê a entrada do usuário e armazena como uma string

            if (int.TryParse(input, out int inNum))
            {
                // Se a conversão for bem-sucedida
                // Determina se o número é positivo ou negativo e armazena a mensagem apropriada em "mensagem"
                string mensagem = inNum < 0 ? "NEGATIVO" : "POSITIVO";

                // Exibe a mensagem, incluindo o valor e se é positivo ou negativo
                Console.WriteLine("Você digitou " + inNum + " " + mensagem);
            }
            else
            {
                // Tratamento para entrada inválida
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
            }

        }
    }
}

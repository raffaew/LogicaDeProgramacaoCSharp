using System;

namespace Exercício01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro para verificar quantos impares possui: ");
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                // Se i / 2 resultar em resto da divisão = 0, i será um número imprar.
                // A estrutura repete ate i ser igual ao número digitado pelo usuário.
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

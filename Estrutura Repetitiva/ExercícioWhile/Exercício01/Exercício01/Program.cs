using System;

namespace Exercício01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a senha: ");
            int input = int.Parse(Console.ReadLine());
            int password = 2002;
            
            // Enquanto os dados inserido não forem igual password, o loop inicia, e executa as linhas de código entre {}.
            while(input!= password)
            {
                Console.Write("Senha Inválida, Tente novamente: ");
                input = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}

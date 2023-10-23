using System;

namespace Exercício03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual o tipo de combustível abastecido? ");
            int tipo = int.Parse(Console.ReadLine());

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            
            while (tipo != 4) {
                if(tipo == 1)
                {
                    alcool++;
                }else if (tipo ==2)
                {
                    gasolina++;
                }else if (tipo == 3)
                {
                    diesel++;
                }

                Console.Write("Qual o tipo de combustível abastecido? ");
                tipo = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine($"\nMUITO OBRIGADO\nAlcool: {alcool}\nGasolina: {gasolina}\nDiesel :{diesel}");
        }
    }
}

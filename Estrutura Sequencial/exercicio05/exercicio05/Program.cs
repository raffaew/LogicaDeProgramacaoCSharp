using System;
using System.Globalization;

namespace exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dados = Console.ReadLine();
            string[] saidaDados = (dados.Split(' '));

            int peca = int.Parse(saidaDados[0]);
            int nPecas = int.Parse(saidaDados[1]);
            double vPecas = double.Parse(saidaDados[2], CultureInfo.InvariantCulture);

            int peca2 = int.Parse(saidaDados[3]);
            int nPecas2 = int.Parse(saidaDados[4]);
            double vPecas2 = double.Parse(saidaDados[5], CultureInfo.InvariantCulture);

            double calc = (nPecas * vPecas) + (nPecas2 * vPecas2);

            Console.WriteLine("VALOR TOTAL A PAGAR: R$ " + calc.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

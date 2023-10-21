using System;
using System.Globalization;

namespace exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = 3.14159;

            double calc = area * raio * raio;

            Console.WriteLine("A=" + calc.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}

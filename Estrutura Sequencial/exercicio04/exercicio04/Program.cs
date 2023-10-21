using System; 
using System.Globalization;

namespace exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
           
            double calc = horas * salario;
            Console.WriteLine("NUMBER = " + numero + "\n" + "SALARIO U$ " + calc.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

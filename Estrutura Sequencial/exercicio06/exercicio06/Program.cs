using System;
using System.Globalization;

namespace exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //a área do triângulo retângulo que tem A por base e C por altura.
            triangulo = A * C / 2.0;

            //a área do círculo de raio C. (pi = 3.14159) 
            circulo = 3.14159 * C * C;

            // a área do trapézio que tem A e B por bases e C por altura. 
            trapezio = (A + B) / 2.0 * C;

            // a área do quadrado que tem lado B. 
            quadrado = B * B;

            // a área do retângulo que tem lados A e B.
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}

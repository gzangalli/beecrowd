using System;
using System.Globalization;

namespace beecrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, triangulo, circulo, trapezio, quadrado, retangulo;
            double pi = 3.14159;

            string[] inputs = Console.ReadLine().Split(' ');
            a = double.Parse(inputs[0], CultureInfo.CurrentCulture);
            b = double.Parse(inputs[1], CultureInfo.CurrentCulture);
            c = double.Parse(inputs[2], CultureInfo.CurrentCulture);

            triangulo = (a * c) / 2;
            circulo = pi * (c * c);
            trapezio = ((a + b) * c) / 2;
            quadrado = b * b;
            retangulo = a * b;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.CurrentCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.CurrentCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.CurrentCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.CurrentCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.CurrentCulture));

        }
    }
}
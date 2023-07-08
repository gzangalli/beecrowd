using System;

namespace beecrowd
{
    class BEE1011
    {
        static void Main(string[] args) {
            double pi = 3.14159;
            double raio = float.Parse(Console.ReadLine());
            double volume = (4/3.0) * pi * (raio * raio * raio);

            Console.WriteLine("VOLUME = " + volume.ToString("F3"));
         }
    }
}

using System;

namespace beecrowd
{
    class BEE1017
    {
        static void Main(string[] args)
        {
            int tempo = int.Parse(Console.ReadLine());
            int velocidade = int.Parse(Console.ReadLine());

            int distancia = tempo * velocidade;
            double litros = distancia / 12.0;

            Console.WriteLine(litros.ToString("F3"));
        }
    }
}

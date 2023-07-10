using System;

namespace beecrowd
{
    class BEE1943
    {
        static void Main(string[] args)
        {
            int[] categorias = { 1, 3, 5, 10, 25, 50, 100 };

            int K = int.Parse(Console.ReadLine());

            foreach (int categoria in categorias)
            {
                if (K <= categoria)
                {
                    Console.WriteLine($"Top {categoria}");
                    break;
                }
            }
        }
    }
}

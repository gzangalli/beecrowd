using System;

namespace beecrowd
{
    class BEE2388
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int distanciaTotal = 0;

            for (int i = 0; i < N; i++)
            {
                string[] intervalo = Console.ReadLine().Split();
                int T = int.Parse(intervalo[0]);
                int V = int.Parse(intervalo[1]);
                distanciaTotal += T * V;
            }

            Console.WriteLine(distanciaTotal);
        }
    }
}

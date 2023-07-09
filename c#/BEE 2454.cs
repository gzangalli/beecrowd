using System;

namespace beecrowd
{
    class BEE2454
    {
        static void Main(string[] args)
        {
            string[] posicoes = Console.ReadLine().Split();

            int P = int.Parse(posicoes[0]);
            int R = int.Parse(posicoes[1]);

            if (P == 1 && R == 1)
            {
                Console.WriteLine("A");
            }
            else if (P == 1 && R == 0)
            {
                Console.WriteLine("B");
            }
            else
            {
                Console.WriteLine("C");
            }
        }
    }
}

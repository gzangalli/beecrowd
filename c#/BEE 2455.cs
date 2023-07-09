using System;

namespace beecrowd
{
    class BEE2455
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split();
            int P1 = int.Parse(valores[0]);
            int C1 = int.Parse(valores[1]);
            int P2 = int.Parse(valores[2]);
            int C2 = int.Parse(valores[3]);

            int equilibrio = P1 * C1 - P2 * C2;

            if (equilibrio == 0)
            {
                Console.WriteLine(0);
            }
            else if (equilibrio > 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(1);
            }
        }
    }
}

using System;

namespace beecrowd
{
    class BEE2386
    {
        static void Main(string[] args)
        {
            int Telescopio = int.Parse(Console.ReadLine());
            int numEstrelas = int.Parse(Console.ReadLine());

            int estrelasVisiveis = 0;

            for (int i = 0; i < numEstrelas; i++)
            {
                int fotons = int.Parse(Console.ReadLine());
                if (fotons * Telescopio >= 40000000)
                {
                    estrelasVisiveis++;
                }
            }

            Console.WriteLine(estrelasVisiveis);
        }
    }
}

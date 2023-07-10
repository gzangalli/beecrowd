using System;
using System.Collections.Generic;

namespace beecrowd
{
    class BEE1259
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            List<int> pares = new List<int>();
            List<int> impares = new List<int>();

            for (int i = 0; i < N; i++)
            {
                int valor = int.Parse(Console.ReadLine());
                if (valor % 2 == 0)
                {
                    pares.Add(valor);
                }
                else
                {
                    impares.Add(valor);
                }
            }

            pares.Sort();
            impares.Sort((x, y) => y.CompareTo(x));

            List<int> final = new List<int>();
            final.AddRange(pares);
            final.AddRange(impares);

            foreach (int valor in final)
            {
                Console.WriteLine(valor);
            }
        }
    }
}

using System;

namespace beecrowd
{
    class BEE2058
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // O número mínimo de triângulos é igual a (N - 2)
            int minTriangles = n - 2;

            Console.WriteLine(minTriangles);
        }
    }
}

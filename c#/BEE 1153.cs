using System;

namespace beecrowd
{
    class BEE1153
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int fatorial = 1;
            for (int i = 2; i <= n; i++)
            {
                fatorial *= i;
            }

            Console.WriteLine(fatorial);
        }
    }
}

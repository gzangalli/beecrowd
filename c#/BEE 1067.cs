using System;

namespace beecrowd
{
    class BEE1067
    {
        static void Main(string[] args)
        {
            int x;
            x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

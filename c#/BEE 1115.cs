using System;

namespace beecrowd
{
    class BEE1115
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] coordinates = Console.ReadLine().Split();
                int x = int.Parse(coordinates[0]);
                int y = int.Parse(coordinates[1]);

                if (x == 0 || y == 0)
                {
                    break;
                }
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }
            }
        }
    }
}

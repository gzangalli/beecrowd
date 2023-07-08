using System;

namespace beecrowd
{
    class BEE2344
    {
        static void Main(string[] args)
        {
            int nota = int.Parse(Console.ReadLine());

            if (nota == 0)
            {
                Console.WriteLine("E");
            }
            else if (nota < 36)
            {
                Console.WriteLine("D");
            }
            else if (nota < 61)
            {
                Console.WriteLine("C");
            }
            else if (nota < 86)
            {
                Console.WriteLine("B");
            }
            else
            {
                Console.WriteLine("A");
            }
        }
    }
}

using System;

namespace beecrowd
{
    class BEE2861
    {
        static void Main(string[] args)
        {
            int perguntas = 0;

            while(true)
            {
                perguntas = int.Parse(Console.ReadLine());
                if (perguntas < 2 || perguntas > 99)
                {
                    perguntas = int.Parse(Console.ReadLine());
                }
                break;
            }

            for (int i = 0; i < perguntas; i++)
            {
                Console.ReadLine();
                Console.WriteLine("gzuz");
            }
        }
    }
}

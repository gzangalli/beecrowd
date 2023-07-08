using System;

namespace beecrowd
{
    class BEE2753
    {
        static void Main(string[] args)
        {
            int a = 97;

            for (int i = 0; i < 26; i++)
            {
                int numero = a + i;
                char letra = (char)numero;
                Console.WriteLine($"{numero} e {letra}");
            }
        }
    }
}

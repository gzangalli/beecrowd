using System;

namespace beecrowd
{
    class BEE1018
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());

            Console.WriteLine(valor);

            int[] notas = { 100, 50, 20, 10, 5, 2, 1 };

            foreach (int nota in notas)
            {
                int quantidade = valor / nota;
                Console.WriteLine($"{quantidade} nota(s) de R$ {nota},00");
                valor %= nota;
            }
        }
    }
}

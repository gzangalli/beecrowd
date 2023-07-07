using System;

namespace beecrowd
{
    class BEE2006
    {
        static void Main(string[] args)
        {
            int tipoCha = int.Parse(Console.ReadLine());
            string[] respostas = Console.ReadLine().Split();

            int numeroAcertos = 0;
            foreach (string resposta in respostas)
            {
                if (int.Parse(resposta) == tipoCha)
                {
                    numeroAcertos++;
                }
            }
            Console.WriteLine(numeroAcertos);
        }
    }
}

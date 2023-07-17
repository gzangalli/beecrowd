using System;

namespace beecrowd
{
    class BEE3419
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int N = int.Parse(inputs[0]); // Número de pilotos
            int V = int.Parse(inputs[1]); // Número de voltas

            int[] pilotos = new int[N]; // Array para armazenar os números dos pilotos
            TimeSpan[] melhoresVoltas = new TimeSpan[N]; // Array para armazenar as melhores voltas dos pilotos

            for (int i = 0; i < N; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');
                pilotos[i] = int.Parse(linha[0]);

                TimeSpan melhorVolta = TimeSpan.MaxValue;
                for (int j = 1; j <= V; j++)
                {
                    TimeSpan volta = TimeSpan.ParseExact(linha[j], @"m\:s\:fff", null);
                    if (volta < melhorVolta)
                    {
                        melhorVolta = volta;
                    }
                }

                melhoresVoltas[i] = melhorVolta;
            }

            TimeSpan melhorTempo = TimeSpan.MaxValue;
            int pilotoComMelhorVolta = -1;

            for (int i = 0; i < N; i++)
            {
                if (melhoresVoltas[i] < melhorTempo)
                {
                    melhorTempo = melhoresVoltas[i];
                    pilotoComMelhorVolta = pilotos[i];
                }
            }

            if (pilotoComMelhorVolta != -1)
            {
                Console.WriteLine(pilotoComMelhorVolta);
            }
            else
            {
                Console.WriteLine("NENHUM");
            }
        }
    }
}

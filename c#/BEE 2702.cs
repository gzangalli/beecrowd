using System;

namespace beecrowd
{
    class BEE2702
    {
        static void Main(string[] args)
        {
            string[] disponivel = Console.ReadLine().Split();
            string[] requisitado = Console.ReadLine().Split();

            int frangoDisponivel = int.Parse(disponivel[0]);
            int bifeDisponivel = int.Parse(disponivel[1]);
            int massaDisponivel = int.Parse(disponivel[2]);

            int frangoRequisitado = int.Parse(requisitado[0]);
            int bifeRequisitado = int.Parse(requisitado[1]);
            int massaRequisitado = int.Parse(requisitado[2]);

            int faltante = 0;

            if (frangoRequisitado > frangoDisponivel)
            {
                faltante += frangoRequisitado - frangoDisponivel;
            }

            if (bifeRequisitado > bifeDisponivel)
            {
                faltante += bifeRequisitado - bifeDisponivel;
            }

            if (massaRequisitado > massaDisponivel)
            {
                faltante += massaRequisitado - massaDisponivel;
            }

            Console.WriteLine(faltante);
        }
    }
}

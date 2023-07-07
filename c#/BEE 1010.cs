using System;

namespace beecrowd
{
    class BEE1010
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split();
            string[] input2 = Console.ReadLine().Split();

            int cod1 = int.Parse(input1[0]);
            int quant1 = int.Parse(input1[1]);
            double valor1 = double.Parse(input1[2]);

            int cod2 = int.Parse(input2[0]);
            int quant2 = int.Parse(input2[1]);
            double valor2 = double.Parse(input2[2]);

            double valorTotal = (quant1 * valor1) + (quant2 * valor2);

            Console.WriteLine($"VALOR A PAGAR: R$ {valorTotal.ToString("F2")}");
        }
    }
}

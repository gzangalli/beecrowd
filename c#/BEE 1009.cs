using System;

namespace beecrowd
{
    class BEE1009
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            float salario = float.Parse(Console.ReadLine());
            float vendas = float.Parse(Console.ReadLine());

            float bonus = (vendas * 15) / 100;

            float salarioTotal = salario + bonus;

            Console.WriteLine("TOTAL = R$ " + salarioTotal.ToString("F2"));
        }
    }
}
using System;

namespace beecrowd
{
    class BEE1008
    {
        static void Main(string[] args)
        {
            int funcionario = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            float salario = float.Parse(Console.ReadLine());

            float salarioTotal = horas * salario;

            Console.WriteLine("NUMBER = " + funcionario);
            Console.WriteLine("SALARY = U$ " + salarioTotal.ToString("F2"));
        }
    }
}
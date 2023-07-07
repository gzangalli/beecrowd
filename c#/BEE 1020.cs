using System;

namespace beecrowd
{
    class BEE1020
    {
        static void Main(string[] args)
        {
            int dias = int.Parse(Console.ReadLine());

            int anos = dias / 365;
            int meses = (dias % 365) / 30;
            dias = (dias % 365) % 30;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
        }
    }
}

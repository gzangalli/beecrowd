using System;
using System.Text.RegularExpressions;

namespace beecrowd
{
    class BEE3140
    {
        static void Main(string[] args)
        {
            string line;
            bool isBodyContent = false;

            while ((line = Console.ReadLine()) != null)
            {
                if (line.Contains("<body>"))
                {
                    isBodyContent = true;
                    continue;
                }
                else if (line.Contains("</body>"))
                {
                    isBodyContent = false;
                    continue;
                }

                if (isBodyContent)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}

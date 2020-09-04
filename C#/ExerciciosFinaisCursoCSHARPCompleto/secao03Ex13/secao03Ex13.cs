using System;

namespace secao03Ex13
{
    class secao03Ex13
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');

            double x = double.Parse(valores[0]);
            double y = double.Parse(valores[1]);

            if (x == y && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
    }
}

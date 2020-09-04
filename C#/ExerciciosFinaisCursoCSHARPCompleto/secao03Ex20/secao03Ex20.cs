using System;
using System.Globalization;

namespace secao03Ex20
{
    class secao03Ex20
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i <= n; i++)
            {
                string[] conjTeste = Console.ReadLine().Split(' ');
                double a = double.Parse(conjTeste[0], CultureInfo.InvariantCulture) * 2;
                double b = double.Parse(conjTeste[1], CultureInfo.InvariantCulture) * 3;
                double c = double.Parse(conjTeste[2], CultureInfo.InvariantCulture) * 5;
                double average = (a + b + c) / 10;
                Console.WriteLine(average.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}

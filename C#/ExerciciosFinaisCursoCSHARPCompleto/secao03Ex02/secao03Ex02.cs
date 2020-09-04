using System;
using System.Globalization;

namespace secao03Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            double raioCirc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaCirc = Math.PI * Math.Pow(2, raioCirc);


            Console.WriteLine($"A = {areaCirc.ToString("F4")}");

        }
    }
}

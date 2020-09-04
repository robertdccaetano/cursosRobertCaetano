using System;
using System.Globalization;

namespace secao03Ex06
{
    class secao03Ex06
    {
        static void Main(string[] args)
        {
            string[] captaValores = Console.ReadLine().Split(' ');

            double A = double.Parse(captaValores[0], CultureInfo.InvariantCulture);
            double B = double.Parse(captaValores[1], CultureInfo.InvariantCulture);
            double C = double.Parse(captaValores[2], CultureInfo.InvariantCulture);

            double areaTriang = A * C / 2.0;
            Console.WriteLine("TRIANGULO:" + areaTriang.ToString("F3", CultureInfo.InvariantCulture));

            double areaCirc = Math.Pow(C, 2) * Math.PI;
            Console.WriteLine("CIRCULO: " + areaCirc.ToString("F3", CultureInfo.InvariantCulture));

            double areaTrapezio = (A + B) * C / 2;
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));

            double areaQuadrado = B * B;
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));

            double areaRetangulo = A * B;
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
           
        }
    }
}

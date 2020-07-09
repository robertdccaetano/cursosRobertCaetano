using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Secao4ClassesAtributosMetodos
{
    class MembrosEstaticos
    {
        static double Pi = 3.14;

        public static void Main(string[] args)
        {

            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circuferência: " +  circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

        }

        static double Circunferencia(double r)
        {

            return 2 * Pi * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3 * Pi * Math.Pow(r, 3);
        }
    }
}

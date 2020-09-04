using secao04Ex03.Entities;
using System;
using System.Globalization;

namespace secao04Ex03
{
    class secao04Ex03
    {
        static void Main(string[] args)
        {
            Retangulo r1 = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retângulo: ");
            r1.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r1.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + r1.Area().ToString("F2"));
            Console.WriteLine("PERÍMETRO = " + r1.Perimetro().ToString("F2"));
            Console.WriteLine("DIAGONAL = " + r1.Diagonal().ToString("F2"));
            
        }
    }
}

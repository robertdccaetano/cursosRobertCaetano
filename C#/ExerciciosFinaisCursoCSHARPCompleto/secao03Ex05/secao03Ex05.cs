using System;
using System.Globalization;

namespace secao03Ex05
{
    class secao03Ex05
    {
        static void Main(string[] args)
        {
            double[] vet1 = new double[3];
            double[] vet2 = new double[3];

            vet1[0] = double.Parse(Console.ReadLine());
            vet1[1] = double.Parse(Console.ReadLine());
            vet1[2] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            vet2[0] = double.Parse(Console.ReadLine());
            vet2[1] = double.Parse(Console.ReadLine());
            vet2[2] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double somaValorPecas = (vet1[1] * vet1[2]) + (vet2[1] * vet2[2]);
            Console.WriteLine("VALOR A PAGAR: R$ " + somaValorPecas.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

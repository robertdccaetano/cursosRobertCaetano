using secao04Ex06.Entities;
using System;
using System.Globalization;

namespace secao04Ex06
{
    class secao04Ex06
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dolar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares você vai comprar? ");
            double qtdDolComprar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.DolarParaReal(qtdDolComprar, cotacao).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

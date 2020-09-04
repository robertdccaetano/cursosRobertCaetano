using System;
using System.Globalization;

namespace secao03Ex11
{
    class secao03Ex11
    {
        static void Main(string[] args)
        {
            string[] valorCodigoQtd = Console.ReadLine().Split(' ');

            int codigo = int.Parse(valorCodigoQtd[0]);
            int qtd = int.Parse(valorCodigoQtd[1]);

            double valorTotal;

            if (codigo == 1)
            {
                valorTotal = qtd * 4.00;
            }
            else if (codigo == 2)
            {
                valorTotal = qtd * 4.50;
            }
            else if (codigo == 3)
            {
                valorTotal = qtd * 5.00;
            }
            else if (codigo == 4)
            {
                valorTotal = qtd * 2.00;
            }
            else if (codigo == 5)
            {
                valorTotal = qtd * 1.50;
            } else
            {
                valorTotal = 0;
            }

            Console.WriteLine("Total: R$" + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

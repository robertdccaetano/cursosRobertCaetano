using System;

namespace secao03Ex09
{
    class secao03Ex09
    {
        static void Main(string[] args)
        {
            string[] valoresMulti = Console.ReadLine().Split(' ');

            int a = int.Parse(valoresMulti[0]);
            int b = int.Parse(valoresMulti[1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("SÃO MÚLTIPLOS");
            }
            else
            {
                Console.WriteLine("NÃO SÃO MÚLTIPLOS");
            }


        }
    }
}

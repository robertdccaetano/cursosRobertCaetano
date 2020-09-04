using System;

namespace secao03Ex17
{
    class secao03Ex17
    {
        static void Main(string[] args)
        {
            int codigoCombustivel = int.Parse(Console.ReadLine());
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (codigoCombustivel != 4)
            {
                if (codigoCombustivel == 1)
                {
                    alcool += 1;
                }
                else if (codigoCombustivel == 2)
                {
                    gasolina += 1;
                }
                else if (codigoCombustivel == 3)
                {
                    diesel += 1;
                }
                else
                {
                }
                codigoCombustivel = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}

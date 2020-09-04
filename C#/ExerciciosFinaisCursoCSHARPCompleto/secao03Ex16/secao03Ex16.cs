using System;

namespace secao03Ex16
{
    class secao03Ex16
    {
        static void Main(string[] args)
        {
            string[] coordenadas = Console.ReadLine().Split(' ');

            double x = double.Parse(coordenadas[0]);
            double y = double.Parse(coordenadas[1]);

            while (x != 0.0 && y != 0.0)
            {
                if (x > 0.0 && y > 0.0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if (x < 0.0 && y > 0.0)
                {
                    Console.WriteLine("Segundo");
                }
                else if (x < 0.0 && y < 0.0)
                {
                    Console.WriteLine("Terceiro");
                }
                else if (x > 0.0 && y < 0.0)
                {
                    Console.WriteLine("Quarto");
                }
                else
                {
                    Console.WriteLine("Impossível de acontecer");
                }

                coordenadas = Console.ReadLine().Split(' ');
                x = int.Parse(coordenadas[0]);
                y = int.Parse(coordenadas[1]);

            }
        }
    }
}

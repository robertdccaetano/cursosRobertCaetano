using System;

namespace secao03Ex18
{
    class secao03Ex18
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());

            for(int i = 1; i < valor; i++)
            {
                if(i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

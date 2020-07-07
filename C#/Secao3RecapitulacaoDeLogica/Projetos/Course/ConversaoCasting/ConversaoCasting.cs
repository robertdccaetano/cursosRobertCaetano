using System;

namespace ConversaoCasting
{
    class ConversaoCasting
    {
        static void Main(string[] args)
        {

            //Conversao Implícita
            float x = 4.5f;
            double y = x;

            Console.WriteLine(y);

            double a;
            float b;

            //Conversao implicita  de float em double (somente pode ser feita com casting)
            //Conversao so pode ser feita explicitamente com casting ex: (float) (double) (int)variavel
            a = 5.1;
            b = (float)a;
            Console.WriteLine(b);

            int k = 5;
            int q = 2;

            //Casting para retornar um resultado double na divisao de dois números ints
            double result = (double) k / q;
            Console.WriteLine(result);

        }
    }
}

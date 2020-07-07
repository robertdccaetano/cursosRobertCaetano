using System;

namespace OperadoresAtribuicao
{
    class OperadoresAtribuicao
    {
        static void Main(string[] args)
        {

            //OP ATRIBUICAO Cumulativo
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            //OP ATRIBUICAO Cumulativo de Strings
            s += "DEF";
            Console.WriteLine(s);

            //OP ATRIBUICAO ARITMÉTICOS
            int b = 10;
            b++;
            Console.WriteLine(b);

            Console.WriteLine("===================");
            int x = 10;
            int y = x++;
            int z = ++x;

            Console.WriteLine(x);
            Console.WriteLine(z);

        }
    }
}

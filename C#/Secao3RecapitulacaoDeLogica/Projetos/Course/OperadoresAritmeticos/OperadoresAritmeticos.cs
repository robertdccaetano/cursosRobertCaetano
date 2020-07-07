using System;

namespace OperadoresAritmeticos
{
    class OperadoresAritmeticos
    {
        static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            int n4 = 10 / 8;
            double n5 = 10.0 / 8.0;
            double n6 = (double) 10 / 8;


            //FORMULA DE BHASKARA
            double a = 1.0, b = -3.0, c = -4.0;
            //Delta sem Funcao Math
            double delta = b * b - 4.0 * a * c;
            //Delta com funcao Math.Pow
            double delta2 = Math.Pow(b, 2.0) - 4.0 * a * c;
            //Math.Sqrt funcao raiz quadrada
            double x1 = -b + ( Math.Sqrt(delta2) ) / ( 2 * a );


            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine("===============\n" );
            Console.WriteLine(delta2);
            Console.WriteLine(x1);

        }
    }
}

using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //sbyte x = 100;
            //Console.WriteLine($"O valor da var é {x}");

            byte n1 = 126;
            //Caracteres char deve ser inserido em aspas simples
            //char pode utilizar tanto o caractere quanto o unicode do mesmo
            char genero = 'M';
            char letra = '\u0041';
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            bool completo = false;
            //Float identifica-se com letra f no final do valor ex: 4.5f
            float varFloat = 10.5f;
            double varDouble = 10.5;
            //Cadeia de caractere imutavel, maneira de deixar o software seguro e livre de erros
            string varString =  "Jesus is alive";
            //varString = "Good news";

            //Tipo (object) é um objeto genérico (toda classe em C# é uma subclasse(filha de object) 
            //Aceita qualquer coisa
            object obj1 = "Robert Caetano";
            object obj2 = 4.5f;

            //Print na tela

            Console.WriteLine(varDouble);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(completo);
            Console.WriteLine("M");
            Console.WriteLine(letra);
            Console.WriteLine(varFloat);
            Console.WriteLine(varString);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

        }
    }
}

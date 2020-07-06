using System;
using System.Globalization;

namespace SaidaDeDados
{
    class SaidaDeDados
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.3578;
            string nome = "Jesus";

            Console.Write("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");

            //Console.WriteLine("--------------------");
            //Console.WriteLine(genero);
            //Console.WriteLine(idade);
            //Console.WriteLine(saldo);
            //Console.WriteLine(nome);

            ////Delimita casa decimais e arredonda de 0 a 4 para baixo de 5 a 9 para cima
            //Console.WriteLine(saldo.ToString("F2"));
            //Console.WriteLine(saldo.ToString("F4"));

            //Namespace System.Globalization = InvariantCulture desconsidera qualquer formatacao especifica de pais
            //neste caso remove a vírgual da var saldo e insere o ponto como delimitador
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            // PLACEHOLDER
            Console.WriteLine("{0} tem {1} anos de idade e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            //INTERPOLACAO
            Console.WriteLine($"{nome} tem {idade} anos de idade e tem saldo igual a {saldo:F2} reais");

            //CONCATENACAO DE STRINGS
            Console.WriteLine(nome + " tem " + idade + " anos de idade e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");


        }
    }
}

using System;
using System.Globalization;

namespace EntradaDadosPT2
{
    class EntradaDadosPT2
    {
        static void Main(string[] args)
        {
            //int n1 = int.Parse(Console.ReadLine());
            //char ch = char.Parse(Console.ReadLine());
            //double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // tipoDado.Parse(variavel);
            string[] vetor = Console.ReadLine().Split(' ');
            string nome = vetor[0];
            char sexo = char.Parse(vetor[1]);
            int idade = int.Parse(vetor[2]);
            double altura = double.Parse(vetor[3], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

            //Console.WriteLine("Você digitou: ");
            //Console.WriteLine(n1);
            //Console.WriteLine(ch);
            //Console.WriteLine(n2.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}

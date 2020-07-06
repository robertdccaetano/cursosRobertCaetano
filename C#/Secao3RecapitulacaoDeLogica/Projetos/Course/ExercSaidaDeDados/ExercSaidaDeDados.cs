using System;
using System.Globalization;

namespace ExercSaidaDeDados
{
    class ExercSaidaDeDados
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:\n");

            Console.WriteLine($"{produto1}, cujo preço é  R$ {preco1:F2}");

            Console.WriteLine($"{produto2}, cujo preço é R$ {preco2} \n");

            Console.WriteLine($"Registro: {idade} anos de idade, código 5290 e gênero: {genero} \n");

            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}\n");

            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3} \n");

            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture) + "\n");

        }
    }

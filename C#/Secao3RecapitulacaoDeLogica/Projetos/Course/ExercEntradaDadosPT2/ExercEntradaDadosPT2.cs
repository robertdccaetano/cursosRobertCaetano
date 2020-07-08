using System;
using System.Globalization;

namespace ExercEntradaDadosPT2
{
    class ExercEntradaDadosPT2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int numerosQuarto = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto?");
            double precoProduto = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha): ");
            string[] vetorDados = Console.ReadLine().Split();
            //Só é possivel utilizar ToString("F2") quando o tipo da variavel for double, por isso
            //foi feito o casting da posicao 2 do vetor que era string para double
            double altura = double.Parse(vetorDados[2]);

            //IMPRESSÃO DOS DADOS NA TELA
            Console.WriteLine(nome);
            Console.WriteLine(numerosQuarto);
            Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(vetorDados[0]);
            Console.WriteLine(vetorDados[1]);
            Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}

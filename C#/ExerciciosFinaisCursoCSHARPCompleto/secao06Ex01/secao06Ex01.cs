using secao06Ex01.Entities;
using System;

namespace secao06Ex01
{
    class secao06Ex01
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int qtdQuartos = int.Parse(Console.ReadLine());

            Aluno aluno = new Aluno();

            Aluno[] vect = new Aluno[10];


            for (int i = 1; i <= qtdQuartos; i++)
            {
                Console.WriteLine($"Aluguel #{i}");
                Console.Write("Nome: ");
                aluno.Nome = Console.ReadLine();
                Console.Write("Email: ");
                aluno.Email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                if (vect[quarto] == null)
                {
                    vect[quarto] = new Aluno(aluno.Nome, aluno.Email);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                Console.WriteLine($"{i}: {vect[i]}");
            }

        }
    }
}

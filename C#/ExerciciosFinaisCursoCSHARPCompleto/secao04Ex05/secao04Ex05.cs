using secao04Ex05.Entities;
using System;
using System.Globalization;

namespace secao04Ex05
{
    class secao04Ex05
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            Aluno a2 = new Aluno();

            Console.Write("Nome do aluno: " );
            a1.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            a1.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("NOTA FINAL = " + a1.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (a1.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + a1.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}

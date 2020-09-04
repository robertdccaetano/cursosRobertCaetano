using secao04Ex01.Entities;
using System;

namespace secao04Ex01
{
    class secao04Ex01
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");

            Console.Write("Nome: ");
            p1.Name = Console.ReadLine();

            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");

            Console.Write("Nome: ");
            p2.Name = Console.ReadLine();

            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p2.Idade < p1.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.Name);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.Name);
            }


        }
    }
}

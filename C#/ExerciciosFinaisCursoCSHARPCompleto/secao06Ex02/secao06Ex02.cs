using secao06Ex02.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace secao06Ex02
{
    class secao06Ex02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos funcionários você vai registrar?");
            int numFunc = int.Parse(Console.ReadLine());
            List<Funcionario> lista = new List<Funcionario>();

            for(int i = 1; i <= numFunc; i++)
            {
                Console.WriteLine($"Funcionário #{i}");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                lista.Add(new Funcionario(id, nome, salario));
            }

            Console.Write("Entre com o ID do funcionário que receberá aumento: ");
            int idFuncAumento = int.Parse(Console.ReadLine());

            Funcionario funcAumento = lista.Find(f => f.Id == idFuncAumento);

            if(funcAumento != null)
            {
                Console.Write("Entre com a porcentagem de aumento: ");
                double porcentAumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcAumento.AumentarSalario(porcentAumento);
            }
            else
            {
                Console.WriteLine("Este funcionário não existe");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de funcionários atualizada:");
            foreach(object func in lista)
            {
                Console.WriteLine(func);
            }
        }
    }
}

using Seção17ExpressoesLambda.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Seção17ExpressoesLambda
{
    class DelegateFunc
    {
        //public static void Main(string[] args)
        //{
        //    /*
        //     * Representa um método que recebe zero ou mais argumentos, e retorna um valor
        //     * */

        //    List<Product> list = new List<Product>();
        //    list.Add(new Product("Tv", 900.00));
        //    list.Add(new Product("Mouse", 50.00));
        //    list.Add(new Product("Tablet", 350.50));
        //    list.Add(new Product("HD Case", 80.90));


        //    //Func<Product, string> func = NameUpper;
        //    // Se colocar { chaves } teria que colocar a palavra return, pois com chaves a expressão
        //    //lambda expera um comando no caso o return
        //    // Sem chaves pode utilizar da expressão lambda sem o comando return
        //    Func<Product, string> func = p => p.Name.ToUpper();

        //    List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

        //    foreach (string s in result)
        //    {
        //        Console.WriteLine(s);
        //    }

        //}

        //static string NameUpper(Product p)
        //{
        //    return p.Name.ToUpper();
        //}
    }
}

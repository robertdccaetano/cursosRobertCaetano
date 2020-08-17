using Seção17ExpressoesLambda.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seção17ExpressoesLambda
{
    class DelegateAction
    {
        //public static void Main(string[] args)
        //{
        //    /*
        //     * - Action (System)
        //     * - Representa um método void que recebe zero ou mais argumentos
        //     */

        //    List<Product> list = new List<Product>();
        //    list.Add(new Product("Tv", 900.00));
        //    list.Add(new Product("Mouse", 50.00));
        //    list.Add(new Product("Tablet", 350.50));
        //    list.Add(new Product("HD Case", 80.90));

        //    Action<Product> act = p => { p.Price += p.Price * 0.1; };

        //    //Para cada item da lista execute a função UpdatePrice
        //    list.ForEach(act);

        //    //Funciona inline com expressão lambda
        //    list.ForEach(p => { p.Price += p.Price * 0.1; });
        //    foreach (Product p in list)
        //    {
        //        Console.WriteLine(p);
        //    }

        //}

        //static void UpdatePrice (Product p)
        //{
        //    p.Price += p.Price * 0.1;
        //}
    }
}

using Secao15GenericSetDictionary.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Secao15GenericSetDictionary
{
    class GetHashCodeEquals
    {
        /*
         * São operações da classse Object utilizadas para comparar se um objeto
         * é igual a outro
         * 
         * -Equals: lento, resposta 100%
         * -GetHashCode: rápido, porém reposta positiva não é 100%
         * 
         * -Os tipos pré-definidos já possuem implementação para essas operações. Classes
         * e structs personalizadas precisam sobrepô-las
         * */

        //public static void Main(string[] args)
        //{
        //    //string a = "Maria";
        //    //string b = "Maria";

        //    //Console.WriteLine(a.Equals(b));

        //    //Console.WriteLine(a.GetHashCode());
        //    //Console.WriteLine(b.GetHashCode());

        //    Client a = new Client {Name = "Maria", Email = "maria@gmail.com" };
        //    Client b = new Client { Name = "Alex", Email = "maria@gmail.com" };

        //    Console.WriteLine(a.Equals(b));
        //    Console.WriteLine(a == b);
        //    Console.WriteLine(a.GetHashCode());
        //    Console.WriteLine(b.GetHashCode());
            
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Secao15GenericSetDictionary.Entities
{
    class HashSetESortedSet
    {
        //public static void Main(string[] args)
        //{
        //    //Conjunto representados pelas coleções HashSet e SortedSet
        //    /*
        //     * Não admite repetições
        //     * Elementos não possuem posição
        //     * Acesso, inserção e remoção de elementos são rápidos
        //     * Oferece operações eficientes de conjunto: interseção, união, diferença.
        //     * */

        //    //HashSet<string> set = new HashSet<string>();

        //    //set.Add("TV");
        //    //set.Add("Notebook");
        //    //set.Add("Tablet");

        //    //Console.WriteLine(set.Contains("Computer"));

        //    //foreach (string element in set) 
        //    //{
        //    //    Console.WriteLine(element);
        //    //}

        //    SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
        //    SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

        //    //PrintCollection(a);

        //    //union
        //    SortedSet<int> c = new SortedSet<int>(a);
        //    c.UnionWith(b);
        //    PrintCollection(c);

        //    //intersection
        //    SortedSet<int> d = new SortedSet<int>(a);
        //    d.IntersectWith(b);
        //    PrintCollection(d);

        //    //diference
        //    SortedSet<int> e = new SortedSet<int>(a);
        //    e.ExceptWith(b);
        //    PrintCollection(e);

        //}

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
                
            }
            Console.WriteLine();
        }
        
    }
}

using System;
using System.Collections.Generic;

namespace secao15Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            Console.Write("How many studentes for course A? ");
            int stdA = int.Parse(Console.ReadLine());
            for (int i = 1; i <= stdA; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                courseA.Add(cod);
            }

            Console.Write("How many studentes for course B? ");
            int stdB = int.Parse(Console.ReadLine());
            for (int i = 1; i <= stdB; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                courseB.Add(cod);
            }


            Console.Write("How many studentes for course C? ");
            int stdC = int.Parse(Console.ReadLine());
            for (int i = 1; i <= stdC; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                courseC.Add(cod);
            }

            HashSet<int> all = new HashSet<int>(courseA);

            all.UnionWith(courseB);
            all.UnionWith(courseC);
            Console.WriteLine("Total students: " + all.Count);

        }
    }
}

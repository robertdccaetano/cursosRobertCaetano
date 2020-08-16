using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Secao14Interfaces.Entities;

namespace Secao14Interfaces
{
    class InterfaceIComparable
    {
        public static void Main(string[] args)
        {
            string path = @"c:\temp\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee func in list)
                    {
                        Console.WriteLine(func);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(ex.Message);
            }
        }
    }
}

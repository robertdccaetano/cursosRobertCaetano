using secao17Ex01.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace secao17Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the full path of file: ");
            string pathFile = Console.ReadLine();

            Console.Write("Enter salary: ");
            double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(pathFile))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                        list.Add(new Employee(name, email, salary));
                    }
                
                }

                var emails = list.Where(obj => obj.Salary > limit).OrderBy(obj => obj.Email).Select(obj => obj.Email);

                var sum = list.Where(obj => obj.Name[0] == 'M').Sum(obj => obj.Salary);

                Console.WriteLine("E-mail of people whose salary is more than " + limit.ToString("F2", CultureInfo.InvariantCulture));
                foreach (string email in emails)
                {
                    Console.WriteLine(email);
                }

                Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(ex.Message);
            }
        }
    }
}

using System;

namespace secao10Ex02
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int numsEmployee = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numsEmployee; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());

                if( outsourced == 'y')
                {

                }

            }
        }
    }
}

using secao11Ex01.Entities;
using System;
using System.Globalization;

namespace secao11Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Holder: ");
            string holder = Console.ReadLine();

            Console.Write("Initial balance: ");
            double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Withdraw limit: ");
            double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Account account = new Account(number, holder, initialBalance, limit);

            Console.Write("Enter amount for withdraw: ");
            double amountWithdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                account.Withdraw(amountWithdraw);
                Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (Exception e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }

        }
    }
}

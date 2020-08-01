using Secao10HerancaPolimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Secao10HerancaPolimorfismo
{
    class ClassesAbstratas
    {
        //Não podem ser instanciadas
        //Forma de garantir heranca total
        //public static void Main(string[] args)
        //{
        //    List<Account> list = new List<Account>();

        //    list.Add(new SavingsAccount(1001, "Alex", 500, 0.01));
        //    list.Add(new BusinessAccount(1002, "Marial", 500, 400.0));
        //    list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
        //    list.Add(new BusinessAccount(1004, "Anna", 500.0, 500));
        //    list.Add(new Account(1005, "Roger", 500.0));


        //    double sum = 0.0;
        //    foreach (Account acc in list)
        //    {
        //        sum += acc.Balance;
        //    }

        //    Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));
        //    foreach (Account acc in list)
        //    {
        //        acc.Withdraw(10.0);
        //    }

        //    foreach (Account acc in list)
        //    {
        //        Console.WriteLine("Updated balance for account "
        //            + acc.Number
        //            + ": "
        //            + acc.Balance.ToString("F2",CultureInfo.InvariantCulture));
        //    }

        //}
    }
}

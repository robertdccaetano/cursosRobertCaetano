using Secao10HerancaPolimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Secao10HerancaPolimorfismo
{
    class UpcastingDowncasting
    {
        //static void Main(string[] args)
        //{
        //    Account account = new Account(1001, "Robert", 0);
        //    BusinessAccount bacc = new BusinessAccount(1002, "Danilo", 0, 500);

        //    // UPCASTING - Conversao da subclasse para superclasse

        //    Account acc1 = bacc;
        //    Account acc2 = new BusinessAccount(1003, "Bog", 0, 200);
        //    Account acc3 = new SavingsAccount(1004, "Ana", 0, 0.01);

        //    //DOWNCASTING - Conversao da superclasse para subclasse

        //    BusinessAccount acc4 = (BusinessAccount)acc2;
        //    acc4.Loan(100.00);

        //    //BusinessAccount acc5 = (BusinessAccount)acc3;
        //    if (acc3 is BusinessAccount)
        //    {
        //        //BusinessAccount acc5 = (BusinessAccount)acc3;
        //        BusinessAccount acc5 = acc3 as BusinessAccount;
        //        acc5.Loan(200.00);
        //        Console.WriteLine("Loan");
        //    }

        //    if (acc3 is SavingsAccount)
        //    {
        //        //SavingsAccount acc5 = (SavingsAccount)acc3;
        //        SavingsAccount acc5 = acc3 as SavingsAccount;
        //        acc5.UpdateBalance();
        //        Console.WriteLine("Update!");
        //    }
        //}
    }
}

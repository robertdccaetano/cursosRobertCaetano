using secao14Ex01.Entities;
using secao14Ex01.Services;
using System;
using System.Globalization;

namespace secao14Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");

            Console.Write("Number: ");
            int numberOfContract = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime dateOfContract = DateTime.Parse(Console.ReadLine());

            Console.Write("Contract value: ");
            double valueOfContract = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter number of installments: ");
            int numberOfInstallments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(numberOfContract, dateOfContract, valueOfContract);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, numberOfInstallments);

            Console.WriteLine("Installments:");
            foreach (Installment instalment in contract.Installments)
            {
                Console.WriteLine(instalment);
            }
        }
    }
}

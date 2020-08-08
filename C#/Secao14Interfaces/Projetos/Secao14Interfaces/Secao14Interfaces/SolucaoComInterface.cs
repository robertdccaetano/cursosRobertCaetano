using Secao14Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Secao14Interfaces.Services;

namespace Secao14Interfaces
{
    class SolucaoComInterface
    {
        //public static void Main(string[] args)
        //{
        //    //Solucao de locacao de carros sem Interface
        //    Console.WriteLine("Enter rental data");

        //    Console.Write("Car model: ");
        //    string model = Console.ReadLine();

        //    Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
        //    DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

        //    Console.Write("Return (dd/MM/yyyy hh:mm): ");
        //    DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);


        //    Console.Write("Enter price per hour: ");
        //    double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //    Console.Write("Enter price per day: ");
        //    double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        //    CarRental carRental = new CarRental(start, finish, new Vehicle(model));

        //    RentalService rentalService = new RentalService(hour, day, new BrazilTaxServices());

        //    rentalService.ProcessInvoice(carRental);

        //    Console.WriteLine("INVOICE: ");
        //    Console.WriteLine(carRental.Invoice);


        //}
    }
}

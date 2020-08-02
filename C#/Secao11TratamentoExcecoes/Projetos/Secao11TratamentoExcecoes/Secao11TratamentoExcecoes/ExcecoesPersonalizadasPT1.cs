using Secao11TratamentoExcecoes.Entities;
using Secao11TratamentoExcecoes.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Secao11TratamentoExcecoes
{
    class ExcecoesPersonalizadasPT1
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation:" + reservation);
                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.WriteLine("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }

        }
    }
}

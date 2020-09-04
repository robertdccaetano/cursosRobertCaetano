using secao06Ex04.Entities;
using secao06Ex04.Entities.Enums;
using System;
using System.Globalization;

namespace secao06Ex04
{
    class secao06Ex04
    {
        static void Main(string[] args)
        {
            Order order = new Order();

            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string cliName = Console.ReadLine();
            Console.Write("E-mail: ");
            string cliEmail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime cliBDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(cliName, cliEmail, cliBDate);
            order.Moment = DateTime.Now;
            order.Status = status;
            order.Client = client;

            Console.WriteLine();
            Console.Write("How many items to this order? ");
            int itemsOrder = int.Parse(Console.ReadLine());

            for (int i = 1; i <= itemsOrder; i++)
            {
                Console.WriteLine($"Enter #{i} item data");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product price: ");
                double prodPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int prodQtity = int.Parse(Console.ReadLine());
                Product product = new Product(prodName, prodPrice);

                OrderItem orderItem = new OrderItem(prodQtity, prodPrice, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMARY:");
            Console.WriteLine(order);
            
        }
    }
}

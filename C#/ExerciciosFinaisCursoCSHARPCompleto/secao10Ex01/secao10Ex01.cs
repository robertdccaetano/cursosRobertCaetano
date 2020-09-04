using secao10Ex01.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace secao10Ex01
{
    class secao10Ex01
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int numProd = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numProd; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char typePro = char.Parse(Console.ReadLine());
                
                Console.Write("Name: ");
                string namePro = Console.ReadLine();

                Console.Write("Price: ");
                double priceProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (typePro == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(namePro, priceProd, customsFee));
                }
                else if (typePro == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(namePro, priceProd, manufactDate));
                }
                else
                {
                    list.Add(new Product(namePro, priceProd));
                }

            }
            Console.WriteLine("PRICE TAGS:");
            foreach (Product item in list)
            {
                Console.WriteLine(item.PriceTag());
            }
                
        }
    }
}

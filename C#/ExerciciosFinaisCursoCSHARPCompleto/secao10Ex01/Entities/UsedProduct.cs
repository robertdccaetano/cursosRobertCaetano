using System;
using System.Globalization;
using System.Text;

namespace secao10Ex01.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            Name = name;
            Price = price;
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(
                Name
                + " (used) $" 
                + Price.ToString("F2", CultureInfo.InvariantCulture) 
                + " (Manufacture date: " 
                + ManufactureDate.ToString("dd/MM/yyyy") 
                + ")" 
            );

            return sb.ToString();
        }
    }
}

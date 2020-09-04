using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace secao10Ex01.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customFee) : base(name, price)
        {
            CustomsFee = customFee;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Name + " $" + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + " (Customs fee: $" + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) +")");
            return sb.ToString();
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }


    }
}

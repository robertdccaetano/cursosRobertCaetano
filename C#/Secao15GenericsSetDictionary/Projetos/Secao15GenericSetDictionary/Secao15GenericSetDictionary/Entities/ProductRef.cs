using System;
using System.Collections.Generic;
using System.Text;

namespace Secao15GenericSetDictionary.Entities
{
    class ProductRef
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public ProductRef(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is ProductRef))
            {
                return false;
            }

            ProductRef other = obj as ProductRef;
            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }
    }
}

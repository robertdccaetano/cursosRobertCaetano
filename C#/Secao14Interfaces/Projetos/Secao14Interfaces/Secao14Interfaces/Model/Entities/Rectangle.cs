using Secao14Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Secao14Interfaces.Model.Entities
{
    class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }
    }
}

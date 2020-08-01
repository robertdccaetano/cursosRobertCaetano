using Secao10HerancaPolimorfismo.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Secao10HerancaPolimorfismo.Entities
{
    class Rectangle : Shapes
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Cor color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}


using Secao10HerancaPolimorfismo.Entities.Enums;
using System;

namespace Secao10HerancaPolimorfismo.Entities
{
    class Circle : Shapes
    {
        public double Radius { get; set; }

        public Circle(double radius,Cor color) :base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
            
        }
    }
}

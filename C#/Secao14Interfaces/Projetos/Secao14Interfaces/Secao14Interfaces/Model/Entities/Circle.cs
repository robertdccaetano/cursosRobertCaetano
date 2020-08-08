using Secao14Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Secao14Interfaces.Model.Entities
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}

using Secao14Interfaces.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Secao14Interfaces.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}

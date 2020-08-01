using Secao10HerancaPolimorfismo.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Secao10HerancaPolimorfismo.Entities
{
    abstract class Shapes
    {
        public Cor Color{ get; set; }

        //public Shapes()
        //{

        //}

        public Shapes(Cor color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}

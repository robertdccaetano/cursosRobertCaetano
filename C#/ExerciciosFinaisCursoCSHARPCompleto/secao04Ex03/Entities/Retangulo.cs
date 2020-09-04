using System;
using System.Collections.Generic;
using System.Text;

namespace secao04Ex03.Entities
{
    class Retangulo
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public double Area()
        {
           
            return this.Largura * this.Altura;
        }

        public double Perimetro()
        {
            return 2 * (this.Largura + this.Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura,2) + Math.Pow(Altura,2));
        }
    }
}

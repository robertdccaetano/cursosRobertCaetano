using System;
using System.Collections.Generic;
using System.Text;

namespace Secao4ClassesAtributosMetodos
{
    class Triangulo
    {
        public double a;
        public double b;
        public double c;

        //Area Stack da memória cria variáveis státicas
        //ex double a, b , c;

        //Area Heap da memória é uma área de alocação dinâmica
        //Cria objeto composto de uma classe (instancia a classse)

        public double Area()
        {
            double p = (a + b + c) / 2;
            //double raiz = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            //return raiz;
        }
       
    }
}

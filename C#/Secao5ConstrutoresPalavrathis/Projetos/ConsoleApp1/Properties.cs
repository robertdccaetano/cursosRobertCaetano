using Course;
using System;
using System.Collections.Generic;
using System.Text;

namespace Secao5ConstruThisSobrecargaEncap
{
    class Properties
    {
        public static void Main(string[] args)
        {

            //PROPERTIES são definições de métodos encapsulados, porém com
            //uma sintaxe semelhante a de atributos e não de métodos
            Produto p = new Produto("TV", 500.00, 10);

            //Propertie Nome
            p.Nome = "T";
            

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);


        }
    }
}

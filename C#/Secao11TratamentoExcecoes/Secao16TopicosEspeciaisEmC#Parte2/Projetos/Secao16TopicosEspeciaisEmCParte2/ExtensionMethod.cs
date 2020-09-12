using System;


namespace Secao16TopicosEspeciaisEmCParte2
{
    class ExtensionMethod
    {
        static void Main(string[] args)
        {
            /*
             * -São métodos que estendem a funcionalidade de um tipo, sem precisar 
             * o código fonte deste tipo, nem herdar desse tipo
             * 
             * -Como fazer um extension method?
             * - - Criar uma classe estática
             * - - Na classe, criar um método statico
             * - - O primeiro parâmetro do método deverá ter o prefixo this, seguido da 
             * - - declaração de um parâmetro do tipo que se deseja estender. Esta será uma
             * - - referência par ao próprio objeto.
             * 
             * */

            DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));

            s1.

        }
    }
}

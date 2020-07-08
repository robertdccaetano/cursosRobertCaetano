using System;

namespace EntradaDadosPT1
{
    class EntradaDadosPT1
    {
        static void Main(string[] args)
        {
            //Entrada de dados por quebra de linha Console.ReadLine()
            //string frase = Console.ReadLine();
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            //string z = Console.ReadLine();


            //Funcao Split('CARACTERE PARA ENCONTRAR E RECORTAR') recorta a string com base nos caracteres encontrados nela 
            //string s = Console.ReadLine();
            //Split Indiretamente
            //string[] vetor = s.Split(" ");

            //Split diretamente 
            string[] vetor = Console.ReadLine().Split(' ');


            string a = vetor[0];
            string b = vetor[1];
            string c = vetor[2];

            Console.WriteLine("Você digitou: ");

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            //Console.WriteLine(frase);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z+ "\n");
        }
    }
}

using System;

namespace Debugging
{
    class Debugging
    {
        static void Main(string[] args)
        {
            //F9 - MARCA BREAKPOINT 
            //F5 - EXECUTA DEBUG
            //F10 - EXECUTA O PROXIMO PASSO ( MAS NAO ENTRA NA FUNCAO, EXECUTA ELA DIRETAMENTE)
            // SHIFT + F5 PARA DEBUG
            //F11 - EXECUTA PASSO ENTRANDO NA FUNCAO


            //ABA AUTOS VS COLOCA VARIAVEIS IMPORTANTES
            //ABA LOCALS (CONTEM TODAS VARIAVEIS DO ESCOPO LOCAL (DO METODO/FUNCAO)))


            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            double resultado = Maior(x, y, z);

            Console.WriteLine("Maior = " + resultado);
        }

        static int Maior(int a, int b, int c)
        {
            int maior;

            if (a > b && a > c )
            {
                maior = a;
            }
            else if (b > c) 
            {
                maior = b;
            }
            else
            {
                maior = c;
            }

            return maior;
        }
    }
}

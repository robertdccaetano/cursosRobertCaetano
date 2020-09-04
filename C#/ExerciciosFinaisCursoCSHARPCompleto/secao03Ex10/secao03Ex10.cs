using System;

namespace secao03Ex10
{
    class secao03Ex10
    {
        static void Main(string[] args)
        {
            string[] vetorHoras = Console.ReadLine().Split(' ');

            int primeiraHora = int.Parse(vetorHoras[0]);
            int segundaHora = int.Parse(vetorHoras[1]);

            int duracaoJogo;

            if (primeiraHora < segundaHora )
            {
                duracaoJogo = segundaHora - primeiraHora;
            } else
            {
                duracaoJogo = 24 - primeiraHora + segundaHora;
            }

            Console.WriteLine("O JOGO DUROU " + duracaoJogo + " HORA(S)");
        }
    }
}

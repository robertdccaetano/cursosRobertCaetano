using System;
using System.Collections.Generic;
using System.Text;

namespace Secao6ComportamentoDeMemoriaArraysListas
{
    class Calculator
    {
        //Utilizando a palavra params antes do parametro da funcao
        //indica ao compilador que esta funcao receberá uma quantia variada de valores em seus parâmetros
       //public static int Sum(params int[] numbers)
       // {
       //     int sum = 0;

       //     for (int i = 0; i < numbers.Length; i++)
       //     {
       //         sum += numbers[i];
       //     }
       //     return sum;
       // }


        //MODIFICADORES DE PARAMETROS REF E OUT
        //palavra ref no parâmetro passa o valor da variável como referência

        public static void Triple(ref int x)
        {
            x = x * 3;
           // return x;
        }

        public static void alteraNome(classeteste obj)
        {
            obj.nome = "alterado";
            // return x;
        }
    }
}



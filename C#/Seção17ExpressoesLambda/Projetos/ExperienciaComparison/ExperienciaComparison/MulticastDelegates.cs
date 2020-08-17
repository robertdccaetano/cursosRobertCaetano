using Seção17ExpressoesLambda.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seção17ExpressoesLambda
{
    delegate void BinaryNumericOperationMulticast(double n1, double n2);



    class MulticastDelegates
    {
        //public static void Main(string[] args)
        //{
        //    /*
        //     * - Multicast delegates
        //     * - - Delegates que guardam a referência para mais de um método
        //     * - - Para adicionar uma referência, pode-se usar o operador +=
        //     * - - A chamada invoke (ou sintaxe reduzida) executa todos os métodos
        //     *     na ordem em que foram adicionados
        //     * - - Seu uso faz sentido para métodos void
        //     * */

        //    double a = 10;
        //    double b = 12;

        //    BinaryNumericOperationMulticast op = CalculationServiceMultiCastDelegate.ShowSum;
        //    op += CalculationServiceMultiCastDelegate.ShowMax;


        //    //Maneira  alternativa verbosa
        //    op.Invoke(a, b);

        //    //Maneira alternativa simplificada
        //    op(a, b);

        //}
    }
}

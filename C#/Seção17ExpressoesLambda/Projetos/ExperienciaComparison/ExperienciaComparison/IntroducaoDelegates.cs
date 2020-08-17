using Seção17ExpressoesLambda.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seção17ExpressoesLambda
{
    delegate double BinaryNumericOperation(double n1, double n2);


    class IntroducaoDelegates
    {
        //static void Main(string[] args)
        //{
        //    /*
        //     * É uma referência (com type safety) para um ou mais métodos
        //     * - - É um tipo referência
        //     * 
        //     * - Uso comuns:
        //     * - - Comunicação entre objetos de forma flexível e extensível (eventos/callbacks)
        //     * - - Parametrização d eoperações por métodos (programação/funcional)
        //     *
        //     * - Delegates pré-definidos
        //     * - - Action
        //     * - - Func
        //     * - - Predicate
        //     */

        //    //Maneira prática e alternativa
        //    BinaryNumericOperation op = CalculationService.Sum;
        //    //Maneira verbosa
        //    BinaryNumericOperation op2 = new BinaryNumericOperation(CalculationService.Sum);

        //    double a = 10;
        //    double b = 12;

        //    //Maneira prática e alternativa
        //    double resultOp = op(a, b);
        //    //Maneira verbosa
        //    double resultOpVerbose = op.Invoke(a, b);

        //    double result = CalculationService.Square(a );

        //    Console.WriteLine(result);
        //    Console.WriteLine(resultOp);

        //}
    }
}

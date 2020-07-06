using System;

namespace Course2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Valores max e min
            int valMin = int.MinValue;
            int valMax = int.MaxValue;

            sbyte valSbyteMinValue = sbyte.MinValue;
            decimal valMaxDecimal = decimal.MaxValue;

            Console.WriteLine(valMin);
            Console.WriteLine(valMax);
            Console.WriteLine(valSbyteMinValue);
            Console.WriteLine(valMaxDecimal);
        }
    }
}

using System;
using System.Globalization;

namespace secao03Ex04
{
    class secao03Ex04
    {
        static void Main(string[] args)
        {
            int numeroFuncionario = int.Parse(Console.ReadLine());
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            double valHorasTrabalhadas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salarFuncionario = horasTrabalhadas * valHorasTrabalhadas;

            Console.WriteLine($"NUMBER = {25}");
            Console.WriteLine($"SALARY = U$ {salarFuncionario.ToString("F2")}");

        }
    }
}

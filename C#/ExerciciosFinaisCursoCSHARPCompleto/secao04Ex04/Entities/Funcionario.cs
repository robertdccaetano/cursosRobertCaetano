using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace secao04Ex04.Entities
{
    class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

        public double SalarioLiquido()
        {
            return this.SalarioBruto - this.Imposto;
        }

        public void AumentarSalario (double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }

        public override string ToString()
        {
            return Nome
                + ", $" 
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace secao06Ex02.Entities
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salario { get; set; }

        public Funcionario(int id, string name, double salario)
        {
            Id = id;
            Name = name;
            Salario = salario;
        }

        public void AumentarSalario(double porcentagem)
        {
             this.Salario += (Salario * porcentagem) / 100.00;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

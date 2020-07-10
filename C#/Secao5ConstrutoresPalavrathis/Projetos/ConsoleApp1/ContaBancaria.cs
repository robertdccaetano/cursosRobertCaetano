using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Secao5ConstruThisSobrecargaEncap
{
    class ContaBancaria
    {
        //Autopropertie com get disponivel e set privado
        public int NumeroConta { get; private set; }
        //Autopropertie com set/get disponivel
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
        }

        public ContaBancaria(int numeroConta, string titular, double depositoInicial) :this(numeroConta, titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5;
        }

        public override string ToString()
        {
            return "Conta "
                + NumeroConta
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

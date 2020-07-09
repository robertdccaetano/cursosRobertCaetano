using System.Globalization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Secao4ClassesAtributosMetodos
{
    class Produto
    {
        public string nome;
        public double preco;
        public int quantidade;

        public double ValorTotalEmEstoque()
        {
            return this.preco * quantidade;
        }

        public override string ToString()
        {
            return nome
                + ", R$"
                + preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AdicionarProdutos(int quantity) 
        {
            quantidade += quantity;

        }

        public void RemoverProdutos(int quantity)
        {
            quantidade -= quantity;
        }

    }
}

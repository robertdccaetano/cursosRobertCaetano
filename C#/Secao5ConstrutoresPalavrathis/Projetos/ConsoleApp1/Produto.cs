using System.Globalization;
namespace Course
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto()
        {
            _quantidade = 10;
        }

        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            _preco = preco;
        }

        //public Produto(string nome, double preco, int quantidade) : this(nome, preco) 
        //{
        //    _quantidade = quantidade;
        //}

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //Definição de uma propertie chamada Nome
        public string Nome
        {
            //Get semelhante ao metodo GetNome
            get { return _nome; }
            //Set semelhante ao metodo SetNome com validacao do nome inserido
            set {
                    //O nome (value) está utilizando o parâmetro que chegaria dentro do método
                    if (value != null && value.Length > 1)
                    {
                        _nome = value;
                    }
                }
        }

        //Definição de uma propertie chamada Preco
        public double Preco
        {
            get { return _preco; }
            
        }

        //Definição de uma propertie chamada Quantidade
        public int Quantidade
        {
            get { return _quantidade; }
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

using System.Globalization;
namespace Course
{
    class Produto
    {
        //Nome não pode fazer autopropertie, pois ele possui uma lógica particular em seu SET
        private string _nome;
        //Auto propertie onde o Set do preço não pode ser alterado por outras classes/arquivos
        //dispensando também o uso dos métodos Getters/Setters
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        //Snippet "prop" + tab + tab Monta estrutura da propertie


        public Produto()
        {
            Quantidade = 10;
        }

        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            Preco = preco;
        }

        //public Produto(string nome, double preco, int quantidade) : this(nome, preco) 
        //{
        //    _quantidade = quantidade;
        //}

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
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
        //public double Preco
        //{
        //    get { return _preco; }
            
        //}

        //Definição de uma propertie chamada Quantidade
        //public int Quantidade
        //{
        //    get { return _quantidade; }
        //}

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

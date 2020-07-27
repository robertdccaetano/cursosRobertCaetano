using Secao9EnumeracaoComposicao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Secao9EnumeracaoComposicao.Entities
{
    //Classe pedido (Order)
    class Order
    {
        //Propriedade Id
        public int Id { get; set; }
        //Propriedade Moment do tipo DateTime
        public DateTime Moment { get; set; }
        //Propriedade Status do Tipo enum OrderStatus
        public OrderStatus Status { get; set; }

        //Criando override do método ToString que e responsavel 
        //por printar na tela os objetos instanciados da classe
        public override string ToString()
        {
            return Id
                + ","
                + Moment
                + ", "
                + Status;
        }
    }
}

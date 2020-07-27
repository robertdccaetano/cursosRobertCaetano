//Local que se encontra o enum OrderStatus
namespace Secao9EnumeracaoComposicao.Entities.Enums
{
    //enumm OrderStatus que herda do tipo struct int
    enum OrderStatus : int
    {
        //PendingPayment item do enum na ordem
        PendingPayment = 0, 
        //Processing item do enum na ordem numero 1
        Processing = 1,
        //Shipped item do enum na ordem numero 2
        Shipped = 2,
        //Delivered item do enum na ordem numero 3
        Delivered = 3
    }
}

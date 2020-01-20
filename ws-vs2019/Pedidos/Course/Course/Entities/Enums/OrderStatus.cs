namespace Course.Entities.Enums
{
    enum OrderStatus : int // apaga o class e coloca enum
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
        
    }
}

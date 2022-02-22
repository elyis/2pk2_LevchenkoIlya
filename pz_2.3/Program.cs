using System;
using pz_2._3;

//Покупатель может указать только адрес доставки, т.к id, сумма и время регистрации должны фиксироваться системой 

//14 вариант
namespace pz_2._3
{
    class Program
    {
        

        static void Main(string[] args)
        {
            RejectedDelivery a = new RejectedDelivery(null);
            a.GetDeliveryInfo();
            RejectedDelivery a2 = new RejectedDelivery("Гамбург");
            a2.GetDeliveryInfo();
            RejectedDelivery a3 = new RejectedDelivery("Этот код не выполняет множество проверок");
            a3.GetDeliveryInfo();
            RejectedDelivery a4 = new RejectedDelivery("ПОэтому можно заниматься этим");
            a4.GetDeliveryInfo();
        }
    }
}
//P.s: код можно было упростить разделив данный класс на заказ и множество заказов
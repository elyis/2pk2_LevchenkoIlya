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
            DeliveryRequest a = new DeliveryRequest();
            a.GetDeliveryInfo();
            DeliveryRequest a2 = new DeliveryRequest("Гамбург");
            a2.GetDeliveryInfo();
            DeliveryRequest a3 = new DeliveryRequest("Этот код не выполняет множество проверок");
            a3.GetDeliveryInfo();
            DeliveryRequest a4 = new DeliveryRequest("ПОэтому можно заниматься этим");
            a4.GetDeliveryInfo();
        }
    }
}
//P.s: код можно было упростить разделив данный класс на заказ и множество заказов
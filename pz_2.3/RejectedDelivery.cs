using System;
using System.Collections.Generic;
using System.Text;

namespace pz_2._3
{

    enum statusErrorOfDelivery
    {
        ALLRIGHT = 0,
        ADDRESS_ERROR
    }

    class RejectedDelivery : DeliveryRequest
    {
        public RejectedDelivery(string address) : base(address)
        {
            if (base.isTypeError == 1)
                Reason = "Ошибка в введенном адресе";
        }

        private string reason;
        public string Reason
        {
            set => reason = value;
            get => reason;
        }

        public override void GetDeliveryInfo()
        {
            if (base.isTypeError == 1)
                Console.WriteLine("Статус заказа не оформлен по причине: " + Reason);
            else
                base.GetDeliveryInfo();
        }

    }
}

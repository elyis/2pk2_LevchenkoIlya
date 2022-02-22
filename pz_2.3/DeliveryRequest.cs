using System;
using System.Collections.Generic;
using System.Text;

namespace pz_2._3
{
    using System;

    public class DeliveryRequest
    {
        private int id;
        static private int[] ids = new int[400];
        static private int numOfDelivery = 0;
        static private float sumOfAllDelivery = 0;

        private string requestTime;
        private string adr;
        private float summ;
        private bool isFramed = true;
        private int isError;

        public string Address
        {
            get => adr;
        }

        public int isTypeError
        {
            get => isError;
        }

        public DeliveryRequest(string address = "В ближайшем пункте выдачи")
        {
            if (string.IsNullOrEmpty(address))
            {
                isFramed = false;
                isError = (int)statusErrorOfDelivery.ADDRESS_ERROR;
            }
            else
            {
                adr = address;
                DeliveryRegistration();
                isError = (int)statusErrorOfDelivery.ALLRIGHT;
                isFramed = true;
                numOfDelivery++;
            } 
        }

        public virtual void GetDeliveryInfo()
        {
        if (isFramed)
            Console.WriteLine("Заказ по адресу: " + adr +
                " произошел в " + requestTime +
                "\nИтоговая сумма заказа составляет " + summ);
        else
            Console.WriteLine("Заказ не оформлен, т.к не были указаны некоторые данные");
        }

        //Установка времени заказа, вычисление стоимости и проверка уникальности id заказа
        private void DeliveryRegistration()
        {
            requestTime = DateTime.Now.ToString();
            summ = OrderCalculation();
            sumOfAllDelivery += summ;

            Random rnd = new Random();
            int temp = rnd.Next(0, (int)Math.Pow(10, 8));
            for (int i = 0; i < numOfDelivery; i++)
            {
                if (ids[i] == temp)
                    temp = rnd.Next(0, (int)Math.Pow(10, 8));
            }

            id = temp;
            ids[numOfDelivery] = temp;
            numOfDelivery++;
        }

        private int OrderCalculation()
        {
            Random rnd = new Random();
            return rnd.Next(100, 10000);
        } 

    }

}


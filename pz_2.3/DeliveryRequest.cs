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

            private string requestTime;
            private string adr;
            private float summ;


            public DeliveryRequest(string address = "В ближайшем ресторане")
            {
                adr = address;
                DeliveryRegistration();
            }

            //Этот конструктор бесполезен,т.к предыдущий выполняет его задачи, а нужно было несколько
            public DeliveryRequest()
            {
                adr = "В ближайшем ресторане города";
                DeliveryRegistration();
            }

            public void GetDeliveryInfo()
            {
                Console.WriteLine("Заказ по адресу: " + adr +
                    " произошел в " + requestTime +
                    "\nИтоговая сумма заказа составляет " + summ);
            }

            //Установка времени заказа, вычисление стоимости и проверка уникальности id заказа
            private void DeliveryRegistration()
            {
                requestTime = DateTime.Now.ToString();
                summ = OrderCalculation();

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

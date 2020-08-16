using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class credit
    {
        public int Payment(int sum, int date, int money)
        {
            int payMounth = sum / date;
            Console.WriteLine("Размер ежемесячного платежа составляет:" + payMounth);
            int persent = payMounth * 100 / money;
            Console.WriteLine("Процент от заработанной платы:" + persent);
            return persent;
        }
    }
}

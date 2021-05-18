using System;

namespace String_formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Number formatting
            int num = 302;
            string numStr = String.Format("Number {0, 0:D5}", num);
            Console.WriteLine(numStr);

            // Decimal formatting  
            decimal money = 99.95m;
            string moneyStr = String.Format("Money {0, 0:C2}", money);
            Console.WriteLine(moneyStr);

            // DateTime formatting  
            DateTime now = DateTime.Now;
            string dtStr = String.Format("{0:d} at {0:t}", now);
            Console.WriteLine(dtStr);
        }
    }
}

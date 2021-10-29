using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Product harddisk = new Product(50);
            harddisk.ProductName = "HARD DİSK";
            Product gsm = new Product(50);
            gsm.ProductName = "GSM";
            gsm.StockControlEvent += Gsm_StockControlEvent;
            for (int i = 10; i <=gsm.Stock; i++)
            {
                harddisk.Sell(10);
                gsm.Sell(10);
                Console.ReadLine();
            }

            //Console.ReadKey();

        }

        private static void Gsm_StockControlEvent()
        {
            Console.WriteLine("GSM about to finished!!!");
        }
    }
}

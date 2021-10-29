using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        public delegate void MyDelegate();

        public delegate void MyDelegate2(string text);

        public delegate int MyDelegate3(int number1, int number2);
        static void Main(string[] args)
        {
            CustomerManager customerManager= new CustomerManager();
            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;
            myDelegate -= customerManager.SendMessage;

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;
            Matematik matematik= new Matematik();
            MyDelegate3 myDelegate3 = matematik.Topla;
            myDelegate3 += matematik.Carpa;
            //var result=myDelegate3(2, 3);
            //Console.WriteLine(result);
            Console.WriteLine(myDelegate3(2,3));
            myDelegate2("HELLO!");
            myDelegate();
            Console.ReadKey();
        }
    }

    class  CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be careful!!");
        }
        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }

    class  Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carpa(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}

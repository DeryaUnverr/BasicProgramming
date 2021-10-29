using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();
            // TryCatch();
            //ActionDemo();
            Func<int, int, int> add = Topla;
            Console.WriteLine(add(2,3));
            //parametresiz methoda delegasyon yapar.
            Func<int> getRandomNumber = delegate()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };
            Func<int> getRandomNumber2=()=>new Random().Next(1,100);
            Console.WriteLine(getRandomNumber());
            Thread.Sleep(1000);
            Console.WriteLine(getRandomNumber2());
            Console.ReadKey();
        }

        static int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        private static void ActionDemo()
        {
            HandleException(() => { Find(); });
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
              
            }
        }

        private static void TryCatch()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
            }
        }

        private static void Find()
        {
            List<string> students = new List<string>
            {
                "ali", "veli", "ayşe", "fatma"
            };
            if (!students.Contains("ahmet"))
            {
                throw new RecordNotFoundException("Record Not Found");
            }
            else
            {
                Console.WriteLine("Record Found");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[4]
                {
                    "derya", "emrah", "duygu", "evren"
                };
                students[4] = "DENİZ";
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}

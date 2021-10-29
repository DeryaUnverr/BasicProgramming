using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 30;
            int number2 = 40;
            int number3;
            Add();
            Console.WriteLine(Add2(20, 30));
            Console.WriteLine(Add3(20));
            Console.WriteLine(Add4(ref number1,50));
            Console.WriteLine(Add5(50,out number3));
            Console.WriteLine(Multiply(2,3));
            Console.WriteLine(Multiply(2,3,3));
            Console.WriteLine(Add6(1,2,3,4,5,6));
            Console.ReadKey();
        }

        static void Add()
        {
            Console.WriteLine("ADDED!");
        }

        static int Add2(int number1,int number2)
        {
            return number1 + number2;
        }

        static int Add3(int number1,int number2=25,int number3=15)//Default parametre
        {
            return number2 + number3;
        }

        static int Add4( ref int number1,int number2)//ref:Değer tiplerinin referans tip gibi kullanılmasını sağlar.
        {
            number1 = 20;
            return number1 + number2;
        }

        static int Add5( int number2,out int number3)
        {
            number3 = 20;
            return number3 + number2;
        }
        static int Multiply(int number2,  int number3)
        {
         
            return number3 * number2;
        }
        static int Multiply(int number2, int number3,int number4)
        {

            return number3 * number2*number4;
        }

        static int Add6(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}

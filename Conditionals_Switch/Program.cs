using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 11;
            switch (number)
            {
                case 11:
                    Console.WriteLine("Number is 11");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                default:
                    Console.WriteLine("Number is not 11 or 20");
                    break;
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            string[] arrays = { "DERYA","DUYGU","EVREN","EMRAH"};
            foreach (var array in arrays)
            {
                Console.WriteLine(array);
            }
            Console.ReadKey();
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 11);
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }

            Console.WriteLine($"Number Now is {number}");
        }

        private static void ForLoop()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("FİNİSHED");

            //for (int i = 100; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //for (; ; )
            //{
            //    Console.WriteLine("merhaba");
            //}
        }
    }
}

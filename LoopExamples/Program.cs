using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopExamples
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("sayi girin: ");
            int sayi = int.Parse(Console.ReadLine());
            if (IsPrimeNumber(sayi))
            {
                Console.WriteLine("This is a prime number".ToUpper());
            }
            else
            {
                Console.WriteLine("This isn't a prime number".ToUpper());
            }

            Console.ReadKey();
        }
        
        static bool IsPrimeNumber(int number)
        {
            
            bool result = true;
            for (int i = 2; i <number-1 ; i++)
            {
                if (number%i==0)
                {
                    
                    result = false;
                    i = number;
                }

            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace TypeAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
           
            decimal number6 = 10.4m;
            double number5 = 10.4;
            char character = 'A';
            bool condition = true;//default'u  false'dur.
            byte number4 = 255;//(-256)
            short number3 = 32767; //+,- 16 bit
            long number2 = 9223372036854775807;//(+,- int in iki katı 64 bit)
            int number1 = 2147483647;//(+,- 32 bit)
            var number7 = 12;
            number7 = 'B';//ascıı nin sayısal karşılığı vardır.
          
            Console.WriteLine($"integer : {number1}");
            Console.WriteLine($"long: {number2}");
            Console.WriteLine($"short: {number3}");
            Console.WriteLine($"byte: {number4}");
            Console.WriteLine($"double: {number5}");
            Console.WriteLine($"decimal: {number6}");
            Console.WriteLine($"var: {number7}");
            Console.WriteLine($"char: {character}");
            Console.WriteLine($"bool: {condition}");

            Console.WriteLine($"{(int)Days.Monday}");
            Console.WriteLine($"{Days.Monday}");
            Console.ReadKey();

        }

        enum Days
        {
            Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
        }
    }
}

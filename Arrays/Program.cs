using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanım 1
            string[] arrays = new string[3];
            arrays[0] = "DERYA";
            arrays[1] = "EMRAH";
            arrays[2] = "DUYGU";
            for (int i = 0; i < arrays.Length; i++)
            {
                Console.WriteLine(arrays[i]);
            }
            //kullanım 2
            string[] arrays2 = { "kalem","kitap","defter"};//string[] arrays2 = new[]{ "kalem","kitap","defter"};
            arrays2[0] = "LAMBA";//DEĞİŞİKLİK YAPABİLİRİZ AMA YENİ BİR ELEMAN EKLEYEMEYİZ
            foreach (var array in arrays2)
            {
                Console.WriteLine(array);
            }

            Console.WriteLine();
            //çok boyutlu diziler
            //string[,] arrays3 = new string[5, 3];
            //arrays3[0, 0] = "İstanbul";
            string[,] arrays3 = new string[5, 3]
            {
                {"İstanbul","izmit","Balıkesir"},
                {"Ankara","Konya","Kırıkkale"},
                {"Antalya","Adana","Mersin"},
                {"Rize","Trabzon","Samsun"},
                {"İzmir","Muğla","Manisa"},
            };
            for (int i = 0; i <= arrays3.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arrays3.GetUpperBound(1); j++)
                {
                    Console.WriteLine(arrays3[i,j]);
                } 
                Console.WriteLine("--------------------------");
            }
            Console.ReadKey();
        }
    }
}

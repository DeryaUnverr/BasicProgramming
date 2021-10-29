using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My Name is Derya ";
            var result = sentence.Length;//cümlenin uzunluğu
            Console.WriteLine($"length: {result}");
            var result2 = sentence.Clone();
            Console.WriteLine($"clone: {result2}");//klonunu oluşturma
            sentence = "My name is Ceren";

             bool result3 =sentence.EndsWith("ğ");//cümleğ ile mi bitiyor
             Console.WriteLine($"bitiş : {result3}");
             bool result4 = sentence.StartsWith("My name");//cümle bununlamı başlıyor
             Console.WriteLine($"başlangıç : {result4}");

             var result5 = sentence.IndexOf("name");//bir stringde belli bir karakteri ifadeyi arama index numarasını verir.yoksa -1
             Console.WriteLine($"index of : {result5}");
             var result6 = sentence.IndexOf(" ");//bulduğu ilk anda çıkar
             Console.WriteLine($"index of : {result6}");

             var result7 = sentence.LastIndexOf(" ");//aramaya sondan başlar bulur çıkar
             Console.WriteLine($"lastIndexOf: {result7}");
            var result8 = sentence.Insert(0, "hello, ");//bir ifadeye başka bir metni yerleştirmek için kuklanılır.
             Console.WriteLine($"insert: {result8}");
             var result9 = sentence.Substring(3);//metini parçalamak için kullanılır.3.karakterden itibaren al
             Console.WriteLine($"Substring: {result9}");
             var result10 = sentence.Substring(3, 5);//3.karakerden itibaren 5 tane al
             Console.WriteLine($"Substring2: {result10}");
             var result11 = sentence.ToLower();//tüm karakterleri küçük harf yapmak
             Console.WriteLine($"Tolower: {result11}");
             var result12 = sentence.ToUpper();//tüm karakterleri büyük yazar
             Console.WriteLine($"ToUpper: {result12}");
             var result13 = sentence.Replace(" ","-");//bir metin içinde belli karakterleri değiştirmek için boşluk yerine -
             Console.WriteLine($"Replace: {result13}");
             var result14 = sentence.Remove(2,4);//bir metinde belli bir indexten sonrasını atmak için kullnaılır.2 den                                                              itibaren 5 tane uçur uçur.
             Console.WriteLine($"Remove: {result14}");

            Console.ReadKey();
        }

        private static void Intro()
        {
            string city1 = "Ankara";
            Console.WriteLine(city1[0]);

            foreach (var city in city1)
            {
                Console.WriteLine(city);
            }

            string city2 = "İzmir";
            Console.WriteLine(city1 + "" + city2);

            Console.WriteLine(String.Format($"{city1} {city2}"));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals_Exam
{
    class Program
    {
        static void Main(string[] args)
        {

            #region IF-ELSE ateş ölçüm

            //Console.Title = "♦ Ateş Ölçüm Testi(İF-ELSE/SWITCH-CASE) ♦";
            //int vucutIsisi = 39;
            //if (vucutIsisi==36)
            //{
            //    Console.WriteLine("Vücut ısınız 36 , Gayet NORMAL ");
            //}
            //else if (vucutIsisi==37)
            //{
            //    Console.WriteLine("Vücut ısınız 37 , NORMAL ");
            //}
            //else if (vucutIsisi==38)
            //{
            //    Console.WriteLine("Vücut ısınız 38 , Biraz YÜKSEK ");
            //}
            //else if (vucutIsisi == 39)
            //{
            //    Console.WriteLine("Vücut ısınız 39 , YÜKSEK ATEŞ !! DURUM RİSKLİ!! ");
            //}
            //else
            //{
            //    Console.WriteLine(" ♣ YANIYORSUN!! ♣"); 
            //}
            #endregion
            #region Switch-Case
            //switch (vucutIsisi)
            //{
            //    case 36:
            //        Console.WriteLine("Vücut ısınız 36 , Gayet NORMAL ");
            //        break;
            //    case 37:
            //        Console.WriteLine("Vücut ısınız 37 , NORMAL ");
            //        break;
            //    case 38:
            //        Console.WriteLine("Vücut ısınız 38 , Biraz YÜKSEK ");
            //        break;
            //    case 39:
            //        Console.WriteLine("Vücut ısınız 39 , YÜKSEK ATEŞ !! DURUM RİSKLİ!! ");
            //        break;
            //    default:
            //        Console.WriteLine(" ♣ YANIYORSUN!! ♣");
            //        break;
            //}  
            #endregion

            Console.Title = "♣ IF - ELSE İLE 4 İSLEM ♣".ToUpper();
            //if-else ile 4 işlem yapma:
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("1.SAYIYI GİRİNİZ: ");
            double sayi1 = double.Parse(Console.ReadLine());
            Console.Write("2.SAYIYI GİRİNİZ: ");
            double sayi2 = double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Yapacak olduğunuz işlemi giriniz:\n" +
                              "\t1-)TOPLAMA\n" +
                              "\t2-)ÇIKARMA\n" +
                              "\t3-)ÇARPMA\n" +
                              "\t4-)BÖLME");
            char secim = Console.ReadKey(true).KeyChar;
            double sonuc = 0.0;
            string islem = "";
            if (secim == '1')
            {
                islem = "TOPLAMA;";
                sonuc = sayi1 + sayi2;
            }
            else if (secim == '2')
            {
                islem = "ÇIKARMA";
                sonuc = sayi1 - sayi2;
            }
            else if (secim == '3')
            {
                islem = "ÇARPMA";
                sonuc = sayi1 * sayi2;
            }
            else if (secim == '4')
            {
                islem = "BÖLME";
                sonuc = sayi1 / sayi2;
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Seçmiş olduğunuz {islem} işleminin sonucu {sonuc} !!");

            Console.ReadKey();
        }
    }
}

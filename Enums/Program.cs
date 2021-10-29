using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        enum Gunler
        {
            pazartesi, salı, çarşamba, perşembe, cuma, cumartesi, pazar
        }

        enum Cinsiyet
        {
            Kadın, Erkek = 5, Diğer
        }
        static void Main(string[] args)
        {
            Console.Title = "ENUM= NUMARALANDIRMA + SABİT".ToUpper();
            Gunler gun = Gunler.cumartesi;
            switch (gun)
            {
                case Gunler.pazartesi:
                    Console.WriteLine("Bugun tatil değil");
                    break;
                case Gunler.salı:
                    Console.WriteLine("Bugun tatil değil");
                    break;
                case Gunler.çarşamba:
                    Console.WriteLine("Bugun tatil değil");
                    break;
                case Gunler.perşembe:
                    Console.WriteLine("Bugun tatil değil");
                    break;
                case Gunler.cuma:
                    Console.WriteLine("Bugun tatil değil");
                    break;
                case Gunler.cumartesi:
                    Console.WriteLine("Bugun tatil");
                    break;
                case Gunler.pazar:
                    Console.WriteLine("Bugun tatil değil");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            Cinsiyet cns = Cinsiyet.Erkek;
            Console.WriteLine("cns:" + cns);
            Cinsiyet cns2 = (Cinsiyet)5;//var olanı yazar(Erkek)
            Console.WriteLine("cns2:" + cns2);
            Cinsiyet cns3 = (Cinsiyet)15;//15 yazar çünkü tanımlı değil
            Console.WriteLine("cns3:" + cns3);
            Console.ReadKey();
        }
    }
}

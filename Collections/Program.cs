using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayLİst();
            //List();
            //Dictionary
            Dictionary<string,string> dictionary= new Dictionary<string, string>();
            dictionary.Add("TABLE","MASA  ");
            dictionary.Add("BOOK","KİTAP");
            dictionary.Add("PEN","DOLMA KALEM");

            foreach (var dictionaries in dictionary)
            {
                Console.WriteLine(dictionaries);
                Console.WriteLine(dictionaries.Key);
                Console.WriteLine(dictionaries.Value);
                
                
            }

            Console.WriteLine(dictionary.ContainsKey("table"));
            Console.WriteLine(dictionary.ContainsValue("kitap"));
            Console.WriteLine(dictionary.ContainsKey("masa"));
            Console.ReadKey();
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");
            Console.WriteLine(cities.Contains("İstanbul"));

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //List<Customer> customers= new List<Customer>();
            List<Customer> customers = new List<Customer>
            {
                new Customer {Id = 1, FirstName = "Ali"},
                new Customer {Id = 2, FirstName = "Veli"},
            };
            Customer customer = new Customer
            {
                Id = 3, FirstName = "Duygu"
            };

            customers.Add(customer);
            customers.Add(new Customer {Id = 4, FirstName = "Deniz"});

            customers.AddRange(new Customer[2]
            {
                new Customer {Id = 5, FirstName = "Emrah"}, new Customer {Id = 6, FirstName = "Evren"}
            });

            var count = customers.Count;
            var index = customers.IndexOf(customer);
            Console.WriteLine($"index: {index}");
            var indexSon = customers.LastIndexOf(customer);
            Console.WriteLine($"index son : {indexSon}");
            customers.Remove(customer); //BULDUĞU İLK DEĞERİ UÇURURÜR
            customers.RemoveAt(2); //seçiliindexi siler
            customers.RemoveAll(c => c.FirstName == "Deniz");
            foreach (var customer1 in customers)
            {
                Console.WriteLine($"{customer1.Id},{customer1.FirstName}");
            }

            Console.WriteLine(customers.Contains(customer));

            Console.WriteLine($"Listedeki eleman sayısı: {count} ");
        }

        private static void ArrayLİst()
        {
            ArrayList list = new ArrayList(); //type-safe yok oldu.
            list.Add("Ankara");
            list.Add("İzmir");
            list.Add(1);
            list.Add('a');

            foreach (var lists in list)
            {
                Console.WriteLine(lists);
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; } 
    }
}

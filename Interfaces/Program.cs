using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // InterfacesInto();

            //Demo();
            ICustomerDal[] customerDals= new ICustomerDal[3]
            {
                new OracleCustomerDal(), 
                new SqlServerCustomerDal(),
                new  MySqlCustomerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.ReadKey();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesInto()
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer {Id = 1, FirsName = "Derya", LastName = "Ünver",Adress = "İzmir"});
            personManager.Add(new Student {Id = 2, FirsName = "Ali", LastName = "Çalışkan",Departmant = "Compiter Science"});
            Worker worker = new Worker
            {
                Id = 3,
                FirsName = "Veli",
                LastName = "Yıldız",
                Departmant = "IT"
                

            };
            personManager.Add(worker);
        }
    }

    interface IPerson
    {
         int Id { get; set; }
         string FirsName { get; set; }
         string LastName { get; set; }
    }

    class Customer:IPerson
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }

        public  string Adress { get; set; }
    }

    class Student:IPerson
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }

    class  Worker:IPerson
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }

    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirsName);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerMnager customerMnager= new CustomerMnager();
            customerMnager.Add();
            customerMnager.Update();

            ProductManager productManager= new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer= new Customer();
            customer.Id = 1;
            customer.FirstName = "DUYGU";
            customer.LastName = "ÜNVER";
            customer.City = "İzmir";
            Console.WriteLine(customer.FirstName);

            Customer customer2 = new Customer()
            {
                Id = 2,
                FirstName = "Ayşe",
                LastName = "Yılmaz",
                City = "Ankara"
            };

            Console.WriteLine(customer2.FirstName);


            Console.ReadKey();
        }
    }
}

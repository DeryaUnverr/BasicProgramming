using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database= new SqlServer();
            database.Add();
            database.Delete();
            Database database2= new Oracle();
            database2.Add();
            database2.Delete();

            Console.ReadKey();
        }
    }

     abstract class Database//tanımlama
    {
        public void Add()
        {
            Console.WriteLine("Added !");
        }

        public abstract void Delete();
    }

     class  SqlServer:Database
     {
        public override void Delete()
        {
            Console.WriteLine("Deleted  by Sql");
        }
    }

    class Oracle:Database
     {
         public override void Delete()
         {
            Console.WriteLine("Deleted  by Oracle");
        }
     }
}

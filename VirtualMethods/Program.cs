using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlserverDatabase database= new SqlserverDatabase();
            database.Add();
            MySqlDatabase database2= new MySqlDatabase();
            database2.Add();
            Console.ReadKey();
        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added Default !");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted Default!");
        }
    }

    class SqlserverDatabase:Database
    {
        public override void Add()
        {
            Console.WriteLine("Added Sql !");
            //base.Add(); temel sınıftaki add metodunu çağır!
        }
    }
    class MySqlDatabase : Database
    {
       
    }
}

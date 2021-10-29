using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustumorManager custumorManager = new CustumorManager(23);
            custumorManager.List();
            CustumorManager custumorManager2 = new CustumorManager();
 
            custumorManager2.List();

            Product product = new Product{Id = 1,Name = "Derya"};
            Product product2= new Product(2,"Duygu");

            EmployeeManager employeeManager= new EmployeeManager(new DatabaseLogger());
            
            PersonManager personManager = new PersonManager("Product");
            personManager.Add();
         

            Console.ReadKey();
        }
    }

    class CustumorManager
    {
        private int _count = 15;
        public CustumorManager()
        {

        }

        public CustumorManager(int count)
        {
            _count = count;
        }
        public void List()
        {
            Console.WriteLine($"Listed {_count} ! ");
        }
        public void Add()
        {
            Console.WriteLine($"Added {_count} !");
        }
    }
    
    class Product
    {
        private int _id;
        private string _name;

        public Product(int ıd,string name)
        {
            Id = _id;
            name = _name;
        }

        public Product()
        {
            
        }
        public int Id { get; set; }
        public string Name { get; set; }

    }

    interface ILogger
    {
        void Log();
    }

    class  DatabaseLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Database Logger");
        }
    }

    class FileLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("File Logger");
        }
    }

    class  EmployeeManager
    {
        private ILogger _logger;

        public EmployeeManager(ILogger logger)
        {
            logger = _logger;
        }
        public void Add()
        {
           _logger.Log();
           Console.WriteLine("Added !");
        }
    }

    class BaseClass
    {
        private string _entity;

        public BaseClass(string entity)
        {
            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine($"{_entity} message");
        }
    }

    class PersonManager:BaseClass
    {
        public PersonManager(string entity) : base(entity)
        {
        }

        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }
    }
}

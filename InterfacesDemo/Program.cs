using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Worker(), 
                new Manager(), 
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }
            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }

            ISalary[] salaries = new ISalary[2]
            {
                new Manager(),
                new Worker()
            };
            foreach (var salary in salaries)
            {
                salary.GetSalary();
            }

            Console.ReadKey();

        }
    }

    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager:IWorker,IEat,ISalary
    {
        public void Work()
        {
            Console.WriteLine("Manager Work");
        }

        public void Eat()
        {
            Console.WriteLine("Manager Eat");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager Salary");
        }
    }

    class Worker:IWorker,IEat,ISalary
    {
        public void Work()
        {
            Console.WriteLine("Worker Work");
        }

        public void Eat()
        {
            Console.WriteLine("Worker Eat");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker Salary");
        }
    }

    class Robot:IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot Work");
        }
    }
   
}

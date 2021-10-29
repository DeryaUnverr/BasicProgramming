using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3] 
            {
                new Person
                { 
                    FirstName="Derya"
                },new Customer
                { 
                    FirstName="Seyma"
                },new Student
                {
                    FirstName="Duygu"
                }
            };
            foreach (var person in people)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadKey();
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person
    {
        public string Adress { get; set; }
    }
    class Student:Person
    {
        public string Departmant { get; set; }
    }
}

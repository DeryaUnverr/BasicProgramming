﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "Ünver", Age = 26 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadKey();
        }
    }
    [ToTable("Customers")]//parametre
    [ToTable("TblCustomers")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]//zorunlu
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }

    }

    class CustomerDal
    {
        [Obsolete("Don't use add,instead use AddNew Method!")]
        public void Add(Customer customer)
        {
            Console.WriteLine($"{customer.Id}, {customer.FirstName} ,{customer.LastName} ,{customer.Age}");
        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine($"{customer.Id}, {customer.FirstName} ,{customer.LastName} ,{customer.Age}");
        }
    }
    [AttributeUsage(AttributeTargets.Property,AllowMultiple = true)]
    class RequiredPropertyAttribute:Attribute
    {
        
    }
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class ToTableAttribute:Attribute //parametre
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}
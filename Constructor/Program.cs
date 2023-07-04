using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Furkan", LastName = "Sırdaş", City = "İstanbul" };

            Customer customer2 = new Customer(2, "Engin" , "Demiroğ" , "Ankara");

            Console.ReadLine();
        }

        
    }

    class Customer
    {
        public Customer()
        {

        }


        public Customer(int id, string firstName, string lastName, string city) //constructor bir method gibi çalışır.
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}

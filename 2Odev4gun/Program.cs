using System;

namespace _2Odev4gun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(2,"Derin","Demiroğ","Ankara");

            Console.WriteLine(customer.FirstName);
        }
    }

    class Customer
    {
        //construcktor
        public Customer(int id, string firstName, string lastName, string city)
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
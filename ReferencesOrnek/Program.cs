using System;

namespace ReferencesOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Emre";

            Customer customer = new Customer();
            customer.FirstName = "Ali";
            customer.CreditCard = "13456789545";

            Employee employee = new Employee();
            employee.FirstName = "Veli";

            Person person3 = customer;
            customer.FirstName = "Ahmet";

            Console.WriteLine(((Customer)person3).CreditCard);

            PersonManager personManager = new PersonManager();
            personManager.Add(customer);



        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Customer : Person
    {
        public string CreditCard { get; set; }

    }

    class Employee : Person
    {
        public int EmployeNumber { get; set; }

    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}

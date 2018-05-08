using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public virtual void Display()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }

    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string firstName, string lastName, string company)
                : base(firstName, lastName)
        {
            Company = company;
        }
        public new void Display()
        {
            Console.WriteLine($"{FirstName} {LastName} работает в {Company}");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Person tom = new Employee("T", "P", "kaka");
            tom.Display();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

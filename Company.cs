using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> Employees { get; set; }
        public Company(string name, DateTime createdDate)
        {
            Name = name;
            CreatedOn = createdDate;
            Employees = new List<Employee>();
        }
        public void ListEmployees()
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"Established {CreatedOn}");
            Console.WriteLine();
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"Employee: {employee.LastName}, {employee.FirstName}, {employee.Title}   Employee Since {employee.StartDate}");
            }
        }
    }
}
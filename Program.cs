using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company Xanthars = new Company("Xanthar's Xylophones", new DateTime(1888, 01, 05));
            // Create three employees
            Employee Xanthar = new Employee()
            {
                Title = "Owner",
                FirstName = "Xanthar",
                LastName = "Xanathar",
                StartDate = new DateTime(1888, 01, 05)
            };
            Employee Xygon = new Employee()
            {
                Title = "Head of Manufacturing",
                FirstName = "Xygon",
                LastName = "Xanathar",
                StartDate = new DateTime(1985, 12, 24)
            };
            Employee Xakery = new Employee()
            {
                Title = "Sales",
                FirstName = "Xakery",
                LastName = "Xtephens",
                StartDate = new DateTime(2009, 05, 05)
            };

            // Assign the employees to the company
            Xanthars.Employees.Add(Xanthar);
            Xanthars.Employees.Add(Xygon);
            Xanthars.Employees.Add(Xakery);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            Xanthars.ListEmployees();
        }
    }
}
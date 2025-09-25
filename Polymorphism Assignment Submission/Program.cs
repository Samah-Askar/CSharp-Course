using System;

namespace InterfaceExample
{
    // Step 1: Define an interface with a Quit method
    interface IQuittable
    {
        void Quit(); // Method signature only, no implementation
    }

    // Step 2: Create an Employee class that implements IQuittable
    class Employee : IQuittable
    {
        // Properties of Employee
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Step 3: Implement the Quit method from the interface
        public void Quit()
        {
            // Custom behavior when employee "quits"
            Console.WriteLine($"{FirstName} {LastName} (ID: {Id}) has quit the company.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Step 4: Create an Employee instance
            Employee emp = new Employee
            {
                Id = 1,
                FirstName = "Samah",
                LastName = "Askar"
            };

            // Step 5: Use polymorphism - assign Employee to IQuittable type
            IQuittable quittable = emp;

            // Step 6: Call the Quit method via interface reference
            quittable.Quit();

            // Wait for key press to close console
            Console.ReadKey();
        }
    }
}

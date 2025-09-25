using System;

namespace EmployeeEqualityApp
{
    // Employee class with Id, FirstName, LastName
    class Employee
    {
        public int Id { get; set; }               // Employee ID
        public string FirstName { get; set; }     // First name
        public string LastName { get; set; }      // Last name

        // Overload '==' operator to compare by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check for null on both sides
            if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
                return true;

            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            return emp1.Id == emp2.Id;
        }

        // Overload '!=' operator
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Override Equals (recommended when overloading ==)
        public override bool Equals(object obj)
        {
            var other = obj as Employee;
            if (other == null)
                return false;
            return this.Id == other.Id;
        }

        // Override GetHashCode when Equals is overridden
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create two Employee objects
            Employee emp1 = new Employee { Id = 1, FirstName = "Samah", LastName = "Askar" };
            Employee emp2 = new Employee { Id = 1, FirstName = "Jane", LastName = "Smith" };

            // Compare using overloaded '=='
            bool areEqual = emp1 == emp2;

            // Output result
            Console.WriteLine("Are the employees equal? " + areEqual);

            // Use '!=' as well
            Console.WriteLine("Are the employees different? " + (emp1 != emp2));

            Console.ReadKey();
        }
    }
}

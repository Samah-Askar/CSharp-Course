using System;

namespace ConsoleAppExample
{
    // Define a class called MathOperations
    class MathOperations
    {
        // Define a void method that takes two integer parameters
        public void DoMath(int num1, int num2)
        {
            // Perform a math operation on the first integer (e.g., multiply it by 3)
            int result = num1 * 3;

            // Display the result of the operation
            Console.WriteLine("Result of math operation on first number: " + result);

            // Display the second integer
            Console.WriteLine("Second number is: " + num2);
        }
    }

    // Main program class
    class Program
    {
        // Main entry point of the console application
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the method using positional arguments
            mathOps.DoMath(8, 12); // 8 will be multiplied, 12 will be displayed

            // Call the method using named arguments
            mathOps.DoMath(num1: 17, num2: 32); // 17 will be multiplied, 32 will be displayed

            // Wait for user to press a key before closing
            Console.ReadKey();
        }
    }
}

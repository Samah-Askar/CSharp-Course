using System;

class Program
{
    static void Main()
    {
        // Display greeting message to the user at the start
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Ask the user for the weight of the package
        Console.Write("Enter package weight: ");
        decimal packageWeight = Convert.ToDecimal(Console.ReadLine());

        // Validate weight threshold
        if (packageWeight > 50)
        {
            // Inform the user and exit if too heavy
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Prompt user for package width
        Console.Write("Enter package width: ");
        decimal packageWidth = Convert.ToDecimal(Console.ReadLine());

        // Prompt user for package height
        Console.Write("Enter package height: ");
        decimal packageHeight = Convert.ToDecimal(Console.ReadLine());

        // Prompt user for package length
        Console.Write("Enter package length: ");
        decimal packageLength = Convert.ToDecimal(Console.ReadLine());

        // Calculate the sum of all dimensions
        decimal totalDimensions = packageWidth + packageHeight + packageLength;

        // Check if the combined size is acceptable
        if (totalDimensions > 50)
        {
            // Let the user know if the size exceeds the limit
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Compute the quote using the shipping cost formula
        decimal shippingCost = (packageWidth * packageHeight * packageLength * packageWeight) / 100;

        // Output the calculated shipping cost, formatted as currency
        Console.WriteLine($"Your estimated total for shipping this package is: ${shippingCost:0.00}");
        Console.WriteLine("Thank you!");
    }
}

using System; // Import the System namespace for console input and output.

namespace CalculatorApp // Define the namespace for the calculator application.
{
    // Define the Program class that contains the application logic.
    class Program
    {
        // Define the main method, which is the entry point of the program.
        static void Main(string[] args)
        {
            // Show the user the available operations.
            Console.WriteLine("Choose an operation:");
            // Tell the user that option 1 is addition.
            Console.WriteLine("1. Addition");
            // Tell the user that option 2 is multiplication.
            Console.WriteLine("2. Multiplication");
            // Ask the user to enter a choice.
            Console.Write("Enter your choice: ");
            // Read the user's choice from the keyboard.
            string choice = Console.ReadLine();
            // Ask the user to enter the first number.
            Console.Write("Enter first number: ");
            // Read the first number and convert it to a double.
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            // Ask the user to enter the second number.
            Console.Write("Enter second number: ");
            // Read the second number and convert it to a double.
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            // Check whether the user chose addition.
            if (choice == "1")
            {
                // Add the two numbers together.
                double result = firstNumber + secondNumber;
                // Display the addition result.
                Console.WriteLine($"The sum is: {result}");
            }
            // Check whether the user chose multiplication.
            else if (choice == "2")
            {
                // Multiply the two numbers together.
                double result = firstNumber * secondNumber;
                // Display the multiplication result.
                Console.WriteLine($"The product is: {result}");
            }
            // Handle any invalid input.
            else
            {
                // Show an error message for an invalid choice.
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}
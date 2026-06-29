using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter the first number.
            Console.Write("Enter first number: ");

            // Read the first number from the keyboard and convert it to a double.
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            // Ask the user to enter the second number.
            Console.Write("Enter second number: ");

            // Read the second number from the keyboard and convert it to a double.
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            // Add the two numbers together.
            double sum = firstNumber + secondNumber;

            // Display the result to the user.
            Console.WriteLine($"The sum is: {sum}");
        }
    }
}
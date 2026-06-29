using System; // This lets us use input and output tools like Console.

namespace CalculatorApp // This groups the calculator program in one place.
{
    // This class contains the calculator program.
    class Program
    {
        // This is the main method, which starts the program.
        static void Main(string[] args)
        {
            // This variable stores whether the user wants to do another calculation.
            string again = "y";

            // This loop keeps the program running until the user says no.
            while (again == "y" || again == "Y")
            {
                // This shows the user the list of math choices.
                Console.WriteLine("Choose an operation:");
                // This shows the addition option.
                Console.WriteLine("1. Addition");
                // This shows the subtraction option.
                Console.WriteLine("2. Subtraction");
                // This shows the multiplication option.
                Console.WriteLine("3. Multiplication");
                // This shows the division option.
                Console.WriteLine("4. Division");
                // This asks the user to choose one of the options.
                Console.Write("Enter your choice: ");
                // This reads the chosen option from the keyboard.
                string choice = Console.ReadLine();
                // This asks the user for the first number.
                Console.Write("Enter first number: ");
                // This reads the first number and turns it into a decimal number.
                double firstNumber = Convert.ToDouble(Console.ReadLine());
                // This asks the user for the second number.
                Console.Write("Enter second number: ");
                // This reads the second number and turns it into a decimal number.
                double secondNumber = Convert.ToDouble(Console.ReadLine());
                // This checks if the user chose addition.
                if (choice == "1")
                {
                    // This adds the two numbers together.
                    double result = firstNumber + secondNumber;
                    // This prints the answer for addition.
                    Console.WriteLine($"The sum is: {result}");
                }
                // This checks if the user chose subtraction.
                else if (choice == "2")
                {
                    // This subtracts the second number from the first number.
                    double result = firstNumber - secondNumber;
                    // This prints the answer for subtraction.
                    Console.WriteLine($"The difference is: {result}");
                }
                // This checks if the user chose multiplication.
                else if (choice == "3")
                {
                    // This multiplies the two numbers together.
                    double result = firstNumber * secondNumber;
                    // This prints the answer for multiplication.
                    Console.WriteLine($"The product is: {result}");
                }
                // This checks if the user chose division.
                else if (choice == "4")
                {
                    // This checks whether the second number is zero.
                    if (secondNumber != 0)
                    {
                        // This divides the first number by the second number.
                        double result = firstNumber / secondNumber;
                        // This prints the answer for division.
                        Console.WriteLine($"The quotient is: {result}");
                    }
                    else
                    {
                        // This shows a message if the user tries to divide by zero.
                        Console.WriteLine("Cannot divide by zero.");
                    }
                }
                // This handles any choice that is not one of the four options.
                else
                {
                    // This shows a message when the user enters an invalid option.
                    Console.WriteLine("Invalid choice.");
                }

                // This asks the user whether they want to do another calculation.
                Console.Write("Do you want to calculate anything else? (y/n): ");
                // This reads the user's answer.
                again = Console.ReadLine();
            }
        }
    }
}
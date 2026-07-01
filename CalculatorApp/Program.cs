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
                // This shows the percentage option.
                Console.WriteLine("5. Percentage");
                // This shows the integer division option.
                Console.WriteLine("6. Integer Division");
                // This shows the root option.
                Console.WriteLine("7. Root of a Number");
                // This shows the square root option.
                Console.WriteLine("8. Square Root");
                // This shows the comparison option.
                Console.WriteLine("9. Compare Two Numbers");
                // This asks the user to choose one of the options.
                Console.Write("Enter your choice: ");
                // This reads the chosen option from the keyboard.
                string choice = Console.ReadLine() ?? string.Empty;

                // These are the numbers we will use for most operations.
                double firstNumber = 0;
                double secondNumber = 0;

                // For square root we only need one number.
                if (choice == "8")
                {
                    // This asks the user for one number for square root.
                    Console.Write("Enter the number for square root: ");
                    // This reads the number and turns it into a decimal number.
                    firstNumber = Convert.ToDouble(Console.ReadLine());
                }
                else if (choice == "7")
                {
                    // This asks the user for the number to find the root of.
                    Console.Write("Enter the number to find the root of: ");
                    firstNumber = Convert.ToDouble(Console.ReadLine());
                    // This asks the user for the root degree.
                    Console.Write("Enter the root degree (for example, 3 for cube root): ");
                    secondNumber = Convert.ToDouble(Console.ReadLine());
                }
                else if (choice == "5")
                {
                    // This asks for the value to which we apply a percentage.
                    Console.Write("Enter the value: ");
                    firstNumber = Convert.ToDouble(Console.ReadLine());
                    // This asks for the percentage to apply to that value.
                    Console.Write("Enter the percentage: ");
                    secondNumber = Convert.ToDouble(Console.ReadLine());
                }
                else if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "6" || choice == "9")
                {
                    // This asks the user for the first number.
                    Console.Write("Enter first number: ");
                    // This reads the first number and turns it into a decimal number.
                    firstNumber = Convert.ToDouble(Console.ReadLine());
                    // This asks the user for the second number.
                    Console.Write("Enter second number: ");
                    // This reads the second number and turns it into a decimal number.
                    secondNumber = Convert.ToDouble(Console.ReadLine());
                }

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
                // This checks if the user chose percentage.
                else if (choice == "5")
                {
                    // This calculates the percentage of the value.
                    double result = firstNumber * secondNumber / 100.0;
                    // This prints the answer for percentage.
                    Console.WriteLine($"{secondNumber}% of {firstNumber} is: {result}");
                }
                // This checks if the user chose integer division.
                else if (choice == "6")
                {
                    // This converts both values to whole numbers.
                    int firstInt = (int)firstNumber;
                    int secondInt = (int)secondNumber;
                    // This checks whether the second value is zero.
                    if (secondInt != 0)
                    {
                        // This divides the two whole numbers and drops any fraction.
                        int result = firstInt / secondInt;
                        // This prints the answer for integer division.
                        Console.WriteLine($"{firstInt} divided by {secondInt} equals: {result}");
                    }
                    else
                    {
                        // This shows a message if the user tries to divide by zero.
                        Console.WriteLine("Cannot divide by zero.");
                    }
                }
                // This checks if the user chose the nth root.
                else if (choice == "7")
                {
                    // This checks whether the root degree is zero.
                    if (secondNumber != 0)
                    {
                        // This finds the nth root using a power formula.
                        double result = Math.Pow(firstNumber, 1.0 / secondNumber);
                        // This prints the answer for the root operation.
                        Console.WriteLine($"The {secondNumber} root of {firstNumber} is: {result}");
                    }
                    else
                    {
                        // This shows a message if the user asks for a zero root.
                        Console.WriteLine("Root degree cannot be zero.");
                    }
                }
                // This checks if the user chose square root.
                else if (choice == "8")
                {
                    // This checks whether the number is negative.
                    if (firstNumber >= 0)
                    {
                        // This finds the square root of the number.
                        double result = Math.Sqrt(firstNumber);
                        // This prints the answer for square root.
                        Console.WriteLine($"The square root of {firstNumber} is: {result}");
                    }
                    else
                    {
                        // This shows a message if the number is negative.
                        Console.WriteLine("Cannot take the square root of a negative number.");
                    }
                }
                // This checks if the user chose comparison.
                else if (choice == "9")
                {
                    // This compares the two numbers.
                    Console.WriteLine($"{firstNumber} > {secondNumber}: {firstNumber > secondNumber}");
                    Console.WriteLine($"{firstNumber} < {secondNumber}: {firstNumber < secondNumber}");
                    Console.WriteLine($"{firstNumber} <= {secondNumber}: {firstNumber <= secondNumber}");

                    if (firstNumber > secondNumber)
                    {
                        Console.WriteLine($"{firstNumber} is greater than {secondNumber}.");
                    }
                    else if (firstNumber < secondNumber)
                    {
                        Console.WriteLine($"{firstNumber} is less than {secondNumber}.");
                    }
                    else
                    {
                        Console.WriteLine($"{firstNumber} is equal to {secondNumber}.");
                    }
                }
                // This handles any choice that is not one of the options.
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
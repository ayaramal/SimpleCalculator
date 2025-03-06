using System;

class Program
{
    static void Main(string[] args)
    {
        double num1, num2, result;
        string operation;

        Console.WriteLine("Welcome to the Simple Calculator!");

        Console.Write("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operation (+, -, *, /): ");
        operation = Console.ReadLine();

        Console.Write("Enter second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        bool keepRunning = true;

        while (keepRunning)
        {
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Result: {num1} + {num2} = {result}");
                    break;

                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Result: {num1} - {num2} = {result}");
                    break;

                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Result: {num1} * {num2} = {result}");
                    break;

                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error! Division by zero is not allowed.");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Result: {num1} / {num2} = {result}");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operation! Please use +, -, *, or /.");
                    break;
            }
            
            Console.Write("Do you want to perform another calculation? (y/n): ");

            string continueChoice = Console.ReadLine();
            keepRunning = continueChoice.ToLower() == "y";

        }

        Console.WriteLine("Thank you for using the calculator. Goodbye!");

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
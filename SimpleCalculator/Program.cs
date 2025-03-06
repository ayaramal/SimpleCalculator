using System;

class Program
{
    static void Main(string[] args)
    {
        double num1, num2, result;
        string operation;
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.WriteLine("Welcome to the Simple Calculator!");

            Console.Write("Enter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operation (+, -, *, /): ");
            operation = Console.ReadLine();

            Console.Write("Enter second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());


            switch (operation)
            {
                case "+":
                    result = Add(num1, num2);
                    Console.WriteLine($"Result: {num1} + {num2} = {result}");
                    break;

                case "-":
                    result = Subtract(num1, num2);
                    Console.WriteLine($"Result: {num1} - {num2} = {result}");
                    break;

                case "*":
                    result = Multiply(num1, num2);
                    Console.WriteLine($"Result: {num1} * {num2} = {result}");
                    break;

                case "/":
                    result = Divide(num1, num2);
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error! Division by zero is not allowed.");
                    }
                    else
                    {
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

    static double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    static double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    static double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    static double Divide(double num1, double num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Error! Division by zero is not allowed.");
            return 0;
        }
        return num1 / num2;
    }
}

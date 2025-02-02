using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace NumericValues.Services;

public class CalculatorService
{
    public static void PerformBasicOperations()
    {
        Console.WriteLine("\n==== Basic Arithmetic Operations ====");

        double num1 = GetNumberInput("Enter the first number: ");
        double num2 = GetNumberInput("Enter the second number: ");

        Console.WriteLine($"\nResults:");
        Console.WriteLine($"Addition: {num1} + {num2} = {num1 + num2}");
        Console.WriteLine($"Subtraction: {num1} - {num2} = {num1 - num2}");
        Console.WriteLine($"Multiplication: {num1} * {num2} = {num1 * num2}");

        if( num2 != 0)
        {
            Console.WriteLine($"Division: {num1} / {num2} = {num1 / num2}");
        }
        else
        {
            Console.WriteLine("Division: Cannot divide by zero");
        }        
    }
    public static void CheckEvenOdd()
    {
        Console.WriteLine("\n==== Even or Odd Check ====");

        int number = GetIntegerInput("Enter a number: ");

        if ( number % 2 == 0 )
        {
            Console.WriteLine($"{number} is Even.");
        }
        else
        {
            Console.WriteLine($"{number} is Odd");
        }
    }
    public static void PrintMultiplicationTable()
    {
        Console.WriteLine("\n==== Multiplication Table ====");

        int number = GetIntegerInput("Enter a number: ");

        Console.WriteLine($"\nMultiplication Table for {number}: ");
        for ( int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} * {i} = {number * i}");
        }
    }
    private static double GetNumberInput(string message)
    {
        double number;
        while(true)
        {
            Console.WriteLine(message);
            string? input = Console.ReadLine();

            if (double.TryParse(input, out number) )
            {
                return number;
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter valid number.");
            }
        }
    }
    private static int GetIntegerInput(string message)
    {
        int number;
        while (true)
        {
            Console.WriteLine(message);
            string? input = Console.ReadLine();

            if (int.TryParse(input, out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Invalid Input! Please enter a valid integer.");
            }
        }
    }
}

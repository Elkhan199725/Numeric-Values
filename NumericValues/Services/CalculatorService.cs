using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static NumericValues.Helpers.InputValidator;

namespace NumericValues.Services;

public class CalculatorService
{
    public static void PerformBasicOperations()
    {
        Console.WriteLine("\n==== Basic Arithmetic Operations ====");

        double num1 = GetValidDouble("Enter the first number: ");
        double num2 = GetValidDouble("Enter the second number: ");

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

        int number = GetValidInt("Enter a number: ");

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

        int number = GetValidInt("Enter a number: ");

        StringBuilder table = new StringBuilder();
        table.AppendLine($"\nMultiplication Table for {number}: ");

        for ( int i = 1; i <= 10; i++)
        {
            table.AppendLine($"{number} * {i} = {number * i}");
        }

        Console.WriteLine(table.ToString());
    }
}

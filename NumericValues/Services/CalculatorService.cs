using NumericValues.Helpers;
using System;
using System.Text;

namespace NumericValues.Services;

public class CalculatorService
{
    public static void PerformBasicOperations()
    {
        Console.WriteLine("\n==== Basic Arithmetic Operations ====");

        double num1 = InputValidator.GetValidDouble("Enter the first number: ");
        double num2 = InputValidator.GetValidDouble("Enter the second number: ");

        Console.Write("\nProcessing ");
        using (var spinner = new Spinner(Console.CursorLeft, Console.CursorTop))
        {
            spinner.Start();
            Thread.Sleep(1500);
            spinner.Stop();
        }

        StringBuilder results = new StringBuilder();
        results.AppendLine("\n📌 Results:");
        results.AppendLine($"➕ Addition: {num1} + {num2} = {num1 + num2:F2}");
        results.AppendLine($"➖ Subtraction: {num1} - {num2} = {num1 - num2:F2}");
        results.AppendLine($"✖ Multiplication: {num1} × {num2} = {num1 * num2:F2}");

        if (num2 != 0)
        {
            results.AppendLine($"➗ Division: {num1} ÷ {num2} = {num1 / num2:F2}");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            results.AppendLine("❌ Division: Cannot divide by zero.");
            Console.ResetColor();
        }

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(results.ToString());
        Console.ResetColor();
    }

    public static void CheckEvenOdd()
    {
        Console.WriteLine("\n==== Even or Odd Check ====");

        int number = InputValidator.GetValidInt("Enter a number: ");

        Console.Write("\nChecking ");
        using (var spinner = new Spinner(Console.CursorLeft, Console.CursorTop))
        {
            spinner.Start();
            Thread.Sleep(1000);
            spinner.Stop();
        }

        bool isEven = number % 2 == 0;
        Console.ForegroundColor = isEven ? ConsoleColor.Green : ConsoleColor.Yellow;
        Console.WriteLine($"\n{number} is {(isEven ? "Even" : "Odd")}.");
        Console.ResetColor();
    }

    public static void PrintMultiplicationTable()
    {
        Console.WriteLine("\n==== Multiplication Table ====");

        int number = InputValidator.GetValidInt("Enter a number: ");

        Console.Write("\nGenerating Table ");
        using (var spinner = new Spinner(Console.CursorLeft, Console.CursorTop))
        {
            spinner.Start();
            Thread.Sleep(1500);
            spinner.Stop();
        }

        StringBuilder table = new StringBuilder();
        table.AppendLine($"\n📌 Multiplication Table for {number}:");

        for (int i = 1; i <= 10; i++)
        {
            table.AppendLine($"   {number} × {i} = {number * i}");
        }

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(table.ToString());
        Console.ResetColor();
    }
}

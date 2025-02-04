using NumericValues.Helpers;
using System;
using System.Linq;
using System.Text;
using System.Threading;

namespace NumericValues.Services;

public class MathService
{
    public static void CalculateCircleAreaCircumference()
    {
        Console.WriteLine("\n==== 🟠 Circle Calculations ====");

        double radius = InputValidator.GetValidDouble("Enter the radius of the circle: ");

        Console.Write("\nCalculating ");
        using (var spinner = new Spinner(Console.CursorLeft, Console.CursorTop))
        {
            spinner.Start();
            Thread.Sleep(1500);
            spinner.Stop();
        }

        const double PI = Math.PI;
        double area = PI * radius * radius;
        double circumference = 2 * PI * radius;

        StringBuilder result = new StringBuilder();
        result.AppendLine($"\n📌 For a circle with radius {radius:F2}:");
        result.AppendLine($"🟢 Area: {area:F2}");
        result.AppendLine($"🟡 Circumference: {circumference:F2}");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(result.ToString());
        Console.ResetColor();
    }

    public static void CalculateSumOfDigits()
    {
        Console.WriteLine("\n==== 🔢 Sum of Digits Calculation ====");

        int number = InputValidator.GetValidInt("Enter a number: ");

        Console.Write("\nProcessing ");
        using (var spinner = new Spinner(Console.CursorLeft, Console.CursorTop))
        {
            spinner.Start();
            Thread.Sleep(1500);
            spinner.Stop();
        }

        int sum = number.ToString().Where(char.IsDigit).Sum(c => c - '0');
        Console.WriteLine($"\n📌 The sum of digits of {number} is: {sum}");
    }

    public static void CalculatePower()
    {
        Console.WriteLine("\n==== 🔋 Power Calculation ====");

        double baseNumber = InputValidator.GetValidDouble("Enter the base number: ");
        int exponent = InputValidator.GetValidInt("Enter the exponent: ");

        Console.Write("\nCalculating ");
        using (var spinner = new Spinner(Console.CursorLeft, Console.CursorTop))
        {
            spinner.Start();
            Thread.Sleep(1500);
            spinner.Stop();
        }

        double result = Math.Pow(baseNumber, exponent);

        if (exponent == 0)
        {
            Console.WriteLine("\n📌 Any number raised to 0 is always **1**.");
        }
        else if (baseNumber == 0 && exponent < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n❌ Error: 0 raised to a negative exponent is undefined.");
            Console.ResetColor();
            return;
        }
        else
        {
            Console.WriteLine($"\n📌 {baseNumber}^{exponent} = {result:F2}");
        }
    }

    public static void FindGreatestNumber()
    {
        Console.WriteLine("\n==== 🔝 Find the Greatest of Three Numbers ====");

        double num1 = InputValidator.GetValidDouble("Enter the first number: ");
        double num2 = InputValidator.GetValidDouble("Enter the second number: ");
        double num3 = InputValidator.GetValidDouble("Enter the third number: ");

        double greatest = Math.Max(num1, Math.Max(num2, num3));

        Console.WriteLine($"\n📌 The greatest number among {num1}, {num2}, and {num3} is: {greatest}");
    }

    public static long FactorialRecursive(int n)
    {
        if (n == 0 || n == 1) return 1;
        return n * FactorialRecursive(n - 1);
    }

    public static void CalculateFactorial()
    {
        Console.WriteLine("\n==== 🧮 Factorial Calculation ====");
        int number = InputValidator.GetPositiveInteger("Enter a non-negative integer: ");

        if (number > 20)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n⚠️ Warning: Factorial for numbers greater than 20 exceeds `long` capacity.");
            Console.ResetColor();
            return;
        }

        Console.Write("\nProcessing ");
        using (var spinner = new Spinner(Console.CursorLeft, Console.CursorTop))
        {
            spinner.Start();
            Thread.Sleep(1500);
            spinner.Stop();
        }

        long result = FactorialRecursive(number);
        Console.WriteLine($"\n📌 {number}! = {result}");
    }

    public static void IsPrime()
    {
        Console.WriteLine("\n==== 🔍 Prime Number Check ====");

        int number = InputValidator.GetValidInt("Enter a number: ");

        Console.Write("\nChecking ");
        using (var spinner = new Spinner(Console.CursorLeft, Console.CursorTop))
        {
            spinner.Start();
            Thread.Sleep(2000);
            spinner.Stop();
        }

        if (number < 2)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n❌ {number} is NOT a prime number.");
            Console.ResetColor();
            return;
        }

        if (number == 2)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n✅ 2 is a PRIME number.");
            Console.ResetColor();
            return;
        }

        if (number % 2 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n❌ {number} is NOT a prime number.");
            Console.ResetColor();
            return;
        }

        for (int i = 3; i * i <= number; i += 2) // Optimized check up to sqrt(n)
        {
            if (number % i == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n❌ {number} is NOT a prime number.");
                Console.ResetColor();
                return;
            }
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\n✅ {number} is a PRIME number.");
        Console.ResetColor();
    }
}

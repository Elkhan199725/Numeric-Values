using NumericValues.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NumericValues.Helpers.InputValidator;

namespace NumericValues.Services;

public class MathService
{
    public static void CalculateCircleAreaCircumference()
    {
        Console.WriteLine("\n==== Circle Calculations ====");

        double radius = GetValidDouble("Enter the radius of the circle: ");

        const double PI = Math.PI;
        double radiusSquared = radius * radius; // Avoid redundant `Math.Pow()`

        double area = PI * radiusSquared;
        double circumference = 2 * PI * radius;

        Console.WriteLine($"\nFor a circle with radius {radius}:");
        Console.WriteLine($"Area: {area}");
        Console.WriteLine($"Circumference: {circumference}");
    }


    public static void CalculateSumOfDigits()
    {
        Console.WriteLine("\n==== Sum of Digits Calculation ====");

        int number = GetValidInt("Enter a number: ");

        int sum = number.ToString().Where(char.IsDigit).Sum(c => c - '0');

        Console.WriteLine($"The sum of digits of {number} is: {sum}");
    }

    public static void CalculatePower()
    {
        Console.WriteLine("\n==== Power Calculation ====");

        double baseNumber = InputValidator.GetValidDouble("Enter the base number: ");
        int exponent = InputValidator.GetValidInt("Enter the exponent: ");

        if (exponent == 0)
        {
            Console.WriteLine($"Any number raised to 0 is 1.");
            return;
        }
        if (baseNumber == 1)
        {
            Console.WriteLine($"1 raised to any power is always 1.");
            return;
        }

        double result = Math.Pow(baseNumber, exponent);
        Console.WriteLine($"{baseNumber} ^ {exponent} = {result}");
    }

    public static void FindGreatestNumber()
    {
        Console.WriteLine("\n==== Find the Greatest of Three Numbers ====");

        double num1 = GetValidDouble("Enter the first number: ");
        double num2 = GetValidDouble("Enter the second number: ");
        double num3 = GetValidDouble("Enter the third number: ");

        double greatest = num1;

        if (num2 > greatest) greatest = num2;
        if (num3 > greatest) greatest = num3;

        Console.WriteLine($"\nThe greatest number among {num1}, {num2}, and {num3} is: {greatest}");
    }


    public static long FactorialRecursive(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        return n * FactorialRecursive(n - 1);
    }

    public static void CalculateFactorial()
    {
        Console.WriteLine("\n==== Factorial Calculation ====");

        int number = GetPositiveInteger("Enter a non-negative integer: ");
        long result = FactorialRecursive(number);

        Console.WriteLine($"{number}! = {result}");
    }

    public static void IsPrime()
    {
        Console.WriteLine("\n==== Prime Number Check ====");

        int number = GetValidInt("Enter a number: ");

        if (number < 2)
        {
            Console.WriteLine($"{number} is NOT a prime number.");
            return;
        }
        if (number == 2)
        {
            Console.WriteLine("2 is a PRIME number.");
            return;
        }
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is NOT a prime number.");
            return;
        }

        for (int i = 3; i <= Math.Sqrt(number); i += 2) // Skip even numbers
        {
            if (number % i == 0)
            {
                Console.WriteLine($"{number} is NOT a prime number.");
                return;
            }
        }

        Console.WriteLine($"{number} is a PRIME number.");
    }

}

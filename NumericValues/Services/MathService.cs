using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericValues.Services;

public class MathService
{
    public static void CalculateCircleAreaCircumference()
    {
        Console.WriteLine("\n==== Circle Calculations ====");

        double radius = GetNumberInput("Enter the radius of the circle: ");
        
        double area = Math.PI * Math.Pow(radius,2);
        double circumference = 2 * Math.PI * radius;

        Console.WriteLine($"\nFor a circle with radius {radius}");
        Console.WriteLine($"Area: {area}");
        Console.WriteLine($"Circumference: {circumference}");
    }

    public static void CalculateSumOfDigits()
    {
        Console.WriteLine("\n==== Sum of Digits Calculation ====");

        int number = GetIntegerInput("Enter a number: ");
        int sum = 0; 
        int temp = Math.Abs(number);

        while( temp > 0 )
        {
            sum += temp % 10;
            temp /= 10;
        }

        Console.WriteLine($"The sum of digits of {number} is: {sum}");
    }

    private static double GetNumberInput(string message)
    {
        double number;
        while (true)
        {
            Console.WriteLine(message);
            string? input = Console.ReadLine();

            if (double.TryParse(input, out number) &&  number > 0)
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
            if(int.TryParse(input, out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter valid number.");
            }
        }
    }
}

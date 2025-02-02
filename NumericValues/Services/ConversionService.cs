using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace NumericValues.Services;

public class ConversionService
{
    public static void ConvertCelsiusToFahrenheit()
    {
        Console.WriteLine("\n==== Celsius to Fahrenheit Conversion ====");

        double celsius = GetNumberInput("Enter temperature in Celsius: ");
        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F.");
    }

    public static double GetNumberInput(string message)
    {
        double number;
        while (true)
        {
            Console.WriteLine(message);
            string? input = Console.ReadLine();

            if (double.TryParse(input, out number))
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

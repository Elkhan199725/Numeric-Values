using NumericValues.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static NumericValues.Helpers.InputValidator;

namespace NumericValues.Services;

public class ConversionService
{
    public static void ConvertCelsiusToFahrenheit()
    {
        Console.WriteLine("\n==== Celsius to Fahrenheit Conversion ====");

        double celsius = GetValidDouble("Enter temperature in Celsius: ");

        const double factor = 9.0 / 5.0;
        const double offset = 32.0;

        double fahrenheit = (celsius * factor) + offset;

        Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F.");
    }

}

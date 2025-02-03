using NumericValues.Helpers;
using System;

namespace NumericValues.Services;

public class ConversionService
{
    public static void ConvertCelsiusToFahrenheit()
    {
        Console.WriteLine("\n==== Celsius to Fahrenheit Conversion ====");

        double celsius = InputValidator.GetValidDouble("Enter temperature in Celsius: ");

        Console.Write("\nConverting ");
        using (var spinner = new Spinner(Console.CursorLeft, Console.CursorTop))
        {
            spinner.Start();
            Thread.Sleep(1500); // Simulate conversion time
            spinner.Stop();
        }

        const double factor = 9.0 / 5.0;
        const double offset = 32.0;
        double fahrenheit = (celsius * factor) + offset;

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\n🌡️ {celsius:F2}°C is equal to {fahrenheit:F2}°F.");
        Console.ResetColor();
    }
}

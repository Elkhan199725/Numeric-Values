using NumericValues.Helpers;
using System;
using System.Text;

namespace NumericValues.Services;

public class ConversionService
{
    public static void ConvertCelsiusToFahrenheit()
    {
        Console.WriteLine("\n==== 🌡️ Celsius to Fahrenheit & Kelvin Conversion ====");

        double celsius = InputValidator.GetValidDouble("Enter temperature in Celsius: ");

        Console.Write("\nConverting ");
        using (var spinner = new Spinner(Console.CursorLeft, Console.CursorTop))
        {
            spinner.Start();
            Thread.Sleep(1500); // Simulate conversion time
            spinner.Stop();
        }

        // Conversion formulas
        const double factor = 9.0 / 5.0;
        const double offset = 32.0;
        const double absoluteZeroCelsius = -273.15;

        double fahrenheit = (celsius * factor) + offset;
        double kelvin = celsius + 273.15;

        // Use StringBuilder for structured output
        StringBuilder results = new StringBuilder();
        results.AppendLine($"\n📌 Conversion Results:");
        results.AppendLine($"🌡️ {celsius:F2}°C = {fahrenheit:F2}°F");
        results.AppendLine($"🌡️ {celsius:F2}°C = {kelvin:F2}K");

        // Warn user if they input a temperature below absolute zero
        if (celsius < absoluteZeroCelsius)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            results.AppendLine("\n⚠️ Warning: Temperature is below absolute zero! Not physically possible.");
            Console.ResetColor();
        }

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(results.ToString());
        Console.ResetColor();
    }
}

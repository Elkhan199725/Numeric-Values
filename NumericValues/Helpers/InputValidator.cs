using System;

namespace NumericValues.Helpers;

public class InputValidator
{
    public static double GetValidDouble(string message)
    {
        double number;
        while (true)
        {
            Console.Write($"{message} ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string? input = Console.ReadLine()?.Trim(); // Remove extra spaces
            Console.ResetColor();

            if (double.TryParse(input, out number))
            {
                return number;
            }

            ShowError("Invalid input! Please enter a valid number.");
        }
    }

    public static double GetPositiveDouble(string message)
    {
        double number;
        while (true)
        {
            Console.Write($"{message} ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string? input = Console.ReadLine()?.Trim();
            Console.ResetColor();

            if (double.TryParse(input, out number))
            {
                if (number > 0)
                {
                    return number;
                }
                ShowError("Number must be greater than 0.");
            }
            else
            {
                ShowError("Invalid input! Please enter a valid positive number.");
            }
        }
    }

    public static int GetValidInt(string message)
    {
        int number;
        while (true)
        {
            Console.Write($"{message} ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string? input = Console.ReadLine()?.Trim();
            Console.ResetColor();

            if (int.TryParse(input, out number))
            {
                return number;
            }

            ShowError("Invalid input! Please enter a valid integer.");
        }
    }

    public static int GetPositiveInteger(string message)
    {
        int number;
        while (true)
        {
            Console.Write($"{message} ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string? input = Console.ReadLine()?.Trim();
            Console.ResetColor();

            if (int.TryParse(input, out number))
            {
                if (number > 0)
                {
                    return number;
                }
                ShowError("Number must be greater than 0.");
            }
            else
            {
                ShowError("Invalid input! Please enter a valid positive integer.");
            }
        }
    }

    // 📌 Centralized Error Display with Red Color
    private static void ShowError(string errorMessage)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"❌ {errorMessage}");
        Console.ResetColor();
    }
}

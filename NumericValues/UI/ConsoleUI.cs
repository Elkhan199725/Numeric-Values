using NumericValues.Helpers;
using NumericValues.Services;
using System;
using System.Threading;

namespace NumericValues.UI;

public class ConsoleUI
{
    public static void Start()
    {
        ShowIntroAnimation(); // Fancy intro animation when app starts

        while (true)
        {
            Console.Clear();
            PrintHeader();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[1]  Arithmetic Operations");
            Console.WriteLine("[2]  Even or Odd Check");
            Console.WriteLine("[3]  Celsius to Fahrenheit");
            Console.WriteLine("[4]  Circle Calculations");
            Console.WriteLine("[5]  Multiplication Table");
            Console.WriteLine("[6]  Sum of Digits");
            Console.WriteLine("[7]  Power Calculation");
            Console.WriteLine("[8]  Greatest of Three Numbers");
            Console.WriteLine("[9]  Factorial Calculation");
            Console.WriteLine("[10] Prime Number Check");
            Console.WriteLine("[0]  Exit");
            Console.ResetColor();
            PrintFooter();

            Console.Write("👉 Enter your choice: ");
            string? input = Console.ReadLine();
            Console.Clear();

            if (input == "0")
            {
                ShowExitAnimation();
                break;
            }

            switch (input)
            {
                case "1":
                    ShowLoadingBar("Performing Arithmetic Operations");
                    CalculatorService.PerformBasicOperations();
                    break;
                case "2":
                    ShowLoadingBar("Checking Even or Odd");
                    CalculatorService.CheckEvenOdd();
                    break;
                case "3":
                    ShowLoadingBar("Converting Temperature");
                    ConversionService.ConvertCelsiusToFahrenheit();
                    break;
                case "4":
                    ShowLoadingBar("Calculating Circle Area and Circumference");
                    MathService.CalculateCircleAreaCircumference();
                    break;
                case "5":
                    ShowLoadingBar("Generating Multiplication Table");
                    CalculatorService.PrintMultiplicationTable();
                    break;
                case "6":
                    ShowLoadingBar("Calculating Sum of Digits");
                    MathService.CalculateSumOfDigits();
                    break;
                case "7":
                    ShowLoadingBar("Performing Power Calculation");
                    MathService.CalculatePower();
                    break;
                case "8":
                    ShowLoadingBar("Finding the Greatest Number");
                    MathService.FindGreatestNumber();
                    break;
                case "9":
                    ShowLoadingBar("Calculating Factorial");
                    MathService.CalculateFactorial();
                    break;
                case "10":
                    ShowLoadingBar("Checking if the Number is Prime");
                    MathService.IsPrime();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n❌ Invalid choice! Please enter a number between 0-10.");
                    Console.ResetColor();
                    break;
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nPress any key to return to the menu...");
            Console.ResetColor();
            Console.ReadKey();
        }
    }

    private static void PrintHeader()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("╔═══════════════════════════════╗");
        Console.WriteLine("║       NUMERIC PRACTICE APP    ║");
        Console.WriteLine("╚═══════════════════════════════╝");
        Console.ResetColor();
    }

    private static void PrintFooter()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("╔═══════════════════════════════╗");
        Console.WriteLine("║       Select an Option        ║");
        Console.WriteLine("╚═══════════════════════════════╝");
        Console.ResetColor();
    }

    private static void ShowExitAnimation()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\nExiting");
        for (int i = 0; i < 3; i++)
        {
            Thread.Sleep(500);
            Console.Write(".");
        }
        Console.WriteLine("\nGoodbye!");
        Console.ResetColor();
        Thread.Sleep(1000);
    }

    private static void ShowLoadingBar(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"\n{message} ");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Cyan;
        using (var spinner = new Spinner(Console.CursorLeft, Console.CursorTop))
        {
            spinner.Start();

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(200);
                Console.Write("█"); // Prints loading blocks
            }

            spinner.Stop();
        }
        Console.ResetColor();
        Console.WriteLine("\n");
    }


    private static void ShowIntroAnimation()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;

        string[] animation = {
            "╔════════════════════════╗",
            "║                        ║",
            "║   NUMERIC PRACTICE     ║",
            "║        APP            ║",
            "║                        ║",
            "╚════════════════════════╝"
        };

        foreach (string line in animation)
        {
            Console.WriteLine(line);
            Thread.Sleep(200); // Creates a smooth loading effect
        }
        Console.ResetColor();

        Thread.Sleep(500);
        Console.Clear();
    }
}

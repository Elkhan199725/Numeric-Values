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
            ShowMenu();

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

    // 📌 Prints the Main Header
    private static void PrintHeader()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("╔════════════════════════════════════════╗");
        Console.WriteLine("║      🌟 NUMERIC PRACTICE APP 🌟       ║");
        Console.WriteLine("╚════════════════════════════════════════╝");
        Console.ResetColor();
    }

    // 📌 Prints the Menu with Animations
    private static void ShowMenu()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("╔═══════════════════════════════════╗");
        Console.WriteLine("║          📜 MAIN MENU            ║");
        Console.WriteLine("╠═══════════════════════════════════╣");

        DisplayMenu(); // Calls the typing effect menu

        Console.WriteLine("╚═══════════════════════════════════╝");
        Console.ResetColor();
    }

    // 📌 Displays Menu with a Smooth Typing Effect
    private static void DisplayMenu()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        string[] menuItems = {
            "[1]  Arithmetic Operations",
            "[2]  Even or Odd Check",
            "[3]  Celsius to Fahrenheit",
            "[4]  Circle Calculations",
            "[5]  Multiplication Table",
            "[6]  Sum of Digits",
            "[7]  Power Calculation",
            "[8]  Greatest of Three Numbers",
            "[9]  Factorial Calculation",
            "[10] Prime Number Check",
            "[0]  Exit"
        };

        foreach (string item in menuItems)
        {
            TypeEffect(item);
        }
        Console.ResetColor();
    }

    // 📌 Simulates Typing Animation
    private static void TypeEffect(string message)
    {
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(20); // Adjusted speed for a smoother effect
        }
        Console.WriteLine();
    }

    // 📌 Animated Loading Bar with Spinner
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
                Thread.Sleep(150);
                Console.Write("█"); // Prints loading blocks
            }

            spinner.Stop();
        }
        Console.ResetColor();
        Console.WriteLine("\n");
    }

    // 📌 Smooth Animated Exit Effect
    private static void ShowExitAnimation()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;

        string[] goodbyeArt = {
            "╔═══════════════════════════╗",
            "║      👋 Goodbye!          ║",
            "║  Thanks for Using Our App ║",
            "║      See You Again!       ║",
            "╚═══════════════════════════╝"
        };

        foreach (string line in goodbyeArt)
        {
            Console.WriteLine(line);
            Thread.Sleep(250);
        }

        Console.ResetColor();
        Thread.Sleep(1200);
        Console.Clear();
    }

    // 📌 Fancy Intro Animation
    private static void ShowIntroAnimation()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;

        string[] animation = {
            "╔════════════════════════╗",
            "║                        ║",
            "║   🌟 NUMERIC PRACTICE  ║",
            "║       APP 📊          ║",
            "║                        ║",
            "╚════════════════════════╝"
        };

        foreach (string line in animation)
        {
            Console.WriteLine(line);
            Thread.Sleep(150);
        }

        Console.ResetColor();
        Thread.Sleep(400);
        Console.Clear();
    }
}

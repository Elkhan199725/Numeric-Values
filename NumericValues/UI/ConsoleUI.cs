using NumericValues.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericValues.UI;

public class ConsoleUI
{
    public static void Start()
    {
        while (true)
        {
            Console.WriteLine
                (@" 
==== Numeric Practice ====
1. Arithmetic Operations
2. Even or Odd
3. Celsius to Fahrenheit
4. Circle Calculations
5. Multiplication Table
6. Sum of Digits
7. Power Calculation
8. Max of Three Numbers
9. Factorial
10. Prime Check
11. Exit
Choose an option: ");

            string? input = Console.ReadLine();
            if (input == "11") break;

            switch (input)
            {
                case "1":
                    CalculatorService.PerformBasicOperations();
                    break;
                case "2":
                    CalculatorService.CheckEvenOdd();
                    break;
                case "3":
                    ConversionService.ConvertCelsiusToFahrenheit();
                    break;
                case "4":
                    MathService.CalculateCircleAreaCircumference();
                    break;
                case "5":
                    CalculatorService.PrintMultiplicationTable();
                    break;
                case "6":
                    MathService.CalculateSumOfDigits();
                    break;
                //case "7":
                //    MathService.CalculatePower();
                //    break;
                //case "8":
                //    MathService.FindGreatestNumber();
                //    break;
                //case "9":
                //    MathService.CalculateFactorial();
                //    break;
                //case "10":
                //    MathService.IsPrime();
                //    break;
                default:
                    Console.WriteLine("Invalid choice! Please enter a number between 1-11.");
                    break;

            }
        }
    }
}

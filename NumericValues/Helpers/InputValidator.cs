using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NumericValues.Helpers;

public class InputValidator
{
    public static double GetValidDouble(string message)
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
                Console.WriteLine("❌ Invalid input! Please enter a valid number.");
            }
        }
    }    public static double GetPositiveDouble(string message)
    {
        double number;
        while (true)
        {
            Console.WriteLine(message);
            string? input = Console.ReadLine();

            if (double.TryParse(input, out number) && number > 0)
            {
                return number;
            }
            else
            {
                Console.WriteLine("❌ Invalid input! Please enter a valid number.");
            }
        }
    }

    public static int GetValidInt(string message)
    {
        int number;
        while (true)
        {
            Console.WriteLine(message);
            string? input = Console.ReadLine();

            if (int.TryParse(input, out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("❌ Invalid input! Please enter a valid integer.");
            }
        }
    }

    public static int GetPositiveInteger(string message)
    {
        int number;
        while (true)
        {
            Console.WriteLine(message);
            string? input = Console.ReadLine();
            
            if(int.TryParse(input, out number) && number > 0)
            {
                return number;
            }
            else
            {
                Console.WriteLine("❌ Invalid input! Please enter a valid integer.");
            }
        }
    }
}

using NumericValues.UI;
using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        try
        {
            Console.OutputEncoding = Encoding.UTF8; // Ensures proper symbol/emoji display
            ConsoleUI.Start();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n❌ An unexpected error occurred: " + ex.Message);
            Console.ResetColor();
        }
        finally
        {
            Console.WriteLine("\n✅ Program execution finished. Press any key to exit...");
            Console.ReadKey();
        }
    }
}

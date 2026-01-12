using System;

namespace InventoryManagementSystem.Utils
{
  public static class InputHelper
  {
    public static decimal GetValidDecimal(string prompt)
    {
      decimal value;
      while (true)
      {
        Console.Write(prompt);
        string input = Console.ReadLine();
        if (!decimal.TryParse(input, out value))
        {
          Console.WriteLine("Invalid input. Please enter a valid decimal number.");
          continue;
        }
        else if (value < 0)
        {
          Console.WriteLine("Value cannot be negative. Try again.");
          continue;
        }
        return value;
      }
    }

    public static int GetValidInt(string prompt)
    {
      int value;
      while (true)
      {
        Console.Write(prompt);
        string input = Console.ReadLine();
        if (!int.TryParse(input, out value))
        {
          Console.WriteLine("Invalid input. Please enter a valid integer.");
          continue;
        }
        else if (value < 0)
        {
          Console.WriteLine("Value cannot be negative. Try again.");
          continue;
        }
        return value;
      }
    }

    public static string GetValidString(string prompt)
    {
      while (true)
      {
        Console.Write(prompt);
        string input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
          Console.WriteLine("Input cannot be empty. Please enter a valid string.");
          continue;
        }
        return input;
      }
    }

    public static bool ConfirmAction(string message)
    {
      Console.WriteLine(message + " (y/n): ");
      string confirm = Console.ReadLine();
      return confirm.ToLower() == "y";

    }
  }
}

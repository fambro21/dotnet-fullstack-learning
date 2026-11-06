// Import namespace - many classes and functions
using System;
using System.Globalization;
using System.Text;

// Defines our namespace is HelloWorld 
namespace HelloWorld
{
  public class Program
  {
    static void Main(string[] args)
    {
      // Prints Hello World on the console
      Console.WriteLine("Hello World!");

      // CONSOLE METHODS
      // Change the text color
      // Console.ForegroundColor = ConsoleColor.Black;

      // Change the background color
      // Console.BackgroundColor = ConsoleColor.White;

      // Set background for whole console
      // Console.Clear();

      // Outputs text without a newline
      Console.Write("What is your name? ");

      // Stores data entered by user in name
      string name = Console.ReadLine();

      // Outputs Hello + value store in name
      Console.WriteLine($"Hello {name}");




    }
  }
}
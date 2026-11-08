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

      // VARIABLES
      // Used to store different types of data

      // Boolean
      bool canIVote = true;

      // Integers
      Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
      Console.WriteLine("Smallest Integer : {0}", int.MinValue);

      // Decimals
      // It is 128-bit precise decimal values
      decimal decPiVal = 3.1415926535897932384626433832M;
      decimal decBigNum = 3.00000000000000000000000000011M;
      Console.WriteLine("DEC : PI + bigNum = {0}", decPiVal + decBigNum);
      Console.WriteLine("Biggest Decimal : {0}", decPiVal + decBigNum);

      // Doubles
      // Doubles are 64-bit float types
      Console.WriteLine("Biggest Double : {0}", Double.MaxValue);

      double dblPiVal = 3.1459265358979;
      double dblBigNum =  3.00000000000002;
      Console.WriteLine("DBL : PI + bigNum - {0}", dblPiVal + dblBigNum);

      // Floats 
      // Floats are 32-bit float types
      Console.WriteLine("Biggest Float : {0}", float.MaxValue.ToString("#"));

      // It is precise to 6 digits 
      float fltPiVal = 3.141592F;
      float fltBigNum = 3.000002F;
      Console.WriteLine("FLT : PI + bigNum = {0}", fltPiVal + fltBigNum);

      // Other Data Types
      // byte : 8-bit unsigned int 0 to 255
      // char : 16-bit unicode character
      // sbyte : 8-bit signed int 128 to 127
      // short : 16-bit signed int -32,768 to 32,767
      // uint : 32-bit unsigned int 0 to 4,294,967,295
      // ulong : 64-bit unsigned int 0 to 18,446,744,073,709,551,615
      // ushort : 16-bit unsigned int 0 to 65,535

    // DATA TYPE CONVERSION

    bool boolFromStr = bool.Parse("True");
    int intFromStr = int.Parse("100");
    double dblFromStr = double.Parse("1.234");

    // Convert double into a string 
    string strVal = dblFromStr.ToString();

    // Get the new data type 
    Console.WriteLine($"Data type : {strVal.GetType()}");

    // Cast double into integer (Explicit Conversion)
    // smaller size type to a larger size
    double dblNum = 12.345;
    Console.WriteLine($"Integer : {(int)dblNum}");

    // Formatting Output
    Console.WriteLine("Currency : {0:c}", 23.455);

    // Pad with zeroes
    Console.WriteLine("Pad with 0s : {0:d4}", 23);

    // Define decimals
    Console.WriteLine("3 Decimals : {0:f3}", 23.4555);

    // Add commas and decimals 
    Console.WriteLine("Commas : {0:n4}", 2300);









    }
  }
}
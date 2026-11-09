// Import namespace - many classes and functions
using System;
using System.Globalization;
using System.Text;

// Defines our namespace is HelloWorld 
namespace HelloWorld
{
  public class Program
  {

    static void PrintArray(int[] intArray, string mess)
    {
      foreach (int k in intArray)
      {
        Console.WriteLine("{0} : {1}", mess, k);
      }
    }

    static double DoDivision(double x, double y)
    {
      if (y == 0)
      {
        throw new System.DivideByZeroException();
      }
      return x / y;
    }

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

    // Strings
    string randString = "This is a string";

    // Number of characters in string
    Console.WriteLine("String Length : {0}", randString.Length);

    // Check if the string contains other string
    Console.WriteLine("String Contains is : {0}", randString.Contains("is"));

    // Index of string match
    Console.WriteLine("Index of is : {0}", randString.IndexOf("is"));

    // Remove number of characters starting at an index
    Console.WriteLine("Remove string : {0}", randString.Remove(10, 6));

    // Add a string with another
    Console.WriteLine("Replace String : {0}", randString.Replace("string", "sentence"));

    // Compare strings and ignore case
    // < 0 : str1 preceeds str2
    // = : Zero
    // > 0 : str2 preceeds str1
    Console.WriteLine("Compare A to B : {0}", String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));

    // Check if strings are equal
    Console.WriteLine("A = a : {0}", String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));

    // Add padding left 
    Console.WriteLine("Pad Left : {0}", randString.PadLeft(20, '.'));

    // Add padding right
    Console.WriteLine("Pad Right : {0} Stuff", randString.PadRight(20, '.'));

    // Trim whitespace
    Console.WriteLine("Trim : {0}", randString.Trim());

    // Make uppercase
    Console.WriteLine("Uppercase : {0}", randString.ToUpper());

    // Make lowercase
    Console.WriteLine("Lowercase : {0}", randString.ToLower());

    // Use Format to create strings
    string newString = String.Format("{0} saw a {1} {2} in the {3}", "Paul", "rabbit", "eating", "field");

    // Add newline with \n
    Console.Write(newString + "\n");

    // Other escape characters
    // \' \" \\ \t \a

    // Verbatim strings ignore escape characters
    Console.WriteLine(@"Exactly What I Typed\n");

    // ARRAYS
    // Arrays are just boxes inside of a bigger box
    // that contain many values of the same 
    // data type
    // Each item is assigned 
    int[] favNums = new int[3];

    // Add a value to the array
    favNums[0] = 23;

    // Retrieve a value
    Console.WriteLine("favNum 0 : {0}", favNums[0]);

    // Create an fill array
    string[] customers = { "Bob", "Sally", "Sue"};

    // You can use var to create arrays, but the
    // values must be of the same type
    var employees = new[] { "Mike", "Paul", "Rick" };

    // Create an array of base objects which is the
    // base type of all other types
    object[] randomArray = { "Paul", 45, 1.234 };

    // GetType knows its true type
    Console.WriteLine("randomArray 0 : {0}", randomArray[0].GetType());

    // Get number of items in array
    Console.WriteLine("Array Size : {0}", randomArray.Length);

    // Use for loop to cycle through the array
    for (int j = 0; j < randomArray.Length; j++)
    {
        Console.WriteLine("Array {0} : Value : {1}", j, randomArray[j]);
    }

    // Multidimensional arrays
    // When you define an array like arrName[5] you
    // are saying you want to create boxes stacked
    // vertically

    // 2 rows and 2 across
    string[,] custNames = new string[2,2] { { "Bob", "Smith" }, { "Sally", "Smith"} };

    // Get value in MD array
    Console.WriteLine("MD Value : {0}", custNames.GetValue(1, 1));

    // Cycle through the multidimensional array
    // Get length of multidimensional array column
    for (int j = 0; j < custNames.GetLength(0); j++)
      {
        for (int k = 0; k < custNames.GetLength(1); k++)
        {
          Console.Write("{0} ", custNames[j, k]);
        }
        Console.WriteLine();
      }

    // foreach can be used to cycle through an array
    int[] randNums = { 1, 4, 9, 2 };

    // You can pass an array to a function
    PrintArray(randNums, "ForEach");

    // Sort array
    Array.Sort(randNums);

    // Reverse array
    Array.Reverse(randNums);

    Console.WriteLine("1 at index : {0} ", Array.IndexOf(randNums, 1));

    // Change value at index 1 to 0
    randNums.SetValue(0, 1);

    // Copy part of an array to another
    int[] srcArray = { 1, 2, 3 };
    int[] destArray = new int[2];
    int startInd = 0;
    int length = 2;

    Array.Copy(srcArray, startInd, destArray, startInd, length);

    PrintArray(destArray, "Copy");

    // Create an array with CreateInstance
    Array anotherArray = Array.CreateInstance(typeof(int), 10);

    // Copy values in srcArray to destArray starting
    // at index 5 in destination
    srcArray.CopyTo(anotherArray, 5);

    foreach (int m in anotherArray)
    {
        Console.WriteLine("CopyTo : {0}", m);
    }

    // IF / ELSE 
    // Relational Operators : > < >= <= == !=
    // Logical Operators : && || !

    int age = 17;

    if ((age >=5) && (age <= 7))
    {
        Console.WriteLine("Go to elementary school");
    } 
    else if ((age > 7) && (age < 13))
    {
       Console.WriteLine("Go to middle school"); 
    }
    else if ((age > 13) && (age < 19))
    {
        Console.WriteLine("Go to high school");
    }
    else
    {
       Console.WriteLine("Go to college"); 
    }

    if ((age < 14) || (age > 67))
    {
        Console.WriteLine("You shouldn't work");
    }

    Console.WriteLine("! true = " + (!true));

    // Ternary Operator
    bool canDrive = age >= 16 ? true: false;

    switch (age)
      {
        case 1:
        case 2:
           Console.WriteLine("Go to Day Care");
           break;
        case 3:
        case 4:
           Console.WriteLine("Go to Preschool");
           break;
        case 5:
           Console.WriteLine("Go to Kindergarten");
           break;
        default:
          Console.WriteLine("Go to another school");

          goto OtherSchool;
      }

    OtherSchool:
      Console.WriteLine("Elementary, Middle, High School");

      string name2 = "Derek";
      string name3 = "Derek";

      if (name2.Equals(name3, StringComparison.Ordinal))
      {
        Console.WriteLine("Name are Equal");
      }

      // While loop
      int i = 1;
      while (i <= 10)
      {
        if (i % 2 == 0)
        {
          i++;

          continue;
        }

        if (i == 9) break;

        Console.WriteLine(i);
        i++;
      }

      // Do While Loop
      // use do while when you must execute the code
      // at least once

      // Generate a random number
      Random rnd = new Random();
      int secretNumber = rnd.Next(1, 11);
      int numberGuessed = 0;
      Console.WriteLine("Random Num : ", secretNumber);

      do
      {
        Console.WriteLine("Enter a number between 1 & 10 : ");
        numberGuessed = Convert.ToInt32(Console.ReadLine());
      } while (secretNumber != numberGuessed);

      Console.WriteLine("You guessed it is was {0}", secretNumber);

      // Exception Handling
      double num1 = 5;
      double num2 = 0;

      try
      {
        Console.WriteLine("5 / 0 = {0}", DoDivision(num1, num2));
      } 
      catch (DivideByZeroException ex)
      {
        Console.WriteLine("You can't Divide by Zero");
        
        // additional info 
        Console.WriteLine(ex.GetType().Name);
        Console.WriteLine(ex.Message);
      }
      catch (Exception ex)
      {
        Console.WriteLine("An error occurred");
        Console.WriteLine(ex.GetType().Name);
        Console.WriteLine(ex.Message);
      }
      finally
      {
        Console.WriteLine("Cleaning Up");
      }












    











    }
  }
}
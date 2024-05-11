namespace Exercise023
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give the first number!");

      string userInput = Console.ReadLine();

      
      double first = Convert.ToDouble(userInput);
      Console.WriteLine("Give the second number!");

      string userdouble = Console.ReadLine();

      double second = Convert.ToDouble(userdouble);

      Console.WriteLine(userInput + " + " + userdouble + " = " + (first + second));
      Console.WriteLine(userInput + " - " + userdouble + " = " + (first - second));
      Console.WriteLine(userInput + " * " + userdouble + " = " + (first * second));
      Console.WriteLine(userInput + " / " + userdouble + " = " + (first / second));
    }
  }
}

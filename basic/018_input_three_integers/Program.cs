namespace Exercise018
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give the first number!");

      string userInput = Console.ReadLine();

      int first = Convert.ToInt32(userInput);

      Console.WriteLine("Give the second number!");

      string userdouble = Console.ReadLine();

      int second = Convert.ToInt32(userdouble);

      Console.WriteLine("Give the third number!");

      string usertriple = Console.ReadLine();

      int third = Convert.ToInt32(usertriple);

      Console.WriteLine("The sum is " + (first + second + third));
    }
  }
}

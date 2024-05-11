namespace Exercise029
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

      if (first > second)
      {
        Console.WriteLine("The larger number is " + first + "!");
      }
      else if (second > first)
      {
        Console.WriteLine("The larger number is " + second + "!");
      }
      else
      {
        Console.WriteLine("They are equal!");
      }
    }
  }
}

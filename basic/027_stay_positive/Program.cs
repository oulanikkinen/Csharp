namespace Exercise027
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number:");
      string userInput = Console.ReadLine();

      int number = Convert.ToInt32(userInput);

      if (number >= 1)
      {
        Console.WriteLine("It is positive");
      }
      else
      {
        Console.WriteLine("It is not positive");
      }
    }
  }
}





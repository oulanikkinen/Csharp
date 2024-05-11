namespace Exercise036
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      while (true)
      {
        Console.WriteLine("Give a number:");
        string input = Console.ReadLine();
        int number = Convert.ToInt32(input);
        if (number > 0)
        {
          Console.WriteLine(number * number);
        }
        else if (number < 0)
        {
          Console.WriteLine("That is negative");
        }
        else
        {
          break;
        }
      }
    }
  }
}

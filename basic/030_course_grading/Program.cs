namespace Exercise030
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give your percent [0 - 100]:");
      string userInput = Console.ReadLine();

      int number = Convert.ToInt32(userInput);

      if (number > 100)
      {
        Console.WriteLine("Outstanding!");
      }
      else if (number >= 90 && number <= 100)
      {
        Console.WriteLine("Grade: 5");
      }
      else if (number >= 80 && number <= 89)
      {
        Console.WriteLine("Grade: 4");
      }
      else if (number >= 70 && number <= 79)
      {
        Console.WriteLine("Grade: 3");
      }
      else if (number >= 60 && number <= 69)
      {
        Console.WriteLine("Grade: 2");
      }
      else if (number >= 50 && number <= 59)
      {
        Console.WriteLine("Grade: 1");
      }
      else if (number >= 0 && number <= 49)
      {
        Console.WriteLine("Fail");
      }
      else
      {
        Console.WriteLine("Impossible");
      }
    }
  }
}

namespace Exercise025
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a number:");
      string userInput = Console.ReadLine();

      int number = Convert.ToInt32(userInput);

      if (number == 1984)
      {
        Console.WriteLine("Orwell");
      }
    }
  }
}

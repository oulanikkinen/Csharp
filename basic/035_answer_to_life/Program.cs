namespace Exercise035
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
        if (input == "42")
        {
          break;
        }
      }
    }
  }
}

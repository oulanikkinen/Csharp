namespace Exercise033
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      
      Console.WriteLine("Give the first string:");

      string userInput = Console.ReadLine();

      Console.WriteLine("Give the second string:");

      string userdouble = Console.ReadLine();

      if (userdouble == userInput)
      {
        Console.WriteLine("Echo!");
      }
      else
      {
        Console.WriteLine("Nope!");
      }
    }
  }
}

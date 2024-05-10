namespace Exercise016
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("How many days?");

      string userInput = Console.ReadLine();

      int intValue = Convert.ToInt32(userInput);

      Console.WriteLine(intValue * 86400);
    }
  }
}

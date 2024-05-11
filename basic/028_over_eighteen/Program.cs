namespace Exercise028
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("How old are you?");
      string userInput = Console.ReadLine();

      int number = Convert.ToInt32(userInput);

      if (number >= 18)
      {
        Console.WriteLine("You're an adult!");
      }
      else
      {
        Console.WriteLine("You're under age!");
      }
    }
  }
}

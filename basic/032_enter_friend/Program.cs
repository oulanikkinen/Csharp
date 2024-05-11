namespace Exercise032
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      string salasana = "Mellon";
      Console.WriteLine("Speak, friend, and enter!");

      string userInput = Console.ReadLine();

      if (salasana == userInput)
      {
        Console.WriteLine("Welcome, friend");
      }
      else
      {
        Console.WriteLine("They've got a cave troll!");
      }
    }
  }
}

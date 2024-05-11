namespace Exercise034
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      while (true)
      {
        Console.WriteLine("Do you want to continue?");
        string input = Console.ReadLine();
        if (input == "no")
        {
          break;
        }
      }
      
    }
  }
}


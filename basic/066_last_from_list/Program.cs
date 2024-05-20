namespace Exercise005
{
  using System;
  using System.Collections.Generic;

  public class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      string lastInput = null;

      while (true)
      {
        string input = Console.ReadLine();

        if (input == "")
        {
          break;
        }

        list.Add(input);
        lastInput = input;
      }

      if (!string.IsNullOrEmpty(lastInput))
      {
        Console.WriteLine(lastInput);
      }
      else
      {
        Console.WriteLine();
      }
    }
  }
}

namespace Exercise006
{
  using System;
  using System.Collections.Generic;

  public class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      string firstInput = null;
      string lastInput = null;

      while (true)
      {
        string input = Console.ReadLine();

        if (input == "")
        {
          break;
        }

        list.Add(input);

        if (firstInput == null)
        {
          firstInput = input;
        }

        lastInput = input;
      }

      if (firstInput != null)
      {
        Console.WriteLine(firstInput);
        Console.WriteLine(lastInput);
      }
      else
      {
        Console.WriteLine();
      }
    }
  }
}

using System;
using System.Collections.Generic;

namespace Exercise004
{
  public class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
          break;
        }
        list.Add(input);
      }

      Console.WriteLine("In total: " + list.Count);
    }
  }
}

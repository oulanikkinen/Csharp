namespace Exercise010
{
  using System;
  using System.Collections.Generic;

  public class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();

      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
        {
          break;
        }
        list.Add(input);
      }

      Console.WriteLine("Search for?");
      int etsittavaLuku = Convert.ToInt32(Console.ReadLine());

      bool loydetty = false;

      for (int i = 0; i < list.Count; i++)
      {
        if (list[i] == etsittavaLuku)
        {
          Console.WriteLine($"{etsittavaLuku} is at index {i}");
          loydetty = true;
        }
      }

      if (!loydetty)
      {
        Console.WriteLine();
      }
    }
  }

}

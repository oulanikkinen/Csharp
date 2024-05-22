namespace Exercise011
{
  using System;
  using System.Collections.Generic;

  public class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      int smallestNumber = int.MaxValue;

      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == 9999)
        {
          break;
        }
        list.Add(input);

        if (input < smallestNumber)
        {
          smallestNumber = input;
        }
      }

      List<int> indices = new List<int>();
      for (int i = 0; i < list.Count; i++)
      {
        if (list[i] == smallestNumber)
        {
          indices.Add(i);
        }
      }

      Console.WriteLine($"Smallest number: {smallestNumber}");

      if (indices.Count > 0)
      {
        //Console.WriteLine("");
        foreach (int index in indices)
        {
          Console.WriteLine("Found at index: " + index);
        }
      }
    }
  }
}

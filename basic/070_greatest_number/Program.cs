namespace Exercise009
{
  using System;
  using System.Collections.Generic;

  public class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      int maxNumber = int.MinValue;

      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
        {
          break;
        }
        list.Add(input);

        if (input > maxNumber)
        {
          maxNumber = input;
        }
      }

      if (list.Count > 0)
      {
        Console.WriteLine("The greatest number: " + maxNumber);
      }
      else
      {
        Console.WriteLine();
      }
    }
  }
}

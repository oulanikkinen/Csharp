namespace Exercise018
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT CHANGE THE FOLLOWING CODE!
      int[] array = new int[10];
      array[0] = 6;
      array[1] = 2;
      array[2] = 8;
      array[3] = 1;
      array[4] = 3;
      array[5] = 0;
      array[6] = 9;
      array[7] = 7;

      Console.WriteLine("Search for?");
      int searching = Convert.ToInt32(Console.ReadLine());

      // Implement the search functionality here
      bool found = false;
      int index = -1;

      for (int i = 0; i < array.Length; i++)
      {
        if (array[i] == searching)
        {
          found = true;
          index = i;
          break;
        }
      }

      if (found)
      {
        Console.WriteLine($"{searching} is at index {index}.");
      }
      else
      {
        Console.WriteLine($"{searching} was not found.");
      }
    }
  }
}

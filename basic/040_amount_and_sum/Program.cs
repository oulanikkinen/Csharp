namespace Exercise040
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      int countnumbers = 0;
      int sumofnumbers = 0;

      while (true)
      {
        Console.WriteLine("Give a number:");

        int number = Convert.ToInt32(Console.ReadLine());

        if (number == 0)
        {
          break;
        }

        if (number != 0)
        {
          countnumbers = countnumbers + 1;
          sumofnumbers = sumofnumbers + number; // Add the number to the total sum
        }
      }

      Console.WriteLine("Total sum of numbers: " + sumofnumbers);
      Console.WriteLine("Total amount of numbers: " + countnumbers);

    }
  }
}

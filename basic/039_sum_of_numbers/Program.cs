namespace Exercise039
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      int countnumbers = 0;


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

          countnumbers = countnumbers + number;
        }
      }

      Console.WriteLine("Total sum of numbers: " + countnumbers);

    }
  }
}



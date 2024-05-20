namespace Exercise021
{
  using System;

  public class Program
  {
    public static void Main(string[] args)
    {
      PrintRightTriangle(4);
      ChristmasTree(10);
    }

    public static void PrintSpaces(int number)
    {
      
      for (int i = 0; i < number; i++)
      {
        Console.Write(" ");
        
      }
    }

    public static void PrintStars(int number)
    {
      
      

      for (int i = 0; i < number; i++)
      {
        Console.Write("*");
      }
      Console.WriteLine();
    }

    public static void PrintRightTriangle(int size)
    {
      for (int i = 1; i <= size; i++)
      {
        PrintSpaces(size - i);
        PrintStars(i);
        //Console.WriteLine();
      }
      //Console.WriteLine();
    }

    public static void ChristmasTree(int height)
    {
      for (int i = 1; i <= height; i++)
      {
        PrintSpaces(height - i);
        PrintStars(2 * i - 1);
        //Console.WriteLine();
      }

      for (int i = 0; i < 2; i++)
      {
        PrintSpaces(height - 2);
        PrintStars(3);
        //Console.WriteLine();
      }


    }
  }
}

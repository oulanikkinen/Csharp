namespace Exercise020
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      PrintSquare(4);
      Console.WriteLine();
      PrintRectangle(17, 3);
      Console.WriteLine();
      PrintTriangle(4);
    }

    public static void PrintSquare(int size)
    {
      for (int i = 0; i < size; i++)
      {
        PrintStars(size);
      }
    }

    public static void PrintRectangle(int width, int height)
    {
      for (int i = 0; i < height; i++)
      {
        PrintStars(width);
      }
    }

    public static void PrintTriangle(int size)
    {
      for (int i = 1; i <= size; i++)
      {
        PrintStars(i);
      }
    }

    public static void PrintStars(int count)
    {
      for (int i = 0; i < count; i++)
      {
        Console.Write("*");
      }
      Console.WriteLine();
    }
  }
}

namespace Exercise003
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      int first = 1;

      first = Convert.ToInt32(Console.ReadLine());

      if (first < 0)
      {
        Console.WriteLine(first * -1);
      }
      else
      {
        Console.WriteLine(first);
      }


    }
  }
}

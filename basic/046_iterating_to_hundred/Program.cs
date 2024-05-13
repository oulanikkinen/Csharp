namespace Exercise006
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      int luku = int.Parse(Console.ReadLine());

      if (luku < 0)
      {
        Console.WriteLine();
      }
      else
      {
        for (int i = luku; i <= 100; i++)
        {
          Console.WriteLine(i);
        }
      }
    }
  }
}
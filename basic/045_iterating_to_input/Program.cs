namespace Exercise005
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
        for (int i = 0; i <= luku; i++)
        {
          Console.WriteLine(i);
        }
      }
    }
  }
}

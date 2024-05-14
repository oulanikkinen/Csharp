namespace Exercise013
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Division(5, 2);
    }

    public static void Division(int numerator, int denominator)
    {
      double result = (double)numerator / denominator;
      Console.WriteLine(result);
    }
  }
}

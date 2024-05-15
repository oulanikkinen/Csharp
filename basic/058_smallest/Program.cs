namespace Exercise018
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      int answer = Smallest(2, 7);
      Console.WriteLine("Smallest: " + answer);
    }

    public static int Smallest(int number1, int number2)
    {
      if (number1 < number2)
      {
        return number1;
      }
      else
      {
        return number2;
      }
    }
  }
}

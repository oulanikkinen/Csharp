namespace Exercise017
{
  using System;
  public class Program
  {

    public static int Sum(int number1, int number2, int number3, int number4)
    {
      int sum = number1 + number2 + number3 + number4;
      return sum;

    }
    public static void Main(string[] args)
    {
      int answer = Sum(4, 3, 6, 1);
      Console.WriteLine("Sum: " + answer);
    }
  }
}

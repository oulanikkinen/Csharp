namespace Exercise019
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      int answer = Greatest(5, 7, 3);
      Console.WriteLine("Greatest: " + answer);
    }

    public static int Greatest(int number1, int number2, int number3)
    {
      if (number1 >= number2 && number1 >= number3)
      {
        return number1;
      }
      else if (number2 >= number1 && number2 >= number3)
      {
        return number2;
      }
      else
      {
        return number3;
      }
    }
  }
}

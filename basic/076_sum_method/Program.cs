namespace Exercise015
{
  using System;
  using System.Collections.Generic;
  public class Program
  {
    public static void Main(string[] args)
    {
      List<int> numbers = new List<int>();
      numbers.Add(3);
      numbers.Add(2);
      numbers.Add(6);
      numbers.Add(-1);
      Console.WriteLine(Sum(numbers));

      numbers.Add(5);
      numbers.Add(1);
      Console.WriteLine(Sum(numbers));
    }

    public static int Sum(List<int> numbers)
    {
      int sum = 0;

      foreach (int number in numbers)
      {
        sum += number;
      }

      return sum;
    }
  }
}

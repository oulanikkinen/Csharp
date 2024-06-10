namespace Exercise019
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
     
      int[] numbers = { 5, 1, 3, 4, 2 }; 
      int sum = SumOfNumbersInArray(numbers);
      Console.WriteLine(sum);
    }

    public static int SumOfNumbersInArray(int[] numbers)
    {
      int sum = 0;
      foreach (int num in numbers)
      {
        sum += num;
      }
      return sum;
    }
  }
}

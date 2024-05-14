namespace Exercise011
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
        PrintUntilNumber(5);
    }

    public static void PrintUntilNumber(int number)
    {
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}
}


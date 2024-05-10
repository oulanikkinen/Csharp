namespace Exercise019
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give the first number!");

      string userInput = Console.ReadLine();

      int first = Convert.ToInt32(userInput);

      Console.WriteLine("Give the second number!");

      string userdouble = Console.ReadLine();

      int second = Convert.ToInt32(userdouble);

      Console.WriteLine(userInput + " + " + userdouble + " = " + (first + second));
    }
  }
}

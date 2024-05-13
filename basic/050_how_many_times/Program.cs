namespace Exercise010
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("How many times?");
        int kertaa = int.Parse(Console.ReadLine());

        for (int i = 0; i < kertaa; i++)
        {
            PrintPhrase();
        }//Write your code here
    }
    public static void PrintPhrase()
        {
            Console.WriteLine("In a hole in the ground there lived a method");
        }
    //Write your method here
  }
}

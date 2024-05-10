namespace Exercise014
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      string truth = "True";
      Console.WriteLine("Give me the truth!");
      
      bool booleanValue = System.Convert.ToBoolean(truth);
      
      Console.WriteLine(booleanValue);

    }
  }
}

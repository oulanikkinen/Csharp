namespace Exercise015
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give a string:");
      string message = Console.ReadLine();
      

      Console.WriteLine("Give an integer:");

        
      string userInput = Console.ReadLine();

        
      int intValue = Convert.ToInt32(userInput);

        
      Console.WriteLine("Give a double:");

      string userdouble = Console.ReadLine();

      double doubleValue = Convert.ToDouble(userdouble);

      //string truth = "True";
      Console.WriteLine("Give a boolean:");
      
      string truth = Console.ReadLine();

      bool booleanValue = System.Convert.ToBoolean(truth);
      
      
      
      Console.WriteLine("Your string: " + message);
      Console.WriteLine("Your integer: " + intValue);
      Console.WriteLine("Your double: " + userdouble);
      Console.WriteLine("Your boolean: " + booleanValue);
 
    }
  }
}

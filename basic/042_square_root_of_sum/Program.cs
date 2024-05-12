namespace Exercise002
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {

      // Tunnistetaan syötteet ja varataan niille muuttujat
      int first = 1;
      int second = 2;

      // Nimitetään käyttäjän syöte muuttujiin
      first = Convert.ToInt32(Console.ReadLine());
      second = Convert.ToInt32(Console.ReadLine());

      double squareRoot = Math.Sqrt(first + second);
      Console.WriteLine(squareRoot);

    }
  }
}

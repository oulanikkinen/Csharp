namespace Exercise001
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      // Tunnistetaan syötteet ja varataan niille muuttujat
      int first = 1;

      // Nimitetään käyttäjän syöte muuttujiin
      first = Convert.ToInt32(Console.ReadLine());;

      // Tunnistetaan laskutoimitus ja varataan muuttuja tulokselle
      Console.WriteLine(first * first);
    }
  }
}

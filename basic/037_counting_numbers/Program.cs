namespace Exercise037
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      // Luo muuttuja pitämään kirjaa ykkösistä. Huom nyt while-silmukan ulkopuolella!
      int countnumbers = 0;

      // Toista kunnes lopetetaan
      while (true)
      {

        // Kysy luku
        Console.WriteLine("Give a number:");
        // Lue luku ja tallenna se muuttujaan
        int number = Convert.ToInt32(Console.ReadLine());
        // Jos 0, lopeta
        if (number == 0)
        {
          break;
        }
        // Jos annettu numero on 1
        if (number != 0)
        {
          // Kasvata muuttujan arvoa 1:llä
          countnumbers = countnumbers + 1;
        }
      }
      // Tulosta montako ykköstä kerättiin
      Console.WriteLine("Total amount of numbers: " + countnumbers);

    }
  }
}

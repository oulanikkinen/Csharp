namespace Exercise007
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Where to?");
      int lopetusLuku = int.Parse(Console.ReadLine());

      Console.WriteLine("Where from?");
      int aloitusLuku = int.Parse(Console.ReadLine());

         int askel = (aloitusLuku <= lopetusLuku) ? 1 : -1;

        for (int i = aloitusLuku; i != lopetusLuku + askel; i += askel)
        {
            Console.WriteLine(i);
        }
      }
    }
  }
//if (aloitusLuku > lopetusLuku)
      //{
        //Console.WriteLine();
      //}
      //else
      //{

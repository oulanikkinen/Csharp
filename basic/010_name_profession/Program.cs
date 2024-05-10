namespace Exercise010
{
  using System;
    using System.Diagnostics;

    public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("I will tell a story, but I need some information.");
      Console.WriteLine("Give a name for main character:");

      string name = Console.ReadLine();

      Console.WriteLine("Give the character a profession:");

      string ammatti = Console.ReadLine();

      Console.Write("Here is the story:\nOnce upon a time there was a " + ammatti + " called " + name + "\nOn her way to work, " + name + " often pondered what being " + ammatti + " meant to them.\nWhen you work as a " + ammatti + " you meet interesting people.\n" + name + " enjoys their work as " + ammatti + ", The end.\n");
    }
  }
}

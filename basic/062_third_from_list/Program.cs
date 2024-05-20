namespace Exercise001
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }

                list.Add(input);
            }

            if (list.Count >= 3) 
            {
                Console.WriteLine(list[2]);
            }
        }
    }
}

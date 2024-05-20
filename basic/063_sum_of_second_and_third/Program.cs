namespace Exercise002
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 0)
                {
                    break;
                }

                list.Add(input);
            }

            if (list.Count >= 3) 
            {
                int sum = list[1] + list[2]; 
                Console.WriteLine(sum); 
            }
        }
    }
}

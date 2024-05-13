namespace Exercise008
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give numbers:");
            int summa = 0;
            int luku;
            int lukujenMaara = 0;
            int parilliset = 0;
            int parittomat = 0;

            while (true)
            {
                luku = int.Parse(Console.ReadLine());

                if (luku == -1)
                {
                    break;
                }

                summa += luku;
                lukujenMaara++;

                if (luku % 2 == 0)
                {
                    parilliset++;
                }
                else
                {
                    parittomat++;
                }
            }

            Console.WriteLine("Thx! Bye!");
            Console.WriteLine("Sum: " + summa);
            Console.WriteLine("Numbers: " + lukujenMaara);

            if (lukujenMaara > 0)
            {
                double keskiarvo = (double)summa / lukujenMaara;
                Console.WriteLine("Average: " + keskiarvo);
            }
            else
            {
                Console.WriteLine("Ei syötettyjä lukuja keskiarvon laskemiseen.");
            }

            Console.WriteLine("Even: " + parilliset);
            Console.WriteLine("Odd: " + parittomat);
        }
    }
}

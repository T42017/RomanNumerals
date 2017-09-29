using System;

namespace Roman_Numerals_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a number between 1 and 3999: ");
            int number = Int32.Parse(Console.ReadLine());
            ConvertToLetters(number);
            Console.ReadKey();
        }

        public static void ConvertToLetters(int num)
        {
            var thousands = (int)Math.Floor((decimal)(num / 1000));
            var remainder = num % 1000;
            var hundreds = (int)Math.Floor((decimal)(remainder / 100));
            remainder = remainder % 100;
            var tens = (int)Math.Floor((decimal)(remainder / 10));
            remainder = remainder % 10;
            var single = remainder;

            Console.WriteLine(thousands + "" + hundreds + "" + tens + "" + single);

            for (int i = 0; i < thousands; i++)
            {
                Console.Write("M");
            }
            if (hundreds == 5)
                Console.Write("D");
            else if (hundreds > 5)
            {
                Console.Write("D");
                for (int i = 5; i < hundreds; i++)
                {
                    Console.Write("C");
                }
            }
            else if (hundreds < 5)
            {
                for (int i = 0; i < hundreds; i++)
                {
                    Console.Write("C");
                }
            }
            if (tens == 5)
                Console.Write("L");
            else if (tens > 5)
            {
                Console.Write("L");
                for (int i = 5; i < tens; i++)
                {
                    Console.Write("X");
                }
            }
            else if (tens < 5)
            {
                for (int i = 0; i < tens; i++)
                {
                    Console.Write("X");
                }
            }
            if (single == 5)
                Console.Write("V");
            else if (single > 5)
            {
                Console.Write("V");
                for (int i = 5; i < single; i++)
                {
                    Console.Write("I");
                }
            }
            else if (single < 5)
            {
                for (int i = 0; i < single; i++)
                {
                    Console.Write("I");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralConverter
{
    class Program
    {
        public static string number;
        public static int choice;

        static void Main(string[] args)
        {
            Console.WriteLine("Roman Numeral Converter\n\nEnter a number:");

            number = Console.ReadLine();

            Console.WriteLine("Converting..");

            RomanNumeralConverter(number);

            Console.ReadLine();
        }

        public static void RomanNumeralConverter(string chosenNumber)
        {
            int tusental = 0;
            int hundratal = 0;
            int tiotal = 0;
            int ental = 0;

            string[] tusental_fix = { "", "M", "MM", "MMMM" };
            string[] hundratal_fix = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"};
            string[] tiotal_fix = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ental_fix = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            if (chosenNumber.Length >= 4)
                tusental = int.Parse(chosenNumber[chosenNumber.Length - 4].ToString());

            if (chosenNumber.Length >= 3)
                hundratal = int.Parse(chosenNumber[chosenNumber.Length - 3].ToString());

            if (chosenNumber.Length >= 2)
                tiotal = int.Parse(chosenNumber[chosenNumber.Length - 2].ToString());

            if (chosenNumber.Length >= 1)
                ental = int.Parse(chosenNumber[chosenNumber.Length - 1].ToString());

            Console.WriteLine(tusental_fix[tusental] + hundratal_fix[hundratal] + tiotal_fix[tiotal] + ental_fix[ental]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RomanNumerals.Core;

namespace RomanNumerals.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to be converted to roman numerals: ");
            try
            {
                string input = Console.ReadLine();
                string roman = HelperMethods.DecimalToRoman(input);
                Console.WriteLine($"{input} in roman numerals is {roman}");
                Main(null);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter an integer.");
                Main(null);
            }
            Console.ReadKey();
        }
    }
}

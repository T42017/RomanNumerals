using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman
{
    internal class Program
    {

        private static void Main(string[] args)
        {
            while (true)
            {
                var input = int.Parse(Console.ReadLine());

                RomanNumerals roman = new RomanNumerals();
                Console.WriteLine(roman.Convert(input));
            }
        }
    }
}

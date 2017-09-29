using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralConverter
{
    class Program
    {
        public static string _number;
        public static List<string> DecimalNumberList = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Roman Numeral Converter\n\nEnter a number:");
            _number = Console.ReadLine();
            

            Console.ReadLine();
            
            RomanNumeralConverter(_number);

            for (int i = 0; i < DecimalNumberList.Count; i++)
            {
                Console.WriteLine(DecimalNumberList[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Converting..");
        }

        public static void RomanNumeralConverter(string number)
        {
            int tusen = 0;
            int hundra = 0;
            //..


            string[] hundra_fix = {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"};

            if(number.Length >= 4)
                tusen = int.Parse(number[0].ToString());

            if(number.Length >= 3)
                hundra = int.Parse(number[number.Length - 3].ToString());

            Console.WriteLine(hundra_fix[hundra]);

            //for (int i = 1; i - numberLength <= 0; i++)
            //{
            //    char currentNumber = number[i];
            //    DecimalNumberList.Add(currentNumber.ToString());

            //    while (i - number.Length > 0)
            //    {
            //        DecimalNumberList[i] += 0;
            //    }
            //}
        }
    }
}

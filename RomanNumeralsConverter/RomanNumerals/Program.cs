using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    class Program
    {
        //I 1
        //V 5
        //X 10
        //L 50
        //C 100
        //D 500
        //M 1000
        static void Main(string[] args)
        {
            int hundra1,tiotal1,ental1;
            String tusen = "", hundra, output = "", tiotal = "", ental;
            Console.WriteLine("Write a number in Arabic number between 1 and 3999");
            String input = Console.ReadLine();

            if (input.Length == 4)
            {
                tusen = input.Substring(0, 1);
                for (int i = 0; i < int.Parse(tusen); i++)
                    output = output + "M";

                hundra = input.Substring(1, 1);
                hundra1 = int.Parse(hundra);
                if (hundra1 >= 5)
                {
                    output = output + "D";
                    hundra1=hundra1 - 5;
                }
                for (int i = 0; i < hundra1; i = i + 1)
                    output = output + "C";

                tiotal = input.Substring(2, 1);
                tiotal1 = int.Parse(tiotal);
                if (tiotal1 >= 5)
                {
                    output = output + "L";
                    tiotal1 = tiotal1 - 5;
                }
                for (int i = 0; i < tiotal1; i = i + 1)
                    output = output + "X";

                ental = input.Substring(3, 1);
                ental1 = int.Parse(ental);
                if (ental1 >= 5)
                {
                    output = output + "V";
                    ental1 = ental1 - 5;
                }
                for (int i = 0; i < ental1; i = i + 1)
                    output = output + "I";

            }
            else if(input.Length ==3)
            {
                hundra = input.Substring(0, 1);
                hundra1 = int.Parse(hundra);
                if (hundra1 >= 5)
                {
                    output = output + "D";
                    hundra1 = hundra1 - 5;
                }
                for (int i = 0; i < hundra1; i = i + 1)
                    output = output + "C";

                tiotal = input.Substring(1, 1);
                tiotal1 = int.Parse(tiotal);
                if (tiotal1 >= 5)
                {
                    output = output + "L";
                    tiotal1 = tiotal1 - 5;
                }
                for (int i = 0; i < tiotal1; i = i + 1)
                    output = output + "X";

                ental = input.Substring(2, 1);
                ental1 = int.Parse(ental);
                if (ental1 >= 5)
                {
                    output = output + "V";
                    ental1 = ental1 - 5;
                }
                for (int i = 0; i < ental1; i = i + 1)
                    output = output + "I";
            }
            else if (input.Length == 2)
            {
                tiotal = input.Substring(0, 1);
                tiotal1 = int.Parse(tiotal);
                if (tiotal1 >= 5)
                {
                    output = output + "L";
                    tiotal1 = tiotal1 - 5;
                }
                for (int i = 0; i < tiotal1; i = i + 1)
                    output = output + "X";

                ental = input.Substring(1, 1);
                ental1 = int.Parse(ental);
                if (ental1 >= 5)
                {
                    output = output + "V";
                    ental1 = ental1 - 5;
                }
                for (int i = 0; i < ental1; i = i + 1)
                    output = output + "I";
            }
            else if (input.Length == 1)
            {
                ental = input.Substring(0, 1);
                ental1 = int.Parse(ental);
                if (ental1 >= 5)
                {
                    output = output + "V";
                    ental1 = ental1 - 5;
                }
                for (int i = 0; i < ental1; i = i + 1)
                    output = output + "I";
            }
            else
                output = "Skriv ett tal mellan 1 och 3999";
           

           Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}

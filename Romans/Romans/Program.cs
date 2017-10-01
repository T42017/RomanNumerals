using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romans
{
    class Program
    {
        static void Main(string[] args)
        {
            int hundred, tens, ones;
            String tusen = "", hundra, output = "", tiotal = "", ental;
            Console.WriteLine("Enter your four digit number: ");
            String input = Console.ReadLine();

            if (input.Length == 4)
            {
                tusen = input.Substring(0, 1);

                for (int i = 0; i < int.Parse(tusen); i++)
                    output = output + "M";

                hundra = input.Substring(1, 1);
                hundred = int.Parse(hundra);

                if (hundred >= 5)
                {
                    output = output + "D";
                    hundred = hundred - 5;
                }

                for (int i = 0; i < hundred; i = i + 1)
                    output = output + "C";

                tiotal = input.Substring(2, 1);
                tens = int.Parse(tiotal);

                if (tens >= 5)
                {
                    output = output + "L";
                    tens = tens - 5;
                }

                for (int i = 0; i < tens; i = i + 1)
                    output = output + "X";

                ental = input.Substring(3, 1);
                ones = int.Parse(ental);

                if (ones >= 5)

                {
                    output = output + "V";
                    ones = ones - 5;
                }
                for (int i = 0; i < ones; i = i + 1)
                    output = output + "I";

            }
            else if (input.Length == 3)
            {
                hundra = input.Substring(0, 1);
                hundred = int.Parse(hundra);

                if (hundred >= 5)
                {
                    output = output + "D";
                    hundred = hundred - 5;
                }

                for (int i = 0; i < hundred; i = i + 1)
                    output = output + "C";

                tiotal = input.Substring(1, 1);
                tens = int.Parse(tiotal);
                if (tens >= 5)
                {
                    output = output + "L";
                    tens = tens - 5;
                }
                for (int i = 0; i < tens; i = i + 1)
                    output = output + "X";

                ental = input.Substring(2, 1);
                ones = int.Parse(ental);
                if (ones >= 5)
                {
                    output = output + "V";
                    ones = ones - 5;
                }
                for (int i = 0; i < ones; i = i + 1)
                    output = output + "I";
            }

            else if (input.Length == 2)
            {
                tiotal = input.Substring(0, 1);
                tens = int.Parse(tiotal);

                if (tens >= 5)

                {
                    output = output + "L";
                    tens = tens - 5;
                }
                for (int i = 0; i < tens; i = i + 1)
                    output = output + "X";

                ental = input.Substring(1, 1);
                ones = int.Parse(ental);

                if (ones >= 5)

                {
                    output = output + "V";
                    ones = ones - 5;
                }
                for (int i = 0; i < ones; i = i + 1)
                    output = output + "I";
            }

            else if (input.Length == 1)

            {
                ental = input.Substring(0, 1);
                ones = int.Parse(ental);
                if (ones >= 5)
                {
                    output = output + "V";
                    ones = ones - 5;
                }
                for (int i = 0; i < ones; i = i + 1)
                    output = output + "I";
            }
            else
                output = "";


            Console.WriteLine(output);
            Console.ReadLine();
        }
    }




    
}

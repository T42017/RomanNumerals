using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsConverter
{
    class Program
    {
       
        static void Main(string[] args)
        {
        String input,output;
            int number;  
            Console.WriteLine("Write your number in Arabic Numerals");

            input = Console.ReadLine();
            number = int.Parse(input);

            


            Console.WriteLine(insert +" is "+output+" in Roman Numberals");


        }
    }
}

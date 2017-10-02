using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Numeralsv1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Write a number to be converted into roman numerals:");
            int tal = int.Parse(Console.ReadLine());
            int legth;
            string[] hundraTal = {"", "C", "CC", "CCC", " CD", "D", "DC", "DCC", "DCCC", "CM"};
            string[] tioTal = {"", "X", "XX", "XXX", " XL", "L", "LX", "LXX", "LXXX", "XC"};
            String[] enTal = {"", "I", "II", "III", " IV", "V", "VI", "VII", "VIII", "IX"};
            while (tal >= 1000)
            {
                Console.Write("M");
                tal -= 1000;
            }
            legth = tal / 100;
            Console.Write(hundraTal[legth]);
            tal -= legth *100;
            legth = tal / 10;
            Console.Write(tioTal[legth]);
            tal -= legth * 10;
            legth = tal;
            Console.Write(enTal[legth]);


            Console.ReadLine();
        }
    }
}

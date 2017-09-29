using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            string RomanNum = "";
            string prevRomanNum = "";
            string YN = "Y";

            Console.WriteLine("write a number here to get it converted to roman numerals:");

            while (true)
            {
                int Number = Convert.ToInt32(Console.ReadLine());



                while (Number >= 1000)
                {
                    Number -= 1000;
                    RomanNum = RomanNum + "M";
                }

                if (Number >= 900)
                {
                    Number -= 900;
                    RomanNum = RomanNum + "CM";
                }
                else if (Number >= 800)
                {
                    Number -= 800;
                    RomanNum = RomanNum + "DCCC";
                }
                else if (Number >= 700)
                {
                    Number -= 700;
                    RomanNum = RomanNum + "DCC";
                }
                else if (Number >= 600)
                {
                    Number -= 600;
                    RomanNum = RomanNum + "DC";
                }
                else if (Number >= 500)
                {
                    Number -= 500;
                    RomanNum = RomanNum + "D";
                }
                else if (Number >= 400)
                {
                    Number -= 400;
                    RomanNum = RomanNum + "CD";
                }
                else if (Number >= 300)
                {
                    Number -= 300;
                    RomanNum = RomanNum + "CCC";
                }
                else if (Number >= 200)
                {
                    Number -= 200;
                    RomanNum = RomanNum + "CC";
                }
                else if (Number >= 100)
                {
                    Number -= 100;
                    RomanNum = RomanNum + "C";
                }

                if (Number>=90)
                {
                    Number -= 90;
                    RomanNum = RomanNum + "XC";
                }
                else if (Number >= 80)
                {
                    Number -= 80;
                    RomanNum = RomanNum + "LXXX";
                }
                else if (Number >= 70)
                {
                    Number -= 70;
                    RomanNum = RomanNum + "LXX";
                }
                else if (Number >= 60)
                {
                    Number -= 60;
                    RomanNum = RomanNum + "LX";
                }
                else if (Number >= 50)
                {
                    Number -= 50;
                    RomanNum = RomanNum + "L";
                }
                else if (Number >= 40)
                {
                    Number -= 40;
                    RomanNum = RomanNum + "XL";
                }
                else if (Number >= 30)
                {
                    Number -= 30;
                    RomanNum = RomanNum + "XXX";
                }
                else if (Number >= 20)
                {
                    Number -= 20;
                    RomanNum = RomanNum + "XX";
                }
                else if (Number >= 10)
                {
                    Number -= 10;
                    RomanNum = RomanNum + "X";
                }

                if (Number == 9)
                {
                    Number -= 9;
                    RomanNum = RomanNum + "IX";
                }
                else if (Number == 8)
                {
                    Number -= 8;
                    RomanNum = RomanNum + "VIII";
                }
                else if (Number == 7)
                {
                    Number -= 7;
                    RomanNum = RomanNum + "VII";
                }
                else if (Number == 6)
                {
                    Number -= 6;
                    RomanNum = RomanNum + "VI";
                }
                else if (Number == 5)
                {
                    Number -= 5;
                    RomanNum = RomanNum + "V";
                }
                else if (Number == 4)
                {
                    Number -= 4;
                    RomanNum = RomanNum + "IV";
                }
                else if (Number == 3)
                {
                    Number -= 3;
                    RomanNum = RomanNum + "III";
                }
                else if (Number == 2)
                {
                    Number -= 2;
                    RomanNum = RomanNum + "II";
                }
                else if (Number == 1)
                {
                    Number -= 1;
                    RomanNum = RomanNum + "I";
                }

                Console.WriteLine("Your number in roman letter is " + RomanNum);
                prevRomanNum = RomanNum;
                RomanNum = "";
                Console.WriteLine("write another number if you want to get it converted:");
            }

        }
    }
}

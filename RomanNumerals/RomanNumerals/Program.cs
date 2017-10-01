using System;

namespace RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                Console.Write("Enter a whole number between 1 - 3999:");
                string input = Console.ReadLine();

                Console.Write("Input in Roman numerals:");
                ConvertToRomanNumb();
                
                Console.ReadLine();
                
                void ConvertToRomanNumb()
                {
                    int counter = int.Parse(input);

                    string output = "";

                    //if (counter >= 3000)
                    //{
                    //    counter -= 3000;
                    //    output = output + "MMM";
                    //}
                        if (counter >= 2000)
                        {
                            counter -= 2000;
                            output = output + "MM";
                        }

                        if (counter >= 1000)
                        {
                            counter -= 1000;
                            output = output + "M";
                        }
                        if (counter >= 900)
                        {
                            counter -= 900;
                            output = output + "CM" ;
                        }
                        if (counter >= 800)
                        {
                            counter -= 800;
                            output = output + "DCCC";
                        }
                        if (counter >= 700)
                        {
                            counter -= 700;
                            output = output + "DCC";
                        }
                        if (counter >= 600)
                        {
                            counter -= 600;
                            output = output + "DC";
                        }
                        if (counter >= 500)
                        {
                            counter -= 500;
                            output = output + "D";
                        }
                        if (counter >= 400)
                        {
                            counter -= 400;
                            output = output + "CD";
                        }
                        if (counter >= 300)
                        {
                            counter -= 300;
                            output = output + "CCC";
                        }
                        if (counter >= 200)
                        {
                            counter -= 200;
                            output = output + "CC";
                        }
                        if (counter >= 100)
                        {
                            counter -= 100;
                            output = output + "C";
                        }
                        if (counter >= 90)
                        {
                            counter -= 90;
                            output = output + "XC";
                        }
                        if (counter >= 80)
                        {
                            counter -= 80;
                            output = output + "LXXX";
                        }
                        if (counter >= 70)
                        {
                            counter -= 70;
                            output = output + "LXX";
                        }
                        if (counter >= 60)
                        {
                            counter -= 60;
                            output = output + "LX";
                        }
                        if (counter >= 50)
                        {
                            counter -= 50;
                            output = output + "L";
                        }
                        if (counter >= 40)
                        {
                            counter -= 40;
                            output = output + "XL";
                        }
                        if (counter >= 30)
                        {
                            counter -= 30;
                            output = output + "XXX";
                        }
                        if (counter >= 20)
                        {
                            counter -= 20;
                            output = output + "XX";
                        }
                        if (counter >= 10)
                        {
                            counter -= 10;
                            output = output + "X";
                        }
                        if (counter >= 9)
                        {
                            counter -= 9;
                            output = output + "IX";
                        }
                        if (counter >= 8)
                        {
                            counter -= 8;
                            output = output + "VIII";
                        }
                        if (counter >= 7)
                        {
                            counter -= 7;
                            output = output + "VII";
                        }
                        if (counter >= 6)
                        {
                            counter -= 6;
                            output = output + "VI";
                        }
                        if (counter >= 5)
                        {
                            counter -= 5;
                            output = output + "V";
                        }
                        if (counter >= 4)
                        {
                            counter -= 4;
                            output = output + "IV";
                        }
                        if (counter >= 3)
                        {
                            counter -= 3;
                            output = output + "III";
                        }
                        if (counter >= 2)
                        {
                            counter -= 2;
                            output = output + "II";
                        }
                        if (counter >= 1)
                        {
                            counter -= 1;
                            output = output + "I";
                        }
                        Console.Write(output); 
                }   
            }
        }
    }
        
}
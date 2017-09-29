using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roman_numerals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (tbxNumbers.Text.All(c => char.IsNumber(c)))
            {
                var number = int.Parse(tbxNumbers.Text);
                ConvertNumberToRoman(number);
                tbxRoman.Text = ConvertNumberToRoman(number);
            }
            else
            {
                MessageBox.Show("Insert a NUMBER between 1-3999, which is not a deciaml!");
            }
        }

        public string ConvertNumberToRoman(int number)
        {
            if (number >= 4000)
                return "Insert a number between 1-3999";

            if (number < 0)
                return "Insert a number between 1-3999";

            if (number >= 1000)
                return "M" + ConvertNumberToRoman(number - 1000);

            if (number >= 900)
                return "CM" + ConvertNumberToRoman(number - 900);

            if (number >= 800)
                return "DCCC" + ConvertNumberToRoman(number - 800);

            if (number >= 700)
                return "DCC" + ConvertNumberToRoman(number - 700);

            if (number >= 600)
                return "DC" + ConvertNumberToRoman(number - 600);

            if (number >= 500)
                return "D" + ConvertNumberToRoman(number - 500);

            if (number >= 400)
                return "CD" + ConvertNumberToRoman(number - 400);

            if (number >= 300)
                return "CCC" + ConvertNumberToRoman(number - 300);

            if (number >= 200)
                return "CC" + ConvertNumberToRoman(number - 200);

            if (number >= 100)
                return "C" + ConvertNumberToRoman(number - 100);

            if (number >= 90)
                return "XC" + ConvertNumberToRoman(number - 90);

            if (number >= 80)
                return "LXXX" + ConvertNumberToRoman(number - 80);

            if (number >= 70)
                return "LXX" + ConvertNumberToRoman(number - 70);

            if (number >= 60)
                return "LX" + ConvertNumberToRoman(number - 60);

            if (number >= 50)
                return "L" + ConvertNumberToRoman(number - 50);

            if (number >= 40)
                return "XL" + ConvertNumberToRoman(number - 40);

            if (number >= 30)
                return "XXX" + ConvertNumberToRoman(number - 30);

            if (number >= 20)
                return "XX" + ConvertNumberToRoman(number - 20);

            if (number >= 10)
                return "X" + ConvertNumberToRoman(number - 10);

            if (number >= 9)
                return "IX" + ConvertNumberToRoman(number - 9);

            if (number >= 8)
                return "VIII" + ConvertNumberToRoman(number - 8);

            if (number >= 7)
                return "VII" + ConvertNumberToRoman(number - 7);

            if (number >= 6)
                return "VI" + ConvertNumberToRoman(number - 6);

            if (number >= 5)
                return "V" + ConvertNumberToRoman(number - 5);

            if (number >= 4)
                return "IV" + ConvertNumberToRoman(number - 4);

            if (number >= 3)
                return "III" + ConvertNumberToRoman(number - 3);

            if (number >= 2)
                return "II" + ConvertNumberToRoman(number - 2);

            if (number >= 1)
                return "I" + ConvertNumberToRoman(number - 1);

            return number == 0 ? "" : number.ToString();
        }
    }
}

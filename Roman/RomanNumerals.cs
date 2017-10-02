using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman
{
    public class RomanNumerals
    {
        private readonly List<RomanCharacter> _romanNumerals = new List<RomanCharacter>();

        public RomanNumerals()
        {
            _romanNumerals.Add(new RomanCharacter(1, "I"));
            _romanNumerals.Add(new RomanCharacter(5, "V"));
            _romanNumerals.Add(new RomanCharacter(10, "X"));
            _romanNumerals.Add(new RomanCharacter(50, "L"));
            _romanNumerals.Add(new RomanCharacter(100, "C"));
            _romanNumerals.Add(new RomanCharacter(500, "D"));
            _romanNumerals.Add(new RomanCharacter(1000, "M"));
        }

        public string Convert(int number)
        {
            string numberAsString = number.ToString();
            StringBuilder romanBuilder = new StringBuilder();
            StringBuilder tempString = new StringBuilder();

            var zeros = 0;
            for (int i = 0; i < numberAsString.Length; i++)
            {
                var singelDigit = int.Parse(numberAsString.Substring(numberAsString.Length - 1 - i, 1));
                if (singelDigit == 0)
                {
                    zeros++;
                    continue;
                }

                tempString.Append(GetRomanNumeralsFromSingelDigit(singelDigit, i));
                tempString.Append(romanBuilder.ToString());
                romanBuilder.Clear();
                romanBuilder.Append(tempString);
                tempString.Clear();
            }

            return romanBuilder.ToString();
        }

        /// <summary>
        /// converts 1-9 to a roman numerals
        /// </summary>
        /// <returns></returns>
        public string GetRomanNumeralsFromSingelDigit(int number, int position)
        {
            StringBuilder romanNumerals = new StringBuilder();

            position = position * 2;

            switch (number)
            {
                case 1:
                    romanNumerals.Append(_romanNumerals[position].Character);
                    break;
                case 2:
                    romanNumerals.Append(_romanNumerals[position].Character + _romanNumerals[position].Character);
                    break;
                case 3:
                    romanNumerals.Append(_romanNumerals[position].Character + _romanNumerals[position].Character + _romanNumerals[position].Character);
                    break;
                case 4:
                    romanNumerals.Append(_romanNumerals[position].Character + _romanNumerals[position + 1].Character);
                    break;
                case 5:
                    romanNumerals.Append(_romanNumerals[position + 1].Character);
                    break;
                case 6:
                    romanNumerals.Append(_romanNumerals[position + 1].Character + _romanNumerals[position].Character);
                    break;
                case 7:
                    romanNumerals.Append(_romanNumerals[position + 1].Character + _romanNumerals[position].Character + _romanNumerals[position].Character);
                    break;
                case 8:
                    romanNumerals.Append(_romanNumerals[position + 1].Character + _romanNumerals[position].Character + _romanNumerals[position].Character + _romanNumerals[position].Character);
                    break;
                case 9:
                    romanNumerals.Append(_romanNumerals[position].Character + _romanNumerals[position + 2].Character);
                    break;
            }

            return romanNumerals.ToString();
        }

    }
}

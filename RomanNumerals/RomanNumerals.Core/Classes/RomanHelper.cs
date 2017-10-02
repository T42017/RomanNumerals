using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumerals.Core
{
    public static class RomanHelper
    {
        private static readonly Dictionary<int, string> _decimalToRomanTable = new Dictionary<int, string>()
        {
            { 1000, "M"    },
            { 900,  "CM"   },
            { 800,  "DCCC" },
            { 700,  "DCC"  },
            { 600,  "DC"   },
            { 500,  "D"    },
            { 400,  "CD"   },
            { 300,  "CCC"  },
            { 200,  "CC"   },
            { 100,  "C"    },
            { 90,   "XC"   },
            { 80,   "LXXX" },
            { 70,   "LXX"  },
            { 60,   "LX"   },
            { 50,   "L"    },
            { 40,   "XL"   },
            { 30,   "XXX"  },
            { 20,   "XX"   },
            { 10,   "X"    },
            { 9,    "IX"   },
            { 8,    "VIII" },
            { 7,    "VII"  },
            { 6,    "VI"   },
            { 5,    "V"    },
            { 4,    "IV"   },
            { 3,    "III"  },
            { 2,    "II"   },
            { 1,    "I"    },
        };

        public static string DecimalToRoman(string input)
        {
            if (input.Any(c => !char.IsNumber(c)) || string.IsNullOrEmpty(input))
                throw new ArgumentException("Input was not a number.");

            int decimalInput = int.Parse(input);

            if (decimalInput <= 0)
                throw new ArgumentException("Number must be greater than zero.");

            var romanBuilder = new StringBuilder();
            foreach (var item in _decimalToRomanTable)
            {
                while (decimalInput >= item.Key)
                {
                    romanBuilder.Append(item.Value);
                    decimalInput -= item.Key;
                }
            }
            return romanBuilder.ToString();
        }
    }
}
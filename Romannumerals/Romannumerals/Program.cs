using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Romannumerals
{
    public static class Rom
    {
        public static void Main()
        {
            while (true)
            {
                Console.Write("Skriv in det talet du vill konvertera tll romerska siffror: ");
                Console.WriteLine();
                int tal = int.Parse(Console.ReadLine());

                Console.WriteLine(ConvertNumToRoman(tal));
            }

            Console.ReadKey();
        }

        public static string ConvertNumToRoman(int tal)
        {
            if (tal >= 1000) return "M" + ConvertNumToRoman(tal - 1000);

            if (tal >= 900) return "CM" + ConvertNumToRoman(tal - 900);

            if (tal >= 500) return "D" + ConvertNumToRoman(tal - 500);

            if (tal >= 400) return "CD" + ConvertNumToRoman(tal - 400);

            if (tal >= 100) return "C" + ConvertNumToRoman(tal - 100);

            if (tal >= 90) return "XC" + ConvertNumToRoman(tal - 90);

            if (tal >= 50) return "L" + ConvertNumToRoman(tal - 50);

            if (tal >= 40) return "XL" + ConvertNumToRoman(tal - 40);

            if (tal >= 10) return "X" + ConvertNumToRoman(tal - 10);

            if (tal >= 9) return "IX" + ConvertNumToRoman(tal - 9);

            if (tal >= 5) return "V" + ConvertNumToRoman(tal - 5);

            if (tal >= 4) return "IV" + ConvertNumToRoman(tal - 4);

            if (tal >= 1) return "I" + ConvertNumToRoman(tal - 1);
            
            return String.Empty;
        }

        //static Rom()
        //{
        //    LexikonRomerskaSiffror = new Dictionary<char, int>
        //    {
        //        {'M', 1000},
        //        {'D', 500},
        //        {'C', 100},
        //        {'L', 50},
        //        {'X', 10},
        //        {'V', 5},
        //        {'I', 1}
        //    };

        //    LexikonNummerTillRomerska = new Dictionary<int, string>
        //    {
        //        {1, "I"},
        //        {5, "V"},
        //        {10, "X"},
        //        {50, "L"},
        //        {100, "C"},
        //        {500, "D"},
        //        {1000, "M"}
        //    };
        //}

        //public static string Till(int tal)
        //{
        //    var romersk = new StringBuilder();

        //    foreach (var sak in LexikonNummerTillRomerska)
        //    {
        //        while (tal >= sak.Key)
        //        {
        //            romersk.Append(sak.Value);
        //            tal -= sak.Key;
        //        }
        //    }
        //    return romersk.ToString();
        //}

        //public static int TagenAv(string romersk)
        //{
        //    int totalt = 0;
        //    int nutid, tidigare = 0;
        //    char nutidRomersk, tidigareRomersk = '\0';

        //    for (int i = 0; i < romersk.Length; i++)
        //    {
        //        nutidRomersk = romersk[i];
        //        tidigare = tidigareRomersk != '\0' ? LexikonRomerskaSiffror[tidigareRomersk] : '\0';
        //        nutid = LexikonRomerskaSiffror[nutidRomersk];

        //        if (tidigare != 0 && nutid > tidigare)
        //        {
        //            totalt = totalt - (2 * tidigare) + nutid;
        //        }
        //        else
        //        {
        //            totalt += nutid;
        //        }
        //        tidigareRomersk = nutidRomersk;
        //    }
        //    return totalt;
    }
    
}
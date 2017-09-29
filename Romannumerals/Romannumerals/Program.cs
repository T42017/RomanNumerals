using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Romannumerals
{
    public static class Rom
    {
        public static readonly Dictionary<char, int> LexikonRomerskaSiffror;
        public static readonly Dictionary<int, string> LexikonNummerTillRomerska;

        public static void Main()
        {
            Console.WriteLine("Skriv in det talet du vill konvertera tll romerska siffror");
        }

        static Rom()
        {
            LexikonRomerskaSiffror = new Dictionary<char, int>
            {
                {'M', 1000},
                {'D', 500},
                {'C', 100},
                {'L', 50},
                {'X', 10},
                {'V', 5},
                {'I', 1}
            };

            LexikonNummerTillRomerska = new Dictionary<int, string>
            {
                {1, "I"},
                {5, "V"},
                {10, "X"},
                {50, "L"},
                {100, "C"},
                {500, "D"},
                {1000, "M"}
            };
        }

        public static string Till(int tal)
        {
            var romersk = new StringBuilder();

            foreach (var sak in LexikonNummerTillRomerska)
            {
                while (tal >= sak.Key)
                {
                    romersk.Append(sak.Value);
                    tal -= sak.Key;
                }
            }
            return romersk.ToString();
        }

        public static int TagenAv(string romersk)
        {
            int totalt = 0;
            int nutid, tidigare =0;
            char nutidRomersk, tidigareRomersk = '\0';

            for (int i = 0; i < romersk.Length; i++)
            {
                nutidRomersk = romersk[i];
                tidigare = tidigareRomersk != '\0' ? LexikonRomerskaSiffror[tidigareRomersk] : '\0';
                nutid = LexikonRomerskaSiffror[nutidRomersk];

                if (tidigare != 0 && nutid > tidigare)
                {
                    totalt = totalt - (2 * tidigare) + nutid;
                }
                else
                {
                    totalt += nutid;
                }
                tidigareRomersk = nutidRomersk;
            }
            return totalt;
        }
        
        
        //public static string ConvertNumToRoman(int tal)
        //{
        //    if (tal >=1000) return "M" + ConvertNumToRoman(tal - 1000);
        //    if (tal >= 500) return "D" + ConvertNumToRoman(tal - 500);
        //    if (tal >= 100) return "C" + ConvertNumToRoman(tal - 100);
        //    if (tal >= 50) return "L" + ConvertNumToRoman(tal - 50);
        //    if (tal >= 10) return "X" + ConvertNumToRoman(tal - 10);
        //    if (tal >= 5) return "V" + ConvertNumToRoman(tal - 5);
        //    if (tal >= 1) return "I" + ConvertNumToRoman(tal - 1);
        //}
    }
}
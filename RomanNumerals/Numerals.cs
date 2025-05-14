using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RomanNumerals
{
    public static class Numerals
    {
        static void SplitNumber(int number, ref int[] places)
        {
            // Split number into thousands, hundreds, tens, and ones

            int curr = number;

            places[0] = curr / 1000;
            curr -= places[0] * 1000;

            places[1] = curr / 100;
            curr -= places[1] * 100;

            places[2] = curr / 10;
            curr -= places[2] * 10;

            places[3] = curr;
            curr -= places[3];

            WriteLine("\nThousands: " + places[0]);
            WriteLine("Hundreds: " + places[1]);
            WriteLine("Tens: " + places[2]);
            WriteLine("Ones: " + places[3]);
        }

        /*
        static void SplitNumeral(string numeral, ref string[] groups)
        {
            // Split numeral in similar way to SplitNumber()

            char ch = numeral[0];
            int g = 0;
            bool[] slots = new bool[4];

            // Loop through numeral, find duplicates, and specify places
            for (int i = 0; i < numeral.Length; i++)
            {
                if (numeral[i] == ch)
                {
                    groups[g] += ch;
                }
                else
                {
                    slots[g] = true;

                    // TODO: Check if a Roman digit has an association with a higher digit in the same place
                    if (!slots[g])
                    {
                        ch = numeral[i];
                    }

                    g++;
                }
            }
        }
        */

        public static string ArabicToRoman(int number)
        {
            int[] places = new int[4];
            SplitNumber(number, ref places);

            string numeral = "";

            // Append numeral
            int p = 0;
            while (p < 4)
            {
                // Initialize digit and digit in place
                int dig = places[p];
                int extDig = (int)Math.Pow(10, 3 - p);

                // Check digits
                if (dig == 9)
                {
                    numeral += (Digits)extDig;
                    numeral += (Digits)(extDig * 10);
                }
                else if (dig == 4)
                {
                    numeral += (Digits)extDig;
                    numeral += (Digits)(extDig * 5);
                }
                else
                {
                    if (dig >= 5)
                    {
                        dig -= 5;
                        numeral += (Digits)(extDig * 5);
                    }

                    for (int i = 0; i < dig; i++)
                    {
                        numeral += (Digits)extDig;
                    }
                }

                p++;
            }

            return numeral;
        }

        public static string[] RomanToArabic(string numeral)
        {
            string[] groups = new string[4];
            // SplitNumeral(numeral, ref groups);

            return groups;
        }
    }
}

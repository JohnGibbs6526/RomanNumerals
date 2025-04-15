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
        static void SplitNumber(int number, out int thousands, out int hundreds, out int tens, out int ones)
        {
            // Split number into thousands, hundreds, tens, and ones

            int curr = number;

            thousands = curr / 1000;
            curr -= thousands * 1000;

            hundreds = curr / 100;
            curr -= hundreds * 100;

            tens = curr / 10;
            curr -= tens * 10;

            ones = curr;
            curr -= ones;

            WriteLine("\nThousands: " + thousands);
            WriteLine("Hundreds: " + hundreds);
            WriteLine("Tens: " + tens);
            WriteLine("Ones: " + ones);
        }
        public static string ArabicToRoman(int number)
        {
            int thousands, hundreds, tens, ones;
            SplitNumber(number, out thousands, out hundreds, out tens, out ones);

            int curr;
            string numeral = "";

            // Append numeral

            // Thousands

            for (int i = 0; i < thousands; i++)
            {
                numeral += "M";
            }

            // Hundreds

            curr = hundreds;
            if (curr == 9)
            {
                numeral += "CM";
            }
            else if (curr == 4)
            {
                numeral += "CD";
            }
            else
            {
                if (curr >= 5)
                {
                    curr -= 5;
                    numeral += "D";
                }

                for (int i = 0; i < curr; i++)
                {
                    numeral += "C";
                }
            }

            // Tens

            curr = tens;
            if (curr == 9)
            {
                numeral += "XC";
            }
            else if (curr == 4)
            {
                numeral += "XL";
            }
            else
            {
                if (curr >= 5)
                {
                    curr -= 5;
                    numeral += "L";
                }

                for (int i = 0; i < curr; i++)
                {
                    numeral += "X";
                }
            }

            // Ones

            curr = ones;
            if (curr == 9)
            {
                numeral += "IX";
            }
            else if (curr == 4)
            {
                numeral += "IV";
            }
            else
            {
                if (curr >= 5)
                {
                    curr -= 5;
                    numeral += "V";
                }

                for (int i = 0; i < curr; i++)
                {
                    numeral += "I";
                }
            }

            return numeral;
        }
    }
}

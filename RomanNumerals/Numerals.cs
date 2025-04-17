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
        public static string ArabicToRoman(int number)
        {
            int[] places = new int[4];
            SplitNumber(number, ref places);

            // int curr;
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

            /*
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
                    numeral += Digits.D;
                }

                for (int i = 0; i < curr; i++)
                {
                    numeral += Digits.C;
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
                    numeral += Digits.L;
                }

                for (int i = 0; i < curr; i++)
                {
                    numeral += Digits.X;
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
                    numeral += Digits.V;
                }

                for (int i = 0; i < curr; i++)
                {
                    numeral += Digits.I;
                }
            }
            */

            return numeral;
        }
    }
}

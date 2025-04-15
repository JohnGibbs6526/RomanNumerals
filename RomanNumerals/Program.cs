using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RomanNumerals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Roman Numeral Conversion\n");

            char again;

            do
            {
                try
                {
                    // Input option
                    WriteLine("\nDo you want to convert Arabic numerals to Roman numerals (a)");
                    Write("or Roman numerals to Arabic numerals (r)? ");
                    char option = char.Parse(ReadLine());

                    if (option == 'a')
                    {
                        // Input Arabic numeral
                        Write("Enter an integer (1 to 3999): ");
                        int number = int.Parse(ReadLine());

                        if (number < 1 || number > 3999)
                        {
                            throw new Exception("Number is not between 1 and 3999. Please try again.");
                        }

                        // Compute Roman numeral
                        string numeral = Numerals.ArabicToRoman(number);
                        WriteLine("\nNumeral: " + numeral);
                    }
                    else if (option == 'r')
                    {
                        WriteLine("Coming soon...");
                    }
                    else
                    {
                        throw new Exception("Not a valid option.");
                    }

                    Write("Do you want to try again? (y/n) ");
                    again = char.Parse(ReadLine());
                }
                catch (Exception ex)
                {
                    WriteLine("  " + ex.Message);
                    again = 'y';
                }
            }
            while (again == 'y');

            Write("\nPress any key to continue... ");
            ReadKey();
        }
    }
}

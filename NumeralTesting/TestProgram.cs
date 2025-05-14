using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RomanNumerals;

namespace NumeralTesting
{
    [TestClass]
    public class TestProgram
    {
        [DataRow(9, "IX")]
        [DataRow(56, "LVI")]
        [DataRow(999, "CMXCIX")]
        [DataRow(555, "DLV")]
        [DataRow(87, "LXXXVII")]

        [TestMethod]
        public void TestArabicToRoman(int number, string numeral)
        {
            Assert.AreEqual(numeral, Numerals.ArabicToRoman(number));
        }
    }
}

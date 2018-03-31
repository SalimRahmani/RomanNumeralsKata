using NUnit.Framework;
using RomanNumeralsKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKataTest
{
    public class RomanNumeralsTest
    {
        private RomanNumeralsProcessor _romanNumeralsProcessor = new RomanNumeralsProcessor();

        [TestCase(1, "I")]
        public void should_return_I_when_input_is_1(int input, string expected)
        {
            string result = _romanNumeralsProcessor.ToRomanNumerals(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(2, "II")]
        [TestCase(3, "III")]
        public void should_return_equal_number_of_strokes_when_input_is_lower_than_4(int input, string expected)
        {
            string result = _romanNumeralsProcessor.ToRomanNumerals(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(4, "IV")]
        public void should_return_IV_when_number_is_4(int input, string expected)
        {
            string result = _romanNumeralsProcessor.ToRomanNumerals(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(5, "V")]
        public void should_return_V_when_number_is_5(int input, string expected)
        {
            string result = _romanNumeralsProcessor.ToRomanNumerals(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(6, "VI")]
        public void should_return_VI_when_number_is_6(int input, string expected)
        {
            string result = _romanNumeralsProcessor.ToRomanNumerals(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(7, "VII")]
        public void should_return_VII_when_number_is_7(int input, string expected)
        {
            string result = _romanNumeralsProcessor.ToRomanNumerals(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(8, "VIII")]
        public void should_return_VIII_when_number_is_8(int input, string expected)
        {
            string result = _romanNumeralsProcessor.ToRomanNumerals(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(9, "IX")]
        public void should_return_IX_when_number_is_9(int input, string expected)
        {
            string result = _romanNumeralsProcessor.ToRomanNumerals(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(19, "XIX")]
        public void should_return_XIX_when_number_is_19(int input, string expected)
        {
            string result = _romanNumeralsProcessor.ToRomanNumerals(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(31, "XXXI")]
        public void should_return_XXXI_when_number_is_31(int input, string expected)
        {
            string result = _romanNumeralsProcessor.ToRomanNumerals(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(40, "XL")]
        public void should_return_XL_when_number_is_40(int input, string expected)
        {
            string result = _romanNumeralsProcessor.ToRomanNumerals(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(48, "XLVIII")]
        public void should_return_XLVIII_when_number_is_48(int input, string expected)
        {
            string result = _romanNumeralsProcessor.ToRomanNumerals(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(50, "L")]
        public void should_return_L_when_number_is_50(int input, string expected)
        {
            string result = _romanNumeralsProcessor.ToRomanNumerals(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(56, "LVI")]
        public void should_return_LVI_when_number_is_56(int input, string expected)
        {
            string result = _romanNumeralsProcessor.ToRomanNumerals(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(80, "LXXX")]
        public void should_return_LXXX_when_number_is_80(int input, string expected)
        {
            string result = _romanNumeralsProcessor.ToRomanNumerals(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(369, "CCCLXIX")]
        public void should_return_CCCLXIX_when_number_is_369(int input, string expected)
        {
            string result = _romanNumeralsProcessor.ToRomanNumerals(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(448, "CDXLVIII")]
        public void should_return_CDXLVIII_when_number_is_448(int input, string expected)
        {
            string result = _romanNumeralsProcessor.ToRomanNumerals(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(2751, "MMDCCLI")]
        public void should_return_MMDCCLI_when_number_is_2751(int input, string expected)
        {
            string result = _romanNumeralsProcessor.ToRomanNumerals(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(3200)]
        public void should_throw_exception_when_number_is_larger_than_3000(int input)
        {
            Assert.Throws<ArgumentException>(() => _romanNumeralsProcessor.ToRomanNumerals(input));
        }

        [TestCase("I", 1)]
        public void should_return_1_when_roman_number_is_I(string input, int expected)
        {
            int result = _romanNumeralsProcessor.ToArabicNumbers(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("V", 5)]
        public void should_return_5_when_roman_number_is_V(string input, int expected)
        {
            int result = _romanNumeralsProcessor.ToArabicNumbers(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("X", 10)]
        public void should_return_10_when_roman_number_is_X(string input, int expected)
        {
            int result = _romanNumeralsProcessor.ToArabicNumbers(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("II", 2)]
        public void should_return_2_when_roman_number_is_II(string input, int expected)
        {
            int result = _romanNumeralsProcessor.ToArabicNumbers(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("IV", 4)]
        public void should_return_4_when_roman_number_is_IV(string input, int expected)
        {
            int result = _romanNumeralsProcessor.ToArabicNumbers(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("CCCLXIX", 369)]
        public void should_return_369_when_roman_number_is_CCCLXIX(string input, int expected)
        {
            int result = _romanNumeralsProcessor.ToArabicNumbers(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("CDXLVIII", 448)]
        public void should_return_448_when_roman_number_is_CDXLVIII(string input, int expected)
        {
            int result = _romanNumeralsProcessor.ToArabicNumbers(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("MMDCCLI", 2751)]
        public void should_return_2751_when_roman_number_is_MMDCCLI(string input, int expected)
        {
            int result = _romanNumeralsProcessor.ToArabicNumbers(input);
            Assert.That(result, Is.EqualTo(expected));
        }



    }
}

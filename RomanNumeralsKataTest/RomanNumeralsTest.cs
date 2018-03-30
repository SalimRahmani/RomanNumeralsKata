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
            string result = _romanNumeralsProcessor.Convert(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(2, "II")]
        [TestCase(3, "III")]
        public void should_return_equal_number_of_strokes_when_input_is_lower_than_4(int input, string expected)
        {
            string result = _romanNumeralsProcessor.Convert(input);
            Assert.That(result, Is.EqualTo(expected));
        }


    }
}

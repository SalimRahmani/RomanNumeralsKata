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
        [TestCase(1, "I")]
        public void should_return_I_when_input_is_1(int input, string expected)
        {
            // arrange
            RomanNumeralsProcessor romanNumeralsProcessor = new RomanNumeralsProcessor();

            // act
            string result = romanNumeralsProcessor.Convert(input);

            // assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
